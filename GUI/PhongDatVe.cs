﻿using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim.DanhSachPhong
{
    public partial class PhongDatVe : Form
    {
        LichChieuDTO lichChieu = null;
        PhongChieuDTO phongChieu = null;
        DatVeBLL datVeBLL;
        Dictionary<string, int> ghes = new Dictionary<string, int>();
        List<int> gheDaChon = new List<int>();
        List<string> gheDaDat = new List<string>();
        public PhongDatVe(LichChieuDTO lc)
        {
            InitializeComponent();
            lichChieu = lc;
            datVeBLL = new DatVeBLL();
            
            // Trang : con
            // Do : da dat ve
            // Xanh la cay : da chon
        }
        private void GhesDraw()
        {
            ghes = datVeBLL.LayDSGhe(lichChieu.MaPhong);
            gheDaDat = datVeBLL.LayVeDaDat(lichChieu.MaLichChieu);
            phongChieu = datVeBLL.LayKieuPhong(lichChieu.MaPhong);
            int r = phongChieu.SoHang;
            int c = phongChieu.SoCot;
            
            GhesPanel.RowStyles.Clear();
            GhesPanel.ColumnStyles.Clear();
            GhesPanel.ColumnCount = c;
            GhesPanel.RowCount = r;
            for (int i = 0; i<c; i++)
            {
                GhesPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100*1f/c));
            }
            for (int i = 0; i < r; i++)
            {
                GhesPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100 * 1f / r));
            }
            for (char i = 'A'; i < 'A' + r; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    Button b = new Button();
                    b.Text = i + "" + j;
                    b.Dock = DockStyle.Fill;
                    b.Margin = new Padding(3, 3, 3, 3);
                    b.BackColor = Color.White;
                    if (gheDaDat.Contains(b.Text))
                    {
                        b.BackColor = Color.Red;
                    }
                    b.Click += new EventHandler(button_Click);
                    GhesPanel.Controls.Add(b);
                }
            }
        }
        private void Reset()
        {
            gheDaDat = datVeBLL.LayVeDaDat(lichChieu.MaLichChieu);
            gheDaChon.Clear();
            foreach (var el in GhesPanel.Controls)
            {
                if (el is Button)
                {
                    var b = el as Button;
                    if (b.BackColor == Color.Red)
                    {
                        continue;
                    }
                    if (b.BackColor == Color.Green)
                    {
                        b.BackColor = Color.White;
                    }
                    if (gheDaDat.Contains(b.Text))
                    {
                        b.BackColor = Color.Red;
                    }
                }
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b.BackColor == Color.Red)
            {
                MessageBox.Show("Ghế đã được đặt.");
                return;
            }
            if (b.BackColor == Color.Green)
            {
                b.BackColor = Color.White;
                gheDaChon.Remove(ghes[b.Text]);
                return;
            }
            b.BackColor = Color.Green;
            gheDaChon.Add(ghes[b.Text]);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (gheDaChon.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn ghế.");
            }
            else
            {
                if (MessageBox.Show($"Bạn có chắc muốn đặt {gheDaChon.Count} vé?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        if (datVeBLL.DatVes(gheDaChon, lichChieu.MaLichChieu))
                        {
                            MessageBox.Show("Mua vé thành công!");
                            Close();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra trong quá trình bán vé ghế hoặc ghế đã được đặt chỗ. Danh sách ghế đã được load lại.");
                        Reset();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PhongDatVe_Load(object sender, EventArgs e)
        {
            try
            {
                GhesDraw();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }

}
