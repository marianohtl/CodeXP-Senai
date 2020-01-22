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

--####################################################################################

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

--####################################################################################
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