Drop DATABASE school;
CREATE DATABASE school;
Use school;

CREATE TABLE Students (
    student_id INT PRIMARY KEY not null,
    name varchar(255)
);

CREATE TABLE Exams (
    exam_id INT PRIMARY KEY not null,
    name varchar(255)
);

CREATE TABLE Students_exams (
    student_id INT,
    exam_id INT,
	FOREIGN KEY (student_id) REFERENCES Students(student_id),
     FOREIGN KEY (exam_id) REFERENCES Exams(exam_id)
);

INSERT INTO Students
VALUES (1,'Mila');
INSERT INTO Students
VALUES (2,'Toni');
INSERT INTO Students
VALUES (3,'Ron');

INSERT INTO Exams
VALUES (101,'Spring MVC');
INSERT INTO Exams
VALUES (102,'Neo4j');
INSERT INTO Exams
VALUES (103,'Oracle 11g');

INSERT INTO Students_exams
VALUES (1,101);
INSERT INTO Students_exams
VALUES (1,102);
INSERT INTO Students_exams
VALUES (2,101);
INSERT INTO Students_exams
VALUES (3,102);
INSERT INTO Students_exams
VALUES (2,102);
INSERT INTO Students_exams
VALUES (2,103);