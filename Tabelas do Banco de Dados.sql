CREATE DATABASE DbControleVenda
 
 USE DbControleVenda
 
CREATE TABLE [dbo].[Agenda] (
    [Id_Agenda]   INT           IDENTITY (1, 1) NOT NULL,
    [NomeCliente] VARCHAR (100) NOT NULL,
    [Data]        VARCHAR (50)  NOT NULL,
    [Horario]     VARCHAR (10)  NOT NULL,
    [Servico]     VARCHAR (100) NOT NULL,
    [Telefone]    VARCHAR (17)  NULL,
    [Email]       VARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([Id_Agenda] ASC)
);

CREATE TABLE [dbo].[Categoria] (
    [Id_Categoria] INT           NOT NULL,
    [Descricao]    VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id_Categoria] ASC)
);

CREATE TABLE [dbo].[Cliente] (
    [Id_Cliente]     INT           NOT NULL,
    [Nome]           VARCHAR (100) NOT NULL,
    [DataNascimento] VARCHAR (10)  NOT NULL,
    [CPF]            VARCHAR (MAX) NOT NULL,
    [RG]             VARCHAR (MAX) NOT NULL,
    [CEP]            VARCHAR (10)  NOT NULL,
    [Bairro]         VARCHAR (50)  NOT NULL,
    [Endereco]       VARCHAR (100) NOT NULL,
    [Numero]         INT           NOT NULL,
    [Cidade]         VARCHAR (100) NOT NULL,
    [Estado]         VARCHAR (30)  NOT NULL,
    [Telefone]       VARCHAR (15)  NULL,
    [Celular]        VARCHAR (16)  NOT NULL,
    [Email]          VARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([Id_Cliente] ASC)
);

CREATE TABLE [dbo].[ContasPagar] (
    [Id]              INT             IDENTITY (1, 1) NOT NULL,
    [Beneficiario]    VARCHAR (100)   NOT NULL,
    [NumeroDocumento] INT             NOT NULL,
    [Vencimento]      VARCHAR (10)    NOT NULL,
    [ValorDocumento]  DECIMAL (18, 2) NOT NULL,
    [Referencia]      VARCHAR (200)   NULL,
    [DataPagamento]   VARCHAR (10)    NULL,
    [Multa]           DECIMAL (18, 2) NULL,
    [Desconto]        DECIMAL (18, 2) NULL,
    [ValorPago]       DECIMAL (18, 2) NULL,
    [Status]          VARCHAR (10)    NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Empresa] (
    [Id_Empresa]        INT           NOT NULL,
    [RazaoSocial]       VARCHAR (100) NOT NULL,
    [NomeFantasia]      VARCHAR (100) NOT NULL,
    [AreaAtuacao]       VARCHAR (100) NOT NULL,
    [CNPJ]              VARCHAR (MAX) NOT NULL,
    [InscricaoEstadual] VARCHAR (MAX) NOT NULL,
    [Endereco]          VARCHAR (100) NOT NULL,
    [CEP]               VARCHAR (10)  NOT NULL,
    [Numero]            INT           NOT NULL,
    [Bairro]            VARCHAR (50)  NOT NULL,
    [Cidade]            VARCHAR (100) NOT NULL,
    [Estado]            VARCHAR (2)   NOT NULL,
    [Telefone]          VARCHAR (16)  NULL,
    [Celular]           VARCHAR (16)  NULL,
    [Email]             VARCHAR (100) NULL,
    [LogoEmpresa]       VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id_Empresa] ASC)
);

CREATE TABLE [dbo].[Fornecedor] (
    [Id_Fornecedor]     INT           NOT NULL,
    [Nome]              VARCHAR (100) NOT NULL,
    [CNPJ]              VARCHAR (MAX) NULL,
    [InscricaoEstadual] VARCHAR (MAX) NULL,
    [Cep]               VARCHAR (10)  NULL,
    [Bairro]            VARCHAR (50)  NULL,
    [Endereco]          VARCHAR (100) NULL,
    [Numero]            VARCHAR (10)  NULL,
    [Cidade]            VARCHAR (100) NULL,
    [Estado]            VARCHAR (30)  NULL,
    [Telefone]          VARCHAR (15)  NULL,
    [Celular]           VARCHAR (16)  NULL,
    [Email]             VARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([Id_Fornecedor] ASC)
);

CREATE TABLE [dbo].[Produto] (
    [Id_Produto]    INT             NOT NULL,
    [CodigoBarra]   VARCHAR (13)    NULL,
    [Descricao]     VARCHAR (100)   NOT NULL,
    [Marca]         VARCHAR (50)    NULL,
    [DataValidade]  VARCHAR (10)    NULL,
    [ValorCusto]    DECIMAL (18, 2) NULL,
    [ValorVenda]    DECIMAL (18, 2) NOT NULL,
    [Lucro]         DECIMAL (18, 2) NULL,
    [EstoqueAtual]  INT             NULL,
    [EstoqueMinimo] INT             NULL,
    [Unidade]       VARCHAR (30)    NULL,
    [Id_Categoria]  INT             NOT NULL,
    [Id_Fornecedor] INT             NULL,
    PRIMARY KEY CLUSTERED ([Id_Produto] ASC),
    FOREIGN KEY ([Id_Fornecedor]) REFERENCES [dbo].[Fornecedor] ([Id_Fornecedor]),
    FOREIGN KEY ([Id_Categoria]) REFERENCES [dbo].[Categoria] ([Id_Categoria])
);

CREATE TABLE [dbo].[Usuario] (
    [Id_Usuario] INT           IDENTITY (1, 1) NOT NULL,
    [Nome]       VARCHAR (100) NOT NULL,
    [Funcao]     VARCHAR (50)  NOT NULL,
    [Email]      VARCHAR (100) NULL,
    [Usuario]    VARCHAR (30)  NOT NULL,
    [Senha]      VARCHAR (MAX) NOT NULL,
    [Situacao]   VARCHAR (20)  NULL,
    [DicaSenha]  VARCHAR (30)  NULL,
	[PerguntaSeguranca] VARCHAR (MAX) NULL,
    [RespostaSeguranca] VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id_Usuario] ASC)
);

CREATE TABLE [dbo].[Venda] (
    [Id_Venda]   INT             NOT NULL,
    [parcelas]   INT             NOT NULL,
    [Desconto]   DECIMAL (18, 2) NOT NULL,
    [ValorTotal] DECIMAL (18, 2) NOT NULL,
    [Lucro]      DECIMAL (18, 2) NOT NULL,
    [DataVenda]  VARCHAR (16)    NOT NULL,
    [HoraVenda]  VARCHAR (10)    NOT NULL,
    [Id_Usuario] INT             NOT NULL,
    [Id_Cliente] INT             NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Venda] ASC),
    FOREIGN KEY ([Id_Usuario]) REFERENCES [dbo].[Usuario] ([Id_Usuario]),
    FOREIGN KEY ([Id_Cliente]) REFERENCES [dbo].[Cliente] ([Id_Cliente])
);

CREATE TABLE [dbo].[FluxoCaixa] (
    [Id_Fluxo]             INT             IDENTITY (1, 1) NOT NULL,
    [ValorEntrada]         DECIMAL (18, 2) NOT NULL,
    [ValorCaixa]           DECIMAL (18, 2) NULL,
    [Desconto]             DECIMAL (18, 2) NULL,
    [EntradaParcela]       DECIMAL (18, 2) NULL,
    [ValorReceber]         DECIMAL (18, 2) NULL,
    [SaldoCaixa]           DECIMAL (18, 2) NULL,
    [ValorTotalCaixa]      DECIMAL (18, 2) NULL,
    [ValorRecebidoPrazo]   DECIMAL (18, 2) NULL,
    [ValorRecebidoParcial] DECIMAL (18, 2) NULL,
    [ValorRecebidoVista]   DECIMAL (18, 2) NULL,
    [ValorRecebidoParcela] DECIMAL (18, 2) NULL,
    [ValorRecebidoCredito] DECIMAL(18, 2) NULL, 
    [ValorRecebidoDebito] DECIMAL(18, 2) NULL,
	[DataEntrada]          VARCHAR (10)    NULL,
    [DataSaida]            VARCHAR (10)    NULL,
    [HoraEntrada]          VARCHAR (10)    NULL,
    [HoraSaida]            VARCHAR (10)    NULL,
    [Id_Usuario]           INT             NOT NULL,    
    PRIMARY KEY CLUSTERED ([Id_Fluxo] ASC),
    FOREIGN KEY ([Id_Usuario]) REFERENCES [dbo].[Usuario] ([Id_Usuario])
);

CREATE TABLE [dbo].[FormaPagamento] (
    [Id_FormaPagamento] INT          IDENTITY (1, 1) NOT NULL,
    [Descricao]         VARCHAR (20) NOT NULL,
    [Id_Venda]          INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_FormaPagamento] ASC),
    FOREIGN KEY ([Id_Venda]) REFERENCES [dbo].[Venda] ([Id_Venda])
);

CREATE TABLE [dbo].[ItensVenda] (
    [Id_ItensVenda] INT             IDENTITY (1, 1) NOT NULL,
    [Valor]         DECIMAL (18, 2) NOT NULL,
    [Quantidade]    INT             NOT NULL,
    [lucroItens]    DECIMAL (18, 2) NOT NULL,
    [Id_Venda]      INT             NOT NULL,
    [Id_Produto]    INT             NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_ItensVenda] ASC),
    FOREIGN KEY ([Id_Produto]) REFERENCES [dbo].[Produto] ([Id_Produto]),
    FOREIGN KEY ([Id_Venda]) REFERENCES [dbo].[Venda] ([Id_Venda])
);

CREATE TABLE [dbo].[PagamentoParcial] (
    [Id_PagamentoParcial] INT             IDENTITY (1, 1) NOT NULL,
    [DataAbatimento]      VARCHAR (30)    NOT NULL,
    [ValorRestante]       DECIMAL (18, 2) NOT NULL,
    [Id_Venda]            INT             NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_PagamentoParcial] ASC),
    FOREIGN KEY ([Id_Venda]) REFERENCES [dbo].[Venda] ([Id_Venda])
);

CREATE TABLE [dbo].[ParcelaVenda] (
    [Id_Parcela]     INT             IDENTITY (1, 1) NOT NULL,
    [Parcela]        INT             NOT NULL,
    [DataVencimento] VARCHAR (10)    NOT NULL,
    [ValorParcelado] DECIMAL (18, 2) NOT NULL,
    [DataPagamento]  VARCHAR (10)    NULL,
    [HoraPagamento]  VARCHAR (10)    NULL,
    [Id_Venda]       INT             NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Parcela] ASC),
    FOREIGN KEY ([Id_Venda]) REFERENCES [dbo].[Venda] ([Id_Venda])
);

CREATE TABLE [dbo].[SaidaCaixa] (
    [Id_SaidaCaixa]  INT             IDENTITY (1, 1) NOT NULL,
    [ValorSaida]     DECIMAL (18, 2) NOT NULL,
    [MotivoRetirada] VARCHAR (MAX)   NOT NULL,
    [Id_Fluxo]       INT             NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_SaidaCaixa] ASC),
    FOREIGN KEY ([Id_Fluxo]) REFERENCES [dbo].[FluxoCaixa] ([Id_Fluxo])
);

CREATE TABLE [dbo].[TipoPagamento] (
    [Id_TipoPagamenro] INT           IDENTITY (1, 1) NOT NULL,
    [Descricao]        VARCHAR (30)  NULL,
    [DadosCartao]      VARCHAR (MAX) NULL,
    [Id_Venda]         INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_TipoPagamenro] ASC),
    FOREIGN KEY ([Id_Venda]) REFERENCES [dbo].[Venda] ([Id_Venda])
);

CREATE TABLE [dbo].[ValorAbatido] (
    [Id_ValorAbatido]      INT             IDENTITY (1, 1) NOT NULL,
    [ValorTotalAbatimento] DECIMAL (18, 2) NOT NULL,
    [Id_PagamentoParcial]  INT             NOT NULL,
    [DataPagamento]        VARCHAR (10)    NOT NULL,
    [HoraPagamento]        VARCHAR (10)    NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_ValorAbatido] ASC),
    FOREIGN KEY ([Id_PagamentoParcial]) REFERENCES [dbo].[PagamentoParcial] ([Id_PagamentoParcial])
);

CREATE TABLE [dbo].[ContasNaoContabilizadas]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1), 
    [Nome_Cliente] VARCHAR(100) NULL, 
    [Bairro_Cliente] VARCHAR(100) NULL, 
    [Endereco_Cliente] VARCHAR(100) NULL, 
    [Numero_Cliente] VARCHAR(30) NULL, 
    [ValorTotal_Venda] DECIMAL(18, 2) NULL, 
    [Data_Venda] VARCHAR(10) NULL
)


insert into cliente values (1,'CLIENTE AVULSO','00/00/000','1txL80yiSZRON3oyvU5Luw==','ZG3pKrNg0qNZyduxtLfdvA==','000000','null','null',9,'null','null','','','')

use master
create table autentico
(
	situacao varchar(25) null
)