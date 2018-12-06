namespace Ado_dz2
{
    partial class Form1
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
            this.listViewTable = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Logo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Admin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.allUsers = new System.Windows.Forms.Button();
            this.adminUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewTable
            // 
            this.listViewTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Logo,
            this.Password,
            this.Adres,
            this.Phone_,
            this.Admin});
            this.listViewTable.FullRowSelect = true;
            this.listViewTable.GridLines = true;
            this.listViewTable.Location = new System.Drawing.Point(12, 55);
            this.listViewTable.MultiSelect = false;
            this.listViewTable.Name = "listViewTable";
            this.listViewTable.Size = new System.Drawing.Size(576, 272);
            this.listViewTable.TabIndex = 4;
            this.listViewTable.UseCompatibleStateImageBehavior = false;
            this.listViewTable.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Id";
            this.id.Width = 33;
            // 
            // Logo
            // 
            this.Logo.Text = "Logo";
            this.Logo.Width = 84;
            // 
            // Password
            // 
            this.Password.Text = "Password";
            this.Password.Width = 94;
            // 
            // Adres
            // 
            this.Adres.Text = "Adres";
            this.Adres.Width = 93;
            // 
            // Phone_
            // 
            this.Phone_.Text = "Phone";
            this.Phone_.Width = 132;
            // 
            // Admin
            // 
            this.Admin.Text = "Admin";
            this.Admin.Width = 133;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(465, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 37);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add User";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // allUsers
            // 
            this.allUsers.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.allUsers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.allUsers.Location = new System.Drawing.Point(12, 12);
            this.allUsers.Name = "allUsers";
            this.allUsers.Size = new System.Drawing.Size(123, 37);
            this.allUsers.TabIndex = 7;
            this.allUsers.Text = "Show All Users";
            this.allUsers.UseVisualStyleBackColor = false;
            // 
            // adminUsers
            // 
            this.adminUsers.BackColor = System.Drawing.Color.Firebrick;
            this.adminUsers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.adminUsers.Location = new System.Drawing.Point(141, 12);
            this.adminUsers.Name = "adminUsers";
            this.adminUsers.Size = new System.Drawing.Size(123, 37);
            this.adminUsers.TabIndex = 8;
            this.adminUsers.Text = "Show Admin Users";
            this.adminUsers.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 337);
            this.Controls.Add(this.adminUsers);
            this.Controls.Add(this.allUsers);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listViewTable);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listViewTable;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader Logo;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader Adres;
        private System.Windows.Forms.ColumnHeader Phone_;
        private System.Windows.Forms.ColumnHeader Admin;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button allUsers;
        private System.Windows.Forms.Button adminUsers;
    }
}

