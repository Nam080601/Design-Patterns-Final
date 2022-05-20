create database coffee
go
use coffee

create table cafe(
	maCf varchar(10),
	tenCf nvarchar(20),
	gia float,
	primary key(maCf)
)

create table toping(
	maTp varchar(10),
	tenTp nvarchar(20),
	gia float,
	primary key(maTp)
)

create table hoadon(
	maHd varchar(10),
	total float,
	primary key(maHd)
)

create table chitiethoadon(
	maCtHd varchar(10),
	maHd varchar(10),
	primary key(maCtHd)
)


alter table chitiethoadon add constraint FK_CHITIETHOADON_MADH foreign key (maHd) references hoadon(maHd)

-- Insert Cafe
insert into cafe values('cf1', N'Sữa đá', 30000)
insert into cafe values('cf2', N'Đen đá', 35000)
insert into cafe values('cf3', N'Sữa nóng', 32000)
insert into cafe values('cf4', N'Đen nóng', 28000)
insert into cafe values('cf5', N'Espresso', 50000)
insert into cafe values('cf6', N'Cappuchino', 40000)

-- Insert Toping
insert into toping values('tp1', N'Bánh Phomai', 5000)
insert into toping values('tp2', N'Pudding Trứng', 15000)
insert into toping values('tp3', N'Matchiato', 20000)
insert into toping values('tp4', N'Kem trứng', 15000)

