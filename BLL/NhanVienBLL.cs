﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
using Model;

namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL quanLyDAL = new NhanVienDAL();
        public bool ThemNhanVien(string _HoTen, DateTime _NgaySinh, string _GioiTinh, string _SoCMND, string _SDT, string _ChucVu, string _DiaChi)
        {
            try
            {
                return quanLyDAL.ThemNhanVien(new NhanVienDTO() { HoVaTen = _HoTen, NgaySinh = _NgaySinh, ChucVu = _ChucVu, GioiTinh = _GioiTinh, DiaChi = _DiaChi, SDT = _SDT, SoCMND = _SoCMND });
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public bool XoaNhanVien(int _maNV, string _HoTen, DateTime _NgaySinh, string _GioiTinh, string _SoCMND, string _SDT, string _ChucVu, string _DiaChi)
        {
            try
            {
                return quanLyDAL.XoaNhanVien(new NhanVienDTO() { MaNhanVien = _maNV, HoVaTen = _HoTen, NgaySinh = _NgaySinh, ChucVu = _ChucVu, GioiTinh = _GioiTinh, DiaChi = _DiaChi, SDT = _SDT, SoCMND = _SoCMND });
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public bool UpdateNhanVien(int _maNV, string _HoTen, DateTime _NgaySinh, string _GioiTinh, string _SoCMND, string _SDT, string _ChucVu, string _DiaChi, string _rowVer)
        {
            try
            {
                return quanLyDAL.UpdateNhanVien(new NhanVienDTO() { MaNhanVien = _maNV, HoVaTen = _HoTen, NgaySinh = _NgaySinh, ChucVu = _ChucVu, GioiTinh = _GioiTinh, DiaChi = _DiaChi, SDT = _SDT, SoCMND = _SoCMND, RowVersion = _rowVer });
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<NhanVienDTO> DanhSachNhanVien()
        {
            try
            {
                return quanLyDAL.DanhSachSinhVien().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}