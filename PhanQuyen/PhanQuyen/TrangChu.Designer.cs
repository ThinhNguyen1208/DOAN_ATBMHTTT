
namespace PhanQuyen
{
    partial class TrangChu
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.suaquyenuser = new System.Windows.Forms.Button();
            this.xoauser = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.dsuser = new System.Windows.Forms.DataGridView();
            this.NguoiDung = new System.Windows.Forms.TextBox();
            this.taouser = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.passuser = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.taorole = new System.Windows.Forms.Button();
            this.dsrole = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.xoarole = new System.Windows.Forms.Button();
            this.passrole = new System.Windows.Forms.TextBox();
            this.suaquyenrole = new System.Windows.Forms.Button();
            this.rolename = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsuser)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsrole)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(879, 551);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(871, 518);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Người dùng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_thoat);
            this.panel1.Controls.Add(this.suaquyenuser);
            this.panel1.Controls.Add(this.xoauser);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Controls.Add(this.dsuser);
            this.panel1.Controls.Add(this.NguoiDung);
            this.panel1.Controls.Add(this.taouser);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.passuser);
            this.panel1.Location = new System.Drawing.Point(0, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 506);
            this.panel1.TabIndex = 22;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(30, 16);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(104, 39);
            this.btn_thoat.TabIndex = 30;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // suaquyenuser
            // 
            this.suaquyenuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suaquyenuser.Location = new System.Drawing.Point(207, 440);
            this.suaquyenuser.Name = "suaquyenuser";
            this.suaquyenuser.Size = new System.Drawing.Size(166, 43);
            this.suaquyenuser.TabIndex = 29;
            this.suaquyenuser.Text = "Sửa Quyền User";
            this.suaquyenuser.UseVisualStyleBackColor = true;
            this.suaquyenuser.Click += new System.EventHandler(this.suaquyenuser_Click);
            // 
            // xoauser
            // 
            this.xoauser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoauser.Location = new System.Drawing.Point(30, 440);
            this.xoauser.Name = "xoauser";
            this.xoauser.Size = new System.Drawing.Size(121, 43);
            this.xoauser.TabIndex = 28;
            this.xoauser.Text = "Xóa User";
            this.xoauser.UseVisualStyleBackColor = true;
            this.xoauser.Click += new System.EventHandler(this.xoauser_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(586, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Tạo người dùng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(590, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(586, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(317, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 33);
            this.label6.TabIndex = 24;
            this.label6.Text = "QUẢN TRỊ VIÊN";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(26, 124);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(197, 20);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "Danh Sách Người Dùng";
            // 
            // dsuser
            // 
            this.dsuser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsuser.Location = new System.Drawing.Point(30, 164);
            this.dsuser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dsuser.Name = "dsuser";
            this.dsuser.RowHeadersWidth = 51;
            this.dsuser.RowTemplate.Height = 24;
            this.dsuser.Size = new System.Drawing.Size(475, 254);
            this.dsuser.TabIndex = 0;
            // 
            // NguoiDung
            // 
            this.NguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NguoiDung.Location = new System.Drawing.Point(259, 69);
            this.NguoiDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NguoiDung.Name = "NguoiDung";
            this.NguoiDung.Size = new System.Drawing.Size(341, 26);
            this.NguoiDung.TabIndex = 4;
            // 
            // taouser
            // 
            this.taouser.AutoSize = true;
            this.taouser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taouser.Location = new System.Drawing.Point(590, 330);
            this.taouser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taouser.Name = "taouser";
            this.taouser.Size = new System.Drawing.Size(117, 37);
            this.taouser.TabIndex = 15;
            this.taouser.Text = "Tạo User";
            this.taouser.UseVisualStyleBackColor = true;
            this.taouser.Click += new System.EventHandler(this.taouser_Click_1);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(590, 204);
            this.username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(244, 26);
            this.username.TabIndex = 11;
            // 
            // passuser
            // 
            this.passuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passuser.Location = new System.Drawing.Point(590, 277);
            this.passuser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passuser.Name = "passuser";
            this.passuser.PasswordChar = '*';
            this.passuser.Size = new System.Drawing.Size(244, 26);
            this.passuser.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(871, 518);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Role";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.taorole);
            this.panel2.Controls.Add(this.dsrole);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.role);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.xoarole);
            this.panel2.Controls.Add(this.passrole);
            this.panel2.Controls.Add(this.suaquyenrole);
            this.panel2.Controls.Add(this.rolename);
            this.panel2.Location = new System.Drawing.Point(-4, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 508);
            this.panel2.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(589, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Tạo role:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(320, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 33);
            this.label7.TabIndex = 25;
            this.label7.Text = "QUẢN TRỊ VIÊN";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh Sách Role:";
            // 
            // taorole
            // 
            this.taorole.AutoSize = true;
            this.taorole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taorole.Location = new System.Drawing.Point(593, 332);
            this.taorole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taorole.Name = "taorole";
            this.taorole.Size = new System.Drawing.Size(115, 37);
            this.taorole.TabIndex = 20;
            this.taorole.Text = "Tạo Role";
            this.taorole.UseVisualStyleBackColor = true;
            this.taorole.Click += new System.EventHandler(this.taorole_Click_1);
            // 
            // dsrole
            // 
            this.dsrole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsrole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsrole.Location = new System.Drawing.Point(34, 141);
            this.dsrole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dsrole.Name = "dsrole";
            this.dsrole.RowHeadersWidth = 51;
            this.dsrole.RowTemplate.Height = 24;
            this.dsrole.Size = new System.Drawing.Size(489, 266);
            this.dsrole.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(593, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Password:";
            // 
            // role
            // 
            this.role.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role.Location = new System.Drawing.Point(260, 63);
            this.role.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(359, 26);
            this.role.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(589, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Rolename:";
            // 
            // xoarole
            // 
            this.xoarole.AutoSize = true;
            this.xoarole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoarole.Location = new System.Drawing.Point(48, 429);
            this.xoarole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xoarole.Name = "xoarole";
            this.xoarole.Size = new System.Drawing.Size(116, 44);
            this.xoarole.TabIndex = 9;
            this.xoarole.Text = "Xóa Role";
            this.xoarole.UseVisualStyleBackColor = true;
            this.xoarole.Click += new System.EventHandler(this.xoarole_Click_1);
            // 
            // passrole
            // 
            this.passrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passrole.Location = new System.Drawing.Point(593, 271);
            this.passrole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passrole.Name = "passrole";
            this.passrole.PasswordChar = '*';
            this.passrole.Size = new System.Drawing.Size(236, 26);
            this.passrole.TabIndex = 17;
            // 
            // suaquyenrole
            // 
            this.suaquyenrole.AutoSize = true;
            this.suaquyenrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suaquyenrole.Location = new System.Drawing.Point(212, 429);
            this.suaquyenrole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.suaquyenrole.Name = "suaquyenrole";
            this.suaquyenrole.Size = new System.Drawing.Size(187, 44);
            this.suaquyenrole.TabIndex = 10;
            this.suaquyenrole.Text = "Sửa Quyền Role";
            this.suaquyenrole.UseVisualStyleBackColor = true;
            this.suaquyenrole.Click += new System.EventHandler(this.suaquyenrole_Click_1);
            // 
            // rolename
            // 
            this.rolename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolename.Location = new System.Drawing.Point(595, 178);
            this.rolename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rolename.Name = "rolename";
            this.rolename.Size = new System.Drawing.Size(236, 26);
            this.rolename.TabIndex = 16;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 544);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrangChu";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsuser)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsrole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.DataGridView dsuser;
        private System.Windows.Forms.TextBox NguoiDung;
        private System.Windows.Forms.Button taouser;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox passuser;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button taorole;
        private System.Windows.Forms.DataGridView dsrole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox role;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button xoarole;
        private System.Windows.Forms.TextBox passrole;
        private System.Windows.Forms.Button suaquyenrole;
        private System.Windows.Forms.TextBox rolename;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button suaquyenuser;
        private System.Windows.Forms.Button xoauser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
    }
}