using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using Oracle.DataAccess.Client;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanQuyen
{
    public partial class Login : Form
    {

       
        public Login()
        {
            InitializeComponent();
        }
       

        private void btn_login_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassWord.Text;

            string connectionString = $"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));User Id={userName};Password={passWord};";
 
            if (check_connection(connectionString))
            {
                OracleConnection conn = new OracleConnection(connectionString);
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select SYS_CONTEXT('emp_ctx','vaitro') from dual";
                string role_user = Convert.ToString(cmd.ExecuteScalar());

                if (role_user == "Thanh tra")
                {
                    ThanhTra form = new ThanhTra(conn,this);
                    this.Hide();
                    form.Show();
                }
                else if(role_user == "Co so y te")
                {
                    NVCSYT form = new NVCSYT(conn,this);
                    this.Hide();
                    form.Show();
                }
                else if (role_user == "Y si/bac si")
                {
                    BacSi form = new BacSi(conn,this);
                    this.Hide();
                    form.Show();
                }
                else if (role_user == "Nghien cuu")
                {
                    NghienCuu form = new NghienCuu(conn,this);
                    this.Hide();
                    form.Show();
                }
                else
                {
                    TrangChu form = new TrangChu(conn);
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }


            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác. Vui lòng nhập lại", "thông báo");
            }
            
        }

        public bool check_connection(string conn)

        {

            bool result = false;
            try {
                OracleConnection connection = new OracleConnection(conn);
                connection.Open();
                result = true;
                connection.Dispose();
                connection.Close();
                OracleConnection.ClearPool(connection);
                
            }
            catch
            {
                result = false;
            }
            return result;

        }
    }
}
