using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado_dz2
{
    public partial class Form1 : Form
    {
        SqlConnection connection = null;
        SqlDataAdapter da = null;
        DataSet ds = null;
        SqlCommandBuilder cmdBldr = null;
        private DataTable dt = null;
        int count = 0;
        string [] query = {
            "SELECT * FROM Dz2User WHERE UserAdmin = 1",
            "SELECT * FROM Dz2User"
        };
        bool flag = true;
        public Form1()
        {
            InitializeComponent();
            listViewTable.MouseDoubleClick += listViewTable_MouseDoubleClick;
            btnAdd.Click += btnAdd_Add_Click;
            adminUsers.Click += AdminUsers_Click;
            allUsers.Click += AllUsers_Click;

            ShowTable(query[1]);
        }

        private void AllUsers_Click(object sender, EventArgs e)
        {
            ShowTable(query[1]);
            flag = false;
        }

        private void AdminUsers_Click(object sender, EventArgs e)
        {
            ShowTable(query[0]);
            flag = true;
        }

        private void btnAdd_Add_Click(object sender, EventArgs e)
        {
            FormAddUser AddUser = new FormAddUser(this, dt, count);
            if (AddUser.ShowDialog() == DialogResult.OK && flag)
            {
                ShowTable(query[0]);
            }
            else
            {
                ShowTable(query[1]);
            }
        }

        private void ShowTable(string strQuery)
        {
            count = 0;
            listViewTable.Items.Clear();
            connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            string stringQuery = strQuery;
            ds = new DataSet();
            da = new SqlDataAdapter(stringQuery, connection);
            cmdBldr = new SqlCommandBuilder(da);
            da.Fill(ds);
            dt = ds.Tables[0];

            string[] str = new string[ds.Tables[0].Columns.Count];
            ListViewItem itemListView;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                count++;
                for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                {
                    str[j] = ds.Tables[0].Rows[i][j].ToString();
                }
                itemListView = new ListViewItem(str);
                listViewTable.Items.Add(itemListView);
            }
        }
        public void Updete_teble(DataTable table)
        {
            ds = table.DataSet;
            da.Update(ds);
        }

        private void listViewTable_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormChangeUser ChangeUser = new FormChangeUser(this, dt, listViewTable.FocusedItem.Index);
                if (ChangeUser.ShowDialog() == DialogResult.OK && flag)
                {
                    ShowTable(query[0]);
                }
                else
                {
                    ShowTable(query[1]);
                }
            }
        }
    }
}
