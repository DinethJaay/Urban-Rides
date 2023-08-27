create database urban_rides
use urban_rides

create table vehical
(
vehicle_number varchar (20) primary key,
engine_number varchar (20) not null,
chassis_number varchar (20) not null,
price float not null,
v_type varchar (20) not null,
v_brand varchar (20) not null,
v_model varchar (20) not null
)

create table customer
(
customer_id varchar (20) primary key,
customer_nic varchar (20) not null,
c_name varchar (200) not null,
c_address varchar (200) not null,
email varchar (200) CHECK(email like '%@gmail.com' or email like'%@yahoo.com') not null,
tp varchar (20) not null,
date date not null,
price float not null,
vehicle_number varchar (20) foreign key references vehical(vehicle_number)
);

create table bill
(
receipt_number varchar(20)  primary key,
customer_id varchar (20) foreign key references customer (customer_id),
out_date date not null,
KM float not null,
vehicle_number varchar (20) foreign key references vehical (vehicle_number),
rent_days int ,
amount float not null,
D_amount float,
total float not null,
)
drop table bill

create table v_service
(
vehical_type varchar(20) primary key,
full_service float not null,
body_wash float not null,
interior_cleaning float not null,
wax_polish float not null,
engine_oil float not null,
coolent float not null,
gear_oil float not null,
air_filter float not null,
oil_filter float not null,
air_freshner float not null,
);

create table c_service
(
c_id int primary key,
c_nic varchar(20) not null,
c_name varchar(200) not null,
c_address varchar(200) not null,
c_tp varchar(20) not null,
vehical_type varchar(20) foreign key references v_service(vehical_type),
v_number varchar(200) not null,
total float not null
);
drop table customer



