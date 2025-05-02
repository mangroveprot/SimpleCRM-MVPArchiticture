namespace SimpleCRM.View._forms
{
    partial class ProductsView
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
            productsListTab = new TabPage();
            searchBtn = new Button();
            searchField = new TextBox();
            productsDataTbl = new DataGridView();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAddNew = new Button();
            deleteBtn = new Button();
            editBtn = new Button();
            addNewBtn = new Button();
            productDetails = new TabPage();
            txt_prodDesc = new TextBox();
            label1 = new Label();
            cancelBtn = new Button();
            saveBtn = new Button();
            txt_qty = new TextBox();
            label8 = new Label();
            txt_productPrice = new TextBox();
            label7 = new Label();
            txt_prodName = new TextBox();
            label3 = new Label();
            txt_productId = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            productsListTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productsDataTbl).BeginInit();
            productDetails.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(productHeader);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 100);
            panel1.TabIndex = 2;
            // 
            // productHeader
            // 
            productHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            productHeader.AutoSize = true;
            productHeader.Font = new Font("Segoe UI", 15F);
            productHeader.Location = new Point(35, 38);
            productHeader.Name = "productHeader";
            productHeader.Size = new Size(102, 35);
            productHeader.TabIndex = 0;
            productHeader.Text = "Product";
            productHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(productsListTab);
            tabControl1.Controls.Add(productDetails);
            tabControl1.Location = new Point(0, 96);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(858, 577);
            tabControl1.TabIndex = 3;
            // 
            // productsListTab
            // 
            productsListTab.Controls.Add(searchBtn);
            productsListTab.Controls.Add(searchField);
            productsListTab.Controls.Add(productsDataTbl);
            productsListTab.Controls.Add(btnDelete);
            productsListTab.Controls.Add(btnEdit);
            productsListTab.Controls.Add(btnAddNew);
            productsListTab.Controls.Add(deleteBtn);
            productsListTab.Controls.Add(editBtn);
            productsListTab.Controls.Add(addNewBtn);
            productsListTab.Location = new Point(4, 29);
            productsListTab.Name = "productsListTab";
            productsListTab.Padding = new Padding(3);
            productsListTab.Size = new Size(850, 544);
            productsListTab.TabIndex = 0;
            productsListTab.Text = "Products";
            productsListTab.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            searchBtn.Anchor = AnchorStyles.Right;
            searchBtn.Location = new Point(669, 28);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(94, 29);
            searchBtn.TabIndex = 13;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // searchField
            // 
            searchField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchField.Location = new Point(8, 28);
            searchField.Name = "searchField";
            searchField.Size = new Size(646, 27);
            searchField.TabIndex = 12;
            // 
            // productsDataTbl
            // 
            productsDataTbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productsDataTbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDataTbl.Location = new Point(8, 74);
            productsDataTbl.Name = "productsDataTbl";
            productsDataTbl.RowHeadersWidth = 51;
            productsDataTbl.Size = new Size(734, 364);
            productsDataTbl.TabIndex = 10;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(748, 171);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(748, 123);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            btnAddNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNew.Location = new Point(748, 74);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(94, 29);
            btnAddNew.TabIndex = 7;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteBtn.Location = new Point(2053, 191);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // editBtn
            // 
            editBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            editBtn.Location = new Point(2053, 143);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(94, 29);
            editBtn.TabIndex = 1;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            // 
            // addNewBtn
            // 
            addNewBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addNewBtn.Location = new Point(2053, 94);
            addNewBtn.Name = "addNewBtn";
            addNewBtn.Size = new Size(94, 29);
            addNewBtn.TabIndex = 0;
            addNewBtn.Text = "Add New";
            addNewBtn.UseVisualStyleBackColor = true;
            // 
            // productDetails
            // 
            productDetails.Controls.Add(txt_prodDesc);
            productDetails.Controls.Add(label1);
            productDetails.Controls.Add(cancelBtn);
            productDetails.Controls.Add(saveBtn);
            productDetails.Controls.Add(txt_qty);
            productDetails.Controls.Add(label8);
            productDetails.Controls.Add(txt_productPrice);
            productDetails.Controls.Add(label7);
            productDetails.Controls.Add(txt_prodName);
            productDetails.Controls.Add(label3);
            productDetails.Controls.Add(txt_productId);
            productDetails.Controls.Add(label2);
            productDetails.Location = new Point(4, 29);
            productDetails.Name = "productDetails";
            productDetails.Padding = new Padding(3);
            productDetails.Size = new Size(850, 544);
            productDetails.TabIndex = 1;
            productDetails.Text = "Edit";
            productDetails.UseVisualStyleBackColor = true;
            // 
            // txt_prodDesc
            // 
            txt_prodDesc.Location = new Point(13, 219);
            txt_prodDesc.Multiline = true;
            txt_prodDesc.Name = "txt_prodDesc";
            txt_prodDesc.Size = new Size(810, 164);
            txt_prodDesc.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(13, 179);
            label1.Name = "label1";
            label1.Size = new Size(112, 28);
            label1.TabIndex = 16;
            label1.Text = "Description";
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Segoe UI", 12F);
            cancelBtn.Location = new Point(674, 495);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(149, 37);
            cancelBtn.TabIndex = 15;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            saveBtn.Font = new Font("Segoe UI", 12F);
            saveBtn.Location = new Point(497, 495);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(153, 37);
            saveBtn.TabIndex = 14;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            // 
            // txt_qty
            // 
            txt_qty.Location = new Point(367, 437);
            txt_qty.Name = "txt_qty";
            txt_qty.Size = new Size(379, 27);
            txt_qty.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(367, 406);
            label8.Name = "label8";
            label8.Size = new Size(88, 28);
            label8.TabIndex = 12;
            label8.Text = "Quantity";
            // 
            // txt_productPrice
            // 
            txt_productPrice.Location = new Point(18, 437);
            txt_productPrice.Name = "txt_productPrice";
            txt_productPrice.PlaceholderText = "Enter price here";
            txt_productPrice.Size = new Size(294, 27);
            txt_productPrice.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(13, 406);
            label7.Name = "label7";
            label7.Size = new Size(54, 28);
            label7.TabIndex = 10;
            label7.Text = "Price";
            // 
            // txt_prodName
            // 
            txt_prodName.Location = new Point(13, 124);
            txt_prodName.Name = "txt_prodName";
            txt_prodName.Size = new Size(810, 27);
            txt_prodName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(11, 93);
            label3.Name = "label3";
            label3.Size = new Size(138, 28);
            label3.TabIndex = 2;
            label3.Text = "Product Name";
            // 
            // txt_productId
            // 
            txt_productId.Location = new Point(8, 60);
            txt_productId.Name = "txt_productId";
            txt_productId.ReadOnly = true;
            txt_productId.Size = new Size(257, 27);
            txt_productId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(11, 32);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 0;
            label2.Text = "Product ID";
            // 
            // ProductsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 679);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductsView";
            Text = "ProductView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            productsListTab.ResumeLayout(false);
            productsListTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productsDataTbl).EndInit();
            productDetails.ResumeLayout(false);
            productDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label productHeader;
        private TabControl tabControl1;
        private TabPage productDetails;
        private Button cancelBtn;
        private Button saveBtn;
        private TextBox txt_qty;
        private Label label8;
        private TextBox txt_productPrice;
        private Label label7;
        private TextBox txt_prodName;
        private Label label3;
        private TextBox txt_productId;
        private Label label2;
        private TextBox txt_prodDesc;
        private Label label1;
        private TabPage productsListTab;
        private DataGridView productsDataTbl;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAddNew;
        private Button deleteBtn;
        private Button editBtn;
        private Button addNewBtn;
        private TextBox searchField;
        private Button searchBtn;
    }
}