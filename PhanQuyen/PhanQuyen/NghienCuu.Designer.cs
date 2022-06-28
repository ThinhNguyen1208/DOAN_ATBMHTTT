
namespace PhanQuyen
{
    partial class NghienCuu
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
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.data_table = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.selectedTable = new System.Windows.Forms.ComboBox();
            this.hscn = new System.Windows.Forms.Button();
            this.ten_user = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_table)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(16, 17);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(106, 42);
            this.btn_thoat.TabIndex = 11;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xem
            // 
            this.btn_xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xem.Location = new System.Drawing.Point(647, 332);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(111, 36);
            this.btn_xem.TabIndex = 10;
            this.btn_xem.Text = "Xem";
            this.btn_xem.UseVisualStyleBackColor = true;
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chọn table mà bạn muốn xem:";
            // 
            // data_table
            // 
            this.data_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_table.Location = new System.Drawing.Point(67, 157);
            this.data_table.Name = "data_table";
            this.data_table.RowHeadersWidth = 49;
            this.data_table.RowTemplate.Height = 24;
            this.data_table.Size = new System.Drawing.Size(547, 211);
            this.data_table.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "NGHIÊN CỨU";
            // 
            // selectedTable
            // 
            this.selectedTable.FormattingEnabled = true;
            this.selectedTable.Items.AddRange(new object[] {
            "HOSOBENHAN",
            "HOSOBENHAN_DV"});
            this.selectedTable.Location = new System.Drawing.Point(338, 95);
            this.selectedTable.Name = "selectedTable";
            this.selectedTable.Size = new System.Drawing.Size(196, 24);
            this.selectedTable.TabIndex = 6;
            // 
            // hscn
            // 
            this.hscn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hscn.Location = new System.Drawing.Point(631, 49);
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
            this.ten_user.Location = new System.Drawing.Point(627, 17);
            this.ten_user.Name = "ten_user";
            this.ten_user.Size = new System.Drawing.Size(123, 20);
            this.ten_user.TabIndex = 26;
            this.ten_user.Text = "Nguyễn Văn A";
            // 
            // NghienCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 413);
            this.Controls.Add(this.hscn);
            this.Controls.Add(this.ten_user);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.data_table);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectedTable);
            this.Name = "NghienCuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NghienCuu";
            ((System.ComponentModel.ISupportInitialize)(this.data_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView data_table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectedTable;
        private System.Windows.Forms.Button hscn;
        private System.Windows.Forms.Label ten_user;
    }
}