use AccountBook;
go

-- �û���
create table users(
	uid nvarchar(10) primary key, -- �û������ 10 λ 
	upwd nvarchar(20) not null -- ������� 20 λ
)
insert into users values('ningxiu','12345678');
select * from users;

-- �����
create table income(
	uid nvarchar(10),
	date datetime,
	sort nvarchar(10),
	subsort nvarchar(10),
	money nvarchar(10), -- decimal(10,2)
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

