﻿using DTO;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LichChieuDAL
    {
		public List<LichChieuDTO> DanhSachLichChieu()
        {
			try
			{
				using (var context = new QLRPContext())
				{
					List<LichChieu> lichChieus = context.LichChieus.Select(p => p).ToList();
					List<LichChieuDTO> lichChieuDTOs = new List<LichChieuDTO>();
					foreach (LichChieu lc in lichChieus)
					{
						var lcDTO = new LichChieuDTO
						{
							MaLichChieu = lc.MaLichChieu,
							MaPhim = lc.MaPhim,
							MaPhong = lc.MaPhong,
							NgayGioChieu = lc.NgayGioChieu,
							RowVersion = BitConverter.ToUInt64(lc.RowVersion, 0).ToString(),
							TenPhim = lc.Phim.TenPhim,
							TenPhong = lc.PhongChieu.TenPhong,
							PhimMoTa = lc.Phim.MoTa,
							SoGheTrong = getSoGheTrong(lc.MaPhong,lc.MaLichChieu)
						};
						lichChieuDTOs.Add(lcDTO);
					}
					return lichChieuDTOs;
				}
			}
			catch (Exception)
			{
				throw;
			}
        }

		public bool ThemLichChieu(LichChieuDTO lichChieu)
		{
			try
			{
				using (var context = new QLRPContext())
				{
					context.LichChieus.Add(new LichChieu()
					{
						MaPhim = lichChieu.MaPhim,
						NgayTao = DateTime.Now,
						NguoiTao = CurrentUser.Username,
						NgaySua = DateTime.Now,
						NguoiSua = CurrentUser.Username,
						MaPhong = lichChieu.MaPhong,
						NgayGioChieu = lichChieu.NgayGioChieu
					});
					context.SaveChanges();
					return true;
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		public bool XoaLichChieu(int malc_delete, string rowVersion)
		{
			try
			{
				using (var context = new QLRPContext())
				{
					var lc = context.LichChieus.SingleOrDefault(l => l.MaLichChieu == malc_delete);
					if (lc!=null)
					{
						if (Utils.ValidateRowversion(lc.RowVersion, rowVersion))
						{
							context.LichChieus.Remove(lc);
							context.SaveChanges();
							return true;
						}
						throw new Exception("Có ai đó đã update đối tượng này trước đó. Danh sách sẽ được load lại.");
					}
					throw new Exception("Lịch chiếu này đã bị xóa bởi ai đó. Danh sách sẽ được load lại.");
				}
			}
			catch (DbUpdateConcurrencyException)
			{
				throw new Exception("Hiện tại, có ai đó cũng đang update đối tượng này. Danh sách sẽ được load lại.");
			}
			catch (Exception)
			{
				throw;
			}
		}

		public bool UpdateLichChieu(LichChieuDTO lichChieu)
		{
			try
			{
				using (var context = new QLRPContext())
				{
					var lichChieu_update = context.LichChieus.SingleOrDefault(p => p.MaLichChieu == lichChieu.MaLichChieu);
					if (lichChieu_update != null)
					{
						if (Utils.ValidateRowversion(lichChieu_update.RowVersion, lichChieu.RowVersion))
						{
							lichChieu_update.MaPhong = lichChieu.MaPhong;
							lichChieu_update.MaPhim = lichChieu.MaPhim;
							lichChieu_update.NgayGioChieu = lichChieu.NgayGioChieu;
							lichChieu_update.NguoiSua = CurrentUser.Username;
							lichChieu_update.NgaySua = DateTime.Now;
							context.SaveChanges();
							return true;
						}
						throw new Exception("Có ai đó đã update đối tượng này trước đó. Danh sách sẽ được load lại.");
					}
					throw new Exception("Lịch chiếu này đã bị xóa bởi ai đó. Danh sách sẽ được load lại.");
				}
			}
			catch (DbUpdateConcurrencyException)
			{
				throw new Exception("Hiện tại, có ai đó cũng đang update đối tượng này. Danh sách sẽ được load lại.");
			}
			catch (Exception)
			{
				throw;
			}
		}

		public List<PhongChieuDTO> getPhongs()
		{
			try
			{
				using (var context = new QLRPContext())
				{
					var list = context.PhongChieus.Select(p => new PhongChieuDTO
					{
						MaPhong = p.MaPhong,
						TenPhong = p.TenPhong,
						SoHang = p.SoHang,
						SoCot = p.SoCot
					}).ToList();
					return list;
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		public List<PhimDTO> getPhims()
		{
			try
			{
				using (var context = new QLRPContext())
				{
					var list = context.Phims.Select(p => new PhimDTO
					{
						MaPhim = p.MaPhim,
						TenPhim = p.TenPhim,
						NgayKhoiChieu = p.NgayKhoiChieu,
						MoTa = p.MoTa,
						TheLoai = p.TheLoai
					}).ToList();
					return list;
				}
			}
			catch (Exception)
			{
				throw;
			}
		}
		public int getSoGheTrong(int maPhong, int maLC)
        {
            try
            {
                using (var context = new QLRPContext())
                {
                    int num_all_seats = context.Ghes.Count(p => p.MaPhong == maPhong);
                    int num_all_booked_seats = context.DatVes.Count(p => p.MaLichChieu == maLC);
                    return num_all_seats - num_all_booked_seats;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
	}
}
