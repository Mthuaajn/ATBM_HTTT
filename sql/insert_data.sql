-- bảng nhân sự
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES ('NV01', 'Nguyễn Văn A', 'M', TO_DATE('1980-01-01', 'YYYY-MM-DD'), 1000, '0123456789', 'Trưởng phòng', NULL);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES ('NV02', 'Trần Thị B', 'F', TO_DATE('1985-02-15', 'YYYY-MM-DD'), 1200, '0987654321', 'Trưởng khoa', NULL);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES ('NV03', 'Lê Văn C', 'M', TO_DATE('1975-03-20', 'YYYY-MM-DD'), 1100, '0167894563', 'Trưởng khoa', NULL);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES ('NV04', 'Phạm Thị D', 'F', TO_DATE('1990-04-25', 'YYYY-MM-DD'), 900, '0147852369', 'Giảng viên', NULL);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES ('NV05', 'Lý Minh E', 'M', TO_DATE('1982-07-30', 'YYYY-MM-DD'), 950, '0123456781', 'Giảng viên', NULL);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES ('NV06', 'Ngô Thanh F', 'F', TO_DATE('1988-09-12', 'YYYY-MM-DD'), 850, '0987654322', 'Giảng viên', NULL);
-- Dơn vị
INSERT INTO DONVI (MADV, TENDV, TRGDV) VALUES ('DV01', 'Phòng Đào Tạo', 'NV01');
INSERT INTO DONVI (MADV, TENDV, TRGDV) VALUES ('DV02', 'Khoa Công Nghệ Thông Tin', 'NV02');
INSERT INTO DONVI (MADV, TENDV, TRGDV) VALUES ('DV03', 'Khoa Kinh Tế', 'NV03');
INSERT INTO DONVI (MADV, TENDV, TRGDV) VALUES ('DV04', 'Khoa Ngoại Ngữ', 'NV04');
INSERT INTO DONVI (MADV, TENDV, TRGDV) VALUES ('DV05', 'Khoa Luật', 'NV05');
INSERT INTO DONVI (MADV, TENDV, TRGDV) VALUES ('DV06', 'Khoa Xã Hội Học', 'NV06');
-- thực hiện cập nhật nhân sự với madv
UPDATE NHANSU SET MADV = 'DV01' WHERE MANV = 'NV01';
UPDATE NHANSU SET MADV = 'DV02' WHERE MANV = 'NV02';
UPDATE NHANSU SET MADV = 'DV03' WHERE MANV = 'NV03';
UPDATE NHANSU SET MADV = 'DV04' WHERE MANV = 'NV04';
UPDATE NHANSU SET MADV = 'DV05' WHERE MANV = 'NV05';
UPDATE NHANSU SET MADV = 'DV06' WHERE MANV = 'NV06';

--bảng sinh viên 
INSERT INTO SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES ('SV01', 'Ngô Minh E', 'M', TO_DATE('2000-05-10', 'YYYY-MM-DD'), '123 Đường ABC', '0178452369', 'CT01', 'NG01', 120, 8.0);
INSERT INTO SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES ('SV02', 'Hoàng Thị F', 'F', TO_DATE('2001-06-15', 'YYYY-MM-DD'), '456 Đường DEF', '0123456780', 'CT02', 'NG02', 130, 7.5);
INSERT INTO SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES ('SV03', 'Trần Văn G', 'M', TO_DATE('1999-03-22', 'YYYY-MM-DD'), '789 Đường GHI', '0178452370', 'CT03', 'NG03', 110, 7.0);
INSERT INTO SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES ('SV04', 'Lê Thị H', 'F', TO_DATE('2000-08-12', 'YYYY-MM-DD'), '321 Đường JKL', '0123456782', 'CT04', 'NG04', 125, 8.2);
INSERT INTO SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES ('SV05', 'Nguyễn Văn I', 'M', TO_DATE('2001-11-25', 'YYYY-MM-DD'), '654 Đường MNO', '0987654323', 'CT05', 'NG05', 140, 8.5);
-- bảng học phần 
INSERT INTO HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES ('HP01', 'Lập trình C', 3, 30, 15, 50, 'DV02');
INSERT INTO HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES ('HP02', 'Kinh tế vi mô', 3, 35, 20, 60, 'DV03');
INSERT INTO HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES ('HP03', 'Ngôn ngữ Anh', 4, 40, 20, 55, 'DV04');
INSERT INTO HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES ('HP04', 'Luật Hành Chính', 3, 30, 15, 45, 'DV05');
INSERT INTO HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES ('HP05', 'Xã Hội Học Đại Cương', 3, 35, 20, 50, 'DV06');
-- bảng khmo
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES ('HP01', 1, 2023, 'CT01');
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES ('HP02', 2, 2023, 'CT02');
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES ('HP03', 1, 2023, 'CT03');
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES ('HP04', 2, 2023, 'CT04');
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES ('HP05', 1, 2023, 'CT05');
--bảng phân công 
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES ('NV04', 'HP01', 1, 2023, 'CT01');
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES ('NV03', 'HP02', 2, 2023, 'CT02');
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES ('NV05', 'HP03', 1, 2023, 'CT03');
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES ('NV06', 'HP04', 2, 2023, 'CT04');
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES ('NV01', 'HP05', 1, 2023, 'CT05');
--bảng Dăng ký 
INSERT INTO DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTH, DIEMQT, DIEMCK, DIEMTK) VALUES ('SV01', 'NV04', 'HP01', 1, 2023, 'CT01', 8.0, 7.5, 8.5, 8.2);
INSERT INTO DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTH, DIEMQT, DIEMCK, DIEMTK) VALUES ('SV02', 'NV03', 'HP02', 2, 2023, 'CT02', 7.0, 7.2, 7.8, 7.3);
INSERT INTO DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTH, DIEMQT, DIEMCK, DIEMTK) VALUES ('SV03', 'NV05', 'HP03', 1, 2023, 'CT03', 7.5, 7.0, 7.9, 7.4);
INSERT INTO DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTH, DIEMQT, DIEMCK, DIEMTK) VALUES ('SV04', 'NV06', 'HP04', 2, 2023, 'CT04', 8.5, 8.2, 8.7, 8.4);
INSERT INTO DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTH, DIEMQT, DIEMCK, DIEMTK) VALUES ('SV05', 'NV01', 'HP05', 1, 2023, 'CT05', 8.7, 8.3, 9.0, 8.8);
