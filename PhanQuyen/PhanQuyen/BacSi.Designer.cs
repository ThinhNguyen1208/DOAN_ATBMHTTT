
namespace PhanQuyen
{
    partial class BacSi
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
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_ds = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_dsbn = new System.Windows.Forms.ComboBox();
            this.cmb_ds = new System.Windows.Forms.ComboBox();
            this.txt_tenBN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cmnd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ngaysinh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tsb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_tsbgd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_dungthuoc = new System.Windows.Forms.TextBox();
            this.btn_Xem = new System.Windows.Forms.Button();
            this.hscn = new System.Windows.Forms.Button();
            this.ten_user = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁC SĨ";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(13, 13);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(112, 46);
            this.btn_thoat.TabIndex = 1;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn danh sách:";
            // 
            // dgv_ds
            // 
            this.dgv_ds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ds.Location = new System.Drawing.Point(29, 145);
            this.dgv_ds.Name = "dgv_ds";
            this.dgv_ds.RowHeadersWidth = 49;
            this.dgv_ds.RowTemplate.Height = 24;
            this.dgv_ds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ds.Size = new System.Drawing.Size(491, 336);
            this.dgv_ds.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(575, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chọn bệnh nhân:";
            // 
            // cmb_dsbn
            // 
            this.cmb_dsbn.FormattingEnabled = true;
            this.cmb_dsbn.Location = new System.Drawing.Point(760, 105);
            this.cmb_dsbn.Name = "cmb_dsbn";
            this.cmb_dsbn.Size = new System.Drawing.Size(222, 24);
            this.cmb_dsbn.TabIndex = 5;
            this.cmb_dsbn.SelectedIndexChanged += new System.EventHandler(this.cmb_dsbn_SelectedIndexChanged);
            // 
            // cmb_ds
            // 
            this.cmb_ds.FormattingEnabled = true;
            this.cmb_ds.Items.AddRange(new object[] {
            "HOSOBENHAN",
            "HOSOBENHAN_DV"});
            this.cmb_ds.Location = new System.Drawing.Point(175, 105);
            this.cmb_ds.Name = "cmb_ds";
            this.cmb_ds.Size = new System.Drawing.Size(215, 24);
            this.cmb_ds.TabIndex = 6;
            // 
            // txt_tenBN
            // 
            this.txt_tenBN.Location = new System.Drawing.Point(760, 153);
            this.txt_tenBN.Multiline = true;
            this.txt_tenBN.Name = "txt_tenBN";
            this.txt_tenBN.Size = new System.Drawing.Size(222, 28);
            this.txt_tenBN.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(575, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên Bệnh Nhân:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(575, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "CMND:";
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.Location = new System.Drawing.Point(760, 201);
            this.txt_cmnd.Multiline = true;
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.Size = new System.Drawing.Size(222, 28);
            this.txt_cmnd.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(575, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ngày Sinh:";
            // 
            // txt_ngaysinh
            // 
            this.txt_ngaysinh.Location = new System.Drawing.Point(760, 250);
            this.txt_ngaysinh.Multiline = true;
            this.txt_ngaysinh.Name = "txt_ngaysinh";
            this.txt_ngaysinh.Size = new System.Drawing.Size(222, 28);
            this.txt_ngaysinh.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(575, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Địa chỉ";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(760, 299);
            this.txt_diachi.Multiline = true;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(222, 28);
            this.txt_diachi.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(575, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tiền Sử Bệnh:";
            // 
            // txt_tsb
            // 
            this.txt_tsb.Location = new System.Drawing.Point(760, 351);
            this.txt_tsb.Multiline = true;
            this.txt_tsb.Name = "txt_tsb";
            this.txt_tsb.Size = new System.Drawing.Size(222, 28);
            this.txt_tsb.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(575, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tiền Sử Bệnh GĐ:";
            // 
            // txt_tsbgd
            // 
            this.txt_tsbgd.Location = new System.Drawing.Point(760, 405);
            this.txt_tsbgd.Multiline = true;
            this.txt_tsbgd.Name = "txt_tsbgd";
            this.txt_tsbgd.Size = new System.Drawing.Size(222, 28);
            this.txt_tsbgd.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(575, 453);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Dùng Thuốc:";
            // 
            // txt_dungthuoc
            // 
            this.txt_dungthuoc.Location = new System.Drawing.Point(760, 453);
            this.txt_dungthuoc.Multiline = true;
            this.txt_dungthuoc.Name = "txt_dungthuoc";
            this.txt_dungthuoc.Size = new System.Drawing.Size(222, 28);
            this.txt_dungthuoc.TabIndex = 19;
            // 
            // btn_Xem
            // 
            this.btn_Xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xem.Location = new System.Drawing.Point(408, 99);
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.Size = new System.Drawing.Size(112, 32);
            this.btn_Xem.TabIndex = 21;
            this.btn_Xem.Text = "Xem";
            this.btn_Xem.UseVisualStyleBackColor = true;
            this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
            // 
            // hscn
            // 
            this.hscn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hscn.Location = new System.Drawing.Point(825, 13);
            this.hscn.Name = "hscn";
            this.hscn.Size = new System.Drawing.Size(157, 39);
            this.hscn.TabIndex = 27;
            this.hscn.Text = "Hồ sơ cá nhân";
            this.hscn.UseVisualStyleBackColor = true;
            this.hscn.Click += new System.EventHandler(this.hscn_Click);
            // 
            // ten_user
            // 
            this.ten_user.AutoSize = true;
            this.ten_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten_user.Location = new System.Drawing.Point(682, 22);
            this.ten_user.Name = "ten_user";
            this.ten_user.Size = new System.Drawing.Size(123, 20);
            this.ten_user.TabIndex = 26;
            this.ten_user.Text = "Nguyễn Văn A";
            // 
            // BacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 505);
            this.Controls.Add(this.hscn);
            this.Controls.Add(this.ten_user);
            this.Controls.Add(this.btn_Xem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_dungthuoc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_tsbgd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_tsb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ngaysinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_cmnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tenBN);
            this.Controls.Add(this.cmb_ds);
            this.Controls.Add(this.cmb_dsbn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_ds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.label1);
            this.Name = "BacSi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BacSi";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_ds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_dsbn;
        private System.Windows.Forms.ComboBox cmb_ds;
        private System.Windows.Forms.TextBox txt_tenBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cmnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ngaysinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tsb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_tsbgd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_dungthuoc;
        private System.Windows.Forms.Button btn_Xem;
        private System.Windows.Forms.Button hscn;
        private System.Windows.Forms.Label ten_user;
    }
}