create database mtk
go
use mtk

create table accounts
(
	id int identity,
	taikhoan varchar(20) not null primary key,
	matkhau varchar(20) not null
)

insert into accounts(taikhoan,matkhau) values
('admin', 'admin'),
('user', 'user')