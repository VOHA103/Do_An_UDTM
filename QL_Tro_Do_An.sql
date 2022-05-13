--///ki 2022 android
use master
go

if exists(select *from sysdatabases where name='QL_PHONG_TRO')
drop database QL_PHONG_TRO
go



create database QL_PHONG_TRO
go
use QL_PHONG_TRO
go


create table LOAI_PHONG(
ID_LOAIPHONG int identity(1,1) primary key,
TENLOAI nvarchar(20),
GIAPHONG float,
_status int,--1 co:0:khong

)
go



CREATE TABLE PHONG
(
ID_PHONG int identity(1,1) PRIMARY KEY,
ID_LOAIPHONG int,
TENPHONG NVARCHAR(50),
DIACHI NVARCHAR(128),
_status int,--1 co:0:khong
CONSTRAINT FK_P_LP FOREIGN KEY(ID_LOAIPHONG) REFERENCES LOAI_PHONG(ID_LOAIPHONG)
)
go



 ---table loai dich vu
 create table LOAI_DICH_VU(
 ID_LOAIDICHVU int identity(1,1) primary key,
 TENDICHVU NVARCHAR(128),
 DONGIA int,
_status int,--1 co:0:khong
 )
 go


 select*from LOAI_DICH_VU

 -----table dich vu
 create table DV_Dien_Nuoc(
 ID_DNuoc int identity(1,1) primary key,
 ID_PHONG int,
 Thang_TT datetime,
CSM int,--chi so moi
 CSC int,---chi so cu
 DonGia float,

CONSTRAINT FK_P_DV FOREIGN KEY(ID_PHONG) REFERENCES PHONG(ID_PHONG)

 )
 go


---table dich vu them
 create table DICHVU_THEM(
 ID_DVT int identity(1,1) primary key,
 ID_LOAIDICHVU int,
 ID_PHONG int,
 TU_NGAY date,
 DEN_NGAY date,
 TONGTIEN float,

CONSTRAINT FK_LDV_DVT FOREIGN KEY(ID_LOAIDICHVU) REFERENCES LOAI_DICH_VU(ID_LOAIDICHVU),
CONSTRAINT FK_P_DVT FOREIGN KEY(ID_PHONG) REFERENCES PHONG(ID_PHONG)
 )
 go

create table KHACH_HANG(
ID_KHACHHANG int identity(1,1) primary key,
TENKHACHHANG nvarchar(50),
GIOITINH nvarchar(5),
DIACHI nvarchar(150),
CMND nchar(20),
SDT nchar(11),
_status int,--1 co:0:khong

)
go


create table HOP_DONG(
ID_HOPDONG int identity(1,1) primary key,
ID_PHONG int,
ID_KHACHHANG int,
TIENCOC int,
NGAYTHUE datetime,
NGAYTRA datetime,
_status int,--1 co:0:khong
CONSTRAINT FK_HD_P FOREIGN KEY(ID_PHONG) REFERENCES PHONG(ID_PHONG),
CONSTRAINT FK_KH_HD FOREIGN KEY(ID_KHACHHANG) REFERENCES KHACH_HANG(ID_KHACHHANG)
)
go

create table HOA_DON(
ID_HOADON int identity(1,1)  primary key,
ID_PHONG int,
TONGTIEN int,
Thang_TToan datetime,

CONSTRAINT FK_HD_P2 FOREIGN KEY(ID_PHONG) REFERENCES PHONG(ID_PHONG)
)
go

go

create table QUAN_LY(
TAIKHOAN char(20) primary key,
MATKHAU char(50),
PHANQUYEN int,

)
go


SET DATEFORMAT DMY
----------Insert data----------------
----insert table: QUANLY
insert into QUAN_LY values('admin','admin',1);
insert into QUAN_LY values('admin1','admin1',1);

---insert table: LOAI_PHONG
insert into LOAI_PHONG values(N'Loại Phòng A',3200000,1);
insert into LOAI_PHONG values(N'Loại Phòng B',4000000,1);

----insert table: PHONG
insert into PHONG values(1,N'Phòng 1',N'TP HCM',1);
insert into PHONG values(2,N'Phòng 2',N'TP HCM',1);



---inset table: LOAI_DICH_VU
 insert into LOAI_DICH_VU values(N'DV WIFI',50000,1);
 insert into LOAI_DICH_VU values(N'DV Rác',10000,1);

 ---insert table:DICHVU_THEM
 insert into DICHVU_THEM values(1,1,'5/1/2022','28/2/2022',null);
 insert into DICHVU_THEM values(2,2,'1/12/2022','20/1/2022',null);
 

 ----insert table :KHACH_HANg
 insert into KHACH_HANG values(N'Võ Thị Thu Hà',N'Nữ',N'Bình Định','052301011327','0328090646',1);
insert into KHACH_HANG values(N'Ngô Thanh Huyền',N'Nữ',N'Quảng Bình ','052301011123','0387388001',1);

 ---insert table :HOP_DONG
insert into HOP_DONG values(1,1,500000,'5/1/2022',null,1);
insert into HOP_DONG values(2,2,1000000,'10/1/2022',null,1);

 ----insert table:DV_DIEN_NUOC
 insert into DV_Dien_Nuoc values(1,'5/3/2022',11.929,11.929,3000);
 insert into DV_Dien_Nuoc values(2,'4/4/2022',735,727,8000);

 ----insert table:HOA_DON

insert into HOA_DON values(1,null,'5/1/2022');
insert into HOA_DON values(2,null,'7/1/2022');
go
select*from HOA_DON



