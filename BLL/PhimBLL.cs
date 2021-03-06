﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using Model;
namespace BLL
{
    public class PhimBLL
    {
        PhimDAL phimDAL = new PhimDAL();

        public List<PhimDTO> DanhSachPhim()
        {
            try
            {
                return phimDAL.DanhSachPhim();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool ThemPhim(string ten, string theloai, DateTime khoichieu, string mota)
        {
            try
            {
                PhimDTO p = new PhimDTO() { TenPhim = ten, TheLoai = theloai, NgayKhoiChieu = khoichieu, MoTa = mota };
                if (phimDAL.ThemPhim(p)) return true;
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool XoaPhim(int ma, string rv)
        {
            try
            {
                return phimDAL.XoaPhim(ma, rv);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool UpdatePhim(int ma, string ten, string theloai, DateTime khoichieu, string rowVersion)
        {
            try
            {
                PhimDTO p = new PhimDTO() { 
                    MaPhim = ma, TenPhim = ten, TheLoai = theloai, 
                    NgayKhoiChieu = khoichieu, 
                    RowVersion = rowVersion
                };
                if (phimDAL.UpdatePhim(p)) return true;
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
