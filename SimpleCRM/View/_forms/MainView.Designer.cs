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
            btnProducts = new Button();
            btnOrders = new Button();
            btnCustomers = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnProducts);
            panel1.Controls.Add(btnOrders);
            panel1.Controls.Add(btnCustomers);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 450);
            panel1.TabIndex = 0;
            // 
            // btnProducts
            // 
            btnProducts.Font = new Font("Segoe UI", 12F);
            btnProducts.Location = new Point(12, 176);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(220, 43);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "Product";
            btnProducts.UseVisualStyleBackColor = true;
            // 
            // btnOrders
            // 
            btnOrders.Font = new Font("Segoe UI", 12F);
            btnOrders.Location = new Point(12, 116);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(220, 43);
            btnOrders.TabIndex = 1;
            btnOrders.Text = "Orders";
            btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            btnCustomers.Font = new Font("Segoe UI", 12F);
            btnCustomers.Location = new Point(12, 53);
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
            ClientSize = new Size(889, 450);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "MainView";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCustomers;
        private Button btnOrders;
        private Button btnProducts;
    }
}