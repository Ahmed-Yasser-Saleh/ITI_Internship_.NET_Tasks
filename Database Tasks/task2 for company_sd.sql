--1
select Fname + ' ' + lname as Fullname,MGRSSN,Dnum,Dname
from Departments, Employee
where SSN = MGRSSN

--2
select Dname,Pname
from Departments, Project
where Project.Dnum = Departments.Dnum

--3
select Fname + ' ' + lname as Fullname,Dependent_name, dependent.Sex,dependent.Bdate
from Employee, Dependent
where ESSN = SSN

--4
select Pname, Pnumber, Plocation
from project
where Project.city ='Cairo'or Project.city ='Alex'

--5
select *
from project
where Pname like 'a%' 

--6
select Fname + ' ' + lname as Fullname
from  Employee
where Employee.Dno = 30 and salary between 1000 and 3000;

--7
select Fname + ' ' + lname as Fullname
from  Employee inner join Works_for
on Employee.Dno = 10 and Works_for.essn = SSN and Works_for.Hours = 10
inner join
Project
on Project.Pnumber = Works_for.Pno and Project.Pname = 'AL Rabwah'

--8
select x.Fname + ' ' + x.lname as Fullname
from  Employee x, Employee y
where y.SSN = x.Superssn and y.Fname = 'kamel' 


--9
select Fname + ' ' + lname as Fullname, Project.Pname
from  Employee inner join Works_for
on Employee.SSN  = Works_for.ESSn 
inner join
Project
on Project.Pnumber = Works_for.Pno 
order by 2

--10
select Project.Pnumber,Departments.Dname, Employee.Lname,Employee.Address,Employee.Bdate
from  Project inner join Departments
on Project.Dnum = Departments.Dnum and Project.City ='cairo'
inner join
Employee
on Employee.SSN = Departments.MGRSSN 

--11
select Employee.*
from  Employee ,Departments
where SSN = MGRSSN

--12
select Employee.*, Dependent.*
from Employee left outer join Dependent
on ESSN = SSN

--13
insert into Employee(SSN,Salary,Superssn,Dno)
values(102672, 3000, 112233, 30)

--14
insert into Employee(SSN,Dno)
values(102660, 30)

--15
update employee 
set Salary = 1.2 * salary
where ssn = 102672