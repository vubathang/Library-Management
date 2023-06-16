CREATE DATABASE QLThuVien
GO

USE QLThuVien
GO

-- NguoiDung
-- Sach
-- PhieuMuon
-- ChiTietPM
-- YeuCauMS9

CREATE TABLE NguoiDung
(
	id INT IDENTITY PRIMARY KEY,
	userName NVARCHAR(20) NOT NULL,
	passWord NVARCHAR(20) NOT NULL,
	type NVARCHAR(10) NOT NULL, -- 0 : admin || 1 : thuthu || 2 : ketoan || 3 : docgia
	fullName NVARCHAR(30) NOT NULL,
	phone NVARCHAR(10) NOT NULL,
	birth DATE NOT NULL,
	address NVARCHAR(30) NOT NULL
)
GO	

CREATE TABLE Sach
(
	id INT IDENTITY PRIMARY KEY,
	title NVARCHAR(20) NOT NULL,
	author NVARCHAR(20) NOT NULL,
	publisher NVARCHAR(20) NOT NULL,
	publicationYear DATE NOT NULL,
	catagory NVARCHAR(20) NOT NULL,
	quantity INT NOT NULL
)
GO	

CREATE TABLE PhieuMuon
(
	id INT IDENTITY PRIMARY KEY,
	idDG INT NOT NULL,
	idTT INT NOT NULL,
	idKT INT,
	borrowDate DATE,
	returnDate DATE,
	amount INT NOT NULL,
	deposit INT, -- Tiền cọc
	refund INT, -- Tiền hoàn
	statusPM NVARCHAR(20) NOT NULL,
	statusBook NVARCHAR(20),
	FOREIGN KEY (idDG) REFERENCES NguoiDung(id),
	FOREIGN KEY (idTT) REFERENCES NguoiDung(id),
	FOREIGN KEY (idKT) REFERENCES NguoiDung(id),
)
GO	

CREATE TABLE ChiTietPM
(
	idPM INT NOT NULL,
	idBook INT NOT NULL,
	quantity INT NOT NULL,
	FOREIGN KEY (idBook) REFERENCES Sach(id),
	FOREIGN KEY (idPM) REFERENCES PhieuMuon(id) 
)
GO	

CREATE TABLE YeuCauMS
(
	id INT IDENTITY PRIMARY KEY,
	idDG INT NOT NULL,
	idBook INT NOT NULL,
	requestDate DATE,
	quantity INT NOT NULL,
	FOREIGN KEY (idDG) REFERENCES NguoiDung(id),
	FOREIGN KEY (idBook) REFERENCES Sach(id)
)
GO	

-- PROC ChapNhanYCMS
CREATE PROCEDURE ChapNhanYCMS
(
    @idYC INT,
    @idTT INT
)
AS
BEGIN
	DECLARE @idPM INT, @idDG INT, @idBook INT, @amount INT
	
	SELECT @idDG = idDG, @idBook = idBook, @amount = quantity FROM YeuCauMS WHERE id = @idYC

    INSERT INTO PhieuMuon (idDG, idTT, idKT, borrowDate, returnDate, amount, deposit, refund, statusPM, statusBook)
    VALUES (@idDG, @idTT, NULL, NULL, NULL, @amount, 0, 0, N'Chưa Thanh Toán', N'Tốt')

    SET @idPM = SCOPE_IDENTITY()

    INSERT INTO ChiTietPM (idPM, idBook, quantity)
    VALUES (@idPM, @idBook, @amount)

    DELETE FROM YeuCauMS WHERE id = @idYC;

    UPDATE Sach SET quantity = quantity - @amount WHERE id = @idBook
END

-- PROC LapPM
CREATE PROCEDURE LapPM
(
	@idTT int,
    @fullName NVARCHAR(30),
	@title NVARCHAR(20),
    @amount INT,
    @borrowDate DATE
)
AS
BEGIN
	DECLARE @idPM INT, @idDG INT, @idBook INT

	SELECT @idDG = id FROM NguoiDung WHERE fullName LIKE @fullName
	SELECT @idBook = id FROM Sach WHERE title LIKE @title

    INSERT INTO PhieuMuon VALUES (@idDG, @idTT, NULL, @borrowDate, NULL, @amount, 0, 0, N'Chưa thanh toán', N'Tốt')

    SET @idPM = SCOPE_IDENTITY()

    INSERT INTO ChiTietPM VALUES (@idPM, @idBook, @amount)

    UPDATE Sach SET quantity = quantity - @amount WHERE id = @idBook
END

-- PROC XoaPT
 CREATE PROCEDURE XoaPT
 (
 	@idPM INT
 )
 AS 
 BEGIN 
 	DELETE FROM ChiTietPM WHERE idPM = @idPM
 	DELETE FROM PhieuMuon WHERE id = @idPM
 END

SELECT * FROM dbo.NguoiDung
SELECT * FROM dbo.Sach
SELECT * FROM dbo.YeuCauMS
SELECT * FROM dbo.PhieuMuon
SELECT * FROM dbo.ChiTietPM


