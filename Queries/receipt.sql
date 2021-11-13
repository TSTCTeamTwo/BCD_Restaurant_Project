--Select * from group2fa212330.Orders
--Select * from group2fa212330.OrderItems
--select * from group2fa212330.Menu


--show order id, full name, menu id, item name, qty, total line cost
--show subtotal, totaldue, tax, tip
--orderid,

SELECT 
	o.OrderID, 
	a.AccountID,
	CONCAT(a.LastName, ', ', a.FirstName) AS 'Full Name',
	oi.ItemID, 
	m.ItemName, 
	oi.Qty,
	m.Price AS 'Individual Price',
	(oi.Qty * m.Price) AS 'Total Line Cost'
FROM group2fa212330.Orders o
INNER JOIN
	group2fa212330.OrderItems oi ON o.OrderID = oi.OrderID
INNER JOIN
	group2fa212330.Menu m ON oi.ItemID = m.ItemID
INNER JOIN
	group2fa212330.Accounts a ON a.AccountID = o.AccountID
WHERE o.OrderID = 1

SELECT TotalDue, Tax, Tip, Subtotal FROM group2fa212330.Orders WHERE OrderID = 1

select * from group2fa212330.Orders