use AccountBook;
go

-- 用户表
create table users(
	uid nvarchar(10) primary key, -- 用户名最大 10 位 
	upwd nvarchar(20) not null -- 密码最大 20 位
)
insert into users values('ningxiu','12345678');
select * from users;