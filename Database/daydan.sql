create database daydan

use daydan
/*khoa ngoai*/
/*blog loai blog*/
alter table blog add constraint fk_blog_loaiblog foreign key (MaLoaiBlog) references LoaiBlog(MaLoaiBlog)
/*Loại thành viên Thành viên*/
alter table ThanhVien add constraint fk_thanhvien_loaitv foreign key (LoaiThanhVien) references LoaiThanhVien(MaLoaiTVien)
/*baigiang thanhvien*/
alter table BaiGiang add constraint fk_bg_thanhvien foreign key(MaThanhVien) references ThanhVien(MaThanhVien)
/*Video ThanhVien*/
alter table Video add constraint fk_video_thanhvien foreign key(MaThanhVien) references ThanhVien(MaThanhVien)
/*Video Blog*/
alter table Video add constraint fk_video_blog foreign key (Mablog) references Blog(MaBlog)
/*Video BaiGiang*/
alter table Video add constraint fk_video_bg foreign key (MaBG) references BaiGiang(MaBaiGiang)
/*Video GiaiDieu*/
alter table Video add constraint fk_videogd foreign key(MaGD) references GiaiDieu(MaGiaiDieu)
/*BaiGiang ChuDe*/
alter table BaiGiang add constraint fk_baigiang_chude foreign key(MaCD) references ChuDe(MaChuDe)
/*Baigiang GiaiDieu*/
alter table BaiGiang add constraint fk_baigiang_giaidieu foreign key(MaGD) references GiaiDieu(MaGiaiDieu)
/*=============================================================================================================*/
/*INSERT LOAI BAI GIANG*/
insert into LoaiBaiGiang(MaLoaiBG,TenLoaiBG,MoTaLoaiBG) values (1,N'Guitar Đệm Hát','')
insert into LoaiBaiGiang(MaLoaiBG,TenLoaiBG,MoTaLoaiBG) values (2,N'Cổ Điển','')
insert into LoaiBaiGiang(MaLoaiBG,TenLoaiBG,MoTaLoaiBG) values (3,N'Ukulele','')
insert into LoaiBaiGiang(MaLoaiBG,TenLoaiBG,MoTaLoaiBG) values (4,N'Finger Style','')
/*INSERT LOAI THANH VIEN*/
SET IDENTITY_INSERT LoaiThanhVien off
insert into LoaiThanhVien(TenLoai,MoTa) values (N'Mới','')
insert into LoaiThanhVien(TenLoai,MoTa) values (N'Vip','')
insert into LoaiThanhVien(TenLoai,MoTa) values (N'Admin','')
/*INSERT CHU DE*/
insert into ChuDe(TenChuDe,MoTaCD) values (N'Nhạc trữ tình','')
insert into ChuDe(TenChuDe,MoTaCD) values (N'Nhạc Bolaro','')
/*INSERT GIAI DIEU*/
insert into GiaiDieu(TenGiaiDieu,MoTa) values (N'Slow','')
insert into GiaiDieu(TenGiaiDieu,MoTa) values (N'Valse','')
/*INSERT LOAI BLOG*/
--alter table LoaiBlog add TenLoaiBlog nvarchar(50)
--alter table LoaiBlog add MotaBlog nvarchar(80)
--alter table LoaiBlog drop column TenLoaiBlog
--alter table LoaiBlog drop column MotaBlog
insert into LoaiBlog(TenLoaiBlog,MotaBlog) values (N'Thông báo từ quản trị','')
insert into LoaiBlog(TenLoaiBlog,MotaBlog) values (N'Cách đánh điệu slow đơn giản','')
/*INSERT THANH VIEN*/
alter table ThanhVien add Email varchar(30)
alter table ThanhVien add Hinhanh varchar(255)
insert into ThanhVien(TenThanhVien,Ngaydangky,Diem,Mota,LoaiThanhVien,UserName,Pass) values (N'ThanhNgan','20160811',7,'',1,'tn95','shuting95')
insert into ThanhVien(TenThanhVien,Ngaydangky,Diem,Mota,LoaiThanhVien,UserName,Pass) values (N'ThanhNgan2','20160811',7,'',1,'htn95','shuting95')
/*INSERT VIDEO*/
insert into Video(Tenvideo,Ngaydang,Trangthai,MaThanhVien,Luotthich,Luotxem) values (N'Video1','20160811','1',1,100,100)
insert into Video(Tenvideo,Ngaydang,Trangthai,MaThanhVien,Luotthich,Luotxem) values (N'Video2','20160811','1',1,100,100)
/*INSERT BAI GIANG*/
insert into BaiGiang(TenBaiGiang,MaLoaiBG,NoiDung,NgayDang,MaThanhVien) values (N'Bài giảng 1',1,N'Bài học đầu tiên cách cầm đàn và cách đánh nốt','20160811',1)
insert into BaiGiang(TenBaiGiang,MaLoaiBG,NoiDung,NgayDang,MaThanhVien) values (N'Bài giảng 2',1,N'Bài học đầu tiên cách cầm đàn và cách đánh nốt','20160811',1)
insert into BaiGiang(TenBaiGiang,MaLoaiBG,NoiDung,NgayDang,MaThanhVien) values (N'Bài giảng 3',1,N'Bài học đầu tiên cách cầm đàn và cách đánh nốt','20160811',1)
/*INSERT BLOG*/
--alter table Blog add Noidung nvarchar(255)
insert into Blog(TenBlog,NgayDang,NoiDung,MaLoaiBlog,Mavideo) values (N'Blog1','20160811',N'Cách đánh hợp âm nhanh nhất',3,1)
insert into Blog(TenBlog,NgayDang,NoiDung,MaLoaiBlog,Mavideo) values (N'Blog2','20160811',N'Cách đánh hợp âm nhanh nhất',3,2)
insert into Blog(TenBlog,NgayDang,NoiDung,MaLoaiBlog,Mavideo) values (N'Blog3','20160811',N'Cách đánh hợp âm nhanh nhất',3,2)


--Procedure account
create proc [dbo].[ThanhVienLogin]
@UserName char(10),
@Password char(12)
as
begin
declare @count int 
declare @res bit
select @count = count(*) from ThanhVien where Username = @UserName and Pass = @Password
if @count >0
set @res = 1
else set @res = 0
select @res
end