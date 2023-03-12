CREATE DATABASE PizzaByte;

USE PizzaByte;

CREATE TABLE Produtos(
	IdProduto INT IDENTITY(1,1) PRIMARY KEY,
	NomeProduto VARCHAR (255),
	CategoriaProduto VARCHAR(255),
	DescricaoProduto Varchar(255),
	ValorProduto DECIMAL(5,2)
);

CREATE TABLE Clientes(
	IdCliente INT IDENTITY(1,1) PRIMARY KEY,
	NomeCliente VARCHAR(255),
	TelefoneCliente VARCHAR(16), /*Imaginei que VARCHAR seria melhor por conta das barrinhas ex: (99) 9 9999-9999*/
	EmailCliente VARCHAR(255),
	SenhaCliente VARCHAR(255),
	Endereco VARCHAR(255)
);

CREATE TABLE Vendas(
	IdVenda INT IDENTITY(1,1) PRIMARY KEY,
	TempoVenda DATETIME, 
	StatusVenda VARCHAR(255),
	DataVenda datetime,
	Preco DECIMAL(5,2),
	TipoVenda BIT,
	idCliente INT,
	idProduto INT,
	idMotoboy INT,
	CONSTRAINT fk_clientes_id FOREIGN KEY (idCliente) 
	REFERENCES Clientes(IdCliente),

	CONSTRAINT fk_produtos_id FOREIGN KEY (idProduto)
	REFERENCES Produtos(IdProduto),

	CONSTRAINT fk_motoboy_id FOREIGN KEY (idMotoboy)
	REFERENCES Motoboy(IdMotoboy)
);

CREATE TABLE Motoboy(
	IdMotoboy INT IDENTITY(1,1) PRIMARY KEY,
	NomeMotoboy VARCHAR(255),
	VeiculoMotoboy VARCHAR(255),
	EnderecoMotoboy VARCHAR(255),
	TelefoneMotoboy VARCHAR(16),
	ValorMotoboy DECIMAL(10,2)
);

CREATE TABLE ProdutoVenda(
	IdProduto INT,
	IdVenda INT,
	Quantidade INT,
	PRIMARY KEY (IdProduto, IdVenda),
	CONSTRAINT fk_produto_id FOREIGN KEY (IdProduto)
	REFERENCES Produtos(IdProduto),
	CONSTRAINT fk_venda_id FOREIGN KEY (IdVenda)
	REFERENCES Vendas(IdVenda)
);

select * from Vendas;

