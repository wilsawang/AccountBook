use AccountBook;
go

-- �û���
create table users(
	uid nvarchar(10) primary key, -- �û������ 10 λ 
	upwd nvarchar(20) not null -- ������� 20 λ
)
insert into users values('ningxiu','12345678');
select * from users;