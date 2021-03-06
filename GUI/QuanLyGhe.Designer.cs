﻿namespace QuanLyRapPhim
{
    partial class QuanLyGhe
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
            this.dgvDSGhe = new System.Windows.Forms.DataGridView();
            this.MaGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenGhe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbHi = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.cbPhongs = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGhe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSGhe
            // 
            this.dgvDSGhe.AllowUserToAddRows = false;
            this.dgvDSGhe.AllowUserToDeleteRows = false;
            this.dgvDSGhe.AllowUserToResizeColumns = false;
            this.dgvDSGhe.AllowUserToResizeRows = false;
            this.dgvDSGhe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSGhe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSGhe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGhe,
            this.TenGhe,
            this.MaPhong,
            this.TenPhong,
            this.RowVersion});
            this.dgvDSGhe.Location = new System.Drawing.Point(12, 142);
            this.dgvDSGhe.Name = "dgvDSGhe";
            this.dgvDSGhe.RowHeadersVisible = false;
            this.dgvDSGhe.RowHeadersWidth = 51;
            this.dgvDSGhe.RowTemplate.Height = 24;
            this.dgvDSGhe.Size = new System.Drawing.Size(827, 337);
            this.dgvDSGhe.TabIndex = 0;
            this.dgvDSGhe.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSGhe_RowEnter);
            // 
            // MaGhe
            // 
            this.MaGhe.DataPropertyName = "MaGhe";
            this.MaGhe.HeaderText = "Mã ghế";
            this.MaGhe.MinimumWidth = 6;
            this.MaGhe.Name = "MaGhe";
            this.MaGhe.ReadOnly = true;
            // 
            // TenGhe
            // 
            this.TenGhe.DataPropertyName = "TenGhe";
            this.TenGhe.HeaderText = "Tên ghế";
            this.TenGhe.MinimumWidth = 6;
            this.TenGhe.Name = "TenGhe";
            this.TenGhe.ReadOnly = true;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên phòng";
            this.TenPhong.MinimumWidth = 6;
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.ReadOnly = true;
            // 
            // RowVersion
            // 
            this.RowVersion.DataPropertyName = "RowVersion";
            this.RowVersion.HeaderText = "RowVersion";
            this.RowVersion.MinimumWidth = 6;
            this.RowVersion.Name = "RowVersion";
            this.RowVersion.ReadOnly = true;
            this.RowVersion.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên ghế";
            // 
            // txtTenGhe
            // 
            this.txtTenGhe.Location = new System.Drawing.Point(227, 31);
            this.txtTenGhe.Name = "txtTenGhe";
            this.txtTenGhe.Size = new System.Drawing.Size(100, 22);
            this.txtTenGhe.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên phòng";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(130, 86);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(280, 86);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(416, 86);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 32);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbHi
            // 
            this.lbHi.AutoSize = true;
            this.lbHi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHi.Location = new System.Drawing.Point(703, 29);
            this.lbHi.Name = "lbHi";
            this.lbHi.Size = new System.Drawing.Size(53, 20);
            this.lbHi.TabIndex = 5;
            this.lbHi.Text = "label4";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(570, 86);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 32);
            this.btnReload.TabIndex = 6;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // cbPhongs
            // 
            this.cbPhongs.FormattingEnabled = true;
            this.cbPhongs.Location = new System.Drawing.Point(524, 27);
            this.cbPhongs.Name = "cbPhongs";
            this.cbPhongs.Size = new System.Drawing.Size(121, 24);
            this.cbPhongs.TabIndex = 7;
            // 
            // QuanLyGhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 491);
            this.Controls.Add(this.cbPhongs);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.lbHi);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenGhe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSGhe);
            this.Name = "QuanLyGhe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QuanLyGhe";
            this.Load += new System.EventHandler(this.QuanLyGhe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGhe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSGhe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenGhe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowVersion;
        private System.Windows.Forms.Label lbHi;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ComboBox cbPhongs;
    }
}