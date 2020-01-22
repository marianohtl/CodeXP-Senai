CREATE DATABASE LojasMel

USE LojasMel

CREATE TABLE marcas(
IdMarca INT IDENTITY PRIMARY KEY NOT NULL, 
Marca VARCHAR(40)
); 

CREATE TABLE cores(
IdCor INT IDENTITY PRIMARY KEY NOT NULL, 
Cores VARCHAR(20)
); 


CREATE TABLE tamanho(
IdTamanho INT IDENTITY PRIMARY KEY NOT NULL, 
Tamanho VARCHAR(5)
);

CREATE TABLE camisa(
IdCamisa INT IDENTITY PRIMARY KEY NOT NULL, 
IdCor INT FOREIGN KEY REFERENCES cores (IdCor),
IdTamanho INT FOREIGN KEY REFERENCES tamanho (IdTamanho),
IdMarca INT FOREIGN KEY REFERENCES marcas (IdMarca)
);

INSERT INTO marcas (Marca) VALUES
('BOSS'),
('LACOSTE'),
('TOMMY');

INSERT INTO cores (Cores) VALUES
('ROSA'),
('AMARELO'),
('VERMELHO'),
('VERDE');

INSERT INTO tamanho(Tamanho) VALUES
('P'),
('M'),
('G'),
('GG');

INSERT INTO camisa( IdCor, IdTamanho, IdMarca) 
VALUES 
(1,1,1),
(1,2,2),
(1,3,3),
(1,4,5);

select * from tamanho;
select * from cores;
select * from marcas;
select * from camisa;




INSERT INTO camisa(IdCor, IdTamanho,IdMarca)
VALUES
(1,1,1),
(1,2,2),
(1,3,1);


UPDATE marcas SET
	Marca = 'Boss'
WHERE IdMarca = 1;


UPDATE marcas SET
	Marca = 'Lacoste'
WHERE IdMarca = 2;

DELETE FROM materia WHERE IdMateria=2;