use AccountBook;
go

-- 用户表
create table users(
	uid nvarchar(10) primary key, -- 用户名最大 10 位 
	upwd nvarchar(20) not null -- 密码最大 20 位
)
insert into users values('ningxiu','12345678');
select * from users;

-- 收入表
create table income(
	uid nvarchar(10),
	date datetime,
	sort nvarchar(10),
	subsort nvarchar(10),
	money nvarchar(10), -- decimal(10,2)
)
alter table income add constraint income_con foreign key(uid) references users(uid);

-- 支出表
create table disburse(
	uid nvarchar(10),
	date datetime,
	sort nvarchar(10),
	subsort nvarchar(10),
	money decimal(10,2)
)
alter table disburse add constraint dis_con foreign key(uid) references users(uid);

