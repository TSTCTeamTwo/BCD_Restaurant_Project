use inew2330fa21


insert into group2fa212330.Accounts (EmployeeID, Email, OneTimePassword, Username, Password, LastName, FirstName) values (null, 'rdemeza0@360.cn', '256sr1OzR8', 'rdemeza0', '59g0GR05', 'Demeza', 'Randall');
insert into group2fa212330.Accounts (EmployeeID, Email, OneTimePassword, Username, Password, LastName, FirstName) values (null, 'fcomberbach1@whitehouse.gov', '585oi1XhE9', 'fcomberbach1', 'aPfJeXLg9sF', 'Comberbach', 'Francois');
insert into group2fa212330.Accounts (EmployeeID, Email, OneTimePassword, Username, Password, LastName, FirstName) values (1, 'sdeerr2@is.gd', '803ey2NeK3', 'sdeerr2', 'xSK0fYE', 'Deerr', 'Sondra');
insert into group2fa212330.Accounts (EmployeeID, Email, OneTimePassword, Username, Password, LastName, FirstName) values (null, 'memtage3@nasa.gov', '4310z2DsO4', 'memtage3', 'sltlqDFn', 'Emtage', 'Michell');
insert into group2fa212330.Accounts (EmployeeID, Email, OneTimePassword, Username, Password, LastName, FirstName) values (2, 'dcoultar4@toplist.cz', '173qa8LgU6', 'dcoultar4', 'YSGQDxS', 'Coultar', 'Douglass');
insert into group2fa212330.Accounts (EmployeeID, Email, OneTimePassword, Username, Password, LastName, FirstName) values (null, 'mmckay5@mysql.com', '814ah6IxW8', 'mmckay5', 'O3UoUjk8r', 'McKay', 'Murial');
insert into group2fa212330.Accounts (EmployeeID, Email, OneTimePassword, Username, Password, LastName, FirstName) values (null, 'hfilippello6@spiegel.de', '823yl0FzG3', 'hfilippello6', 'oZengJzEX2N', 'Filippello', 'Hector');
insert into group2fa212330.Accounts (EmployeeID, Email, OneTimePassword, Username, Password, LastName, FirstName) values (null, 'lasker7@scribd.com', '282jn8XmM3', 'lasker7', 'nHzIEsLvZYQj', 'Asker', 'Lindie');
insert into group2fa212330.Accounts (EmployeeID, Email, OneTimePassword, Username, Password, LastName, FirstName) values (3, 'mgillison8@qq.com', '548hq4YuV5', 'mgillison8', 'N8o8jHDN', 'Gillison', 'Maurizio');
insert into group2fa212330.Accounts (EmployeeID, Email, OneTimePassword, Username, Password, LastName, FirstName) values (null, 'mcrookshanks9@reference.com', '523nu1UcP4', 'mcrookshanks9', 'h2lRLoG', 'Crookshanks', 'Mic');
insert into group2fa212330.Accounts (EmployeeID, Email, OneTimePassword, Username, Password, LastName, FirstName) values (null, 'tpesica@tuttocitta.it', '903yz8SpF8', 'tpesica', 'iFN7A3NblsGO', 'Pesic', 'Tito');
insert into group2fa212330.Accounts (EmployeeID, Email, OneTimePassword, Username, Password, LastName, FirstName) values (null, 'ngilmanb@state.gov', '316iq8GpV7', 'ngilmanb', 'CawIz0', 'Gilman', 'Nicholle');
insert into group2fa212330.Accounts (EmployeeID, Email, OneTimePassword, Username, Password, LastName, FirstName) values (null, 'ctukec@cornell.edu', '228di9UbM9', 'ctukec', 'YfDPRPU9zx9', 'Tuke', 'Cristal');
insert into group2fa212330.Accounts (EmployeeID, Email, OneTimePassword, Username, Password, LastName, FirstName) values (4, 'apregeld@networksolutions.com', '278iy2JtO0', 'apregeld', 'vnSRl6xKma', 'Pregel', 'Angie');
insert into group2fa212330.Accounts (EmployeeID, Email, OneTimePassword, Username, Password, LastName, FirstName) values (5, 'cfranceye@t.co', '090kd2UzA8', 'cfranceye', 'gJCLlrKMpTG', 'Francey', 'Clim');

select * from group2fa212330.Employees
select * from group2fa212330.Accounts

insert into group2fa212330.Employees (PositionID, isAdmin, isActive, AccountNumber, RoutingNumber, Address, Phone) values (5, 1, 0, 892197960675, 439544342, '47 Transport Road', '554-245-9533');
insert into group2fa212330.Employees (PositionID, isAdmin, isActive, AccountNumber, RoutingNumber, Address, Phone) values (6, 1, 0, 389688784565, 942063316, '39 Delaware Alley', '727-734-5345');
insert into group2fa212330.Employees (PositionID, isAdmin, isActive, AccountNumber, RoutingNumber, Address, Phone) values (5, 0, 0, 568115576442, 626697340, '12 Novick Alley', '699-816-5223');
insert into group2fa212330.Employees (PositionID, isAdmin, isActive, AccountNumber, RoutingNumber, Address, Phone) values (2, 1, 0, 183880128705, 348518844, '652 Porter Avenue', '863-154-6706');
insert into group2fa212330.Employees (PositionID, isAdmin, isActive, AccountNumber, RoutingNumber, Address, Phone) values (8, 1, 0, 746485451224, 925212284, '36 Hansons Pass', '809-354-3538');


insert into group2fa212330.Positions (PositionTitle) values ('Manager');
insert into group2fa212330.Positions (PositionTitle) values ('Cashier');
insert into group2fa212330.Positions (PositionTitle) values ('Waiter');
insert into group2fa212330.Positions (PositionTitle) values ('Host');
insert into group2fa212330.Positions (PositionTitle) values ('Head Chef');
insert into group2fa212330.Positions (PositionTitle) values ('Busser');
insert into group2fa212330.Positions (PositionTitle) values ('Dishwasher');
insert into group2fa212330.Positions (PositionTitle) values ('Chef');
select * from group2fa212330.Positions

INSERT INTO group2fa212330.Images (ImageName, Image, Description) values ('Sample1', CAST('0123456789ABCDEF' AS varbinary(max)), 'Same');
INSERT INTO group2fa212330.Images (ImageName, Image, Description) values ('Sample2', CAST('0123456789ABCDEF' AS varbinary(max)), 'Same');
INSERT INTO group2fa212330.Images (ImageName, Image, Description) values ('Sample3', CAST('0123456789ABCDEF' AS varbinary(max)), 'Same');
INSERT INTO group2fa212330.Images (ImageName, Image, Description) values ('Sample4', CAST('0123456789ABCDEF' AS varbinary(max)), 'Same');
INSERT INTO group2fa212330.Images (ImageName, Image, Description) values ('Sample5', CAST('0123456789ABCDEF' AS varbinary(max)), 'Same');
INSERT INTO group2fa212330.Images (ImageName, Image, Description) values ('Sample6', CAST('0123456789ABCDEF' AS varbinary(max)), 'Same');
--select * from group2fa212330.Images


SELECT * FROM group2fa212330.Salary;
SELECT * FROM group2fa212330.Paycheck


