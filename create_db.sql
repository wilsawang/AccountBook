create database AccountBook;
use AccountBook;
go

-- 用户表
create table users(
	uid nvarchar(10) primary key, -- 用户名最大 10 位 
	upwd nvarchar(20) not null -- 密码最大 20 位
)
insert into users values('ningxiu','12345678');
insert into users values('ning','12345678');
select * from users;

-- 收入表
drop table income;
create table income(
	uid nvarchar(10),
	date datetime,
	sort nvarchar(10),
	subsort nvarchar(10),
	money decimal(10,2)
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


insert into income values('ningxiu','2023-12-8','家庭','生活费',2000);
insert into income values('ningxiu','2023-12-7','家庭','奖励',300);
insert into income values('ningxiu','2023-11-28','学校','奖学金',6000);
insert into income values('ningxiu','2023-12-3','学校','助学金',3500);
insert into income values('ningxiu','2023-11-27','社会','工资',2000);
insert into income values('ningxiu','2023-12-9','其他','其他',3);
insert into income values('ningxiu','2023-12-12','家庭','生活费',1500);

insert into disburse values('ningxiu','2023-12-4','衣','服饰',342);
insert into disburse values('ningxiu','2023-12-5','衣','眼镜',900);
insert into disburse values('ningxiu','2023-11-30','食','外卖',17);
insert into disburse values('ningxiu','2023-12-31','食','外卖',22);
insert into disburse values('ningxiu','2023-12-2','食','水果',10);
insert into disburse values('ningxiu','2023-11-25','住','租房',1200);
insert into disburse values('ningxiu','2023-12-1','住','酒店',340);
insert into disburse values('ningxiu','2023-11-25','行','电动车',1.6);
insert into disburse values('ningxiu','2023-12-11','行','地铁',7);
insert into disburse values('ningxiu','2023-12-1','其他','其他',340);
insert into disburse values('ningxiu','2023-12-12','食','堂食',7);

select * from income where date>='2023-01-01' and date<='2023-12-31';