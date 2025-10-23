# Invoice Processor Desktop Legacy

Sistema desktop Windows Forms para processamento e gerenciamento de Notas Fiscais através da importação de arquivos XML.

## Descrição

Aplicação desktop desenvolvida em C# (.NET Framework) que permite importar, armazenar e consultar notas fiscais eletrônicas a partir de arquivos XML. O sistema utiliza Entity Framework 6 para persistência de dados em banco de dados SQL Server.

## Interface
<img width="776" height="522" alt="Captura de tela 2025-10-04 123756" src="https://github.com/user-attachments/assets/7619b026-889d-4ff9-9653-09852ef7f7d6" />

## Funcionalidades

- Importação de nota fiscal única (arquivo XML)
- Importação em lote de múltiplas notas fiscais
- Listagem de todas as notas fiscais cadastradas
- Busca de nota fiscal por número
- Validação de duplicidade
- Visualização em grid com formatação de valores e datas

## Tecnologias

- .NET Framework 4.8
- Windows Forms
- Entity Framework 6.5.1
- SQL Server
- C#

## Estrutura da Nota Fiscal (XML)

```xml
<NotaFiscal>
  <Numero>12345</Numero>
  <Prestador>
    <CNPJ>12345678901234</CNPJ>
  </Prestador>
  <Tomador>
    <CNPJ>98765432109876</CNPJ>
  </Tomador>
  <DataEmissao>2025-10-04</DataEmissao>
  <Servico>
    <Descricao>Descrição do serviço prestado</Descricao>
    <Valor>1000.50</Valor>
  </Servico>
</NotaFiscal>
```

## Configuração

Configure a connection string no arquivo `App.config`:

```xml
<connectionStrings>
  <add name="NotaFiscalConnection" 
       connectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\NotasFiscais.mdf;Integrated Security=True"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

## Como Usar

1. Execute a aplicação
2. Clique em "Importar Único" ou "Importar Múltiplos" para carregar arquivos XML
3. Use "Listar Todas" para visualizar todas as notas
4. Use "Buscar por Número" para localizar uma nota específica

## Requisitos

- Windows 7 ou superior
- .NET Framework 4.8 ou superior
- SQL Server LocalDB ou SQL Server 2022
