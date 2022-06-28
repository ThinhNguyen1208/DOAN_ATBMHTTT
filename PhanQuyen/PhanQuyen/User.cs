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
    public partial class User : Form
    {
        public static string name;
        private OracleConnection connection;
        public User(OracleConnection con, string username)
        {
            InitializeComponent();
            this.connection = con;
            label1.Text = "Danh sách quyền của " + username;
            User.name = username;
            loadform();
        }
        public class privs {
            public string col { get; set; }
            public string priv{ get; set; }
            public string tab { get; set; }
        }
        public class checkpriv
        {
            public string col { get; set; }
            public bool sel { get; set; }
            public string upd { get; set; }
        }
        public class tabprivs
        {
            public string tab { get; set; }
            public string priv { get; set; }
        }
        public void loadform()
        {
            try
            {
                DataTable data = new DataTable();
                string query = "SELECT table_name FROM all_tables where owner='USER_QLBV'";

                OracleCommand cmd = new OracleCommand(query, this.connection);
                data.Load(cmd.ExecuteReader());

                dataGridView1.DataSource = data;

                table.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "table_name"));

                string query1 = "SELECT ROLE FROM SYS.DBA_ROLES";

                OracleCommand cmd1 = new OracleCommand(query1, this.connection);
                DataTable t = new DataTable();
                t.Load(cmd1.ExecuteReader());
                role.DisplayMember = "ROLE";
                role.ValueMember = "ROLE";
                role.DataSource = t;
            }
            catch (Exception err)
            {
                MessageBox.Show("loi");
            };
           
            

        }
        public List<tabprivs> loadlistptb()
        {
            var privslist = new List<tabprivs>();

            DataTable data = new DataTable();
            string query = "SELECT * FROM SYS.dba_tab_privs where GRANTEE = '" + name + "'";

            OracleCommand cmd = new OracleCommand(query, this.connection);
            data.Load(cmd.ExecuteReader());
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i]["TYPE"].ToString() == "TABLE" && ((data.Rows[i]["PRIVILEGE"].ToString() == "INSERT") || (data.Rows[i]["PRIVILEGE"].ToString() == "DELETE")))
                {
                    tabprivs temp = new tabprivs();
                    temp.tab = data.Rows[i]["TABLE_NAME"].ToString();
                    temp.priv = data.Rows[i]["PRIVILEGE"].ToString();
                    privslist.Add(temp);
                }
            }



            DataTable data1 = new DataTable();
            string query1 = "SELECT * FROM SYS.DBA_ROLE_PRIVS where GRANTEE = '" + name + "'";

            OracleCommand cmd1 = new OracleCommand(query1, this.connection);
            data1.Load(cmd1.ExecuteReader());
            for (int j = 0; j < data1.Rows.Count; j++)
            {
                data = new DataTable();
                query = "SELECT * FROM  SYS.ROLE_TAB_PRIVS  where Role = '" + data1.Rows[j]["GRANTED_ROLE"].ToString() + "'";
                cmd = new OracleCommand(query, connection);
                data.Load(cmd.ExecuteReader());
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    if ((data.Rows[i]["PRIVILEGE"].ToString() == "INSERT") || (data.Rows[i]["PRIVILEGE"].ToString() == "DELETE"))
                    {
                        tabprivs temp = new tabprivs();
                        temp.tab = data.Rows[i]["TABLE_NAME"].ToString();
                        temp.priv = data.Rows[i]["PRIVILEGE"].ToString();
                        privslist.Add(temp);
                    }
                }
            }


            return privslist;

        }
        public List<privs> loadlistpcol()
        {
            var privslist = new List<privs>();

            DataTable data = new DataTable();
            string query = "SELECT * FROM SYS.dba_tab_privs where GRANTEE = '" + name + "'";

            OracleCommand cmd = new OracleCommand(query, connection);
            data.Load(cmd.ExecuteReader());
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i]["TYPE"].ToString() == "VIEW" && ((data.Rows[i]["PRIVILEGE"].ToString() == "SELECT") || (data.Rows[i]["PRIVILEGE"].ToString() == "UPDATE")))
                {
                    DataTable dataview = new DataTable();
                    string queryview = "SELECT * FROM " + data.Rows[i]["TABLE_NAME"] + " where  1 = 2";
                    OracleCommand cmdview = new OracleCommand(queryview, connection);
                    dataview.Load(cmdview.ExecuteReader());
                    foreach (DataColumn column in dataview.Columns)
                    {
                        privs temp = new privs();
                        temp.col = column.ColumnName.ToString();
                        temp.priv = data.Rows[i]["PRIVILEGE"].ToString();
                        temp.tab = data.Rows[i]["TABLE_NAME"].ToString();
                        privslist.Add(temp);
                    }
                }
                if (data.Rows[i]["TYPE"].ToString() == "TABLE" && ((data.Rows[i]["PRIVILEGE"].ToString() == "SELECT") || (data.Rows[i]["PRIVILEGE"].ToString() == "UPDATE")))
                {

                    DataTable dataview = new DataTable();
                    string queryview = "SELECT distinct COLUMN_NAME FROM SYS.USER_TAB_COLUMNS WHERE table_name ='" + data.Rows[i]["TABLE_NAME"].ToString() + "'";
                    OracleCommand cmdview = new OracleCommand(queryview, connection);
                    dataview.Load(cmdview.ExecuteReader());
                    for (int j = 0; j < dataview.Rows.Count; j++)
                    {
                        privs temp = new privs();
                        temp.col = dataview.Rows[j]["COLUMN_NAME"].ToString();
                        temp.priv = data.Rows[i]["PRIVILEGE"].ToString();
                        temp.tab = data.Rows[i]["TABLE_NAME"].ToString();
                        privslist.Add(temp);
                    }
                }
            }
            query = "SELECT * FROM SYS.dba_col_privs where GRANTEE = '" + name + "'";
            cmd = new OracleCommand(query, connection);
            data.Load(cmd.ExecuteReader());
            for (int i = 0; i < data.Rows.Count; i++)
            {
                privs temp = new privs();
                temp.col = data.Rows[i]["COLUMN_NAME"].ToString();
                temp.priv = data.Rows[i]["PRIVILEGE"].ToString();
                temp.tab = data.Rows[i]["TABLE_NAME"].ToString();
                privslist.Add(temp);
            }




            DataTable data1 = new DataTable();
            string query1 = "SELECT * FROM SYS.DBA_ROLE_PRIVS where GRANTEE = '" + name + "'";
          
            OracleCommand cmd1 = new OracleCommand(query1, connection);
            data1.Load(cmd1.ExecuteReader());
            for (int j = 0; j < data1.Rows.Count; j++)
            {
                data = new DataTable();
                query = "SELECT * FROM  SYS.ROLE_TAB_PRIVS  where Role = '" + data1.Rows[j]["GRANTED_ROLE"].ToString() + "'";
                cmd = new OracleCommand(query, connection);
                data.Load(cmd.ExecuteReader());
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    if ((data.Rows[i]["PRIVILEGE"].ToString() == "SELECT") || (data.Rows[i]["PRIVILEGE"].ToString() == "UPDATE"))
                    {
                        if (data.Rows[i]["COLUMN_NAME"].ToString() == "")
                        {
                            DataTable dataview = new DataTable();
                            string queryview = "SELECT * FROM " + data.Rows[i]["TABLE_NAME"] + " where  1 = 2";
                            OracleCommand cmdview = new OracleCommand(queryview, connection);
                            dataview.Load(cmdview.ExecuteReader());
                            foreach (DataColumn column in dataview.Columns)
                            {
                                privs temp = new privs();
                                temp.col = column.ColumnName.ToString();
                                temp.priv = data.Rows[i]["PRIVILEGE"].ToString();
                                temp.tab = data.Rows[i]["TABLE_NAME"].ToString();
                                privslist.Add(temp);
                            }
                        }
                        else
                        {
                            privs temp = new privs();
                            temp.col = data.Rows[i]["COLUMN_NAME"].ToString();
                            temp.priv = data.Rows[i]["PRIVILEGE"].ToString();
                            temp.tab = data.Rows[i]["TABLE_NAME"].ToString();
                            privslist.Add(temp);
                        }
                    }
                }
            }

            return privslist;
        }

        private void table_TextChanged(object sender, EventArgs e)
        {
            insert.Checked = false;
            delete.Checked = false;
            var privslisttab = new List<tabprivs>();
            privslisttab = loadlistptb();
            foreach (tabprivs num in privslisttab)
            {
                if (num.tab == table.Text)
                    if (num.priv == "INSERT")
                        insert.Checked = true;
                    else
                        delete.Checked = true;
            }

            var privslist = new List<privs>();
            privslist = loadlistpcol();
            DataTable data = new DataTable();
            string query = " SELECT column_name FROM SYS.USER_TAB_COLUMNS WHERE table_name = '" + table.Text + "'";

            OracleCommand cmd = new OracleCommand(query, connection);
            data.Load(cmd.ExecuteReader());

            data.Columns.Add(new DataColumn("SELECT", typeof(bool)));
            data.Columns.Add(new DataColumn("UPDATE", typeof(bool)));
            for (int i = 0; i < data.Rows.Count; i++)
            {
                foreach (privs num in privslist)
                {
                    if (num.tab.Contains(table.Text))
                        if (num.col == data.Rows[i]["column_name"].ToString())
                            data.Rows[i][num.priv] = true;
                }
            }
            dataGridView2.DataSource = data;

        }

        private void dongy_Click(object sender, EventArgs e)
        {


            string query1 = "alter session set \"_ORACLE_SCRIPT\"=true";
            OracleCommand command1 = new OracleCommand(query1, connection);
            command1.ExecuteNonQuery();
            string query2 = "begin Drop_User('" + name + "'); end;";
            OracleCommand command2 = new OracleCommand(query2, connection);
            int result = command2.ExecuteNonQuery();




            query2 = "begin Grant_NewUser('" + name + "','123'); end;";
            command2 = new OracleCommand(query2, connection);
            result = command2.ExecuteNonQuery();


            if (insert.Checked == true)
            {

                query2 = "grant insert on " + table.Text + " to " + name;
                command2 = new OracleCommand(query2, connection);
                result = command2.ExecuteNonQuery();

            }
            if (delete.Checked == true)
            {

                query2 = "grant delete on " + table.Text + " to " + name;
                command2 = new OracleCommand(query2, connection);
                result = command2.ExecuteNonQuery();

            }

            string select = "";
            string update = "";
            int i = 0;
            
            foreach (DataGridViewRow dr in dataGridView2.Rows)
            {
                try
                {
                    if (Convert.ToBoolean(dr.Cells[1].Value))
                    {
                        if (i != 0)
                            select = select + "," + dr.Cells[0].Value.ToString();
                        if (i == 0)
                        {
                            select = select + dr.Cells[0].Value.ToString();
                            i = i + 1;
                        }
                    }
                }
                catch (Exception ee) { }
            }
            i = 0;
            foreach (DataGridViewRow dr in dataGridView2.Rows)
            {
                try
                {
                    if (Convert.ToBoolean(dr.Cells[2].Value))
                    {
                        if (i != 0)
                            update = update + "," + dr.Cells[0].Value.ToString();
                        if (i == 0)
                        {
                            update = update + dr.Cells[0].Value.ToString();
                            i = i + 1;
                        }
                    }
                }
                catch (Exception ee) { }
            }
            if (select != "")
            {
                query2 = "Create or replace view VIEW_" + table.Text + "_" + name + " as SELECT " + select + " from " + table.Text;
                command2 = new OracleCommand(query2, connection);
                result = command2.ExecuteNonQuery();
                query2 = "grant SELECT ON VIEW_" + table.Text + "_" + name + " TO " + name;
                command2 = new OracleCommand(query2, connection);
                result = command2.ExecuteNonQuery();
            }
            if (update != "")
            {
                query2 = "grant update(" + update + ") on VIEW_" + table.Text + "_" + name + " to " + name;
                command2 = new OracleCommand(query2, connection);
                result = command2.ExecuteNonQuery();
            }
            MessageBox.Show("Thành công", "Success", MessageBoxButtons.OK);
            
        }

        private void grant_Click(object sender, EventArgs e)
        {

            try
            {
               
                string query1 = "alter session set \"_ORACLE_SCRIPT\"=true";
                OracleCommand command1 = new OracleCommand(query1, connection);
                command1.ExecuteNonQuery();
                string query2 = "grant " + role.Text + " to " + User.name;
                OracleCommand command2 = new OracleCommand(query2, connection);
                int result = command2.ExecuteNonQuery();


                MessageBox.Show("Thành công", "Success", MessageBoxButtons.OK);
                
            }
            catch (Exception ee)
            {
                MessageBox.Show("không Thành công", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form main = new TrangChu(this.connection);
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void btn_revoke_user_Click(object sender, EventArgs e)
        {

            try
            {
               
                string query1 = "begin Revoke_all('" + name + "'); end;";
                OracleCommand command1 = new OracleCommand(query1, connection);
                command1.ExecuteReader();


                MessageBox.Show("Thành công", "Success", MessageBoxButtons.OK);
               
            }
            catch (Exception ee)
            {
                MessageBox.Show("Tồn tại quyền không thể revoke!!" + ee.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
