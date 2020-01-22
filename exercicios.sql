

--############################################ ex_2
CREATE DATABASE ex_2

USE ex_2

CREATE TABLE diretores(
IdDiretor INT PRIMARY KEY NOT NULL IDENTITY,
NomeDiretor VARCHAR(30) NOT NULL,
RG VARCHAR(20),
CPF VARCHAR(20)
);

CREATE TABLE departamento(
IdDepartamento INT PRIMARY KEY NOT NULL IDENTITY,
NomeDepartamento VARCHAR(30) NOT NULL,
Andar VARCHAR(10),
Setor VARCHAR(10),
IdDiretor INT FOREIGN KEY REFERENCES diretores (IdDiretor)
);

INSERT INTO diretores (NomeDiretor, RG ,CPF)
VALUES ('Andre', '5555555555','4414414412'),
('Marcela', '6666666666','4414414412'),
('José', '77777777','4414414412'),
('Dep 4', '8888888','4414414412');


INSERT INTO departamento (NomeDepartamento, Andar ,Setor,IdDiretor)
VALUES ('Dep 1', '1º', '3','1'),
('Dep 1', '1º', '2','2'),
('Dep 1', '1º', '3','3');


SELECT * FROM diretores;

SELECT * FROM departamento;

-- #################################### EX_3
CREATE DATABASE ex_3

USE ex_3


CREATE TABLE autor(
IdAutor INT PRIMARY KEY IDENTITY NOT NULL,
NomeAutor VARCHAR(25) NOT NULL,
RG VARCHAR(20),
CPF VARCHAR(20)
);

CREATE TABLE livro(
IdLivro INT PRIMARY KEY IDENTITY NOT NULL,
NomeLivro VARCHAR(25) NOT NULL,
Codigo VARCHAR(20),
Editora VARCHAR(20)
);

CREATE TABLE obras(
IdObra INT PRIMARY KEY IDENTITY NOT NULL,
IdLivro INT FOREIGN KEY REFERENCES livro (IdLivro),
IdAutor INT FOREIGN KEY REFERENCES autor (IdAutor)
);

INSERT INTO autor (NomeAutor, RG, CPF) 
VALUES ('Gabriela', '11111111','11111111'),
('Fernando', '11111111','11111111'),
('Ana', '11111111','11111111'),
('Gabriel', '11111111','11111111');

INSERT INTO livro (NomeLivro, Codigo, Editora) 
VALUES ('Cokies para Todos','00000','Abril'),
('O mágico de Oz','22222','Saraiva'), 
('Nárnia','33333','Fundamento'), 
('The power of quiet','4444','S.A. Edição');


INSERT INTO obras(IdLivro, IdAutor) VALUES 
('1','1'),
('1','2'),
('1','3'),
('2','1');

SELECT * FROM autor;
SELECT * FROM livro;
SELECT * FROM obras;

--#############################################################ex_4
CREATE DATABASE ex_4;
USE ex_4;

CREATE TABLE equipe(
IdEquipe INT IDENTITY PRIMARY KEY,
NomeEquipe varchar(30),
QntIntegrantes INT,
Periodo varchar(20)
);

INSERT INTO equipe (NomeEquipe, QntIntegrantes, Periodo) 
VALUES
('Equipe 01','10', 'Manhã'),
('Equipe 02','5', 'Tarde'),
('Equipe 03','9', 'Manhã');


CREATE TABLE jogadores(
IdJogador INT IDENTITY PRIMARY KEY,
NomeJogador varchar(30),
Idade INT,
Genero varchar(10),
IdEquipe INT FOREIGN KEY REFERENCES equipe (IdEquipe)
);



INSERT INTO jogadores(NomeJogador, Idade, Genero, IdEquipe) 
VALUES
('Marcio','10', 'Masculino',1),
('Maria','5', 'Feminino',1),
('José Assis','9', 'Masculino',2);

select * from jogadores;

--#############################################################ex_5
CREATE DATABASE ex_5

USE ex_5


CREATE TABLE cliente(
IdCli INT PRIMARY KEY IDENTITY,
NomeCli VARCHAR(20),
RG VARCHAR(15),
CPF VARCHAR(15)
);

INSERT INTO cliente(NomeCli, RG,CPF) 
VALUES 
('Maria', '000000','000000'),
('Roger', '111111','111111'),
('José', '222222','222222'); 

SELECT * FROM cliente;


CREATE TABLE produto(
IdProduto INT PRIMARY KEY IDENTITY,
NomeProduto VARCHAR(20),
CodigoProduto VARCHAR(15),
PRECO FLOAT
);

INSERT INTO produto(NomeProduto,CodigoProduto,PRECO) 
VALUES 
('BATATA', '000000',2.99),
('AVEIA', '111111',6),
('FAROFA', '222222',9.9); 

SELECT * FROM produto;

CREATE TABLE carrinho(
IdCarrinho INT PRIMARY KEY IDENTITY,
IdProduto INT FOREIGN KEY REFERENCES produto(IdProduto),
IdCli INT FOREIGN KEY REFERENCES cliente(IdCli)
);

INSERT INTO carrinho(IdProduto, IdCli) 
VALUES 
(1,1),
(1,2),
(1,3),
(2,1),
(2,2),
(3,3);

SELECT * FROM carrinho;

--############################################################## ex_6

CREATE DATABASE ex_6;
USE ex_6;

CREATE TABLE alunos_cadastrados(
	IdAluno INT IDENTITY PRIMARY KEY NOT NULL,
	NomeAluno varchar(100),
	RA VARCHAR(20),
	IdadeAluno INT,
	IdCursos INT FOREIGN KEY REFERENCES cursos_cadastrados (IdCursos)
);


CREATE TABLE cursos_cadastrados(
	IdCursos INT IDENTITY PRIMARY KEY NOT NULL,
	NomeCurso varchar(100),
	DuracaoCurso varchar(10),
);


INSERT INTO cursos_cadastrados (NomeCurso, DuracaoCurso) values ('A Fina Arte de Fazer Miçangas','20');
INSERT INTO cursos_cadastrados (NomeCurso, DuracaoCurso) values ('Aprenda Inglês em 30 Dias','4');

INSERT INTO alunos_cadastrados (NomeAluno, RA, IdadeAluno, IdCursos) values ('Vitor','2222',20,1);


select * from alunos_cadastrados;

select * from cursos_cadastrados;

--#################################################################################### ex_7

CREATE DATABASE ex_7;
USE ex_7;

CREATE TABLE alunos_cadastrados(
	IdAluno INT IDENTITY PRIMARY KEY NOT NULL,
	NomeAluno varchar(100),
	RA VARCHAR(20),
	IdadeAluno INT,
	IdTurma INT FOREIGN KEY REFERENCES turma (IdTurma)
);


CREATE TABLE turma(
	IdTurma INT IDENTITY PRIMARY KEY NOT NULL,
	NomeTurma varchar(50),
	Periodo varchar(10),
	DuracaoCurso varchar(10)
);



INSERT INTO turma (NomeCurso, DuracaoCurso) values ('A Fina Arte de Fazer Miçangas','20');

INSERT INTO alunos_cadastrados ( NomeAluno ,RA ,IdadeAluno, IdTurma) 
values 
('Vinicius','5555',20,1),
('Vinicias','6666',19,1),
('Giovana','7777',22,3);


INSERT INTO turma (NomeTurma, Periodo, DuracaoCurso) 
values 
('TURMA A', 'MANHÃ', '1200'), 
('TURMA B', 'MANHÃ', '1200'),
('TURMA C', 'MANHÃ', '1200'),
('TURMA A', 'TARDE', '1200'), 
('TURMA B', 'TARDE', '1200'),
('TURMA A', 'NOITE', '1200');
;

select * from alunos_cadastrados;

select * from turma;

--#################################################################################### ex_8
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

CREATE TABLE projetos(
IdProjetos INT IDENTITY PRIMARY KEY NOT NULL,
IdProjeto INT FOREIGN KEY REFERENCES tipo_projeto (IdProjeto),
IdEmpregado INT FOREIGN KEY REFERENCES empregados (IdEmpregado)
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

INSERT INTO projetos(IdProjeto,IdEmpregado) 
VALUES
('43','1'),
('43','2'),
('45','1');


select * from departamento;
select * from localizacao;
select * from localizacao_departamento;
select * from empregados;
select * from dependentes;
select * from tipo_projeto;
select * from projetos;





