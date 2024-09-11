Create database QLDIEMSV

CREATE TABLE KHOA
(
	MaKhoa char (10) PRIMARY KEY,
	TenKhoa nvarchar (20) NOT NULL UNIQUE,
	SDTKhoa varchar (10)
)

CREATE TABLE GIANGVIEN
(
	MaGV char (10) PRIMARY KEY,
	HovaTenGV nvarchar (50),
	GioiTinhGV nvarchar (10) check (GioiTinhGV = N'Nam' or GioiTinhGV = N'Nữ'),
	NgaySinh date,
	SDTGV nchar (10),
	DiaChiGV nvarchar (50),
	MaKhoa char (10) foreign key (MaKhoa) references KHOA
)

CREATE TABLE SINHVIEN
(
	MaSV char (10) PRIMARY KEY,
	HovaTenSV nvarchar (50),
	GioiTinhSV nvarchar (10) check (GioiTinhSV = N'Nam' or GioiTinhSV = N'Nữ'),
	NgaySinh date,
	QueQuan nvarchar (20),
	SDTSV nchar (10),
	MaKhoa char (10) foreign key (MaKhoa) references KHOA
) 

CREATE TABLE HOCKY
(
	MaHK char (5) PRIMARY KEY,
	TenHK nvarchar (20),
	ThoiGianBDHK date,
	ThoiGianKTHK date
)

CREATE TABLE MONHOC
(
	MaMH char (10) PRIMARY KEY,
	TenMH nvarchar (20),
	SoTinChi int,
	SoTietLT int,
	SoTietTH int	
)

CREATE TABLE LOPMONHOC
(
	MaLopMH char (10) PRIMARY KEY,
	MaMH char (10) foreign key (MaMH) references MONHOC,
	MaGV char (10) foreign key (MaGV) references GIANGVIEN,
	MaHK char (5) foreign key (MaHK) references HOCKY,
	NgayBD date,
	NgayKT date,	
)

CREATE TABLE BANGDIEM
(
	MaSV char (10) foreign key (MaSV) references SINHVIEN,
	MaLopMH char (10) foreign key (MaLopMH) references LOPMONHOC,
	DiemGK float check (DiemGK>=0 and DiemGK<=10),
	DiemCK float check (DiemCK>=0 and DiemCK<=10),
	PRIMARY KEY (MaSV, MaLopMH)
)


