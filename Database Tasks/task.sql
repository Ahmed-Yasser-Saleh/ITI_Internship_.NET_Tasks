--1
select Dependent_name, Dependent.Sex
from Dependent inner join Employee
on Dependent.ESSN = Employee.SSN
where Dependent.Sex = 'F' and Employee.Sex = 'F'
union all
select Dependent_name, Dependent.Sex
from Dependent inner join Employee
on Dependent.ESSN = Employee.SSN
where Dependent.Sex = 'M' and Employee.Sex = 'M'

--2
select Pname, Hours
FROM Employee inner join Works_for
on ESSn = SSN
inner join 
Project
on Project.Pnumber = Works_for.Pno

--3
Select Departments.* from
Departments inner join Employee
on Departments.Dnum = Employee.Dno
where Employee.SSN = (select min(ssn) from Employee)

--4
Select Departments.Dname, max(salary) as mx_salary, min(salary) as min_salary, avg(salary) as avg_salary from 
Departments inner join Employee
on Departments.Dnum = Employee.Dno
group by Departments.Dname

--5
SELECT Employee.Fname + ' ' + Employee.Lname AS fullname
FROM Employee
INNER JOIN Departments ON Departments.MGRSSN = Employee.SSN
LEFT OUTER JOIN Dependent 
ON Dependent.ESSN = Employee.SSN
WHERE Dependent.ESSN IS NULL;

--6 
Select Departments.Dname, count(Employee.SSN) as employee_num
from Departments inner join Employee
on Departments.Dnum = Employee.Dno
group by Departments.Dname
having avg(salary) < (select avg(Salary) from Employee)

--7
select Pname, Employee.Fname + ' ' + Employee.Lname AS fullname
FROM Employee inner join Works_for
on ESSn = SSN
inner join 
Project
on Project.Pnumber = Works_for.Pno
inner join
Departments
on Employee.Dno = Departments.Dnum
order by Departments.Dnum, fullname

--8
select  distinct top(2) salary
from Employee
order by salary desc
--==
SELECT MAX(Salary) AS MaxSalary
FROM Employee
union all
SELECT MAX(Salary) AS MaxSalary
FROM Employee
WHERE Salary < (SELECT MAX(Salary) FROM Employee)

--9
SELECT Employee.Fname + ' ' + Employee.Lname AS fullname
from employee inner join Dependent
on (SELECT Employee.Fname + ' ' + Employee.Lname AS fullname) = Dependent.Dependent_name 

--10
SELECT Employee.SSN, Employee.Fname + ' ' + Employee.Lname AS fullname
FROM Employee
WHERE EXISTS (
    SELECT 1
    FROM Dependent
    WHERE Dependent.ESSN = Employee.SSN
)

--11
insert into departments
values('DEPT IT', 100, 112233, '1-11-2006')

--12
update Departments
set MGRSSN = 968574
where Dnum = 100

update Departments
set MGRSSN = 102672
where Dnum = 20

update Employee
set Superssn = 102672
where SSN = 102660

--13
update Employee
set Superssn = null
where superssn = (select ssn from Employee where Fname + ' ' + Lname = 'Kamel mohamed')

update Departments
set MGRSSN = null
where MGRSSN = (select ssn from Employee where Fname + ' ' + Lname = 'Kamel mohamed')

delete from Dependent
where ESSN = (select ssn from Employee where Fname + ' ' + Lname = 'Kamel mohamed')

delete from Works_for
where ESSN = (select ssn from Employee where Fname + ' ' + Lname = 'Kamel mohamed')

delete from Employee
where Fname + ' ' + Lname = 'Kamel mohamed'

--14
update Employee
set salary = 1.3 * (select salary from
Employee inner join Works_for
on ESSn = SSN
inner join 
Project
on Project.Pnumber = Works_for.Pno
where Project.Pname = 'Al Rabwah')
