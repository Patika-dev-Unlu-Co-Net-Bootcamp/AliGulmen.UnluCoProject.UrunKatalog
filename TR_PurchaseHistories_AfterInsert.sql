CREATE TRIGGER TR_PurchaseHistories_AfterInsert ON PurchaseHistories
AFTER Insert 
--This trigger will work after insert query, 
--We will work with "instead of" because if there is an issue with information, we won't run query and we will give an error
--This trigger will work when someone buys a product, we will get informations from purchasehistories table and update product informations 
AS
BEGIN
	
	--First, lets take all informations from inserted table
	DECLARE @buyerId nvarchar(450), @sellerId nvarchar(450), @productId int, @soldPrice int, @purchasedDate datetime2(7)
	SELECT @buyerId = BuyerId, @sellerId = SellerId, @productId = ProductId, @soldPrice = SoldPrice, @purchasedDate = PurchasedDate FROM inserted    
	

		UPDATE Products SET Products.UserId=@buyerId, IsSold=1, IsOfferable=0 WHERE Products.Id = @productId;
	
END