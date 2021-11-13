--Select the correct db
use [inew2330fa21];
GO

--Checks if the OrderItems table exists, if it does, drop
IF OBJECT_ID(N'group2fa212330.OrderItems', N'U') IS NOT NULL  
   DROP TABLE [group2fa212330].[OrderItems];
GO

--Checks if the Orders table exists, if it does, drop
IF OBJECT_ID(N'group2fa212330.Orders', N'U') IS NOT NULL  
   DROP TABLE [group2fa212330].[Orders];  
GO

--Checks if the Menu table exists, if it does, drop
IF OBJECT_ID(N'group2fa212330.Menu', N'U') IS NOT NULL  
   DROP TABLE [group2fa212330].[Menu];  
GO

--Checks if the Images table exists, if it does, drop
IF OBJECT_ID(N'group2fa212330.Images', N'U') IS NOT NULL  
   DROP TABLE [group2fa212330].[Images];  
GO

--Checks if the Payment table exists, if it does, drop
IF OBJECT_ID(N'group2fa212330.Payment', N'U') IS NOT NULL  
   DROP TABLE [group2fa212330].[Payment];  
GO



--Checks if the Paycheck table exists, if it does, drop
IF OBJECT_ID(N'group2fa212330.Paycheck', N'U') IS NOT NULL  
   DROP TABLE [group2fa212330].[Paycheck];  
GO

--Checks if the Employees table exists, if it does, drop
IF OBJECT_ID(N'group2fa212330.Employees', N'U') IS NOT NULL  
   DROP TABLE [group2fa212330].[Employees];  
GO

--Checks if the Positions table exists, if it does, drop
IF OBJECT_ID(N'group2fa212330.Positions', N'U') IS NOT NULL  
   DROP TABLE [group2fa212330].[Positions];  
GO

--Checks if the Salary table exists, if it does, drop
IF OBJECT_ID(N'group2fa212330.Salary', N'U') IS NOT NULL  
   DROP TABLE [group2fa212330].[Salary];  
GO

--Checks if the Account table exists, if it does, drop
IF OBJECT_ID(N'group2fa212330.Accounts', N'U') IS NOT NULL  
   DROP TABLE [group2fa212330].[Accounts];  
GO
--Checks if the Categories table exists, if it does, drop
IF OBJECT_ID(N'group2fa212330.Categories', N'U') IS NOT NULL  
   DROP TABLE [group2fa212330].[Categories];  
GO

----------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------

-- Create the Table --> Positions
CREATE TABLE [inew2330fa21].[group2fa212330].[Positions] (

    PositionID			INT				NOT NULL	PRIMARY KEY IDENTITY,
	PositionTitle		VARCHAR(50)		NOT NULL
);
GO

--Create the Table --> Images
CREATE TABLE [inew2330fa21].[group2fa212330].[Images] (

    ImageID				INT				NOT NULL	PRIMARY KEY IDENTITY,
	ImageName			VARCHAR(50)		NOT NULL,
	Image				VARBINARY(MAX)	NOT NULL,
	Description			VARCHAR(100)	NOT NULL
);
GO

--Create the Table --> Categories
CREATE TABLE [inew2330fa21].[group2fa212330].[Categories] (

	CategoryID			INT				NOT NULL	PRIMARY KEY IDENTITY,
	CategoryName		VARCHAR(50)		NOT NULL,
	ItemsInCategory		INT				NOT NULL	DEFAULT 0
);
GO

--Create the Table --> Menu
CREATE TABLE [inew2330fa21].[group2fa212330].[Menu] (

    ItemID				INT				NOT NULL	PRIMARY KEY IDENTITY,
	ItemName			VARCHAR(75)		NOT NULL,
	ItemDescription		VARCHAR(100)	NOT NULL,
	ImageID				INT				NOT NULL	REFERENCES [group2fa212330].[Images](ImageID),
	Price				MONEY			NOT NULL	CHECK(Price >= 0),
	CategoryID			INT				NOT NULL	REFERENCES [group2fa212330].[Categories](CategoryID)
);
GO

--Create Trigger --> After adding or deleting a menu item add to category account 
CREATE TRIGGER AddItemToItemCount
    ON [group2fa212330].[Menu]
    AFTER DELETE, INSERT
    AS
    BEGIN
    SET NOCOUNT ON
	IF EXISTS (SELECT 1 FROM inserted)
		UPDATE group2fa212330.Categories
		SET ItemsInCategory = ItemsInCategory + 1
		Where Categories.CategoryID = CategoryID
	ELSE
		UPDATE group2fa212330.Categories
		SET ItemsInCategory = ItemsInCategory - 1
		WHERE Categories.CategoryID = CategoryID
    END
GO

--Create Table --> Accounts
CREATE TABLE [inew2330fa21].[group2fa212330].[Accounts](
	
	AccountID			INT							PRIMARY KEY IDENTITY,
	--EmployeeID			INT				NULL		REFERENCES [group2fa212330].[Employees](EmployeeID),
	Email				VARCHAR(75)		NOT NULL,
	OneTimePassword		VARCHAR(20)		NOT NULL,
	Username			VARCHAR(50)		NOT NULL,
	Password			VARCHAR(20)		NOT NULL,
	LastName			VARCHAR(35)		NOT NULL,
	FirstName			VARCHAR(35)		NOT NULL,
	IsEmployee          BIT				NOT NULL
);
GO

--Create Table --> Employees
CREATE TABLE [inew2330fa21].[group2fa212330].[Employees](

	EmployeeID			INT							PRIMARY KEY IDENTITY,
	AccountID			INT							REFERENCES [group2fa212330].[Accounts](AccountID),
	PositionID			INT				NOT NULL	REFERENCES [group2fa212330].[Positions](PositionID),
	isAdmin				BIT				NOT NULL,
	isActive			BIT				NOT NULL,
	AccountNumber		VARCHAR(17)		NOT NULL,
	RoutingNumber		VARCHAR(9)		NOT NULL,
	Address				VARCHAR(20)		NOT NULL,
	Phone				VARCHAR(20)		NOT NULL
);
GO

--Create Table --> Paycheck
CREATE TABLE [inew2330fa21].[group2fa212330].[Paycheck](

	PaycheckID			INT							PRIMARY KEY IDENTITY,
	EmployeeID			INT				NOT NULL	REFERENCES [group2fa212330].[Employees](EmployeeID),
	Tips				MONEY			NULL		CHECK( Tips >= 0 ),
	NetPay				MONEY			NULL,
	HoursWorked			FLOAT			NULL,
	SalaryPay			MONEY			NULL,
	HourlyPay			MONEY			NULL,
	WeeklyPaid			MONEY			NOT NULL,
	SocialSecurityTax	FLOAT			NULL,
	FICA				FLOAT			NULL,
	Retirement			FLOAT			NULL,
	CHECK((SalaryPay IS NULL AND HourlyPay IS NOT NULL) OR (SalaryPay IS NOT NULL AND HourlyPay IS NULL))
);
GO


CREATE TABLE [inew2330fa21].[group2fa212330].[Payment](

	PaymentID			INT							PRIMARY KEY IDENTITY,
	AccountID			INT							REFERENCES [group2fa212330].[Accounts](AccountID),
	Type				VARCHAR(50)		NOT NULL,
	CardNumber			VARCHAR(16)		NOT NULL,
	CardName			VARCHAR(50)		NOT NULL,
	SecurityCode		VARCHAR(3)		NOT NULL,
	ExpirationDate		VARCHAR(4)		NOT NULL

);
GO

--Create Table --> Orders
CREATE TABLE [inew2330fa21].[group2fa212330].[Orders](
	
	OrderID				INT				NOT NULL	PRIMARY KEY IDENTITY,
	EmployeeID			INT				NOT NULL	REFERENCES [group2fa212330].[Employees](EmployeeID),
	AccountID			INT				NOT NULL	REFERENCES [group2fa212330].[Accounts](AccountID),
	PaymentID			INT				NOT NULL	REFERENCES [group2fa212330].[Payment](PaymentID),
	OrderDate			DATE			NOT NULL,
	OrderQty			INT				NOT NULL,
	TotalDue			MONEY			NOT NULL,
	Tip					MONEY			NOT NULL

);

--Create the Table --> OrderItems
CREATE TABLE [inew2330fa21].[group2fa212330].[OrderItems](

	OrderID				INT				NOT NULL,
	ItemID				INT				NOT NULL,
	Qty					INT				NOT NULL
	CONSTRAINT CK_OrderItem PRIMARY KEY(OrderID, ItemID)
);
GO

CREATE TRIGGER [group2fa212330].[AddAndDeleteItemToOrder]
    ON [group2fa212330].[OrderItems]
    AFTER DELETE, INSERT, UPDATE
    AS
	BEGIN
	SET NOCOUNT ON
    IF EXISTS (SELECT * FROM inserted) and  EXISTS (SELECT * FROM deleted) -- IF THE ITEM COUNT IS UPDATED
	
	UPDATE group2fa212330.Orders
	SET OrderQty = OrderQty + -((SELECT Qty FROM inserted) - (SELECT Qty FROM deleted)), 
	TotalDue = TotalDue + -((Select inserted.Qty * m.Price from inserted inner join group2fa212330.Menu m on inserted.ItemID = m.ItemID) - (Select deleted.Qty * m.Price from deleted inner join group2fa212330.Menu m on deleted.ItemID = m.ItemID))
	WHERE OrderID = (Select OrderID FROM inserted);
    
	ELSE IF EXISTS(SELECT * FROM inserted)-- IF THE ITEM IS ADDED TO THE ITEM

    UPDATE group2fa212330.Orders
	SET OrderQty = OrderQty + (Select Qty from inserted), TotalDue = TotalDue + (Select inserted.Qty * m.Price from inserted inner join group2fa212330.Menu m on inserted.ItemID = m.ItemID)
	WHERE OrderID = (SELECT OrderID FROM inserted);

	ElSE IF EXISTS(SELECT * FROM deleted)-- IF THE ITEM IS DELETED FROM THE ITEM

    UPDATE group2fa212330.Orders
	SET OrderQty = OrderQty - (Select Qty from deleted), 
	TotalDue = TotalDue - (Select deleted.Qty * m.Price from deleted inner join group2fa212330.Menu m on deleted.ItemID = m.ItemID)
	where OrderID = (SELECT OrderID FROM deleted);
END


insert into group2fa212330.Positions (PositionTitle) values ('Manager');
insert into group2fa212330.Positions (PositionTitle) values ('Cashier');
insert into group2fa212330.Positions (PositionTitle) values ('Waiter');
insert into group2fa212330.Positions (PositionTitle) values ('Host');
insert into group2fa212330.Positions (PositionTitle) values ('Head Chef');
insert into group2fa212330.Positions (PositionTitle) values ('Busser');
insert into group2fa212330.Positions (PositionTitle) values ('Dishwasher');
insert into group2fa212330.Positions (PositionTitle) values ('Chef');
GO
select * from group2fa212330.Images
INSERT INTO group2fa212330.Images (ImageName, Image, Description) values ('Sample1', CAST('0123456789ABCDEF' AS varbinary(max)), 'Same');
INSERT INTO group2fa212330.Images (ImageName, Image, Description) values ('Sample2', CAST('0123456789ABCDEF' AS varbinary(max)), 'Same');
INSERT INTO group2fa212330.Images (ImageName, Image, Description) values ('Sample3', CAST('0123456789ABCDEF' AS varbinary(max)), 'Same');
INSERT INTO group2fa212330.Images (ImageName, Image, Description) values ('Sample4', CAST('0123456789ABCDEF' AS varbinary(max)), 'Same');
INSERT INTO group2fa212330.Images (ImageName, Image, Description) values ('Sample5', CAST('0123456789ABCDEF' AS varbinary(max)), 'Same');
INSERT INTO group2fa212330.Images (ImageName, Image, Description) values ('Sample6', CAST('0123456789ABCDEF' AS varbinary(max)), 'Same');
GO


insert into group2fa212330.Accounts (Email, OneTimePassword, Username, Password, LastName, FirstName, IsEmployee) values ('rdemeza0@360.cn', '256sr1OzR8', 'rdemeza0', '59g0GR05', 'Demeza', 'Randall',0);
insert into group2fa212330.Accounts (Email, OneTimePassword, Username, Password, LastName, FirstName, IsEmployee) values ('fcomberbach1@whitehouse.gov', '585oi1XhE9', 'fcomberbach1', 'aPfJeXLg9sF', 'Comberbach', 'Francois',0);
insert into group2fa212330.Accounts (Email, OneTimePassword, Username, Password, LastName, FirstName, IsEmployee) values ('sdeerr2@is.gd', '803ey2NeK3', 'sdeerr2', 'xSK0fYE', 'Deerr', 'Sondra',1);
insert into group2fa212330.Accounts (Email, OneTimePassword, Username, Password, LastName, FirstName, IsEmployee) values ('memtage3@nasa.gov', '4310z2DsO4', 'memtage3', 'sltlqDFn', 'Emtage', 'Michell',0);
insert into group2fa212330.Accounts (Email, OneTimePassword, Username, Password, LastName, FirstName, IsEmployee) values ('dcoultar4@toplist.cz', '173qa8LgU6', 'dcoultar4', 'YSGQDxS', 'Coultar', 'Douglass',1);
insert into group2fa212330.Accounts (Email, OneTimePassword, Username, Password, LastName, FirstName, IsEmployee) values ('mmckay5@mysql.com', '814ah6IxW8', 'mmckay5', 'O3UoUjk8r', 'McKay', 'Murial',0);
insert into group2fa212330.Accounts (Email, OneTimePassword, Username, Password, LastName, FirstName, IsEmployee) values ('hfilippello6@spiegel.de', '823yl0FzG3', 'hfilippello6', 'oZengJzEX2N', 'Filippello', 'Hector',0);
insert into group2fa212330.Accounts (Email, OneTimePassword, Username, Password, LastName, FirstName, IsEmployee) values ('lasker7@scribd.com', '282jn8XmM3', 'lasker7', 'nHzIEsLvZYQj', 'Asker', 'Lindie',0);
insert into group2fa212330.Accounts (Email, OneTimePassword, Username, Password, LastName, FirstName, IsEmployee) values ('mgillison8@qq.com', '548hq4YuV5', 'mgillison8', 'N8o8jHDN', 'Gillison', 'Maurizio',1);
insert into group2fa212330.Accounts (Email, OneTimePassword, Username, Password, LastName, FirstName, IsEmployee) values ('mcrookshanks9@reference.com', '523nu1UcP4', 'mcrookshanks9', 'h2lRLoG', 'Crookshanks', 'Mic',0);
insert into group2fa212330.Accounts (Email, OneTimePassword, Username, Password, LastName, FirstName, IsEmployee) values ('tpesica@tuttocitta.it', '903yz8SpF8', 'tpesica', 'iFN7A3NblsGO', 'Pesic', 'Tito',0);
insert into group2fa212330.Accounts (Email, OneTimePassword, Username, Password, LastName, FirstName, IsEmployee) values ('ngilmanb@state.gov', '316iq8GpV7', 'ngilmanb', 'CawIz0', 'Gilman', 'Nicholle',0);
insert into group2fa212330.Accounts (Email, OneTimePassword, Username, Password, LastName, FirstName, IsEmployee) values ('ctukec@cornell.edu', '228di9UbM9', 'ctukec', 'YfDPRPU9zx9', 'Tuke', 'Cristal',0);
insert into group2fa212330.Accounts (Email, OneTimePassword, Username, Password, LastName, FirstName, IsEmployee) values ('apregeld@networksolutions.com', '278iy2JtO0', 'apregeld', 'vnSRl6xKma', 'Pregel', 'Angie',1);
insert into group2fa212330.Accounts (Email, OneTimePassword, Username, Password, LastName, FirstName, IsEmployee) values ('cfranceye@t.co', '090kd2UzA8', 'cfranceye', 'gJCLlrKMpTG', 'Francey', 'Clim',1);
GO

insert into group2fa212330.Employees (AccountID, PositionID, isAdmin, isActive, AccountNumber, RoutingNumber, Address, Phone) values (3,5, 1, 1, 892197960675, 439544342, '47 Transport Road', '554-245-9533');
insert into group2fa212330.Employees (AccountID, PositionID, isAdmin, isActive, AccountNumber, RoutingNumber, Address, Phone) values (5,6, 1, 1, 389688784565, 942063316, '39 Delaware Alley', '727-734-5345');
insert into group2fa212330.Employees (AccountID, PositionID, isAdmin, isActive, AccountNumber, RoutingNumber, Address, Phone) values (9,5, 0, 0, 568115576442, 626697340, '12 Novick Alley', '699-816-5223');
insert into group2fa212330.Employees (AccountID, PositionID, isAdmin, isActive, AccountNumber, RoutingNumber, Address, Phone) values (14,2, 1, 0, 183880128705, 348518844, '652 Porter Avenue', '863-154-6706');
insert into group2fa212330.Employees (AccountID, PositionID, isAdmin, isActive, AccountNumber, RoutingNumber, Address, Phone) values (15,8, 1, 0, 746485451224, 925212284, '36 Hansons Pass', '809-354-3538');
GO

insert into group2fa212330.Paycheck(EmployeeID, Tips, NetPay, SalaryPay, WeeklyPaid, SocialSecurityTax, FICA, Retirement) values(1,0,500,30000,700,100,50,50)
insert into group2fa212330.Paycheck(EmployeeID, Tips, NetPay, SalaryPay, WeeklyPaid, SocialSecurityTax, FICA, Retirement) values(1,0,400,27000,600,100,50,50)
insert into group2fa212330.Paycheck(EmployeeID, Tips, NetPay, HoursWorked, HourlyPay, WeeklyPaid,SocialSecurityTax, FICA, Retirement) values(3,30,290,25,12,300,0,30,10)
insert into group2fa212330.Paycheck(EmployeeID, Tips, NetPay, HoursWorked, HourlyPay, WeeklyPaid,SocialSecurityTax, FICA, Retirement) values(4,0,142,18,9,162,0,10,10)
insert into group2fa212330.Paycheck(EmployeeID, Tips, NetPay, HoursWorked, HourlyPay, WeeklyPaid,SocialSecurityTax, FICA, Retirement) values(5,30,240,25,10,250,0,30,10)
GO

insert into group2fa212330.Menu(ItemName,ItemDescription, ImageID, Price, CategoryID) values('Cheeseburger','2 buns with a slice of cheese',1,6.99,1)
insert into group2fa212330.Menu(ItemName,ItemDescription, ImageID, Price, CategoryID) values('Hamburger','2 buns and a burger with onions and a pickle',2,6.99,1)
insert into group2fa212330.Menu(ItemName,ItemDescription, ImageID, Price, CategoryID) values('Chicken Tenders','4 Pieces of chicken tenders',3,7.99,1)
insert into group2fa212330.Menu(ItemName,ItemDescription, ImageID, Price, CategoryID) values('Shakes','Choice of Vanilla, Chocolate or Strawberry',4,1.99,4)
insert into group2fa212330.Menu(ItemName,ItemDescription, ImageID, Price, CategoryID) values('Lava Cake','Warm cake with ice cream on top',5,3.99,3)
insert into group2fa212330.Menu(ItemName,ItemDescription, ImageID, Price, CategoryID) values('Ice Cream Cone','Ice cream on a cone',6,1.99,3)
GO


insert into group2fa212330.Orders(EmployeeID, AccountID, PaymentID, OrderDate, OrderQty, TotalDue, Tip) values (1, 1,8, convert(varchar, getdate(), 23) , 0,0,0);
insert into group2fa212330.Orders(EmployeeID, AccountID, PaymentID, OrderDate, OrderQty, TotalDue, Tip) values (2,7,12, convert(varchar, getdate(), 23) , 0,0,0);
insert into group2fa212330.Orders(EmployeeID, AccountID, PaymentID, OrderDate, OrderQty, TotalDue, Tip) values (3,13,10, convert(varchar, getdate(), 23) , 0,0,0);
insert into group2fa212330.Orders(EmployeeID, AccountID, PaymentID, OrderDate, OrderQty, TotalDue, Tip) values (4,2,9, convert(varchar, getdate(), 23) , 0,0,0);
insert into group2fa212330.Orders(EmployeeID, AccountID, PaymentID, OrderDate, OrderQty, TotalDue, Tip) values (5,10,11, convert(varchar, getdate(), 23) , 0,0,0);
go

select * from group2fa212330.Orders;
go
--OrderID,	EmployeeID,	AccountID,	PaymentID,	OrderDate,	OrderQty,	TotalDue,	Tip


--insert into group2fa212330.Orders (EmployeeID, AccountID, PaymentID, OrderDate, OrderQty, TotalDue, Tip)


update group2fa212330.Images
set ImageName = 'cheeseburger'
where ImageID = 1;

select * from group2fa212330.Orders
update group2fa212330.Menu set ImageID = 1 where ItemID = 1
update group2fa212330.Menu set ImageID = 2 where ItemID = 2
update group2fa212330.Menu set ImageID = 3 where ItemID = 3
update group2fa212330.Menu set ImageID = 4 where ItemID = 4
update group2fa212330.Menu set ImageID = 5 where ItemID = 5
update group2fa212330.Menu set ImageID = 6 where ItemID = 6

insert into group2fa212330.Paycheck(EmployeeID, Tips, NetPay, SalaryPay, WeeklyPaid, SocialSecurityTax, FICA, Retirement) values(1,0,500,30000,700,100,50,50)
insert into group2fa212330.Paycheck(EmployeeID, Tips, NetPay, SalaryPay, WeeklyPaid, SocialSecurityTax, FICA, Retirement) values(1,0,400,27000,600,100,50,50)
insert into group2fa212330.Paycheck(EmployeeID, Tips, NetPay, HoursWorked, HourlyPay, WeeklyPaid,SocialSecurityTax, FICA, Retirement) values(3,30,290,25,12,300,0,30,10)
insert into group2fa212330.Paycheck(EmployeeID, Tips, NetPay, HoursWorked, HourlyPay, WeeklyPaid,SocialSecurityTax, FICA, Retirement) values(4,0,142,18,9,162,0,10,10)
insert into group2fa212330.Paycheck(EmployeeID, Tips, NetPay, HoursWorked, HourlyPay, WeeklyPaid,SocialSecurityTax, FICA, Retirement) values(5,30,240,25,10,250,0,30,10)

insert into group2fa212330.Menu(ItemName,ItemDescription, ImageID, Price, CategoryID) values('Cheeseburger','2 buns with a slice of cheese',1,6.99,1)
insert into group2fa212330.Menu(ItemName,ItemDescription, ImageID, Price, CategoryID) values('Hamburger','2 buns and a burger with onions and a pickle',2,6.99,1)
insert into group2fa212330.Menu(ItemName,ItemDescription, ImageID, Price, CategoryID) values('Chicken Tenders','4 Pieces of chicken tenders',3,7.99,1)
insert into group2fa212330.Menu(ItemName,ItemDescription, ImageID, Price, CategoryID) values('Shakes','Choice of Vanilla, Chocolate or Strawberry',4,1.99,4)
insert into group2fa212330.Menu(ItemName,ItemDescription, ImageID, Price, CategoryID) values('Lava Cake','Warm cake with ice cream on top',5,3.99,3)
insert into group2fa212330.Menu(ItemName,ItemDescription, ImageID, Price, CategoryID) values('Ice Cream Cone','Ice cream on a cone',6,1.99,3)