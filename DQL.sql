/*Mostrar Dados*/

SELECT * FROM materia;

SELECT * FROM aluno;

SELECT * FROM trabalho;


/*Mostrar dados específicos de um aluno*/
SELECT * FROM aluno WHERE IdAluno =4;

/*Mostrar dados em uma "busca" com Like*/
SELECT * FROM aluno WHERE NomeAluno LIKE '%T%';


/*Ordenar por nome do aluno de forma ascendente*/
Select * FROM aluno ORDER BY NomeAluno ASC;

/*Ordenar por nome do aluno de forma decrescente*/
Select * FROM aluno ORDER BY NomeAluno DESC;



-- ####################################

SELECT * FROM aluno;

/* Utilizamos a função nativa COUNT jpara retornar o número de registros na minha tabela

AS >>> ALIAS

Usamos o Alias "AS" para nomear a coluna 
*/

Select COUNT(*) AS total_registros FROM aluno;

/*Pegamos a idade máxima do aluno */

SELECT MAX(Idade) AS idade_maxima FROM aluno;

/*Pegamos a idade mínima do aluno */

SELECT MIN(Idade) AS idade_minima FROM aluno;

/*Pegamos média de idade dos alunos */

SELECT AVG(Idade) As media_idade FROM aluno;


/*Somando as Idade*/
SELECT SUM(Idade) As soma_de_idades FROM aluno

SELECT 
	COUNT(*) AS total,
	Max(Idade) AS idade_maxima,
	Min(Idade) AS idade_minima,
	AVG(Idade) AS media_idade,
	SUM(Idade) AS soma_idade
FROM aluno;

-- #########################################################


select * from trabalho
INNER JOIN materia ON materia.IdMateria = trabalho.IdMateria
INNER JOIN aluno ON aluno.IdAluno = trabalho.IdAluno;


select 
	aluno.NomeAluno,
	aluno.RA,
	aluno.Idade,
	materia.Materia,
	trabalho.Nota
FROM trabalho
	INNER JOIN materia ON materia.IdMateria = trabalho.IdMateria
	INNER JOIN aluno ON aluno.IdAluno = trabalho.IdAluno;
		

-- #########################################################
/* 
	SUBSTRING 
	Pegamos parte de um string 
*/

SELECT SUBSTRING (NomeAluno, 0,2) AS inicial FROM aluno;

/*
UPPER
Deixar tudo em maiúscula
*/
SELECT UPPER(NomeAluno) AS Nome FROM aluno;

/*
LOWER
Deixar tudo em maiúscula
*/
SELECT LOWER(NomeAluno) AS Nome FROM aluno;