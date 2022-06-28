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
    public partial class ThongTin : Form
    {

        private OracleConnection connection;
        public ThongTin(OracleConnection con)
        {
            InitializeComponent();
            this.connection = con;
            Load_thongtincanhan();
        }

        private void Load_thongtincanhan()
        {
            string query = "select * from USER_QLBV.NHANVIEN";
            OracleCommand cmd = new OracleCommand(query, this.connection);
            DataTable data = new DataTable();
            data.Load(cmd.ExecuteReader());

            DataRow row = data.Rows[0];

            txt_ten.Text = row["HOTEN"].ToString();
            txt_phai.Text = row["PHAI"].ToString();
            txt_ngaysinh.Text = row["NGAYSINH"].ToString();
            txt_cmnd.Text = row["CMND"].ToString();
            txt_qq.Text = row["QUEQUAN"].ToString();
            txt_sdt.Text = row["SDT"].ToString();
            txt_vaitro.Text = row["VAITRO"].ToString();

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string ten = txt_ten.Text;
            string phai = txt_phai.Text;
            string ngaysinh = txt_ngaysinh.Text;
            string cmnd = txt_cmnd.Text;
            string quequan = txt_qq.Text;
            string sdt = txt_sdt.Text;
            string vaitro = txt_vaitro.Text;


            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(phai) || string.IsNullOrEmpty(ngaysinh) || string.IsNullOrEmpty(cmnd) || string.IsNullOrEmpty(quequan) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(vaitro))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin trước khi thêm", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = $"update USER_QLBV.nhanvien set HOTEN = '{ten}',PHAI = '{phai}',NGAYSINH = TO_DATE('{Convert.ToDateTime(ngaysinh).ToString()}', 'mm/dd/yyyy hh:mi:ss AM'),CMND = '{cmnd}',QUEQUAN = '{quequan}',SDT = '{sdt}',VAITRO = '{vaitro}'";
                OracleCommand cmd = new OracleCommand(query,this.connection);
                int isSuccess = cmd.ExecuteNonQuery();
                if(isSuccess > 0)
                {
                    MessageBox.Show("Lưu thông tin thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                else
                {
                    MessageBox.Show("Lưu thông tin không thành công! Vui lòng kiểm tra lại", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
