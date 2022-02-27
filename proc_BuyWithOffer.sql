CREATE procedure proc_BuyWithOffer(@offerId int) 
As
Begin

--Get offer information from offers table
DECLARE @productId int, @offeredPrice int, @offererId nvarChar(450), @ownerId nvarChar(450)
SELECT @productId = ProductId, @offeredPrice = OfferedPrice, @offererId = UserId FROM Offers WHERE Id=@offerId
SELECT @ownerId = UserId FROM Products WHERE Id=@productId



--Now we will create purchase history with these datas, then we can update informations
INSERT INTO PurchaseHistories (ProductId,BuyerId,SellerId,SoldPrice,PurchasedDate,IsActive,CreationDate)  VALUES (@productId, @offererId, @ownerId,@offeredPrice, GETDATE(),1,GETDATE())

--product update will be done with Trigger, so we don't touch that information
END