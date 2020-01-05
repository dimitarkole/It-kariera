use soft_uni;
/*Problem 2.	Намерете цялата информация за отделите*/
/*Select* from departments;*/

/*Problem 3.	Намерете всички имена на отдели*/
/*Select name from departments;*/

/*Problem 4.	Намерете заплатата на всеки служител*/
/*Select first_name, last_name, salary from employees;*/

/*Problem 5.	Намерете пълното име на всеки служител*/
/*Select first_name, middle_name, last_name from employees;*/

/*Problem 6.	Намерете имейл адреса на всеки служител*/
/*Select concat(employees.first_name,".",employees.last_name,"@softuni.bg") 
as full_email_address from employees;*/

/*Problem 7. 	Намерете всички различни работни заплати*/
/*Select Salary from employees Group by Salary;*/

/*Problem 8.	Намерете цялата информация за служители*/
/*Select	employees.employee_id as id, 
employees.first_name as FirstName,
employees.last_name	as LastName,
employees.middle_name as MiddleName,
employees.job_title	as Job,
employees.department_id	as DeptID,
employees.manager_id as MngrID,
employees.hire_date as HireDate,
employees.salary as salary,
employees.address_id as address_id			
 from employees;
*/

/*Problem 9.	Намерете имената на всички служители със заплата в диапазон*/
/*Select first_name, last_name, salary from employees 
	where salary>=20000 && salary<=30000;*/
    
/*Problem 10.	Намерете имената на всички служители*/
Select concat(employees.first_name," ", employees.middle_name, " ",
	employees.last_name) 
as full_name from employees;