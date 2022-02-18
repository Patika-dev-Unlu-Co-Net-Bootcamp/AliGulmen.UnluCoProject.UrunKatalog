using Microsoft.EntityFrameworkCore.Migrations;

namespace AliGulmen.UnluCoProject.UrunKatalog.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO AspNetUsers(Id,FirstName,LastName,Gender,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount) VALUES ('1','ahmet1','yılmaz',2, 'ahmet1', 'ahmet1', 'ahmetyilmaz1@xyz.com', 'ahmetyilmaz1@xyz.com', 1, '123456', '0', '1', '053500000001', 1, 0, '01.01.2022', 0, 1)");
            migrationBuilder.Sql("INSERT INTO AspNetUsers(Id,FirstName,LastName,Gender,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount) VALUES ('2','ahmet2','yılmaz',2, 'ahmet2', 'ahmet2', 'ahmetyilmaz2@xyz.com', 'ahmetyilmaz2@xyz.com', 1, '123456', '0', '1', '053500000002', 1, 0, '01.01.2022', 0, 1)");
            migrationBuilder.Sql("INSERT INTO AspNetUsers(Id,FirstName,LastName,Gender,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount) VALUES ('3','ahmet3','yılmaz',0, 'ahmet3', 'ahmet3', 'ahmetyilmaz3@xyz.com', 'ahmetyilmaz3@xyz.com', 1, '123456', '0', '1', '053500000003', 1, 0, '01.01.2022', 0, 1)");
            migrationBuilder.Sql("INSERT INTO AspNetUsers(Id,FirstName,LastName,Gender,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount) VALUES ('4','ahmet4','yılmaz',0, 'ahmet4', 'ahmet4', 'ahmetyilmaz4@xyz.com', 'ahmetyilmaz4@xyz.com', 1, '123456', '0', '1', '053500000004', 1, 0, '01.01.2022', 0, 1)");
            migrationBuilder.Sql("INSERT INTO AspNetUsers(Id,FirstName,LastName,Gender,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount) VALUES ('5','ahmet5','yılmaz',0, 'ahmet5', 'ahmet5', 'ahmetyilmaz5@xyz.com', 'ahmetyilmaz5@xyz.com', 1, '123456', '0', '1', '053500000005', 1, 0, '01.01.2022', 0, 1)");




            migrationBuilder.Sql("Insert INTO Brands (Name,Description,IsActive,CreationDate) VALUES ('Dell','Electronic Components',1,'01.01.2022')");
            migrationBuilder.Sql("Insert INTO Brands (Name,Description,IsActive,CreationDate) VALUES ('Mango','Women Clothing',1,'01.01.2021')");
            migrationBuilder.Sql("Insert INTO Brands (Name,Description,IsActive,CreationDate) VALUES ('Lego','Minimal Games',1,'01.01.2020')");
            migrationBuilder.Sql("Insert INTO Brands (Name,Description,IsActive,CreationDate) VALUES ('Black&Decker','Tools',1,'01.06.2022')");
            migrationBuilder.Sql("Insert INTO Brands (Name,Description,IsActive,CreationDate) VALUES ('YKY','All type of books',1,'10.10.2022')");

            migrationBuilder.Sql("Insert INTO Categories (Name,Description,IsActive,CreationDate) VALUES ('Electronics','Computer, Video Games, Cameras',1,'10.10.2022')");
            migrationBuilder.Sql("Insert INTO Categories (Name,Description,IsActive,CreationDate) VALUES ('Art','Comic Books, Antiques, Pottery',1,'10.10.2022')");
            migrationBuilder.Sql("Insert INTO Categories (Name,Description,IsActive,CreationDate) VALUES ('Fashion','Clothing, Shoes, Handbags',1,'10.10.2022')");
            migrationBuilder.Sql("Insert INTO Categories (Name,Description,IsActive,CreationDate) VALUES ('Hobbies','Card Games, Action Figures, Toys',1,'10.10.2022')");
            migrationBuilder.Sql("Insert INTO Categories (Name,Description,IsActive,CreationDate) VALUES ('Home&Garden','Kitchen, Dining & Bar Supplies, Decor',1,'10.10.2022')");


            migrationBuilder.Sql("Insert INTO Conditions (Status,Description,IsActive,CreationDate) VALUES ('New','The item is brand new, unused, unopened, and undamaged',1,'10.10.2020')");
            migrationBuilder.Sql("Insert INTO Conditions (Status,Description,IsActive,CreationDate) VALUES ('Used','The item was previously used.',1,'10.10.2020')");
            migrationBuilder.Sql("Insert INTO Conditions (Status,Description,IsActive,CreationDate) VALUES ('Seller refurbished','The item has been restored to working order by the seller.',1,'10.10.2020')");
            migrationBuilder.Sql("Insert INTO Conditions (Status,Description,IsActive,CreationDate) VALUES ('Open box','The item is in excellent, new condition with no wear.',1,'10.10.2020')");
            migrationBuilder.Sql("Insert INTO Conditions (Status,Description,IsActive,CreationDate) VALUES ('New with tags','The brand-new, unused, and unworn item is in the original packaging.',1,'10.10.2020')");
            migrationBuilder.Sql("Insert INTO Conditions (Status,Description,IsActive,CreationDate) VALUES ('New with defects','The item is brand new, unused, and unworn. Possible cosmetic imperfections range from natural color variations to scuffs, cuts.',1,'10.10.2020')");

            migrationBuilder.Sql("Insert INTO Colors (Name,IsActive,CreationDate) VALUES ('Black',1,'10.10.2020')");
            migrationBuilder.Sql("Insert INTO Colors (Name,IsActive,CreationDate) VALUES ('Yellow',1,'10.10.2020')");
            migrationBuilder.Sql("Insert INTO Colors (Name,IsActive,CreationDate) VALUES ('Orange',1,'10.10.2020')");
            migrationBuilder.Sql("Insert INTO Colors (Name,IsActive,CreationDate) VALUES ('White',1,'10.10.2020')");
            migrationBuilder.Sql("Insert INTO Colors (Name,IsActive,CreationDate) VALUES ('Purple',1,'10.10.2020')");




            migrationBuilder.Sql("Insert INTO Products (Name,Description,PictureUrl,BuyItNowPrice,IsOfferable,IsSold,ConditionId,UserId,ColorId,BrandId,CategoryId,IsActive,CreationDate) " +
                "VALUES ('Latitude E5440','Dell Laptop Latitude E5440 Light Gaming Computer PC i5 8GB 256GB SSD Win 10 Pro','C:\\Images\\1.png',220,1,0,2,1,1,1,1,1,'10.10.2020')");

            migrationBuilder.Sql("Insert INTO Products (Name,Description,PictureUrl,BuyItNowPrice,IsOfferable,IsSold,ConditionId,UserId,ColorId,BrandId,CategoryId,IsActive,CreationDate) " +
                "VALUES ('Long twist tea dress','Mango navy leaf pattened long twist tea dress Small ladies fashion clothing.','C:\\Images\\2.png',9,0,0,5,2,3,2,3,1,'10.10.2020')");

            migrationBuilder.Sql("Insert INTO Products (Name,Description,PictureUrl,BuyItNowPrice,IsOfferable,IsSold,ConditionId,UserId,ColorId,BrandId,CategoryId,IsActive,CreationDate) " +
                "VALUES ('Clean Code: A Handbook of Agile Software Craftsmanship','Even bad code can function. But if code isn’t clean, it can bring a development organization to its knees.','C:\\Images\\3.png',32,0,1,1,3,2,5,2,1,'10.10.2020')");

            migrationBuilder.Sql("Insert INTO Products (Name,Description,PictureUrl,BuyItNowPrice,IsOfferable,IsSold,ConditionId,UserId,ColorId,BrandId,CategoryId,IsActive,CreationDate) " +
                "VALUES ('Fire Station City Fire (60215)','Kids can protect the citizens of LEGO city with the action-packed fire rescue building set, featuring a 3-level fire station.','C:\\Images\\4.png',70,0,0,2,4,1,3,4,1,'10.10.2020')");

            migrationBuilder.Sql("Insert INTO Products (Name,Description,PictureUrl,BuyItNowPrice,IsOfferable,IsSold,ConditionId,UserId,ColorId,BrandId,CategoryId,IsActive,CreationDate) " +
                "VALUES ('LDX120C Cordless Drill Driver 20V Max Battery and Charger','Will include 1 battery and charger, also new and unused.','C:\\Images\\5.png',35,1,0,4,5,1,4,5,1,'10.10.2020')");


            migrationBuilder.Sql("Insert INTO Offers (UserId,ProductId,OfferedPrice,IsAccepted,IsActive,CreationDate) VALUES (1,1,200,0,1,'10.10.2020')");
            migrationBuilder.Sql("Insert INTO Offers (UserId,ProductId,OfferedPrice,IsAccepted,IsActive,CreationDate) VALUES (1,2,7,0,1,'10.10.2020')");
            migrationBuilder.Sql("Insert INTO Offers (UserId,ProductId,OfferedPrice,IsAccepted,IsActive,CreationDate) VALUES (1,3,30,0,1,'10.10.2020')");
            migrationBuilder.Sql("Insert INTO Offers (UserId,ProductId,OfferedPrice,IsAccepted,IsActive,CreationDate) VALUES (1,4,50,0,1,'10.10.2020')");
            migrationBuilder.Sql("Insert INTO Offers (UserId,ProductId,OfferedPrice,IsAccepted,IsActive,CreationDate) VALUES (2,1,210,1,1,'10.10.2020')");
            migrationBuilder.Sql("Insert INTO Offers (UserId,ProductId,OfferedPrice,IsAccepted,IsActive,CreationDate) VALUES (2,2,8,0,1,'10.10.2020')");
            migrationBuilder.Sql("Insert INTO Offers (UserId,ProductId,OfferedPrice,IsAccepted,IsActive,CreationDate) VALUES (4,5,32,0,1,'10.10.2020')");



            migrationBuilder.Sql("Insert INTO PurchaseHistories (ProductId,SellerId,BuyerId,SoldPrice,PurchasedDate,IsActive,CreationDate) VALUES (1,2,1,200,'10.10.2020',1,'10.10.2020')");
            migrationBuilder.Sql("Insert INTO PurchaseHistories (ProductId,SellerId,BuyerId,SoldPrice,PurchasedDate,IsActive,CreationDate) VALUES (3,4,2,200,'10.10.2020',1,'10.10.2020')");
            migrationBuilder.Sql("Insert INTO PurchaseHistories (ProductId,SellerId,BuyerId,SoldPrice,PurchasedDate,IsActive,CreationDate) VALUES (4,5,1,200,'10.10.2020',1,'10.10.2020')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Brands WHERE Name IN ('Siemens', 'Mango', 'Lego', 'Black&Decker', 'YKY')");
            migrationBuilder.Sql("DELETE FROM Categories WHERE Name IN ('Electronics', 'Art', 'Fashion', 'Hobbies', 'Home&Garden')");
            migrationBuilder.Sql("DELETE FROM Conditions WHERE Status IN ('New', 'Used', 'Seller refurbished', 'Open box', 'New with tags', 'New with defects')");
            migrationBuilder.Sql("DELETE FROM Colors WHERE Name IN ('Black', 'Yellow', 'Orange', 'White', 'Purple')");
            migrationBuilder.Sql("DELETE FROM AspNetUsers WHERE Id IN ('1', '2', '3', '5', '4')");
            migrationBuilder.Sql("DELETE FROM Products WHERE Id IN (1,2,3,4,5)");
            migrationBuilder.Sql("DELETE FROM Offers WHERE Id IN (1,2,3,4,5)");
            migrationBuilder.Sql("DELETE FROM PurchaseHistories WHERE Id IN (1,2,3,4,5)");


        }
    }
}
