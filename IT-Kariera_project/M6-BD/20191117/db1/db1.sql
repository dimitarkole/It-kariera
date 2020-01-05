Drop DATABASE  db1;
CREATE DATABASE db1;
Use db1;

CREATE TABLE Passports (
    passport_id INT NOT NULL PRIMARY KEY,
    passport_number varchar(255)    
);

CREATE TABLE Persons (
    person_id INT PRIMARY KEY,
    first_name varchar(255),
    salary Double,
    passport_id INT NOT NULL,
	FOREIGN KEY (passport_id) REFERENCES Passports(passport_id)
);

INSERT INTO Passports(passport_id, passport_number)
VALUES (101, 'N34FG21B');

INSERT INTO Passports(passport_id, passport_number)
VALUES (102, 'K65LO4R7');

INSERT INTO Passports(passport_id, passport_number)
VALUES (103, 'K65LO4R7');

INSERT INTO Persons(person_id,
    first_name,
    salary,
    passport_id)
VALUES (1,
'Roberto',
 43300.00,
 101);

INSERT INTO Persons(person_id, first_name, salary, passport_id)
VALUES (2,'Tom', 56100.00, 102);

INSERT INTO Persons(person_id, first_name, salary, passport_id)
VALUES (3,'Yana', 60200.00, 103);