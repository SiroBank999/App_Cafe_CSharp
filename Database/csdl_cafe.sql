CREATE DATABASE csdl_cafe
GO
USE csdl_cafe
GO

-- Food
-- Table
-- FoodCategory
-- Account
-- Bill
-- BillInfo

CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống'	-- Trống || Có người
)
GO

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Nhơn Nguyễn',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL  DEFAULT 0 -- 1: admin && 0: staff
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0,
	image NVARCHAR(100) NULL,
	
	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATETIME NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATETIME,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0 -- 1: đã thanh toán && 0: chưa thanh toán
	
	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO
INSERT INTO Account(UserName,DisplayName,PassWord,Type) VALUES('admin','Nguyen Van Nhon','123456',1)
GO
--THÊM DANH MỤC
SELECT * FROM FoodCategory
SELECT * FROM Food
INSERT INTO FoodCategory(name) VALUES(N'Cafe')
INSERT INTO FoodCategory(name) VALUES(N'Sữa')
INSERT INTO FoodCategory(name) VALUES(N'Nước')
INSERT INTO FoodCategory(name) VALUES(N'Thức ăn')
INSERT INTO FoodCategory(name) VALUES(N'Trà')
INSERT INTO FoodCategory(name) VALUES(N'Khác')
GO
--THÊM MÓN
INSERT INTO Food(name,idCategory,price,image) VALUES(N'Cafe đen',1,20000,N'cafe_den.jpg')
INSERT INTO Food(name,idCategory,price,image) VALUES(N'Cafe sữa',1,25000,N'cafe_sua.jpg')
INSERT INTO Food(name,idCategory,price,image) VALUES(N'7-Up',3,15000,N'7_up.jpg')
INSERT INTO Food(name,idCategory,price,image) VALUES(N'Coca',3,15000,N'coca.jpg')
INSERT INTO Food(name,idCategory,price,image) VALUES(N'Pepsi',3,15000,N'pepsi.jpg')
INSERT INTO Food(name,idCategory,price,image) VALUES(N'Nước suối',3,8000,N'nuoc.jpg')
INSERT INTO Food(name,idCategory,price,image) VALUES(N'Trà tắc',5,25000,N'tra_tac.png')
INSERT INTO Food(name,idCategory,price,image) VALUES(N'Trà đào',5,25000,N'tra_dao.jpg')
INSERT INTO Food(name,idCategory,price,image) VALUES(N'Sữa nóng',2,15000,N'sua_nong.jpg')
INSERT INTO Food(name,idCategory,price,image) VALUES(N'Sữa chua',2,55000,N'sua_chua.jpg')
INSERT INTO Food(name,idCategory,price,image) VALUES(N'Bò khô',4,55000,N'bo_kho.jpg')
INSERT INTO Food(name,idCategory,price,image) VALUES(N'Gà khô',4,45000,N'gakho.jpg')
INSERT INTO Food(name,idCategory,price,image) VALUES(N'Xoài lắc',4,13000,N'xoai.jpg')

GO
CREATE PROC CheckAccount
	@username NVARCHAR(100),
	@password NVARCHAR(1000)
AS
	BEGIN
	SELECT * FROM Account WHERE UserName = @username AND PassWord = @password
	END
EXEC CheckAccount 'admin','123456'
GO

--Thêm bàn
DECLARE @i INT = 1
WHILE @i < =10
BEGIN
	INSERT INTO TableFood ([name]) VALUES ('' + CAST(@i AS nvarchar(100)))
	SET @i = @i + 1

END
--PROC DANH SÁCH BÀN
CREATE PROC ListTable
AS
SELECT * FROM TableFood

ListTable
CREATE PROC UpdateStatusTable
@id int,@status nvarchar(100)
AS
UPDATE TableFood SET status = @status WHERE id = @id
UpdateStatusTable 10 ,N'Có người'
--PROC DANH SÁCH MÓN
CREATE PROC ListFood
AS
SELECT * FROM Food
ListFood

--PROC LẤY BILL THEO ID BÀN
CREATE PROC getBillByIdTable
@idTable int
AS
SELECT * FROM Bill WHERE idTable = @idTable AND status = 0
getBillByIdTable 10
-- THÊM HÓA ĐƠN
SELECT * FROM Bill
CREATE PROC InsertBill
@idTable int
AS
INSERT INTO Bill(DateCheckIn,idTable,[status]) VALUES(GETDATE(),@idTable,0)
InsertBill 10
--THƯỜNG
INSERT INTO Bill(DateCheckIn,idTable,[status]) VALUES(GETDATE(),9,0) 
--THÊM CHI TIẾT HÓA ĐƠN
INSERT INTO BillInfo(idBill,idFood,[count]) VALUES(1,1,2)
INSERT INTO BillInfo(idBill,idFood,[count]) VALUES(1,3,2)
INSERT INTO BillInfo(idBill,idFood,[count]) VALUES(2,4,2)
--THÊM BILLINFO PROC
CREATE PROC InsertBillInfo
@idBill int, @idFood int, @count int
AS
INSERT INTO BillInfo(idBill,idFood,[count]) VALUES(@idBill,@idFood,@count)
InsertBillInfo 3,5,5
-- LẤY DANH SÁCH BILLINFO PROC
CREATE PROC getBillInfoById
@idBill int
AS
SELECT * FROM BillInfo WHERE idBill = @idBill
getBillInfoById 1
--ITEM BILL
CREATE PROC ItemBill(
	 @idTable int
)
AS
--SELECT * FROM BillInfo
SELECT Food.name as NameFood, BillInfo.[count] as [SL],BillInfo.id as idBillInfo, Food.price as Price FROM Bill,BillInfo,Food 
WHERE Bill.id = BillInfo.idBill AND BillInfo.idFood = Food.id  AND Bill.idTable = @idTable AND Bill.status = 0
ItemBill 2
-- CẬP NHẬT BILL INFO
CREATE PROC UpdateBillInfo
@count int ,@id int
AS
UPDATE BillInfo SET count =@count WHERE id = @id
UpdateBillInfo 9, 1


