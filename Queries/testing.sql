--insert into group2fa212330.OrderItems
--(OrderID, ItemID, Qty) values (1,5,2)
update group2fa212330.OrderItems
set Qty = 1
where ItemID = 1

delete from group2fa212330.OrderItems
where OrderID = 1 and  ItemID = 1;


update group2fa212330.Orders
set TotalDue = 8.98, OrderQty = 2
where OrderID = 1
select * from group2fa212330.Orders
select * from group2fa212330.Menu
select * from group2fa212330.OrderItems


Select (Qty * Price) from deleted inner join group2fa212330.Menu on deleted.ItemID = group2fa212330.menu.ItemID

select * from group2fa212330.Orders
select * from group2fa212330.Menu
select * from group2fa212330.OrderItems

select sum(Qty * Price) from group2fa212330.Orders inner join group2fa212330.OrderItems on orders.OrderID = OrderItems.OrderID
inner join group2fa212330.Menu on OrderItems.ItemID = Menu.ItemID
