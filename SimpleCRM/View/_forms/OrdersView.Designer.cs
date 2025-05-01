namespace SimpleCRM.View._forms
{
    partial class OrdersView
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
            txt_dateAndTime = new Label();
            orderDateLabel = new Label();
            productHeader = new Label();
            tabControl1 = new TabControl();
            ordersListTab = new TabPage();
            orderDataTbl = new DataGridView();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAddNew = new Button();
            searchBtn = new Button();
            searchField = new TextBox();
            orderDetails = new TabPage();
            txt_status = new ComboBox();
            label5 = new Label();
            txt_totalAmount = new TextBox();
            label4 = new Label();
            cancelBtn = new Button();
            saveBtn = new Button();
            txt_qty = new TextBox();
            label8 = new Label();
            txt_productPrice = new TextBox();
            label7 = new Label();
            txt_productId = new TextBox();
            label2 = new Label();
            txt_customerId = new TextBox();
            label1 = new Label();
            txt_orderId = new TextBox();
            pr = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            ordersListTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderDataTbl).BeginInit();
            orderDetails.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(txt_dateAndTime);
            panel1.Controls.Add(orderDateLabel);
            panel1.Controls.Add(productHeader);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 100);
            panel1.TabIndex = 3;
            // 
            // txt_dateAndTime
            // 
            txt_dateAndTime.AutoSize = true;
            txt_dateAndTime.Location = new Point(705, 49);
            txt_dateAndTime.Name = "txt_dateAndTime";
            txt_dateAndTime.Size = new Size(109, 20);
            txt_dateAndTime.TabIndex = 19;
            txt_dateAndTime.Text = "Date And Time";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderDateLabel.Location = new Point(600, 48);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new Size(99, 23);
            orderDateLabel.TabIndex = 18;
            orderDateLabel.Text = "Order Date:";
            // 
            // productHeader
            // 
            productHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            productHeader.AutoSize = true;
            productHeader.Font = new Font("Segoe UI", 15F);
            productHeader.Location = new Point(35, 38);
            productHeader.Name = "productHeader";
            productHeader.Size = new Size(82, 35);
            productHeader.TabIndex = 0;
            productHeader.Text = "Oders";
            productHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ordersListTab);
            tabControl1.Controls.Add(orderDetails);
            tabControl1.Location = new Point(2, 109);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(833, 504);
            tabControl1.TabIndex = 4;
            // 
            // ordersListTab
            // 
            ordersListTab.Controls.Add(orderDataTbl);
            ordersListTab.Controls.Add(btnDelete);
            ordersListTab.Controls.Add(btnEdit);
            ordersListTab.Controls.Add(btnAddNew);
            ordersListTab.Controls.Add(searchBtn);
            ordersListTab.Controls.Add(searchField);
            ordersListTab.Location = new Point(4, 29);
            ordersListTab.Name = "ordersListTab";
            ordersListTab.Padding = new Padding(3);
            ordersListTab.Size = new Size(825, 471);
            ordersListTab.TabIndex = 0;
            ordersListTab.Text = "Orders";
            ordersListTab.UseVisualStyleBackColor = true;
            // 
            // orderDataTbl
            // 
            orderDataTbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            orderDataTbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderDataTbl.Location = new Point(6, 41);
            orderDataTbl.Name = "orderDataTbl";
            orderDataTbl.RowHeadersWidth = 51;
            orderDataTbl.Size = new Size(713, 427);
            orderDataTbl.TabIndex = 18;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(725, 151);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(725, 103);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            btnAddNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNew.Location = new Point(725, 54);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(94, 29);
            btnAddNew.TabIndex = 15;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            searchBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchBtn.Location = new Point(658, 6);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(94, 29);
            searchBtn.TabIndex = 14;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // searchField
            // 
            searchField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchField.Location = new Point(6, 6);
            searchField.Name = "searchField";
            searchField.Size = new Size(646, 27);
            searchField.TabIndex = 13;
            // 
            // orderDetails
            // 
            orderDetails.Controls.Add(txt_status);
            orderDetails.Controls.Add(label5);
            orderDetails.Controls.Add(txt_totalAmount);
            orderDetails.Controls.Add(label4);
            orderDetails.Controls.Add(cancelBtn);
            orderDetails.Controls.Add(saveBtn);
            orderDetails.Controls.Add(txt_qty);
            orderDetails.Controls.Add(label8);
            orderDetails.Controls.Add(txt_productPrice);
            orderDetails.Controls.Add(label7);
            orderDetails.Controls.Add(txt_productId);
            orderDetails.Controls.Add(label2);
            orderDetails.Controls.Add(txt_customerId);
            orderDetails.Controls.Add(label1);
            orderDetails.Controls.Add(txt_orderId);
            orderDetails.Controls.Add(pr);
            orderDetails.Location = new Point(4, 29);
            orderDetails.Name = "orderDetails";
            orderDetails.Padding = new Padding(3);
            orderDetails.Size = new Size(825, 471);
            orderDetails.TabIndex = 1;
            orderDetails.Text = "order";
            orderDetails.UseVisualStyleBackColor = true;
            // 
            // txt_status
            // 
            txt_status.Items.AddRange(new object[] { "Pending", "Paid", "Unpaid" });
            txt_status.Location = new Point(97, 327);
            txt_status.Name = "txt_status";
            txt_status.Size = new Size(151, 28);
            txt_status.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 326);
            label5.Name = "label5";
            label5.Size = new Size(86, 31);
            label5.TabIndex = 22;
            label5.Text = "Status:";
            // 
            // txt_totalAmount
            // 
            txt_totalAmount.Font = new Font("Segoe UI", 12F);
            txt_totalAmount.Location = new Point(655, 323);
            txt_totalAmount.Name = "txt_totalAmount";
            txt_totalAmount.Size = new Size(147, 34);
            txt_totalAmount.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(490, 324);
            label4.Name = "label4";
            label4.Size = new Size(167, 31);
            label4.TabIndex = 20;
            label4.Text = "Total Amount:";
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Segoe UI", 12F);
            cancelBtn.Location = new Point(667, 408);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(149, 37);
            cancelBtn.TabIndex = 19;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            saveBtn.Font = new Font("Segoe UI", 12F);
            saveBtn.Location = new Point(490, 408);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(153, 37);
            saveBtn.TabIndex = 18;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            // 
            // txt_qty
            // 
            txt_qty.Location = new Point(359, 104);
            txt_qty.Name = "txt_qty";
            txt_qty.Size = new Size(379, 27);
            txt_qty.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(350, 73);
            label8.Name = "label8";
            label8.Size = new Size(88, 28);
            label8.TabIndex = 16;
            label8.Text = "Quantity";
            // 
            // txt_productPrice
            // 
            txt_productPrice.Location = new Point(4, 104);
            txt_productPrice.Name = "txt_productPrice";
            txt_productPrice.PlaceholderText = "Enter price here";
            txt_productPrice.Size = new Size(294, 27);
            txt_productPrice.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(3, 73);
            label7.Name = "label7";
            label7.Size = new Size(54, 28);
            label7.TabIndex = 14;
            label7.Text = "Price";
            // 
            // txt_productId
            // 
            txt_productId.Location = new Point(567, 31);
            txt_productId.Name = "txt_productId";
            txt_productId.ReadOnly = true;
            txt_productId.Size = new Size(257, 27);
            txt_productId.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(565, 3);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 6;
            label2.Text = "Product ID";
            // 
            // txt_customerId
            // 
            txt_customerId.Location = new Point(283, 31);
            txt_customerId.Name = "txt_customerId";
            txt_customerId.ReadOnly = true;
            txt_customerId.Size = new Size(257, 27);
            txt_customerId.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(281, 3);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 4;
            label1.Text = "Customer ID";
            // 
            // txt_orderId
            // 
            txt_orderId.Location = new Point(3, 31);
            txt_orderId.Name = "txt_orderId";
            txt_orderId.ReadOnly = true;
            txt_orderId.Size = new Size(257, 27);
            txt_orderId.TabIndex = 3;
            // 
            // pr
            // 
            pr.AutoSize = true;
            pr.Font = new Font("Segoe UI", 12F);
            pr.Location = new Point(1, 3);
            pr.Name = "pr";
            pr.Size = new Size(87, 28);
            pr.TabIndex = 2;
            pr.Text = "Order ID";
            // 
            // OrdersView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 612);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "OrdersView";
            Text = "OrdersView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ordersListTab.ResumeLayout(false);
            ordersListTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderDataTbl).EndInit();
            orderDetails.ResumeLayout(false);
            orderDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label productHeader;
        private TabControl tabControl1;
        private TabPage ordersListTab;
        private TabPage orderDetails;
        private TextBox searchField;
        private Button searchBtn;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAddNew;
        private DataGridView orderDataTbl;
        private TextBox txt_orderId;
        private Label pr;
        private TextBox txt_productId;
        private Label label2;
        private TextBox txt_customerId;
        private Label label1;
        private Label txt_dateAndTime;
        private Label orderDateLabel;
        private TextBox txt_qty;
        private Label label8;
        private TextBox txt_productPrice;
        private Label label7;
        private Button cancelBtn;
        private Button saveBtn;
        private TextBox txt_totalAmount;
        private Label label4;
        private Label label5;
        private ComboBox txt_status;
    }
}