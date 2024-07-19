--1
select * from Employee
--2
select Fname, Lname, Salary, Dno from Employee
--3
select Pname, PLocation,Dnum from Project
--4
select Fname + ' ' + lname as Fullname ,salary * 0.1 as annual_commission 
from Employee
--5
select SSN,	Fname, Lname from Employee
where Salary >= 1000
--6
select SSN,	Fname, Lname from Employee
where (Salary * 12) >= 10000
--7
select Fname, Lname, Salary from Employee
where SEX = 'F'
--8
select Dnum, Dname from departments
where MGRSSN = 968574
--9
select Pname, PLocation,Pnumber from Project
where Dnum = 10