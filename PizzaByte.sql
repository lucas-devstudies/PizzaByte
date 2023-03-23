CREATE DATABASE PizzaByte;

USE PizzaByte;

CREATE TABLE Produtos(
	IdProduto INT IDENTITY(1,1) PRIMARY KEY,
	NomeProduto VARCHAR (255),
	CategoriaProduto VARCHAR(255),
	DescricaoProduto Varchar(255),
	ValorProduto DECIMAL(5,2)
);

CREATE TABLE Usuarios(
	IdCliente INT IDENTITY(1,1) PRIMARY KEY,
	TipoCliente CHAR,
	NomeCliente VARCHAR(255),
	TelefoneCliente VARCHAR(16), /*Imaginei que VARCHAR seria melhor por conta das barrinhas ex: (99) 9 9999-9999*/
	EmailCliente VARCHAR(255),
	SenhaCliente VARCHAR(255),
	Endereco VARCHAR(255)
);

CREATE TABLE Entrega(
	IdEntrega INT IDENTITY(1,1) PRIMARY KEY,
	NomeMotoboy VARCHAR(255),
	VeiculoMotoboy VARCHAR(255),
	TelefoneMotoboy VARCHAR(16),
	ValorEntrega DECIMAL (18,2),
	ValorMotoboy DECIMAL(10,2)
);


CREATE TABLE Vendas(
	IdVenda INT IDENTITY(1,1) PRIMARY KEY,
	TempoVenda DATETIME, 
	StatusVenda VARCHAR(255),
	DataVenda datetime,
	Preco DECIMAL(5,2),
	TipoVenda CHAR,
	idCliente INT,
	idEntrega INT,
	CONSTRAINT fk_Usuarios_id FOREIGN KEY (idCliente) 
	REFERENCES Usuarios(IdCliente),
	CONSTRAINT fk_entrega_id FOREIGN KEY (idEntrega)
	REFERENCES Entrega(IdEntrega)
);
CREATE TABLE Carrinho(
	IdCarrinho INT PRIMARY KEY,
	QuantidadePC INT,
	Sabores VARCHAR (255),
	Observacao VARCHAR (255),
);
CREATE TABLE CarrinhoProduto(
	IdCarrinho int,
	IdProduto int,
	PRIMARY KEY (IdCarrinho, IdProduto),
	FOREIGN KEY(IdProduto)
	REFERENCES Produtos(IdProduto),
	FOREIGN KEY (IdCarrinho)
	REFERENCES Carrinho(IdCarrinho)
);

drop table Carrinho;
DROP DATABASE PizzaByte;

INSERT INTO Produtos
(NomeProduto, CategoriaProduto,
DescricaoProduto, ValorProduto)
VALUES 
('Pizza pequena tradicional', 'Pizza', 'Pizza Pequena até 2 sabores', 18.90);

INSERT INTO Clientes
(NomeCliente, TelefoneCliente, EmailCliente, SenhaCliente, Endereco)
VALUES 
('Taís Waine', '(92) 99111-1111', 'taisWaine@gmail.com', 'senhadatais', 'Avenida Paulista, n57, casa verde');

INSERT INTO Entrega
(NomeMotoboy, VeiculoMotoboy, TelefoneMotoboy, ValorEntrega, ValorMotoboy)
VALUES
('Carlos Alberto', 'Moto Honda pr 147', '(92) 99999-9999', 10.00, 5.00)

INSERT INTO Vendas
(TempoVenda, StatusVenda, DataVenda, Preco, TipoVenda, idCliente, idProduto, idEntrega)
VALUES
('20:00', 'Em andamento', '22/03/2023',  33.90, 0,1,1,1)

INSERT INTO ProdutoCliente
(IdProduto, QuantidadePC, IdVenda, Sabores, Observacao)
VALUES 
(1, 1, 1, 'Pizza Catupiry', 'Sem milho')

SELECT *
FROM Vendas v
INNER JOIN Entrega e ON e.IdEntrega IS NOT NULL
INNER JOIN Clientes c ON c.IdCliente IS NOT NULL
INNER JOIN Produtos p ON v.IdVenda IS NOT NULL

