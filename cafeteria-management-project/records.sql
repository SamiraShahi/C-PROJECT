use cms
create table records(
id int primary key not null,
amount int not null,
paidamount int not null,
dueamount int not null
)
insert into records(id,amount,paidamount,dueamount) values(5409,500,500,0)
select * from records