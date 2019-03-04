-- Switch to the system (aka master) database
USE master;
GO

-- Delete the World Database (IF EXISTS)
IF EXISTS(select * from sys.databases where name='MvcMovie')
DROP DATABASE MvcMovie;
GO

-- Create a new World Database
CREATE DATABASE MvcMovie;
GO

-- Switch to the World Database
USE MvcMovie
GO

-- Begin a TRANSACTION that must complete with no errors
BEGIN TRANSACTION;

CREATE TABLE movie (
    id INT NOT NULL IDENTITY,
	title VARCHAR(64) NOT NULL,
	genre VARCHAR(64) NOT NULL,
	length int NOT NULL,
	director VARCHAR(64) NOT NULL,
	price MONEY NOT NULL,
	releaseDate DATETIME NOT NULL,    
    CONSTRAINT pk_movie_id PRIMARY KEY (id),
);

COMMIT TRANSACTION;

INSERT INTO movie(title, length, genre, director, price, releaseDate)
VALUES ('The Hobbit: An Unexpected Journey', 169, 'Fantasy', 'Peter Jackson', 3.99, '12/12/2012');
