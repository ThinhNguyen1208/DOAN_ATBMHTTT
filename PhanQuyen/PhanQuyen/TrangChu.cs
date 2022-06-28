using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Configuration;

namespace PhanQuyen
{
    public partial class TrangChu : Form
    {
        public BindingSource dsnguoidung = new BindingSource();
        public BindingSource dsvaitro = new BindingSource();

        private OracleConnection connection;
        public TrangChu(OracleConnection con)
        {
            InitializeComponent();
            this.connection = con;
            loadform();
        }
        public void loadform()
        {
            dsuser.DataSource = dsnguoidung;
            
            DataTable data = new DataTable();
            string query = "select username,user_id from all_users";
            OracleCommand cmd = new OracleCommand(query, this.connection);
            data.Load(cmd.ExecuteReader());
            dsnguoidung.DataSource = data;
             
            dsrole.DataSource = dsvaitro;
           
            data = new DataTable();
            query = "SELECT ROLE FROM SYS.DBA_ROLES";
            cmd = new OracleCommand(query, this.connection);
            data.Load(cmd.ExecuteReader());
            dsvaitro.DataSource = data;
            
            role.DataBindings.Add(new Binding("text", dsrole.DataSource, "ROLE"));
            NguoiDung.DataBindings.Add(new Binding("text", dsuser.DataSource, "username"));          
        }

        private void taorole_Click_1(object sender, EventArgs e)
        {
            if (rolename.Text != null && passrole.Text != null)
                    try
                    {
                        string query1 = "alter session set \"_ORACLE_SCRIPT\"=true";
                        OracleCommand command1 = new OracleCommand(query1, this.connection);
                        command1.ExecuteNonQuery();
                        string query2 = "begin grant_NewRole('" + rolename.Text + "','" + passrole.Text + "'); end;";
                        OracleCommand command2 = new OracleCommand(query2, this.connection);
                        int result = command2.ExecuteNonQuery();

                        rolename.Text = "";
                        passrole.Text = "";
                        DataTable data = new DataTable();
                        MessageBox.Show("Thành công", "Success", MessageBoxButtons.OK);
                        

                        string query = "SELECT ROLE FROM DBA_ROLES";
                        OracleCommand cmd = new OracleCommand(query, this.connection);
                        data.Load(cmd.ExecuteReader());
                        dsvaitro.DataSource = data;
                    }
                    catch(Exception ee)
                    {
                        rolename.Text = "";
                        passrole.Text = "";
                        MessageBox.Show("Không thành công", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
        }

        private void taouser_Click_1(object sender, EventArgs e)
        {
            if (username.Text != null && passuser.Text != null)
            {
                try
                {

                    string query2 = "begin Grant_NewUser('" + username.Text + "','" + passuser.Text + "'); end;";
                    OracleCommand command2 = new OracleCommand(query2, this.connection);
                    int result = command2.ExecuteNonQuery();

                    username.Text = "";
                    passuser.Text = "";
                    DataTable data = new DataTable();
                    MessageBox.Show("Thành công", "Success", MessageBoxButtons.OK);

                    string query = "select username,user_id from all_users";
                    OracleCommand cmd = new OracleCommand(query, this.connection);
                    data.Load(cmd.ExecuteReader());
                    dsnguoidung.DataSource = data;
                }
                catch (Exception ee)
                {
                    username.Text = "";
                    passuser.Text = "";
                    MessageBox.Show("Không thành công", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        } 

        private void xoauser_Click(object sender, EventArgs e)
        {
            if (NguoiDung.Text != null)
            {
                try
                {

                    string query1 = "alter session set \"_ORACLE_SCRIPT\"=true";
                    OracleCommand command1 = new OracleCommand(query1, this.connection);
                    command1.ExecuteNonQuery();
                    string query2 = "begin Drop_User('" + NguoiDung.Text + "'); end;";
                    OracleCommand command2 = new OracleCommand(query2, this.connection);
                    int result = command2.ExecuteNonQuery();

                    DataTable data = new DataTable();
                    MessageBox.Show("Thành công", "Success", MessageBoxButtons.OK);
                    string query = "select username,user_id from all_users";
                    OracleCommand cmd = new OracleCommand(query, this.connection);
                    data.Load(cmd.ExecuteReader());
                    dsnguoidung.DataSource = data;

                }
                catch (Exception ee)
                {
                    MessageBox.Show("Không thành công", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void suaquyenuser_Click(object sender, EventArgs e)
        {
            User us = new User(this.connection, NguoiDung.Text);
            this.Hide();
            us.ShowDialog();
            this.Close();
        }
      

        private void xoarole_Click_1(object sender, EventArgs e)
        {
            if (role.Text != null)
            {
                try
                {
                    
                    string query1 = "alter session set \"_ORACLE_SCRIPT\"=true";
                    OracleCommand command1 = new OracleCommand(query1, this.connection);
                    command1.ExecuteNonQuery();
                    string query2 = "begin Drop_Role('" + role.Text + "'); end;";
                    OracleCommand command2 = new OracleCommand(query2, this.connection);
                    int result = command2.ExecuteNonQuery();


                    DataTable data = new DataTable();
                    MessageBox.Show("Thành công", "Success", MessageBoxButtons.OK);
                    string query = "SELECT ROLE FROM DBA_ROLES";
                    OracleCommand cmd = new OracleCommand(query, this.connection);
                    data.Load(cmd.ExecuteReader());
                    dsvaitro.DataSource = data;
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Không thành công", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void suaquyenrole_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form rl = new Role(this.connection,role.Text);
            rl.ShowDialog();
            this.Close();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
