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
    public partial class NVCSYT : Form
    {
        private OracleConnection connection;
        private Login login;
        private DataTable data;
        public NVCSYT(OracleConnection conn,Login log)
        {
            InitializeComponent();
            this.connection = conn;
            this.login = log;
            Load_ten_user();
            Load_ds_hsba();
            Load_thongtin_hsba();
            Load_ds_hsba_dv();
            Load_thongtin_hsba_dv();
        }

        private void Load_ten_user()
        {
            string query = "select SYS_CONTEXT('emp_ctx','hoten') from dual";
            OracleCommand cmd = new OracleCommand(query, this.connection);
            string tenUser = Convert.ToString(cmd.ExecuteScalar());
            ten_user.Text = tenUser;
        }

        private int tao_mahsba()
        {
            string connectionString = $"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));User Id=USER_QLBV;Password=123;";
            int ma_hsba = 0;
            using (OracleConnection con = new OracleConnection(connectionString))
            {
                string query = "select MAHSBA from HOSOBENHAN";
                con.Open();
                OracleCommand cmd = new OracleCommand(query,con);
                DataTable data = new DataTable();
                data.Load(cmd.ExecuteReader());

                List<int> ds_mahsba = new List<int>();
                foreach (DataRow row in data.Rows)
                {
                    ds_mahsba.Add(Convert.ToInt32(row["MAHSBA"]));
                }
                ds_mahsba.Sort();

              
                for(int i = 0; i < ds_mahsba.Count - 1; i++)
                {
                    
                    if (ds_mahsba[i+1] != ds_mahsba[i] + 1)
                    {
                        ma_hsba = ds_mahsba[i] + 1;
                        break;
                    }
                    if (i == ds_mahsba.Count - 2)
                    {
                        ma_hsba = ds_mahsba[i + 1] + 1;
                    }
                }

            }
            return ma_hsba;
        }

        private void Load_ds_hsba()
        {
            string connectionString = $"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));User Id=USER_QLBV;Password=123;";
            OracleCommand cmd1 = this.connection.CreateCommand();
            cmd1.CommandText = "select SYS_CONTEXT('emp_ctx','csyt') from dual";
            string csyt = Convert.ToString(cmd1.ExecuteScalar());


            using (OracleConnection con = new OracleConnection(connectionString)) 
            {
                string query = $"select * from HOSOBENHAN where MACSYT= {csyt}";
                OracleCommand cmd = new OracleCommand(query, con);
                con.Open();
                this.data = new DataTable();
                this.data.Load(cmd.ExecuteReader());
                ds_hsba.DataSource = data;
            } ; 

        }

        private void Load_thongtin_hsba()
        {
            string connectionString = $"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));User Id=USER_QLBV;Password=123;";
            OracleCommand cmd1 = this.connection.CreateCommand();
            cmd1.CommandText = "select SYS_CONTEXT('emp_ctx','csyt') from dual";
            string csyt = Convert.ToString(cmd1.ExecuteScalar());

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                // Lấy ra mã bệnh nhân có cùng cơ sở y tế với nhân viên cơ sở y tế đang đăng nhập
                string query = $"select MABN from BENHNHAN where MACSYT = '{csyt}'";
                OracleCommand cmd = new OracleCommand(query, con);
                con.Open();
                DataTable data1 = new DataTable();
                data1.Load(cmd.ExecuteReader());
                for (int i = 0; i < data1.Rows.Count; i++)
                {
                    maBN.Items.Add(data1.Rows[i][0]);
                }

                // Lấy ra mã bác sĩ có cùng cơ sở y tế với nhân viên cơ sở ý tế đang đăng nhập
                query = $"select MANV from NHANVIEN where CSYT = '{csyt}' and VAITRO = 'Y si/bac si'";
                cmd = new OracleCommand(query, con);
                DataTable data2 = new DataTable();
                data2.Load(cmd.ExecuteReader());
                for (int i = 0; i < data2.Rows.Count; i++)
                {
                    maBS.Items.Add(data2.Rows[i][0]);
                }

                maCSYT.Items.Add(csyt);
            };
        }

        private void Load_ds_hsba_dv()
        {
            string connectionString = $"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));User Id=USER_QLBV;Password=123;";
            OracleCommand cmd1 = this.connection.CreateCommand();
            cmd1.CommandText = "select SYS_CONTEXT('emp_ctx','csyt') from dual";
            string csyt = Convert.ToString(cmd1.ExecuteScalar());
            using (OracleConnection con = new OracleConnection(connectionString))
            {
                string query = $"select * from HOSOBENHAN_DV where MAHSBA IN (select MAHSBA from HOSOBENHAN where MACSYT = {csyt})";
                OracleCommand cmd = new OracleCommand(query, con);
                con.Open();
                DataTable data = new DataTable();
                data.Load(cmd.ExecuteReader());
                ds_hsbadv.DataSource = data;
            };

        }

        private void Load_thongtin_hsba_dv()
        {
            string connectionString = $"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));User Id=USER_QLBV;Password=123;";
            OracleCommand cmd1 = this.connection.CreateCommand();
            cmd1.CommandText = "select SYS_CONTEXT('emp_ctx','csyt') from dual";
            string csyt = Convert.ToString(cmd1.ExecuteScalar());

            using (OracleConnection con = new OracleConnection(connectionString))
            {
             
                // Lấy ra mã hồ sơ bệnh án có cùng cơ sở y tế với nhân viên cơ sở y tế đang đăng nhập
                string query = $"select MAHSBA from HOSOBENHAN where MACSYT = '{csyt}'";
                OracleCommand cmd = new OracleCommand(query, con);
                con.Open();
                DataTable data1 = new DataTable();
                data1.Load(cmd.ExecuteReader());
                for (int i = 0; i < data1.Rows.Count; i++)
                {
                    ma_hsba.Items.Add(data1.Rows[i][0]);
                }

                // Lấy ra mã nhân viên có có cùng cơ sở y tế với nhân viên cơ sở ý tế đang đăng nhập
                query = $"select MANV from NHANVIEN where CSYT = '{csyt}' and VAITRO = 'Y si/bac si'";
                cmd = new OracleCommand(query, con);
                DataTable data2 = new DataTable();
                data2.Load(cmd.ExecuteReader());
                for (int i = 0; i < data2.Rows.Count; i++)
                {
                    maktv.Items.Add(data2.Rows[i][0]);
                }
            };
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.connection.Dispose();
            this.connection.Close();
            OracleConnection.ClearPool(this.connection);
            this.Close();
            this.login.Close();
        }

        private void btn_Them_hsba_Click(object sender, EventArgs e)
        {
            string ma_BN = maBN.Text;
            string ngay = ngayLap.Text;
            string chuandoan = chuanDoan.Text;
            string ma_BS = maBS.Text;
            string ma_Khoa = maKhoa.Text;
            string ma_csyt = maCSYT.Text;
            string ketluan = KetLuan.Text;
            

            if(string.IsNullOrEmpty(ma_BN) || string.IsNullOrEmpty(ngay) || string.IsNullOrEmpty(chuandoan) || string.IsNullOrEmpty(ma_BS) || string.IsNullOrEmpty(ma_Khoa) || string.IsNullOrEmpty(ma_csyt) || string.IsNullOrEmpty(ketluan))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin trước khi thêm", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int mahsba = this.tao_mahsba();
               
                string query = $"insert into USER_QLBV.HOSOBENHAN values({mahsba}, {Convert.ToInt32(ma_csyt)}, {Convert.ToInt32(ma_BN)}, {Convert.ToInt32(ma_BS)}, TO_DATE('{Convert.ToDateTime(ngay).ToString()}', 'mm/dd/yyyy hh:mi:ss AM'), '{chuandoan}', {Convert.ToInt32(ma_Khoa)}, '{ketluan}')";
                OracleCommand cmd = new OracleCommand(query,this.connection);
                int isSuccess = cmd.ExecuteNonQuery();
                if(isSuccess > 0)
                {
                    MessageBox.Show("Thêm hồ sơ bệnh án thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_ds_hsba();
                    ma_hsba.Items.Add(mahsba);
                }
                else
                {
                    MessageBox.Show("Thêm hồ sơ bệnh án không thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

        private void btn_xoa_hsba_Click(object sender, EventArgs e)
        {
            if(ds_hsba.SelectedRows[0] != null)
            {
                int selectedRowIndex = ds_hsba.SelectedRows[0].Index;
                int mahsba = Convert.ToInt32(ds_hsba.Rows[selectedRowIndex].Cells["MAHSBA"].Value.ToString());
              
                string query = $"begin delete from USER_QLBV.HOSOBENHAN_DV where MAHSBA = {mahsba}; delete from USER_QLBV.HOSOBENHAN where MAHSBA = {mahsba}; end;";
                OracleCommand cmd = new OracleCommand(query,this.connection);
                int isSuccess = cmd.ExecuteNonQuery();

                if(isSuccess < 0)
                {
                    MessageBox.Show("Xóa hồ sơ bệnh án thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_ds_hsba();
                    Load_ds_hsba_dv();
                    ma_hsba.Items.Remove(mahsba);
                }
                else
                {
                    MessageBox.Show("Xóa hồ sơ bệnh án không thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }

        private void them_hsba_dv_Click(object sender, EventArgs e)
        {
            string mahsba = ma_hsba.Text;
            string maDV = madv.Text;
            string ngayLap = ngay_dv.Text;
            string maKtv = maktv.Text;
            string ket_qua = ketqua.Text;


            if (string.IsNullOrEmpty(mahsba) || string.IsNullOrEmpty(maDV) || string.IsNullOrEmpty(ngayLap) || string.IsNullOrEmpty(maKtv) || string.IsNullOrEmpty(ket_qua))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin trước khi thêm", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                string query = $"insert into USER_QLBV.HOSOBENHAN_DV values({Convert.ToInt32(mahsba)}, {Convert.ToInt32(maDV)}, TO_DATE('{Convert.ToDateTime(ngayLap).ToString()}', 'mm/dd/yyyy hh:mi:ss AM'),  {Convert.ToInt32(maKtv)}, '{ket_qua}')";
                OracleCommand cmd = new OracleCommand(query, this.connection);
                int isSuccess = cmd.ExecuteNonQuery();
                if (isSuccess > 0)
                {
                    MessageBox.Show("Thêm hồ sơ bệnh án thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_ds_hsba_dv();
                }
                else
                {
                    MessageBox.Show("Thêm hồ sơ bệnh án không thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void xoa_hsba_dv_Click(object sender, EventArgs e)
        {
            if (ds_hsbadv.SelectedRows[0] != null)
            {
                int selectedRowIndex = ds_hsbadv.SelectedRows[0].Index;
                int ma_hsba = Convert.ToInt32(ds_hsbadv.Rows[selectedRowIndex].Cells["MAHSBA"].Value.ToString());

                string query = $"begin delete from USER_QLBV.HOSOBENHAN_DV where MAHSBA = {ma_hsba}; end;";
                OracleCommand cmd = new OracleCommand(query, this.connection);
                int isSuccess = cmd.ExecuteNonQuery();

                if (isSuccess < 0)
                {
                    MessageBox.Show("Xóa hồ sơ bệnh án thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_ds_hsba();
                    Load_ds_hsba_dv();
                }
                else
                {
                    MessageBox.Show("Xóa hồ sơ bệnh án không thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }

        private void hscn_Click(object sender, EventArgs e)
        {
            ThongTin form_thongtin = new ThongTin(this.connection);
            form_thongtin.Show();
        }
    }
}
