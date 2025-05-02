namespace SimpleCRM.View
{
    partial class MainView
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
            btnLogout = new Button();
            display_user = new Label();
            btnUsers = new Button();
            btnProducts = new Button();
            btnOrders = new Button();
            btnCustomers = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(display_user);
            panel1.Controls.Add(btnUsers);
            panel1.Controls.Add(btnProducts);
            panel1.Controls.Add(btnOrders);
            panel1.Controls.Add(btnCustomers);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 530);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom;
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.Font = new Font("Segoe UI", 12F);
            btnLogout.ForeColor = SystemColors.ControlLight;
            btnLogout.Location = new Point(12, 450);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(220, 43);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // display_user
            // 
            display_user.AutoSize = true;
            display_user.Font = new Font("Segoe UI", 12F);
            display_user.Location = new Point(40, 31);
            display_user.Name = "display_user";
            display_user.Size = new Size(150, 28);
            display_user.TabIndex = 4;
            display_user.Text = "Hello Username";
            // 
            // btnUsers
            // 
            btnUsers.Anchor = AnchorStyles.Top;
            btnUsers.Font = new Font("Segoe UI", 12F);
            btnUsers.Location = new Point(12, 91);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(220, 43);
            btnUsers.TabIndex = 3;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            btnProducts.Anchor = AnchorStyles.Top;
            btnProducts.Font = new Font("Segoe UI", 12F);
            btnProducts.Location = new Point(12, 273);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(220, 43);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "Product";
            btnProducts.UseVisualStyleBackColor = true;
            // 
            // btnOrders
            // 
            btnOrders.Anchor = AnchorStyles.Top;
            btnOrders.Font = new Font("Segoe UI", 12F);
            btnOrders.Location = new Point(12, 213);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(220, 43);
            btnOrders.TabIndex = 1;
            btnOrders.Text = "Orders";
            btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            btnCustomers.Anchor = AnchorStyles.Top;
            btnCustomers.Font = new Font("Segoe UI", 12F);
            btnCustomers.Location = new Point(12, 150);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(220, 43);
            btnCustomers.TabIndex = 0;
            btnCustomers.Text = "Customers";
            btnCustomers.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 530);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "MainView";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCustomers;
        private Button btnOrders;
        private Button btnProducts;
        private Button btnUsers;
        private Label display_user;
        private Button btnLogout;
    }
}