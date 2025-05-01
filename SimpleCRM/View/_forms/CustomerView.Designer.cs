namespace SimpleCRM.View
{
    partial class CustomerView
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
            customersHeader = new Label();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            customersListTab = new TabPage();
            customerDataTbl = new DataGridView();
            searchField = new TextBox();
            label1 = new Label();
            searchBtn = new Button();
            deleteBtn = new Button();
            editBtn = new Button();
            addNewBtn = new Button();
            customerDetails = new TabPage();
            cancelBtn = new Button();
            saveBtn = new Button();
            txt_phonenumber = new TextBox();
            label8 = new Label();
            txt_email = new TextBox();
            label7 = new Label();
            txt_suffix = new TextBox();
            label6 = new Label();
            txt_lastname = new TextBox();
            label5 = new Label();
            txt_middlename = new TextBox();
            label4 = new Label();
            txt_firstname = new TextBox();
            label3 = new Label();
            txt_customerId = new TextBox();
            label2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            customersListTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerDataTbl).BeginInit();
            customerDetails.SuspendLayout();
            SuspendLayout();
            // 
            // customersHeader
            // 
            customersHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            customersHeader.AutoSize = true;
            customersHeader.Font = new Font("Segoe UI", 15F);
            customersHeader.Location = new Point(35, 38);
            customersHeader.Name = "customersHeader";
            customersHeader.Size = new Size(154, 35);
            customersHeader.TabIndex = 0;
            customersHeader.Text = "CUSTOMERS";
            customersHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(customersHeader);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(858, 105);
            panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(customersListTab);
            tabControl1.Controls.Add(customerDetails);
            tabControl1.Location = new Point(0, 111);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(858, 387);
            tabControl1.TabIndex = 2;
            // 
            // customersListTab
            // 
            customersListTab.Controls.Add(customerDataTbl);
            customersListTab.Controls.Add(searchField);
            customersListTab.Controls.Add(label1);
            customersListTab.Controls.Add(searchBtn);
            customersListTab.Controls.Add(deleteBtn);
            customersListTab.Controls.Add(editBtn);
            customersListTab.Controls.Add(addNewBtn);
            customersListTab.Location = new Point(4, 29);
            customersListTab.Name = "customersListTab";
            customersListTab.Padding = new Padding(3);
            customersListTab.Size = new Size(850, 354);
            customersListTab.TabIndex = 0;
            customersListTab.Text = "Customers";
            customersListTab.UseVisualStyleBackColor = true;
            // 
            // customerDataTbl
            // 
            customerDataTbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customerDataTbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerDataTbl.Location = new Point(8, 89);
            customerDataTbl.Name = "customerDataTbl";
            customerDataTbl.RowHeadersWidth = 51;
            customerDataTbl.Size = new Size(734, 209);
            customerDataTbl.TabIndex = 5;
            // 
            // searchField
            // 
            searchField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchField.Location = new Point(8, 40);
            searchField.Name = "searchField";
            searchField.Size = new Size(646, 27);
            searchField.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F);
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(0, 19);
            label1.TabIndex = 1;
            // 
            // searchBtn
            // 
            searchBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchBtn.Location = new Point(660, 40);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(94, 29);
            searchBtn.TabIndex = 3;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteBtn.Location = new Point(748, 188);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // editBtn
            // 
            editBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            editBtn.Location = new Point(748, 140);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(94, 29);
            editBtn.TabIndex = 1;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            // 
            // addNewBtn
            // 
            addNewBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addNewBtn.Location = new Point(748, 91);
            addNewBtn.Name = "addNewBtn";
            addNewBtn.Size = new Size(94, 29);
            addNewBtn.TabIndex = 0;
            addNewBtn.Text = "Add New";
            addNewBtn.UseVisualStyleBackColor = true;
            // 
            // customerDetails
            // 
            customerDetails.Controls.Add(cancelBtn);
            customerDetails.Controls.Add(saveBtn);
            customerDetails.Controls.Add(txt_phonenumber);
            customerDetails.Controls.Add(label8);
            customerDetails.Controls.Add(txt_email);
            customerDetails.Controls.Add(label7);
            customerDetails.Controls.Add(txt_suffix);
            customerDetails.Controls.Add(label6);
            customerDetails.Controls.Add(txt_lastname);
            customerDetails.Controls.Add(label5);
            customerDetails.Controls.Add(txt_middlename);
            customerDetails.Controls.Add(label4);
            customerDetails.Controls.Add(txt_firstname);
            customerDetails.Controls.Add(label3);
            customerDetails.Controls.Add(txt_customerId);
            customerDetails.Controls.Add(label2);
            customerDetails.Location = new Point(4, 29);
            customerDetails.Name = "customerDetails";
            customerDetails.Padding = new Padding(3);
            customerDetails.Size = new Size(850, 354);
            customerDetails.TabIndex = 1;
            customerDetails.Text = "Customer Edit";
            customerDetails.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Segoe UI", 12F);
            cancelBtn.Location = new Point(674, 293);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(149, 37);
            cancelBtn.TabIndex = 15;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            saveBtn.Font = new Font("Segoe UI", 12F);
            saveBtn.Location = new Point(497, 293);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(153, 37);
            saveBtn.TabIndex = 14;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            // 
            // txt_phonenumber
            // 
            txt_phonenumber.Location = new Point(463, 201);
            txt_phonenumber.Name = "txt_phonenumber";
            txt_phonenumber.Size = new Size(379, 27);
            txt_phonenumber.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(463, 170);
            label8.Name = "label8";
            label8.Size = new Size(144, 28);
            label8.TabIndex = 12;
            label8.Text = "Phone Number";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(8, 201);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(424, 27);
            txt_email.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(8, 170);
            label7.Name = "label7";
            label7.Size = new Size(59, 28);
            label7.TabIndex = 10;
            label7.Text = "Email";
            // 
            // txt_suffix
            // 
            txt_suffix.Location = new Point(711, 121);
            txt_suffix.Name = "txt_suffix";
            txt_suffix.Size = new Size(131, 27);
            txt_suffix.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(711, 90);
            label6.Name = "label6";
            label6.Size = new Size(60, 28);
            label6.TabIndex = 8;
            label6.Text = "Suffix";
            // 
            // txt_lastname
            // 
            txt_lastname.Location = new Point(438, 121);
            txt_lastname.Name = "txt_lastname";
            txt_lastname.Size = new Size(257, 27);
            txt_lastname.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(438, 90);
            label5.Name = "label5";
            label5.Size = new Size(103, 28);
            label5.TabIndex = 6;
            label5.Text = "Last Name";
            // 
            // txt_middlename
            // 
            txt_middlename.Location = new Point(281, 121);
            txt_middlename.Name = "txt_middlename";
            txt_middlename.Size = new Size(131, 27);
            txt_middlename.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(281, 90);
            label4.Name = "label4";
            label4.Size = new Size(131, 28);
            label4.TabIndex = 4;
            label4.Text = "Middle Name";
            // 
            // txt_firstname
            // 
            txt_firstname.Location = new Point(8, 121);
            txt_firstname.Name = "txt_firstname";
            txt_firstname.Size = new Size(257, 27);
            txt_firstname.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(8, 90);
            label3.Name = "label3";
            label3.Size = new Size(106, 28);
            label3.TabIndex = 2;
            label3.Text = "First Name";
            // 
            // txt_customerId
            // 
            txt_customerId.Location = new Point(8, 60);
            txt_customerId.Name = "txt_customerId";
            txt_customerId.ReadOnly = true;
            txt_customerId.Size = new Size(257, 27);
            txt_customerId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(8, 29);
            label2.Name = "label2";
            label2.Size = new Size(120, 28);
            label2.TabIndex = 0;
            label2.Text = "Customer ID";
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 498);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CustomerView";
            Text = "CustomerView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            customersListTab.ResumeLayout(false);
            customersListTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customerDataTbl).EndInit();
            customerDetails.ResumeLayout(false);
            customerDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label customersHeader;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage customerDetails;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TabPage customersListTab;
        private DataGridView customerDataTbl;
        private TextBox searchField;
        private Label label1;
        private Button searchBtn;
        private Button deleteBtn;
        private Button editBtn;
        private Button addNewBtn;
        private TextBox txt_middlename;
        private Label label4;
        private TextBox txt_firstname;
        private Label label3;
        private TextBox txt_customerId;
        private Label label2;
        private TextBox txt_lastname;
        private Label label5;
        private TextBox txt_suffix;
        private Label label6;
        private TextBox txt_email;
        private Label label7;
        private TextBox txt_phonenumber;
        private Label label8;
        private Button cancelBtn;
        private Button saveBtn;
    }
}