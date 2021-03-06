﻿namespace QuanLyRapPhim
{
    partial class NVBVForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvLichChieu = new System.Windows.Forms.DataGridView();
            this.TenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phòng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLichChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoGheTrong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbThongTinLichChieu = new System.Windows.Forms.GroupBox();
            this.txtGheTrong = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtGioChieu = new System.Windows.Forms.TextBox();
            this.txtNgayChieu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.btnLichSu = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.cbOptions = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieu)).BeginInit();
            this.gbThongTinLichChieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLichChieu
            // 
            this.dgvLichChieu.AllowUserToAddRows = false;
            this.dgvLichChieu.AllowUserToDeleteRows = false;
            this.dgvLichChieu.AllowUserToResizeColumns = false;
            this.dgvLichChieu.AllowUserToResizeRows = false;
            this.dgvLichChieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichChieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenPhim,
            this.NgayChieu,
            this.GioChieu,
            this.Phòng,
            this.MaLichChieu,
            this.MaPhong,
            this.MoTa,
            this.SoGheTrong});
            this.dgvLichChieu.Location = new System.Drawing.Point(12, 186);
            this.dgvLichChieu.Name = "dgvLichChieu";
            this.dgvLichChieu.RowHeadersVisible = false;
            this.dgvLichChieu.RowHeadersWidth = 51;
            this.dgvLichChieu.RowTemplate.Height = 24;
            this.dgvLichChieu.Size = new System.Drawing.Size(627, 300);
            this.dgvLichChieu.TabIndex = 0;
            this.dgvLichChieu.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichChieu_RowEnter);
            // 
            // TenPhim
            // 
            this.TenPhim.DataPropertyName = "TenPhim";
            this.TenPhim.HeaderText = "Tên phim";
            this.TenPhim.MinimumWidth = 6;
            this.TenPhim.Name = "TenPhim";
            this.TenPhim.ReadOnly = true;
            // 
            // NgayChieu
            // 
            this.NgayChieu.DataPropertyName = "NgayChieu";
            this.NgayChieu.HeaderText = "Ngày chiếu";
            this.NgayChieu.MinimumWidth = 6;
            this.NgayChieu.Name = "NgayChieu";
            this.NgayChieu.ReadOnly = true;
            // 
            // GioChieu
            // 
            this.GioChieu.DataPropertyName = "GioChieu";
            this.GioChieu.HeaderText = "Giờ chiếu";
            this.GioChieu.MinimumWidth = 6;
            this.GioChieu.Name = "GioChieu";
            this.GioChieu.ReadOnly = true;
            // 
            // Phòng
            // 
            this.Phòng.DataPropertyName = "TenPhong";
            this.Phòng.HeaderText = "Tên phòng";
            this.Phòng.MinimumWidth = 6;
            this.Phòng.Name = "Phòng";
            this.Phòng.ReadOnly = true;
            // 
            // MaLichChieu
            // 
            this.MaLichChieu.DataPropertyName = "MaLichChieu";
            this.MaLichChieu.HeaderText = "MaLichChieu";
            this.MaLichChieu.MinimumWidth = 6;
            this.MaLichChieu.Name = "MaLichChieu";
            this.MaLichChieu.ReadOnly = true;
            this.MaLichChieu.Visible = false;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "MaPhong";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            this.MaPhong.Visible = false;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "PhimMoTa";
            this.MoTa.HeaderText = "MoTa";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            this.MoTa.Visible = false;
            // 
            // SoGheTrong
            // 
            this.SoGheTrong.DataPropertyName = "SoGheTrong";
            this.SoGheTrong.HeaderText = "Số ghế trống";
            this.SoGheTrong.MinimumWidth = 6;
            this.SoGheTrong.Name = "SoGheTrong";
            this.SoGheTrong.ReadOnly = true;
            // 
            // gbThongTinLichChieu
            // 
            this.gbThongTinLichChieu.Controls.Add(this.txtGheTrong);
            this.gbThongTinLichChieu.Controls.Add(this.txtTenPhong);
            this.gbThongTinLichChieu.Controls.Add(this.txtGioChieu);
            this.gbThongTinLichChieu.Controls.Add(this.txtNgayChieu);
            this.gbThongTinLichChieu.Controls.Add(this.label5);
            this.gbThongTinLichChieu.Controls.Add(this.label4);
            this.gbThongTinLichChieu.Controls.Add(this.label3);
            this.gbThongTinLichChieu.Controls.Add(this.label2);
            this.gbThongTinLichChieu.Controls.Add(this.txtTenPhim);
            this.gbThongTinLichChieu.Controls.Add(this.label1);
            this.gbThongTinLichChieu.Location = new System.Drawing.Point(12, 12);
            this.gbThongTinLichChieu.Name = "gbThongTinLichChieu";
            this.gbThongTinLichChieu.Size = new System.Drawing.Size(861, 86);
            this.gbThongTinLichChieu.TabIndex = 1;
            this.gbThongTinLichChieu.TabStop = false;
            // 
            // txtGheTrong
            // 
            this.txtGheTrong.Location = new System.Drawing.Point(708, 47);
            this.txtGheTrong.Name = "txtGheTrong";
            this.txtGheTrong.Size = new System.Drawing.Size(131, 22);
            this.txtGheTrong.TabIndex = 1;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(538, 47);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(131, 22);
            this.txtTenPhong.TabIndex = 1;
            // 
            // txtGioChieu
            // 
            this.txtGioChieu.Location = new System.Drawing.Point(368, 47);
            this.txtGioChieu.Name = "txtGioChieu";
            this.txtGioChieu.Size = new System.Drawing.Size(131, 22);
            this.txtGioChieu.TabIndex = 1;
            // 
            // txtNgayChieu
            // 
            this.txtNgayChieu.Location = new System.Drawing.Point(198, 47);
            this.txtNgayChieu.Name = "txtNgayChieu";
            this.txtNgayChieu.Size = new System.Drawing.Size(131, 22);
            this.txtNgayChieu.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(705, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số ghế còn trống";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giờ chiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày chiếu";
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Location = new System.Drawing.Point(28, 47);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(131, 22);
            this.txtTenPhim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên phim";
            // 
            // btnDatVe
            // 
            this.btnDatVe.Location = new System.Drawing.Point(606, 115);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(75, 39);
            this.btnDatVe.TabIndex = 2;
            this.btnDatVe.Text = "Bán vé";
            this.btnDatVe.UseVisualStyleBackColor = true;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // btnLichSu
            // 
            this.btnLichSu.Location = new System.Drawing.Point(720, 115);
            this.btnLichSu.Name = "btnLichSu";
            this.btnLichSu.Size = new System.Drawing.Size(131, 39);
            this.btnLichSu.TabIndex = 2;
            this.btnLichSu.Text = "Lịch sử bán vé";
            this.btnLichSu.UseVisualStyleBackColor = true;
            this.btnLichSu.Click += new System.EventHandler(this.btnLichSu_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(380, 119);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(169, 28);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tìm kiếm bằng";
            // 
            // pbPoster
            // 
            this.pbPoster.Location = new System.Drawing.Point(660, 186);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(213, 300);
            this.pbPoster.TabIndex = 5;
            this.pbPoster.TabStop = false;
            // 
            // cbOptions
            // 
            this.cbOptions.FormattingEnabled = true;
            this.cbOptions.Items.AddRange(new object[] {
            "Tên phim",
            "Ngày chiếu",
            "Giờ chiếu",
            "Tên phòng"});
            this.cbOptions.Location = new System.Drawing.Point(210, 123);
            this.cbOptions.Name = "cbOptions";
            this.cbOptions.Size = new System.Drawing.Size(121, 24);
            this.cbOptions.TabIndex = 6;
            this.cbOptions.SelectedIndexChanged += new System.EventHandler(this.cbOptions_SelectedIndexChanged);
            // 
            // NVBVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 498);
            this.Controls.Add(this.cbOptions);
            this.Controls.Add(this.pbPoster);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnLichSu);
            this.Controls.Add(this.btnDatVe);
            this.Controls.Add(this.gbThongTinLichChieu);
            this.Controls.Add(this.dgvLichChieu);
            this.Name = "NVBVForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách vé xem phim và bán vé";
            this.Load += new System.EventHandler(this.LichChieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieu)).EndInit();
            this.gbThongTinLichChieu.ResumeLayout(false);
            this.gbThongTinLichChieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLichChieu;
        private System.Windows.Forms.GroupBox gbThongTinLichChieu;
        private System.Windows.Forms.TextBox txtGheTrong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtGioChieu;
        private System.Windows.Forms.TextBox txtNgayChieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.Button btnLichSu;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.ComboBox cbOptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phòng;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLichChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoGheTrong;
    }
}