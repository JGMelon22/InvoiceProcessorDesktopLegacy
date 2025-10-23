using InvoiceProcessorDesktopLegacy.Infrastructure.Services;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceProcessorDesktopLegacy
{
    public partial class Form1 : Form
    {
        private readonly NotaFiscalImportService _importService;

        public Form1()
        {
            InitializeComponent();
            _importService = new NotaFiscalImportService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            AtualizarStatus("Sistema pronto. Selecione uma operação.");
        }

        private void ConfigurarDataGridView()
        {
            dgvNotasFiscais.AutoGenerateColumns = true;
            dgvNotasFiscais.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNotasFiscais.MultiSelect = false;
            dgvNotasFiscais.AllowUserToAddRows = false;
            dgvNotasFiscais.AllowUserToDeleteRows = false;
            dgvNotasFiscais.ReadOnly = true;
        }

        private async void btnImportarUnico_Click(object sender, System.EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.Title = "Selecione um arquivo XML";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    await ProcessarImportacao(new[] { openFileDialog.FileName });
                }
            }
        }

        private async void btnImportarMultiplos_Click(object sender, System.EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.Title = "Selecione múltiplos arquivos XML";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    await ProcessarImportacao(openFileDialog.FileNames);
                }
            }
        }

        private async void btnListarTodas_Click(object sender, System.EventArgs e)
        {
            try
            {
                AtualizarStatus("Carregando lista de notas fiscais...");
                Cursor = Cursors.WaitCursor;

                var notas = await _importService.ListarTodas();

                dgvNotasFiscais.DataSource = notas;

                FormatarColunas();

                AtualizarStatus($"{notas.Count} nota(s) fiscal(is) encontrada(s)");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                                 $"Erro ao listar notas: {ex.Message}",
                                 "Erro",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error
                );
                AtualizarStatus("Erro ao carregar lista");
            }

            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private async Task ProcessarImportacao(string[] arquivos)
        {
            try
            {
                AtualizarStatus("Importando arquivos...");
                Cursor = Cursors.WaitCursor;

                var result = await _importService.ImportFromXmlFiles(arquivos);

                if (result.Success)
                {
                    MessageBox.Show(
                        result.Message,
                        "Importação Concluída",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    if (result.Errors.Any())
                    {
                        var errors = string.Join("\n", result.Errors);
                        MessageBox.Show(
                            $"Avisos encontrados:\n\n{errors}",
                            "Avisos",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }

                    btnListarTodas_Click(null, null);
                }
                else
                {
                    MessageBox.Show(
                        result.Message,
                        "Erro na Importação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }

                AtualizarStatus(result.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erro ao importar: {ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                AtualizarStatus("Erro na importação");
            }

            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private async void btnBuscarNumero_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                MessageBox.Show(
                    "Por favor, informe o número da nota fiscal",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtNumero.Focus();
                return;
            }

            int.TryParse(txtNumero.Text, out int numero);

            try
            {
                AtualizarStatus($"Buscando nota fiscal {numero}...");
                Cursor = Cursors.WaitCursor;

                var nota = await _importService.BuscarPorNumero(numero);

                if (nota != null)
                {
                    dgvNotasFiscais.DataSource = new[] { nota };
                    FormatarColunas();
                    AtualizarStatus($"Nota fiscal {numero} encontrada");
                }
                else
                {
                    dgvNotasFiscais.DataSource = null;
                    MessageBox.Show(
                        $"Nota fiscal {numero} não encontrada",
                        "Não Encontrado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    AtualizarStatus($"Nota fiscal {numero} não encontrada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erro ao buscar nota: {ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                AtualizarStatus("Erro na busca");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void FormatarColunas()
        {
            if (dgvNotasFiscais.Columns.Count > 0)
            {
                if (dgvNotasFiscais.Columns.Contains("ValorTotal"))
                {
                    dgvNotasFiscais.Columns["ValorTotal"].DefaultCellStyle.Format = "C2";
                    dgvNotasFiscais.Columns["ValorTotal"].HeaderText = "Valor Total";
                }
                if (dgvNotasFiscais.Columns.Contains("DataEmissao"))
                {
                    dgvNotasFiscais.Columns["DataEmissao"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvNotasFiscais.Columns["DataEmissao"].HeaderText = "Data Emissão";
                }

                if (dgvNotasFiscais.Columns.Contains("Numero"))
                    dgvNotasFiscais.Columns["Numero"].HeaderText = "Número";

                if (dgvNotasFiscais.Columns.Contains("CNPJPrestador"))
                    dgvNotasFiscais.Columns["CNPJPrestador"].HeaderText = "CNPJ Prestador";


                if (dgvNotasFiscais.Columns.Contains("CNPJTomador"))
                    dgvNotasFiscais.Columns["CNPJTomador"].HeaderText = "CNPJ Tomador";

                if (dgvNotasFiscais.Columns.Contains("DescricaoServico"))
                    dgvNotasFiscais.Columns["DescricaoServico"].HeaderText = "Descrição do Servico";
            }
        }

        private void AtualizarStatus(string mensagem)
        {
            lblStatus.Text = $"{DateTime.Now:HH:mm:ss} - {mensagem}";
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
