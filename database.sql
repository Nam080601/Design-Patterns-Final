CREATE DATABASE MTK
GO
USE MTK

CREATE TABLE TAIKHOAN
(
	TENTAIKHOAN VARCHAR(10) PRIMARY KEY,
	MATKHAU VARCHAR(20)
)

CREATE TABLE SANPHAM
(
	MASP VARCHAR(20) PRIMARY KEY,
	TENSP NVARCHAR(20),
	GIA FLOAT
)

CREATE TABLE THEM
(
	MASPTHEM VARCHAR(20) PRIMARY KEY,
	TENSPTHEM NVARCHAR(20),
	GIA FLOAT
)

CREATE TABLE HOADON
(
	MAHD VARCHAR(20) PRIMARY KEY,
	TONG FLOAT
)

CREATE TABLE CHITIETHOADON
(
	MAHD VARCHAR(20) PRIMARY KEY,
	TENSP NVARCHAR(20),
	TENSPTHEM NVARCHAR(20),
	TONG FLOAT,
	FOREIGN KEY (MAHD) REFERENCES HOADON(MAHD)
)

-- INSERT TAIKHOAN
INSERT INTO TAIKHOAN VALUES
('admin', '123456')

-- INSERT SANPHAM
INSERT INTO SANPHAM VALUES
('DENDA', N'CÀ PHÊ ĐEN ĐÁ', 20000),
('DENNONG', N'CÀ PHÊ ĐEN NÓNG', 20000),
('SUABO', N'SỮA BÒ TƯƠI', 17000),
('SUADAUNANH', N'SỮA ĐẬU NÀNH', 15000)

-- INSERT THEM
INSERT INTO THEM VALUES
('DUONG', N'ĐƯỜNG', 5000),
('SUA', N'SỮA', 5000),
('BOTCAFE', N'BỌT CAFE', 3000)
