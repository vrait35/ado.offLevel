using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado_dz2
{
    public partial class FormAddUser : Form
    {
        private DataTable dataTable = null;
        private Form1 Form = null;
        private int countRows = 0;
        public FormAddUser(Form1 form, DataTable dTable, int num)
        {
            InitializeComponent();
            dataTable = dTable;
            Form = form;
            countRows = num;
            add.Click += Add_Click;
            cancel.Click += Cancel_Click;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (textBoxLogo.Text == "" || textBoxPassword.Text == "" || textBoxAdress.Text == "" ||
                textBoxPhone.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполненны!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (dataTable.Rows[i][1].ToString().Equals(textBoxLogo.Text))
                {
                    MessageBox.Show("Такой Login существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            DataRow row = dataTable.NewRow();
            row["Id"] = countRows;
            row["UserLogin"] = textBoxLogo.Text;
            row["UserPassword"] = textBoxPassword.Text;
            row["UserAdress"] = textBoxAdress.Text;
            row["UserPhone"] = textBoxPhone.Text;
            if (comboBox1_Admin.SelectedIndex == 0)
            {
                row["UserAdmin"] = "True";
            }
            else
            {
                row["UserAdmin"] = "False";
            }

            dataTable.Rows.Add(row);
            Form.Updete_teble(dataTable);
            this.DialogResult = DialogResult.OK;
        }
    }
}
