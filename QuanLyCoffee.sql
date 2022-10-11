CREATE DATABASE QuanLyCoffee_M10
GO

USE QuanLyCoffee_M10
GO

CREATE TABLE Account
(
	username VARCHAR(50) NOT NULL,
	password VARCHAR(50) NOT NULL,
	status BIT NOT NULL,
	displayName NVARCHAR(50) NOT NULL,

	PRIMARY KEY (Username)
)
GO

CREATE TABLE CategoryBeverage (
	id VARCHAR(10) NOT NULL,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',

	PRIMARY KEY (id)
) 
GO

CREATE TABLE Bill (
	idBill INT PRIMARY KEY,
	idCard INT NOT NULL,
	dateCheckIn DATETIME DEFAULT GETDATE(), 
	customerMoney MONEY,
	totalMoney MONEY
) 
GO

CREATE TABLE Beverage (
	idBeverage VARCHAR(50) NOT NULL,
	nameBeverage NVARCHAR(100) DEFAULT N'Chưa đặt tên',
	idCategory VARCHAR(10),
	size VARCHAR(2),	
	price SMALLMONEY,
	available BIT DEFAULT 1,

	PRIMARY KEY (idBeverage)
) 
GO

CREATE TABLE Card (
	id INT IDENTITY PRIMARY KEY,
	status BIT NOT NULL DEFAULT 0
)
GO

CREATE TABLE BillInfo (
	idBill INT NOT NULL,
	idBeverage VARCHAR(50) NOT NULL,
	numberBeverage INT NOT NULL
)
GO

SELECT * FROM Account
SELECT * FROM CategoryBeverage
SELECT * FROM Beverage
SELECT * FROM BillInfo
SELECT * FROM Bill

---------------------------------------------
INSERT INTO Account VALUES ('admin', 'admin', 1, N'admin')
INSERT INTO Account VALUES ('nv', 'nv', 0, N'Nhân viên')
INSERT INTO Account VALUES ('1', '1', 1, N'Chủ quán')
GO

INSERT CategoryBeverage VALUES ('CF', N'Coffee')
INSERT CategoryBeverage VALUES ('TTC', N'Trà trái cây')
INSERT CategoryBeverage VALUES ('TS', N'Trà sữa')
GO

INSERT Beverage VALUES ('CF01', N'Cà phê đen', 'CF', 'S', 25000, 1)
INSERT Beverage VALUES ('CF02', N'Cà phê đen', 'CF', 'M', 28000, 1)
INSERT Beverage VALUES ('CF11', N'Bạc xỉu', 'CF', 'S', 28000, 1)
INSERT Beverage VALUES ('CF12', N'Bạc xỉu', 'CF', 'M', 31000, 1)
INSERT Beverage VALUES ('TTC01', N'Trà đào', 'TTC', 'S', 30000, 1)
INSERT Beverage VALUES ('TTC02', N'Trà đào', 'TTC', 'M', 35000, 1)
INSERT Beverage VALUES ('TT01', N'Trà sữa olong', 'TS', 'S', 33000, 1)
INSERT Beverage VALUES ('TT02', N'Trà sữa olong', 'TS', 'M', 38000, 0)
GO

------------------------------------------------

CREATE PROC ChangePassword
@username VARCHAR(50), @password VARCHAR(50), @newPassword VARCHAR(50)
AS
BEGIN
	UPDATE Account SET password = @newPassword WHERE username = @username AND password = @password
END
GO

CREATE PROC AddAccount
@username VARCHAR(50), @password VARCHAR(50), @status BIT, @displayName NVARCHAR(50)
AS
BEGIN
	INSERT INTO Account VALUES(@username, @password, @status, @displayName)
END
GO

CREATE PROC AdminConfirm
@username VARCHAR(50) , @password VARCHAR(50)
AS
BEGIN
	SELECT * FROM Account WHERE username = @username AND password = @password
END


CREATE PROC AddCategory
@id VARCHAR(10), @name NVARCHAR(100)
AS
BEGIN
	INSERT INTO CategoryBeverage VALUES(@id, @name)
END
GO

CREATE PROC UpdateCategory
@id VARCHAR(10), @name NVARCHAR(100)
AS
BEGIN
	UPDATE CategoryBeverage SET name = @name
	WHERE id = @id
END
GO

CREATE PROC RemoveCategory
@id VARCHAR(10)
AS
BEGIN
	DELETE CategoryBeverage WHERE id = @id
END
GO



delete CategoryBeverage WHERE id = 'TD'



CREATE PROC SearchBeverage
@nameBeverage NVARCHAR(100)
AS
BEGIN
	SELECT * FROM Beverage WHERE nameBeverage LIKE '%' + @nameBeverage + '%'
END

EXEC SearchBeverage N'Cà phê'
GO

CREATE PROC AddBeverage
@idBeverage VARCHAR(50), @nameBeverage NVARCHAR(100), @idCategory VARCHAR(10), @size VARCHAR(2), @price SMALLMONEY, @available BIT
AS
BEGIN
	INSERT INTO Beverage VALUES(@idBeverage, @nameBeverage, @idCategory, @size, @price, @available)
END
GO

EXEC AddBeverage 'TS13' , N'Trà sữa thái xanh' , 'TS' , 'L' , 40000 , 1
GO

CREATE PROC UpdateBeverage
@idBeverage VARCHAR(50), @nameBeverage NVARCHAR(100), @idCategory VARCHAR(10), @size VARCHAR(2), @price SMALLMONEY, @available BIT
AS
BEGIN
	UPDATE Beverage SET nameBeverage = @nameBeverage, idCategory = @idCategory, size = @size, price = @price, available = @available
	WHERE idBeverage = @idBeverage
END
GO

CREATE PROC RemoveBeverage
@id VARCHAR(50)
AS
BEGIN
	DELETE Beverage WHERE idBeverage = @id
END
GO

DECLARE @i INT = 0
WHILE @i <= 20
BEGIN
	INSERT INTO Card VALUES (0)
	SET @i = @i + 1
END
GO

SELECT * FROM Card WHERE status = 1
GO

CREATE PROC UpdateCard
@idCard INT
AS
BEGIN
	IF (SELECT status FROM Card WHERE id = @idCard) = 0
		UPDATE Card SET status = 1 WHERE id = @idCard
	ELSE
		UPDATE Card SET status = 0 WHERE id = @idCard
END

EXEC UpdateCard 1



CREATE PROC InsertBill
@idBill INT ,@idCard INT, @customerMoney MONEY, @totalMoney MONEY
AS
BEGIN
    INSERT INTO Bill(idBill, idCard, customerMoney, totalMoney)
    VALUES (@idBill ,@idCard, @customerMoney, @totalMoney)
END
GO

EXEC InsertBill @idBill = 1, @idCard = 1, @customerMoney = 500000, @totalMoney = 210000
EXEC InsertBill 1, 1, 500000, 210000
SELECT * FROM Bill

DELETE FROM Bill WHERE idBill = 2

CREATE PROC InsertBillInfor
@idBill INT ,@idBeverage VARCHAR(50), @numberBeverage INT
AS
BEGIN
    INSERT INTO BillInfo(idBill, idBeverage, numberBeverage)
    VALUES (@idBill ,@idBeverage, @numberBeverage)
END
GO

EXEC InsertBillInfor @idBill = 1, @idBeverage = 'CF01', @numberBeverage = 2
EXEC InsertBillInfor @idBill = 1, @idBeverage = 'CF02', @numberBeverage = 1
GO


CREATE PROC ShowBillInfo
@id INT
AS
BEGIN
	SELECT A.idBeverage , B.nameBeverage , B.price , A.numberBeverage 
	FROM BillInfo A JOIN Beverage B ON A.idBeverage = B.idBeverage
	WHERE A.idBill = @id
END
GO

DECLARE @date DATETIME
SELECT @date = CONVERT(varchar(20),CONVERT(datetime, '2022-08-10' + ' 00:00:00'), 111)
SELECT idBill, idCard ,FORMAT(dateCheckIn, 'yyyy/MM/dd hh:mm') as dateCheckin, customerMoney, totalMoney FROM Bill WHERE dateCheckIn > @date


CREATE PROC BillToday
@day VARCHAR(20)
AS
BEGIN
DECLARE @date DATETIME
SELECT @date = CONVERT(varchar(20),CONVERT(datetime, @day + ' 00:00:00'), 111)
SELECT idBill, idCard ,FORMAT(dateCheckIn, 'yyyy/MM/dd hh:mm') as dateCheckin, customerMoney, totalMoney FROM Bill WHERE dateCheckIn > @date
END
GO

CREATE PROC BillInTime
@time INT, @date VARCHAR(20)
AS
BEGIN
	DECLARE @day DATETIME
	SELECT @day = CONVERT(varchar(20),CONVERT(datetime, @date + ' 00:00:00'), 111)
	SELECT @day = DATEADD(DAY , @time , @day)
	SELECT idBill, idCard ,FORMAT(dateCheckIn, 'yyyy/MM/dd hh:mm') as dateCheckin, customerMoney, totalMoney FROM Bill WHERE dateCheckIn > @day
END
GO

DECLARE @Date datetime2 = '2011-09-23'
SELECT DATEADD(DAY,1,@Date)

DECLARE @date1 DATE, @date2 DATE;
SET @date1 = '2021-01-01'
SET @date2 = '2021-02-01'                                 
IF @date1 = @date2                                                
	SELECT 'equal date'
ELSE
	IF @date1 < @date2 SELECT 'date2 is greater'              
	ELSE SELECT 'date1 is greater'



declare  @day1 datetime;
declare  @day2 datetime;
select   @day1 = CONVERT(varchar(20),GETDATE(), 114) --CONVERT(varchar(20),CONVERT(datetime, '2022-10-08 00:00:00'), 114)
select   @day2 = CONVERT(varchar(20),CONVERT(datetime, '2022-08-11 00:00:00'), 114)
if @day1 <= @day2
 print '@@day1 less then @@day2'
else
 print '@@day1 more then @@day2'


 select replace(convert(varchar, getdate(), 111), '/','-')
