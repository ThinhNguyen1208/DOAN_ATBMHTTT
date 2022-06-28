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
    public partial class NghienCuu : Form
    {
        private OracleConnection connection;
        private Login login;
        public NghienCuu(OracleConnection con, Login log)
        {
            InitializeComponent();
            this.login = log;
            this.connection = con;
            Load_ten_user();
        }

        private void Load_ten_user()
        {
            string query = "select SYS_CONTEXT('emp_ctx','hoten') from dual";
            OracleCommand cmd = new OracleCommand(query, this.connection);
            string tenUser = Convert.ToString(cmd.ExecuteScalar());
            ten_user.Text = tenUser;
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {

            string table = selectedTable.Text;
            DataTable data = new DataTable();

            string query = "select * from USER_QLBV." + table;
            OracleCommand cmd = new OracleCommand(query, this.connection);
            data.Load(cmd.ExecuteReader());
            data_table.DataSource = data;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.connection.Dispose();
            this.connection.Close();
            OracleConnection.ClearPool(this.connection);
            this.Close();
            this.login.Close();
        }

        private void hscn_Click(object sender, EventArgs e)
        {
            ThongTin form_thongtin = new ThongTin(this.connection);
            form_thongtin.Show();
        }
    }
}
