CREATE DATABASE meumedico
GO

USE meumedico
GO

CREATE TABLE Paises (
	IDPais INT IDENTITY(1,1) PRIMARY KEY,
	Pais VARCHAR(50),
	Sigla VARCHAR(2)
	);

CREATE TABLE Estados (
	IDEstado INT IDENTITY(1,1) PRIMARY KEY,
	IDPais INT,
	Estado VARCHAR(50),
	Sigla VARCHAR(2),
	CONSTRAINT FK_IDPais FOREIGN KEY (IDPais) REFERENCES Paises(IDPais)
	);

CREATE TABLE Cidades(
	IDCidade INT IDENTITY(1,1) PRIMARY KEY,
	IDEstado INT,
	Cidade VARCHAR(10)
	);

	
CREATE TABLE Especialidades (
	IDEspecialidade SMALLINT IDENTITY(1,1) PRIMARY KEY,
	Especialidade VARCHAR(80)
	);

CREATE TABLE Medicos (
	IDMedico INT PRIMARY KEY IDENTITY(1,1),
	IDEspecialidade SMALLINT,
	CRM VARCHAR(30),
	Nome VARCHAR(80),
	Endereco VARCHAR(100),
	Bairro VARCHAR(60),
	IDCidade INT,
	Email VARCHAR(100),
	AtendePorConvenio BIT,
	TemClinica BIT,
	WebsiteBlog VARCHAR(50),	
	CONSTRAINT FK_IDCidade FOREIGN KEY (IDCidade) REFERENCES Cidades(IDCidade),
	CONSTRAINT FK_IDEspecialidade FOREIGN KEY (IDEspecialidade) REFERENCES Especialidades(IDEspecialidade)
	);

CREATE TABLE Usuarios (
	IDUsuario INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(80),
	Usuario VARCHAR(30),
	Senha VARCHAR(20),
	Email VARCHAR(100)
	);


-- POPULAR ESTA CARALHA DE BANCO DE DADOS --

-- INSERT ESPECIALIDADES --
INSERT INTO Especialidades(Especialidade) VALUES ('Acupuntura');
INSERT INTO Especialidades(Especialidade) VALUES ('Alergia e Imunologia');
INSERT INTO Especialidades(Especialidade) VALUES ('Anestesiologia');
INSERT INTO Especialidades(Especialidade) VALUES ('Angiologia');
INSERT INTO Especialidades(Especialidade) VALUES ('Oncologia');
INSERT INTO Especialidades(Especialidade) VALUES ('Cardiologia');
INSERT INTO Especialidades(Especialidade) VALUES ('Gastroenterologia');

-- INSERT PAISES --
INSERT INTO Paises(Pais,Sigla) VALUES ('Brasil', 'BR');
INSERT INTO Paises(Pais,Sigla) VALUES ('Argentina', 'AG');
INSERT INTO Paises(Pais,Sigla) VALUES ('Estados Unidos', 'US');
INSERT INTO Paises(Pais,Sigla) VALUES ('Jap�o', 'JP');
INSERT INTO Paises(Pais,Sigla) VALUES ('Alemanha', 'AL');
INSERT INTO Paises(Pais,Sigla) VALUES ('R�ssia', 'RS');
INSERT INTO Paises(Pais,Sigla) VALUES ('Holanda', 'HL');

-- INSERT ESTADO --
INSERT INTO Estados(Estado,IDPais,Sigla) VALUES ('Paran�',1,'PR');
INSERT INTO Estados(Estado,IDPais,Sigla) VALUES ('Buenos Aires',2,'BA');
INSERT INTO Estados(Estado,IDPais,Sigla) VALUES ('New York',3,'NY');
INSERT INTO Estados(Estado,IDPais,Sigla) VALUES ('Tokyo',4,'TY');
INSERT INTO Estados(Estado,IDPais,Sigla) VALUES ('Frankfurt',5,'FK');
INSERT INTO Estados(Estado,IDPais,Sigla) VALUES ('Moscow',6,'BR');
INSERT INTO Estados(Estado,IDPais,Sigla) VALUES ('Amsterd�',7,'AS');

-- INSERT CIDADE --
INSERT INTO Cidades(IDEstado,Cidade) VALUES (1,'Londrina');
INSERT INTO Cidades(IDEstado,Cidade) VALUES (2,'Nabu');
INSERT INTO Cidades(IDEstado,Cidade) VALUES (3,'Fagnusfi');
INSERT INTO Cidades(IDEstado,Cidade) VALUES (4,'Otaku');
INSERT INTO Cidades(IDEstado,Cidade) VALUES (5,'Hitler');
INSERT INTO Cidades(IDEstado,Cidade) VALUES (6,'Vodka');
INSERT INTO Cidades(IDEstado,Cidade) VALUES (7,'Maconha');

--INSERT MEDICOS --
INSERT INTO Medicos(IDEspecialidade,CRM,Nome,Endereco,Bairro,IDCidade,Email,AtendePorConvenio,TemClinica,WebsiteBlog)
VALUES (1,'Jefferson','Xakdoakado','aoskdaosdko','dasdasd',1,'odakdosa@asdkao.com',0,0,'www.amanha.com');

INSERT INTO Medicos(IDEspecialidade,CRM,Nome,Endereco,Bairro,IDCidade,Email,AtendePorConvenio,TemClinica,WebsiteBlog)
VALUES (2,'Lucas','Hehe','Aooba','dasdasd',1,'HEHE@asdkao.com',0,1,'www.heheaoba.com');

INSERT INTO Medicos(IDEspecialidade,CRM,Nome,Endereco,Bairro,IDCidade,Email,AtendePorConvenio,TemClinica,WebsiteBlog)
VALUES (3,'Andrey','Fagus','Parece','dasdasd',1,'Fagus@asdkao.com',1,0,'www.aahbom.com');

INSERT INTO Medicos(IDEspecialidade,CRM,Nome,Endereco,Bairro,IDCidade,Email,AtendePorConvenio,TemClinica,WebsiteBlog)
VALUES (4,'Ian','Turobom','Timtirin','dasdasd',1,'tintirimtintim@asdkao.com',1,1,'www.elreidelgado.com');

INSERT INTO Medicos(IDEspecialidade,CRM,Nome,Endereco,Bairro,IDCidade,Email,AtendePorConvenio,TemClinica,WebsiteBlog)
VALUES (5,'Morgana','Maezona','Vinte','dasdasd',1,'mae@asdkao.com',0,0,'www.sete.com');

INSERT INTO Medicos(IDEspecialidade,CRM,Nome,Endereco,Bairro,IDCidade,Email,AtendePorConvenio,TemClinica,WebsiteBlog)
VALUES (6,'Otavio','asda','gf','dasdasd',1,'gh@asdkao.com',1,0,'www.sad2.com');

INSERT INTO Medicos(IDEspecialidade,CRM,Nome,Endereco,Bairro,IDCidade,Email,AtendePorConvenio,TemClinica,WebsiteBlog)
VALUES (7,'Samuel','LightKeeper','sdg','dasdasd',1,'elrel@asdkao.com',0,1,'www.narguile.com');

-- INSERT USUARIO --
INSERT INTO Usuarios(Nome,Usuario,Senha,Email) VALUES ('Jefferson','jeff','1','odakdosa@asdkao.com');
INSERT INTO Usuarios(Nome,Usuario,Senha,Email) VALUES ('Lucas','lucas','2','HEHE@asdkao.com');
INSERT INTO Usuarios(Nome,Usuario,Senha,Email) VALUES ('Andrey','andrey','3','Fagus@asdkao.com');
INSERT INTO Usuarios(Nome,Usuario,Senha,Email) VALUES ('Ian','ian','4','tintirimtintim@asdkao.com');
INSERT INTO Usuarios(Nome,Usuario,Senha,Email) VALUES ('Morgana','mrogs','5','mae@asdkao.com');
INSERT INTO Usuarios(Nome,Usuario,Senha,Email) VALUES ('Otavio','policial','6','gh@asdkao.com');
INSERT INTO Usuarios(Nome,Usuario,Senha,Email) VALUES ('Samuel','sam','7','elrel@asdkao.com');
