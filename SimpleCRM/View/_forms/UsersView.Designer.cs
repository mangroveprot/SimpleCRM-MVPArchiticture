namespace SimpleCRM.View._forms
{
    partial class UsersView
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
            panel1 = new Panel();
            productHeader = new Label();
            tabControl1 = new TabControl();
            userListTab = new TabPage();
            usersDataTbl = new DataGridView();
            addNewBtn = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
            searchField = new TextBox();
            searchBtn = new Button();
            userDetails = new TabPage();
            cancelBtn = new Button();
            saveBtn = new Button();
            label6 = new Label();
            txt_role = new ComboBox();
            txt_email = new TextBox();
            label5 = new Label();
            txt_password = new TextBox();
            Pa = new Label();
            txt_username = new TextBox();
            label1 = new Label();
            txt_fullname = new TextBox();
            label3 = new Label();
            txt_userId = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            userListTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usersDataTbl).BeginInit();
            userDetails.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(productHeader);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(856, 100);
            panel1.TabIndex = 3;
            // 
            // productHeader
            // 
            productHeader.AutoSize = true;
            productHeader.Font = new Font("Segoe UI", 15F);
            productHeader.Location = new Point(35, 38);
            productHeader.Name = "productHeader";
            productHeader.Size = new Size(76, 35);
            productHeader.TabIndex = 0;
            productHeader.Text = "Users";
            productHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(userListTab);
            tabControl1.Controls.Add(userDetails);
            tabControl1.Location = new Point(1, 107);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(856, 706);
            tabControl1.TabIndex = 4;
            // 
            // userListTab
            // 
            userListTab.Controls.Add(usersDataTbl);
            userListTab.Controls.Add(addNewBtn);
            userListTab.Controls.Add(editBtn);
            userListTab.Controls.Add(deleteBtn);
            userListTab.Controls.Add(searchField);
            userListTab.Controls.Add(searchBtn);
            userListTab.Location = new Point(4, 29);
            userListTab.Name = "userListTab";
            userListTab.Padding = new Padding(3);
            userListTab.Size = new Size(848, 673);
            userListTab.TabIndex = 0;
            userListTab.Text = "Users";
            userListTab.UseVisualStyleBackColor = true;
            // 
            // usersDataTbl
            // 
            usersDataTbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersDataTbl.Location = new Point(48, 54);
            usersDataTbl.Name = "usersDataTbl";
            usersDataTbl.RowHeadersWidth = 51;
            usersDataTbl.Size = new Size(667, 608);
            usersDataTbl.TabIndex = 15;
            // 
            // addNewBtn
            // 
            addNewBtn.Location = new Point(732, 55);
            addNewBtn.Name = "addNewBtn";
            addNewBtn.Size = new Size(94, 29);
            addNewBtn.TabIndex = 14;
            addNewBtn.Text = "Add New";
            addNewBtn.UseVisualStyleBackColor = true;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(732, 116);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(94, 29);
            editBtn.TabIndex = 13;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(732, 176);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 12;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // searchField
            // 
            searchField.Location = new Point(48, 7);
            searchField.Name = "searchField";
            searchField.Size = new Size(645, 27);
            searchField.TabIndex = 11;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(699, 7);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(94, 29);
            searchBtn.TabIndex = 10;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // userDetails
            // 
            userDetails.Controls.Add(cancelBtn);
            userDetails.Controls.Add(saveBtn);
            userDetails.Controls.Add(label6);
            userDetails.Controls.Add(txt_role);
            userDetails.Controls.Add(txt_email);
            userDetails.Controls.Add(label5);
            userDetails.Controls.Add(txt_password);
            userDetails.Controls.Add(Pa);
            userDetails.Controls.Add(txt_username);
            userDetails.Controls.Add(label1);
            userDetails.Controls.Add(txt_fullname);
            userDetails.Controls.Add(label3);
            userDetails.Controls.Add(txt_userId);
            userDetails.Controls.Add(label2);
            userDetails.Location = new Point(4, 29);
            userDetails.Name = "userDetails";
            userDetails.Padding = new Padding(3);
            userDetails.Size = new Size(848, 673);
            userDetails.TabIndex = 1;
            userDetails.Text = "tabPage2";
            userDetails.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Segoe UI", 12F);
            cancelBtn.Location = new Point(673, 594);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(149, 37);
            cancelBtn.TabIndex = 19;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            saveBtn.Font = new Font("Segoe UI", 12F);
            saveBtn.Location = new Point(496, 594);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(153, 37);
            saveBtn.TabIndex = 18;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(9, 215);
            label6.Name = "label6";
            label6.Size = new Size(50, 28);
            label6.TabIndex = 17;
            label6.Text = "Role\r\n";
            // 
            // txt_role
            // 
            txt_role.FormattingEnabled = true;
            txt_role.Items.AddRange(new object[] { "Admin", "User" });
            txt_role.Location = new Point(9, 246);
            txt_role.Name = "txt_role";
            txt_role.Size = new Size(322, 28);
            txt_role.TabIndex = 16;
            txt_role.Text = "Select a role";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(417, 246);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(382, 27);
            txt_email.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(415, 215);
            label5.Name = "label5";
            label5.Size = new Size(59, 28);
            label5.TabIndex = 14;
            label5.Text = "Email";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(415, 185);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(384, 27);
            txt_password.TabIndex = 11;
            // 
            // Pa
            // 
            Pa.AutoSize = true;
            Pa.Font = new Font("Segoe UI", 12F);
            Pa.Location = new Point(415, 154);
            Pa.Name = "Pa";
            Pa.Size = new Size(93, 28);
            Pa.TabIndex = 10;
            Pa.Text = "Password";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(9, 185);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(322, 27);
            txt_username.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 152);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 8;
            label1.Text = "Username";
            // 
            // txt_fullname
            // 
            txt_fullname.Location = new Point(9, 110);
            txt_fullname.Name = "txt_fullname";
            txt_fullname.Size = new Size(810, 27);
            txt_fullname.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(7, 79);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 6;
            label3.Text = "Full Name";
            // 
            // txt_userId
            // 
            txt_userId.Location = new Point(4, 46);
            txt_userId.Name = "txt_userId";
            txt_userId.ReadOnly = true;
            txt_userId.Size = new Size(257, 27);
            txt_userId.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(7, 18);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 4;
            label2.Text = "UserID";
            // 
            // UsersView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 810);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "UsersView";
            Text = "UsersView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            userListTab.ResumeLayout(false);
            userListTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usersDataTbl).EndInit();
            userDetails.ResumeLayout(false);
            userDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label productHeader;
        private TabControl tabControl1;
        private TabPage userListTab;
        private TabPage userDetails;
        private DataGridView usersDataTbl;
        private Button addNewBtn;
        private Button editBtn;
        private Button deleteBtn;
        private TextBox searchField;
        private Button searchBtn;
        private TextBox txt_fullname;
        private Label label3;
        private TextBox txt_userId;
        private Label label2;
        private TextBox txt_email;
        private Label label5;
        private TextBox txt_password;
        private Label Pa;
        private TextBox txt_username;
        private Label label1;
        private ComboBox txt_role;
        private Label label6;
        private Button cancelBtn;
        private Button saveBtn;
    }
}