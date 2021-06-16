Create database HTQL_BANVEXEMFILM
Use HTQL_BANVEXEMFILM

Create table KHACH_HANG( MaKH varchar(20) not null primary key, HoTen varchar(20) not null, 
 Sđt char(10) not null, Doanhso money not null)


Create table NHAN_VIEN(MaNV varchar(15) not null primary key, 
  HoTen varchar(20) not null, Diachi char(15) not null, 
  NgaySinh date not null, Gioitinh bit not null, 
  Sđt char (10) not null)

 Create table VE ( MaVe varchar(20) not null primary Key,
MaLV char(10) not null,  MaNV varchar(15) not null, 
 MaKH varchar(20) not null,Ghe int, NgayBan date not null)
  
 Create table LOAI_VE( MaLV char(10) not null primary key, TenLV varchar(10) not null,
 DonGia int not null )

 Alter table VE 
 Add constraint FK_LOAI_VE foreign key (MaLV) References LOAI_VE(MaLV)
  
 Alter table VE
 Add Constraint FK_NHAN_VIEN Foreign Key(MaNV) References NHAN_VIEN(MaNV)

  Alter table VE 
 Add Constraint FK_KHACH_HANG Foreign key (MaKH) References KHACH_HANG(MaKH)
  
   Insert into KHACH_HANG(MaKH,HoTen,Sđt,Doanhso)
   values ('H001','Luong The Thanh','0934697655',110000),
           ('H002','Vo The Thai','0882345100',800000),
           ('H003','Luong Van Thanh','0934697444',400000),
           ('H004','Tran Van Nhon','0914697855',150000),
           ('H005','Do The Thu','0934696655',220000),
           ('H006','Do Van Phuc','0905055044',110000),
           ('H007','Tran Thi Uyen','0186317388',80000),
           ('H011','Vo Hoai bao','0945677888',100000),
           ('H009','Vo Van Hiep','0912697455',200000),
           ('H008','Nguyen Thanh','0905699645',300000),
		   ('H010' ,'Nguyen Thuan','0905699645',400000)

   Insert into NHAN_VIEN(MaNV, HoTen, NgaySinh,Gioitinh,Sđt,Diachi)
   values ('NV01' , 'Tran Van Tu', '1998-10-02', 1, '0935678900', 'Da Nang'),
           ('NV02' , 'Le Van Trong', '1997-10-03', 1, '0933476510', 'Da Nang'),
           ('NV03' , 'Do Kim Phuc', '1997-02-15', 1, '0977024555', 'Quang Nam'),
           ('NV04' , 'Ngo Hoang Nhi', '1995-08-02', 0, '0931077009', 'Quang Tri'),
           ('NV05' , 'Do Xuan Thu', '1996-06-06', 1, '0978012333', 'Hoi An'),
           ('NV06' , 'Nguyen Thi Van ', '1997-03-04', 0, '0935678123', 'Quang Binh'),
           ('NV07' , 'Ngo Thi Huyen', '1998-10-02', 0, '0934566777', 'Quang Nam'),
           ('NV08' , 'Tran Thi My Uyen', '1996-08-02', 0, '0905777888', 'Da Nang')
    
     Insert into LOAI_VE(MaLV, TenLV, DonGia)
     values ('LV03', 'VIP', 110000),
           ('LV02', 'Normal', 50000),
		   ('LV01', 'Khuyenmai', 40000)
	   
      Insert into VE(MaVe, MaLV,MaNV,MaKH,NgayBan,Ghe)
 values  ('V01', 'LV01', 'NV01', 'H001', '2011-03-07', 10),
         ('V02', 'LV02', 'NV02', 'H002', '2011-07-07', 11),
	     ('V03', 'LV01', 'NV03', 'H003', '2011-02-10', 13),
	     ('V04', 'LV03', 'NV04', 'H004', '2012-03-07', 20),
	     ('V05', 'LV01', 'NV05', 'H005', '2012-04-08', 17),
         ('V06', 'LV01', 'NV06', 'H006', '2013-11-02', 15),
	     ('V08', 'LV02', 'NV01', 'H008', '2014-10-03', 12),
	     ('V07', 'LV03', 'NV07', 'H007', '2012-01-07', 14),		       
	     ('V09', 'LV03', 'NV02', 'H009', '2012-08-14', 20),
	     ('V10', 'LV03', 'NV08', 'H003', '2014-08-08', 21),
	     ('V11', 'LV02', 'NV07', 'H010', '2011-03-03', 24),
	     ('V12', 'LV02', 'NV05', 'H011', '2012-06-10', 26),
	     ('V13', 'LV02', 'NV06', 'H008', '2013-05-04', 27),
	     ('V14', 'LV02', 'NV05', 'H007', '2015-04-04', 30),
	     ('V15', 'LV02', 'NV04', 'H005', '2013-05-06', 40)

 Select * from VE
 Select * from KHACH_HANG
 Select * from NHAN_VIEN
 Select * from LOAI_VE
  
          