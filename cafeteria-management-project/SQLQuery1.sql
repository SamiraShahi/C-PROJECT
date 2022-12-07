create database cms
use cms
create table password(
pass nvarchar(255)
)
insert into password(pass) values('cms')
select * from password