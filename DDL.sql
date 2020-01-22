/* Criar Banco*/

CREATE DATABASE boletim; -- Cada linha dessas se chama consulta  - DDL (query de consulta)

DROP DATABASE boletim;

USE boletim;

-- identity serve para auto incrementar o id
/*Criandoum tabela */
CREATE TABLE aluno(
	IdAluno INT IDENTITY PRIMARY KEY NOT NULL,
	NomeAluno varchar(100),
	RA VARCHAR(20),
	Idade INT,
);

CREATE TABLE materia(
	IdMateria INT IDENTITY PRIMARY KEY NOT NULL,
	NomeAluno VARCHAR(50) NOT NULL
	);


	

CREATE TABLE trabalho(
	IdTrabalho INT IDENTITY PRIMARY KEY NOT NULL,
	Nota DECIMAL,
	-- CHAMAMOS NOSSAS CHAVES ESTRANGEIRAS
	IdMateria INT FOREIGN KEY REFERENCES materia (IdMateria),
	IdAluno INT FOREIGN KEY REFERENCES aluno (IdAluno)
	);

    -- Incluindo nova tabela coluna
ALTER TABLE materia ADD Teste VARCHAR(100);

ALTER TABLE materia DROP COLUMN Teste;