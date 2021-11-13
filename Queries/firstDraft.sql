--1
--Determines whether the login information exists or not.
	   SELECT CASE WHEN EXISTS 
      (
            SELECT 1 FROM group2fa212330.Accounts where Username = 'bob' AND Password = 'bob123'
      )
      THEN 'TRUE' ELSE 'FALSE' END AS 'DoesAccountExist';

--2
--Retrieves the current customer's payment
SELECT * FROM group2fa212330.Payment WHERE AccountID = 1;
--3
--Paramater Query for Crystal Reports - Part 1
SELECT * from group2fa212330.Images;

--4
--Paramater Query for Crystal Reports - Part 2
SELECT * FROM group2fa212330.Orders where AccountID = 1;

--5
--Fill the dgvMenu control with the food items, 1 = food
SELECT * FROM group2fa212330.Menu WHERE CategoryID = 1;

--6
--Fill the dgvDessertsAndShakes control with the food items, 2 = shakes, 3 = desserts
SELECT * FROM group2fa212330.Menu WHERE CategoryID IN (2,3);

--7
--Retrieve the banking information from the employee
SELECT a.AccountID, a.Email, CONCAT(a.FirstName, ' ', a.LastName) as 'Name',
e.AccountNumber, e.RoutingNumber FROM group2fa212330.Employees e INNER JOIN group2fa212330.Accounts a
ON a.AccountID = e.AccountID where e.EmployeeID = 1;

--8
--Retrieve the personal information
SELECT AccountID, Email, Username, Password, CONCAT(FirstName, ' ', LastName) AS 'Name' FROM group2fa212330.Accounts;

--9
--Selects the otp for the forgotten password account
SELECT OneTimePassword FROM group2fa212330.Accounts WHERE Email = 'fcomberbach1@whitehouse.gov';

--10
--Select all from new paycheck to insert into the form
select * from group2fa212330.Paycheck

--had to delete 4 queries due to permission rights trouble with CREATE TRANSACTION, CREATE PROCEDURE, and CREATE TRIGGER