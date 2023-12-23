create database AccountBook;
use AccountBook;
go

-- �û���
create table users(
	uid nvarchar(10) primary key, -- �û������ 10 λ 
	upwd nvarchar(20) not null -- ������� 20 λ
)
insert into users values('ningxiu','12345678');
insert into users values('ning','12345678');
select * from users;

-- �����
drop table income;
create table income(
	uid nvarchar(10),
	date datetime,
	sort nvarchar(10),
	subsort nvarchar(10),
	money decimal(10,2)
)
alter table income add constraint income_con foreign key(uid) references users(uid);
-- ֧����
create table disburse(
	uid nvarchar(10),
	date datetime,
	sort nvarchar(10),
	subsort nvarchar(10),
	money decimal(10,2)
)
alter table disburse add constraint dis_con foreign key(uid) references users(uid);


insert into income values('ningxiu','2023-12-8','��ͥ','�����',2000);
insert into income values('ningxiu','2023-12-7','��ͥ','����',300);
insert into income values('ningxiu','2023-11-28','ѧУ','��ѧ��',6000);
insert into income values('ningxiu','2023-12-3','ѧУ','��ѧ��',3500);
insert into income values('ningxiu','2023-11-27','���','����',2000);
insert into income values('ningxiu','2023-12-9','����','����',3);
insert into income values('ningxiu','2023-12-12','��ͥ','�����',1500);

insert into disburse values('ningxiu','2023-12-4','��','����',342);
insert into disburse values('ningxiu','2023-12-5','��','�۾�',900);
insert into disburse values('ningxiu','2023-11-30','ʳ','����',17);
insert into disburse values('ningxiu','2023-12-31','ʳ','����',22);
insert into disburse values('ningxiu','2023-12-2','ʳ','ˮ��',10);
insert into disburse values('ningxiu','2023-11-25','ס','�ⷿ',1200);
insert into disburse values('ningxiu','2023-12-1','ס','�Ƶ�',340);
insert into disburse values('ningxiu','2023-11-25','��','�綯��',1.6);
insert into disburse values('ningxiu','2023-12-11','��','����',7);
insert into disburse values('ningxiu','2023-12-1','����','����',340);
insert into disburse values('ningxiu','2023-12-12','ʳ','��ʳ',7);

select * from income where date>='2023-01-01' and date<='2023-12-31';