USE [inew2330fa21]
GO
/****** Object:  Trigger [group2fa212330].[AddAndDeleteItemToOrder]    Script Date: 10/20/2021 2:29:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER TRIGGER [group2fa212330].[AddAndDeleteItemToOrder]
    ON [group2fa212330].[OrderItems]
    AFTER DELETE, INSERT, UPDATE
    AS
	BEGIN
	SET NOCOUNT ON
    IF EXISTS (SELECT * FROM inserted) and EXISTS (SELECT * FROM deleted) -- IF THE ITEM COUNT IS UPDATED
	
	UPDATE group2fa212330.Orders
	SET OrderQty = OrderQty + -((SELECT Qty FROM deleted) - (SELECT Qty FROM inserted)),
	TotalDue = TotalDue + -((Select deleted.Qty * m.Price from deleted inner join group2fa212330.Menu m on deleted.ItemID = m.ItemID) - (Select inserted.Qty * m.Price from inserted inner join group2fa212330.Menu m on inserted.ItemID = m.ItemID)),
	Tax = (TotalDue + -((Select deleted.Qty * m.Price from deleted inner join group2fa212330.Menu m on deleted.ItemID = m.ItemID) - (Select inserted.Qty * m.Price from inserted inner join group2fa212330.Menu m on inserted.ItemID = m.ItemID)))*.0625
	WHERE OrderID = (Select OrderID FROM inserted);
    
	ELSE IF EXISTS(SELECT * FROM inserted) AND NOT EXISTS(SELECT * FROM deleted)-- IF THE ITEM IS ADDED TO THE ITEM

    UPDATE group2fa212330.Orders
	SET OrderQty = OrderQty + (Select Qty from inserted), TotalDue = TotalDue + (Select inserted.Qty * m.Price from inserted inner join group2fa212330.Menu m on inserted.ItemID = m.ItemID)
	WHERE OrderID = (SELECT OrderID FROM inserted);

	ElSE IF EXISTS(SELECT * FROM deleted) AND NOT EXISTS(SELECT * FROM INSERTED)-- IF THE ITEM IS DELETED FROM THE ITEM

    UPDATE group2fa212330.Orders
	SET OrderQty = OrderQty - (Select Qty from deleted), 
	TotalDue = TotalDue - (Select deleted.Qty * m.Price from deleted inner join group2fa212330.Menu m on deleted.ItemID = m.ItemID),
	Tax = (TotalDue + -((Select deleted.Qty * m.Price from deleted inner join group2fa212330.Menu m on deleted.ItemID = m.ItemID) - (Select inserted.Qty * m.Price from inserted inner join group2fa212330.Menu m on inserted.ItemID = m.ItemID)))*.0625
	where OrderID = (SELECT OrderID FROM deleted);
END