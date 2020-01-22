CREATE DATABASE ex_8;
USE ex_8;

CREATE TABLE departamento(
IdDepartamento INT IDENTITY PRIMARY KEY NOT NULL,
NomeDepartamento varchar(100)
);

CREATE TABLE localizacao(
IdLocalizacao INT IDENTITY PRIMARY KEY NOT NULL,
Localizacao varchar(60),
Andar varchar(10),
Setor varchar(10)
);

INSERT INTO departamento(NomeDepartamento) 
VALUES 
('Rosas de Outono'),
('Primavera Feliz'),
('Fragância de Morango');

INSERT INTO localizacao(Localizacao, Andar, Setor)
VALUES
('Belém', '1º','2'),
('Mooca', '1º','2'),
('Tatuapé', '2º','3');

CREATE TABLE localizacao_departamento(
IdLocalizacaoDepartamento INT IDENTITY PRIMARY KEY NOT NULL, 
IdLocalizacao INT FOREIGN KEY REFERENCES localizacao (IdLocalizacao),
IdDepartamento INT FOREIGN KEY REFERENCES departamento (IdDepartamento)
);


INSERT INTO localizacao_departamento(IdLocalizacao, IdDepartamento)
VALUES
(1,1),
(1,2),
(1,3),
(2,1),
(2,2),
(2,3);

CREATE TABLE empregados(
IdEmpregado INT IDENTITY PRIMARY KEY NOT NULL,
NomeEmpregado VARCHAR(100),
SalarioEmpregado MONEY,
CPF VARCHAR(15),
RG VARCHAR(15),
IdDepartamento INT FOREIGN KEY REFERENCES departamento (IdDepartamento)
);



CREATE TABLE dependentes(
IdDependente INT IDENTITY PRIMARY KEY NOT NULL,
NomeDependente VARCHAR(100) NOT NULL,
IdadeDependente VARCHAR(5),
IdEmpregado INT FOREIGN KEY REFERENCES empregados (IdEmpregado)
);

CREATE TABLE tipo_projeto(
IdProjeto INT IDENTITY PRIMARY KEY NOT NULL,
NomeProjeto VARCHAR(80) NOT NULL,
TipoProjeto VARCHAR(20) NOT NULL,
IdDepartamento INT FOREIGN KEY REFERENCES departamento (IdDepartamento)
);


INSERT INTO empregados(NomeEmpregado,SalarioEmpregado,CPF,RG,IdDepartamento) 
VALUES 
('Thalita Mariano', '8000,00','441257348-60','55080131-5','1'),
('Gabriel Azevedo', '8000,00','441257348-60','55080131-5','1'),
('Ângela Guimarães', '8000,00','441257348-60','55080131-5','2'),
('Alberto', '8000,00','441257348-60','55080131-5','2');

INSERT INTO dependentes(NomeDependente,IdadeDependente,IdEmpregado) 
VALUES
('Mariazinha','5',1),
('Joãozinho','5',1),
('Isabelzinha','5',1),
('Joaninha','5',2),
('Carlinhos','5',2);

INSERT INTO tipo_projeto( NomeProjeto, TipoProjeto ,IdDepartamento)
VALUES
('PROJETO A', 'Aulas','1'),
('PROJETO B', 'Manual','1'),
('PROJETO C', 'Artístico','1'),
('PROJETO D', 'Aulas','2'),
('PROJETO E', 'Artístico','3'),
('PROJETO F', 'Aulas','2');

CREATE TABLE projetos(
IdProjetos INT IDENTITY PRIMARY KEY NOT NULL,
IdProjeto INT FOREIGN KEY REFERENCES tipo_projeto (IdProjeto),
IdEmpregado INT FOREIGN KEY REFERENCES empregados (IdEmpregado)
);

INSERT INTO projetos(IdProjeto,IdEmpregado) 
VALUES
(1,1),
(2,1),
(3,2);

select * from departamento;
select * from localizacao;
select * from localizacao_departamento;
select * from empregados;
select * from dependentes;
select * from tipo_projeto;
select * from projetos;