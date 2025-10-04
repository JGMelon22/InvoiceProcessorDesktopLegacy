using InvoiceProcessorDesktopLegacy.Entities;
using InvoiceProcessorDesktopLegacy.Infrastructure.Data;
using InvoiceProcessorDesktopLegacy.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InvoiceProcessorDesktopLegacy.Infrastructure.Services
{
    public class NotaFiscalImportService
    {
        public async Task<ImportResult> ImportFromXml(string filePath)
        {
            return await ImportFromXmlFiles(new[] { filePath });
        }

        public async Task<ImportResult> ImportFromXmlFiles(string[] filePaths)
        {
            var result = new ImportResult { Success = true };

            try
            {
                using (var context = new AppDbContext())
                {
                    foreach (var filePath in filePaths)
                    {
                        try
                        {
                            var notaFiscal = ParseXmlFile(filePath);

                            var exists = await context.NotasFiscais.FindAsync(notaFiscal.Numero);

                            if (exists != null)
                            {
                                result.Errors.Add($"Nota {notaFiscal.Numero} já existe no banco de dados");
                                result.ErrorCount++;
                                continue;
                            }

                            context.NotasFiscais.Add(notaFiscal);
                            result.ProcessedCount++;
                        }
                        catch (Exception ex)
                        {
                            result.Errors.Add($"Erro ao processar {Path.GetFileName(filePath)}: {ex.Message}");
                            result.ErrorCount++;
                        }
                    }

                    if (result.ProcessedCount > 0)
                    {
                        await context.SaveChangesAsync();
                        result.Message = $"{result.ProcessedCount} nota(s) importada(s) com sucesso";
                    }

                    else
                    {
                        result.Success = false;
                        result.Message = "Nenhuma nota foi importada";
                    }

                    if (result.Errors.Count > 0)
                    {
                        result.Message += $". {result.ErrorCount} erro(s) encontrado(s)";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Erro geral: {ex.Message}";
            }

            return result;
        }

        public async Task<List<NotaFiscal>> ListarTodas()
        {
            using (var context = new AppDbContext())
            {
                return await context.NotasFiscais
                    .OrderBy(n => n.Numero)
                    .AsNoTracking()
                    .ToListAsync();
            }
        }

        public async Task<NotaFiscal> BuscarPorNumero(int numero)
        {
            using (var context = new AppDbContext())
            {
                return await context.NotasFiscais.FindAsync(numero);
            }
        }

        private NotaFiscal ParseXmlFile(string filePath)
        {
            var xdoc = XDocument.Load(filePath);
            var root = xdoc.Root;

            if (root == null || root.Name.LocalName != "NotaFiscal")
            {
                throw new Exception("Arquivo XML inválido: elemento raiz 'NotaFiscal' não encontrado");
            }

            var nota = new NotaFiscal
            {
                Numero = int.Parse(root.Element("Numero")?.Value ?? "0"),
                CNPJPrestador = root.Element("Prestador")?.Element("CNPJ")?.Value ?? string.Empty,
                CNPJTomador = root.Element("Tomador")?.Element("CNPJ")?.Value ?? string.Empty,
                DataEmissao = DateTime.Parse(root.Element("DataEmissao")?.Value ?? DateTime.MinValue.ToString()),
                DescricaoServico = root.Element("Servico")?.Element("Descricao")?.Value ?? string.Empty,
                ValorTotal = decimal.Parse(root.Element("Servico")?.Element("Valor")?.Value ?? "0", CultureInfo.InvariantCulture)
            };

            return nota;
        }
    }
}
