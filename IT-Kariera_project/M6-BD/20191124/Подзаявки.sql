use soft_uni;

SELECT first_name, last_name, salary 
	from employees
	Where salary IN 
    (Select min(salary) from employees);
    
SELECT first_name, last_name, salary 
	from employees
	Where salary >=
    (Select min(salary) from employees)
    && salary <=
    (Select min(salary)*1.1 from employees);