using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanQuyen
{
    public partial class BacSi : Form
    {
        private OracleConnection connection;
        private Login login;
        private DataTable ds_benhnhan;
        public BacSi(OracleConnection con, Login log)
        {
            InitializeComponent();
            this.connection = con;
            this.login = log;
            this.ds_benhnhan = new DataTable();
            Load_ten_user();
            Load_ds_benhnhan();
        }

        private void Load_ten_user()
        {
            string query = "select SYS_CONTEXT('emp_ctx','hoten') from dual";
            OracleCommand cmd = new OracleCommand(query, this.connection);
            string tenUser = Convert.ToString(cmd.ExecuteScalar());
            ten_user.Text = tenUser;
        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            string table = cmb_ds.Text;
            DataTable data = new DataTable();

            string query = "select * from USER_QLBV." + table;
            OracleCommand cmd = new OracleCommand(query, this.connection);
            data.Load(cmd.ExecuteReader());
            dgv_ds.DataSource = data;
        }

        private void Load_ds_benhnhan()
        {
            string query = "select * from USER_QLBV.BENHNHAN";
            OracleCommand cmd = new OracleCommand(query, this.connection);
            this.ds_benhnhan.Load(cmd.ExecuteReader());
           
            foreach(DataRow row in this.ds_benhnhan.Rows)
            {
                cmb_dsbn.Items.Add(row["MABN"].ToString());
            }
            
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.connection.Dispose();
            this.connection.Close();
            OracleConnection.ClearPool(this.connection);
            this.Close();
            this.login.Close();
        }

        private void cmb_dsbn_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
            int selectedValue = Convert.ToInt32(cmb_dsbn.Text);

            DataRow[] row = this.ds_benhnhan.Select($"MABN = {selectedValue}");

            txt_tenBN.Text = row[0]["TENBN"].ToString();
            txt_cmnd.Text = row[0]["CMND"].ToString();
            txt_ngaysinh.Text = row[0]["NGAYSINH"].ToString();
            txt_diachi.Text = row[0]["SONHA"].ToString() +" - "+ row[0]["TENDUONG"].ToString() + " - " + row[0]["QUANHUYEN"].ToString() + " - " + row[0]["TINHTP"].ToString();
            txt_tsb.Text = row[0]["TIENSUBENH"].ToString();
            txt_tsbgd.Text = row[0]["TIENSUBENHGD"].ToString();
            txt_dungthuoc.Text = row[0]["DIUNGTHUOC"].ToString();
        }

        private void hscn_Click(object sender, EventArgs e)
        {
            ThongTin form_thongtin = new ThongTin(this.connection);
            form_thongtin.Show();
        }
    }
}
