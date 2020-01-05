Drop DATABASE Employe;
CREATE DATABASE Employe;
Use Employe;

CREATE TABLE teachers (
    teacher_id INT NOT NULL PRIMARY KEY,
    name varchar(255),
    manager_id int,
    FOREIGN KEY (manager_id) REFERENCES teachers(teacher_id)
);

INSERT INTO teachers
VALUES (101,'John', NUll);