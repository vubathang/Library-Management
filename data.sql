CREATE DATABASE QLThuVien
GO

USE QLThuVien
GO

-- NguoiDung
-- Sach
-- PhieuMuon
-- ChiTietPM
-- YeuCauMS

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
    VALUES (@idDG, @idTT, NULL, NULL, NULL, @amount, 0, 0, N'Chưa thanh toán', N'Tốt')

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

-- Insert data
INSERT INTO NguoiDung (userName, passWord, type, fullName, phone, birth, address)
VALUES ('admin1', 'password1', '0', 'Admin 1', '1234567890', '1995-01-01', 'Address 1'),
('thuthu1', 'password2', '1', N'Thủ Thư 1', '0987654321', '1995-05-10', 'Address 2'),
('ketoan1', 'password3', '2', N'Kế Toán 1', '0123456789', '1998-12-25', 'Address 3'),
('docgia1', 'docgia1', '3', N'Độc Giả 1', '0912345678', '1997-09-15', 'Address 4'),
('docgia2', 'docgia2', '3', N'Độc Giả 2', '0909876543', '1996-07-20', 'Address 5'),
('docgia3', 'docgia3', '3', N'Độc Giả 3', '0378942378', '1999-07-20', 'Address 6'),
('docgia4', 'docgia4', '3', N'Độc Giả 4', '0372974324', '2000-07-20', 'Address 7'),
('docgia5', 'docgia5', '3', N'Độc Giả 5', '0912345678', '1993-08-25', 'Address 8'),
('docgia6', 'docgia6', '3', N'Độc Giả 6', '0909876543', '1992-06-30', 'Address 9'),
('docgia7', 'docgia7', '3', N'Độc Giả 7', '0987654321', '1991-02-15', 'Address 10');
GO

INSERT INTO Sach (title, author, publisher, publicationYear, catagory, quantity)
VALUES (N'Sách 1', N'Tác Giả 1', N'Nhà Xuất Bản 1', '2020-01-01', N'Thể Loại 1', 20),
(N'Sách 2', N'Tác Giả 2', N'Nhà Xuất Bản 2', '2019-02-05', N'Thể Loại 2', 20),
(N'Sách 3', N'Tác Giả 3', N'Nhà Xuất Bản 3', '2018-03-10', N'Thể Loại 1', 25),
(N'Sách 4', N'Tác Giả 4', N'Nhà Xuất Bản 1', '2021-06-15', N'Thể Loại 3', 30),
(N'Sách 5', N'Tác Giả 2', N'Nhà Xuất Bản 2', '2022-09-20', N'Thể Loại 2', 25),
(N'Sách 6', N'Tác Giả 3', N'Nhà Xuất Bản 3', '2017-11-25', N'Thể Loại 1', 20),
(N'Sách 7', N'Tác Giả 1', N'Nhà Xuất Bản 1', '2023-03-12', N'Thể Loại 3', 15),
(N'Sách 8', N'Tác Giả 4', N'Nhà Xuất Bản 2', '2020-05-18', N'Thể Loại 2', 20),
(N'Sách 9', N'Tác Giả 2', N'Nhà Xuất Bản 3', '2019-07-23', N'Thể Loại 1', 25),
(N'Sách 10', N'Tác Giả 3', N'Nhà Xuất Bản 1', '2022-09-30', N'Thể Loại 3', 30);
GO

INSERT INTO PhieuMuon (idDG, idTT, idKT, borrowDate, returnDate, amount, deposit, refund, statusPM, statusBook)
VALUES
(4, 2, NULL, '2023-06-10', '2023-05-20', 2, 0, NULL, N'Chưa thanh toán', 'Tốt'),
(5, 2, NULL, '2023-06-12', '2023-04-19', 3, 0, NULL, N'Chưa thanh toán', 'Tốt'),
(7, 2, NULL, '2023-06-15', '2023-05-22', 1, 0, NULL, N'Chưa thanh toán', 'Tốt'),
(4, 2, 3, '2023-06-16', '2023-05-23', 2, 50000, NULL, N'Đã thanh toán', 'Tốt'),
(6, 2, 3, '2023-06-18', '2023-05-25', 1, 40000, NULL, N'Đã thanh toán', 'Tốt'),
(8, 2, 3, '2023-06-20', '2023-05-27', 2, 30000, NULL, N'Đã thanh toán', 'Tốt'),
(9, 2, 3, '2023-06-22', '2023-05-29', 3, 80000, NULL, N'Đã trả', 'Tốt'),
(10, 2, 3, '2023-06-24', '2023-05-01', 2, 50000, NULL, N'Đã trả', 'Tốt'),
(7, 2, 3, '2023-06-26', '2023-05-03', 1, 30000, NULL, N'Đã trả', 'Tốt'),
(8, 2, 3, '2023-06-28', '2023-05-05', 2, 40000, 40000, N'Hoàn thành', 'Tốt');
GO

INSERT INTO ChiTietPM (idPM, idBook, quantity)
VALUES
(1, 2, 2),
(2, 3, 3),
(3, 1, 1),
(4, 5, 2),
(5, 4, 1),
(6, 1, 2),
(7, 4, 3),
(8, 5, 2),
(9, 3, 1),
(10, 2, 2);
GO

INSERT INTO YeuCauMS (idDG, idBook, requestDate, quantity)
VALUES
(5, 5, '2023-06-11', 2),
(7, 4, '2023-06-13', 1),
(4, 1, '2023-06-16', 3),
(6, 2, '2023-06-17', 2),
(9, 3, '2023-06-18', 1),
(10, 4, '2023-06-14', 2),
(8, 2, '2023-06-10', 1),
(5, 5, '2023-06-06', 3),
(8, 3, '2023-06-01', 2),
(7, 1, '2023-05-25', 1);
GO

SELECT * FROM dbo.NguoiDung
SELECT * FROM dbo.Sach
SELECT * FROM dbo.YeuCauMS
SELECT * FROM dbo.PhieuMuon
SELECT * FROM dbo.ChiTietPM
