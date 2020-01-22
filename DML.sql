/*Inserir Dados de um Aluno*/
use boletim;

INSERT INTO aluno (NomeAluno, RA , Idade) VALUES ('Thalita', 'R123', 24);


/*Inserir dados na tabela matéria*/

INSERT INTO materia (Materia) VALUES ('ING');


UPDATE aluno SET
	NomeAluno = 'Thalita Mariano',
	Idade = 20
WHERE IdAluno = 1;


DELETE FROM materia WHERE IdMateria=2;


TRUNCATE TABLE NomeTabela