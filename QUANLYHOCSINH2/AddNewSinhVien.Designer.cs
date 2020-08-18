namespace QUANLYHOCSINH2
{
    partial class AddNewSinhVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CobGioiTinh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMaSinhVien = new System.Windows.Forms.TextBox();
            this.TxtTenSinhVien = new System.Windows.Forms.TextBox();
            this.TxtQueQuan = new System.Windows.Forms.TextBox();
            this.BntCatGiu = new System.Windows.Forms.Button();
            this.BntThoat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DprNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sinh viên";
            // 
            // CobGioiTinh
            // 
            this.CobGioiTinh.FormattingEnabled = true;
            this.CobGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.CobGioiTinh.Location = new System.Drawing.Point(248, 172);
            this.CobGioiTinh.Name = "CobGioiTinh";
            this.CobGioiTinh.Size = new System.Drawing.Size(121, 32);
            this.CobGioiTinh.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giớ tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quê quán";
            // 
            // TxtMaSinhVien
            // 
            this.TxtMaSinhVien.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtMaSinhVien.Location = new System.Drawing.Point(248, 36);
            this.TxtMaSinhVien.Name = "TxtMaSinhVien";
            this.TxtMaSinhVien.Size = new System.Drawing.Size(216, 29);
            this.TxtMaSinhVien.TabIndex = 2;
            // 
            // TxtTenSinhVien
            // 
            this.TxtTenSinhVien.Location = new System.Drawing.Point(248, 104);
            this.TxtTenSinhVien.Name = "TxtTenSinhVien";
            this.TxtTenSinhVien.Size = new System.Drawing.Size(401, 29);
            this.TxtTenSinhVien.TabIndex = 2;
            // 
            // TxtQueQuan
            // 
            this.TxtQueQuan.Location = new System.Drawing.Point(248, 249);
            this.TxtQueQuan.Name = "TxtQueQuan";
            this.TxtQueQuan.Size = new System.Drawing.Size(833, 29);
            this.TxtQueQuan.TabIndex = 2;
            // 
            // BntCatGiu
            // 
            this.BntCatGiu.Location = new System.Drawing.Point(311, 421);
            this.BntCatGiu.Name = "BntCatGiu";
            this.BntCatGiu.Size = new System.Drawing.Size(153, 40);
            this.BntCatGiu.TabIndex = 3;
            this.BntCatGiu.Text = "Cất giữ";
            this.BntCatGiu.UseVisualStyleBackColor = true;
            this.BntCatGiu.Click += new System.EventHandler(this.BntCatGiu_Click);
            // 
            // BntThoat
            // 
            this.BntThoat.Location = new System.Drawing.Point(616, 421);
            this.BntThoat.Name = "BntThoat";
            this.BntThoat.Size = new System.Drawing.Size(153, 40);
            this.BntThoat.TabIndex = 3;
            this.BntThoat.Text = "Thoát";
            this.BntThoat.UseVisualStyleBackColor = true;
            this.BntThoat.Click += new System.EventHandler(this.BntThoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày sinh";
            // 
            // DprNgaySinh
            // 
            this.DprNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DprNgaySinh.Location = new System.Drawing.Point(578, 179);
            this.DprNgaySinh.Name = "DprNgaySinh";
            this.DprNgaySinh.Size = new System.Drawing.Size(159, 29);
            this.DprNgaySinh.TabIndex = 4;
            // 
            // AddNewSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 560);
            this.Controls.Add(this.DprNgaySinh);
            this.Controls.Add(this.BntThoat);
            this.Controls.Add(this.BntCatGiu);
            this.Controls.Add(this.TxtQueQuan);
            this.Controls.Add(this.TxtTenSinhVien);
            this.Controls.Add(this.TxtMaSinhVien);
            this.Controls.Add(this.CobGioiTinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewSinhVien";
            this.Text = "AddNewSinhVien";
            this.Load += new System.EventHandler(this.AddNewSinhVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BntCatGiu;
        private System.Windows.Forms.Button BntThoat;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox CobGioiTinh;
        public System.Windows.Forms.TextBox TxtMaSinhVien;
        public System.Windows.Forms.TextBox TxtTenSinhVien;
        public System.Windows.Forms.TextBox TxtQueQuan;
        public System.Windows.Forms.DateTimePicker DprNgaySinh;
    }
}