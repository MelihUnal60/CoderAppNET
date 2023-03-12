namespace AppNET.Presentation.WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.grdCategory = new System.Windows.Forms.DataGridView();
            this.ctxGrdCategoryMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.grdProduct = new System.Windows.Forms.DataGridView();
            this.ctxGridProduct = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProductSellPrice = new System.Windows.Forms.TextBox();
            this.cmbCategortList = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductBuyPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnShopping = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbShopType = new System.Windows.Forms.ComboBox();
            this.txtShopProductPrice = new System.Windows.Forms.TextBox();
            this.txtShopProductStock = new System.Windows.Forms.TextBox();
            this.txtShopProductName = new System.Windows.Forms.TextBox();
            this.grgShoppingInfo = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).BeginInit();
            this.ctxGrdCategoryMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            this.ctxGridProduct.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grgShoppingInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSaveCategory);
            this.groupBox1.Controls.Add(this.txtCategoryName);
            this.groupBox1.Controls.Add(this.txtCategoryId);
            this.groupBox1.Location = new System.Drawing.Point(34, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(405, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kategori Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kategori Id";
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.Location = new System.Drawing.Point(300, 162);
            this.btnSaveCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(86, 31);
            this.btnSaveCategory.TabIndex = 2;
            this.btnSaveCategory.Text = "KAYDET";
            this.btnSaveCategory.UseVisualStyleBackColor = true;
            this.btnSaveCategory.Click += new System.EventHandler(this.btnSaveCategory_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(109, 98);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(277, 27);
            this.txtCategoryName.TabIndex = 1;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(109, 44);
            this.txtCategoryId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(277, 27);
            this.txtCategoryId.TabIndex = 0;
            // 
            // grdCategory
            // 
            this.grdCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCategory.ContextMenuStrip = this.ctxGrdCategoryMenu;
            this.grdCategory.Location = new System.Drawing.Point(34, 319);
            this.grdCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdCategory.Name = "grdCategory";
            this.grdCategory.RowHeadersVisible = false;
            this.grdCategory.RowHeadersWidth = 51;
            this.grdCategory.RowTemplate.Height = 25;
            this.grdCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCategory.Size = new System.Drawing.Size(405, 336);
            this.grdCategory.TabIndex = 1;
            // 
            // ctxGrdCategoryMenu
            // 
            this.ctxGrdCategoryMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxGrdCategoryMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.toolStripSeparator1});
            this.ctxGrdCategoryMenu.Name = "contextMenuStrip1";
            this.ctxGrdCategoryMenu.Size = new System.Drawing.Size(133, 58);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.duzenleToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
            // 
            // grdProduct
            // 
            this.grdProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProduct.ContextMenuStrip = this.ctxGridProduct;
            this.grdProduct.Location = new System.Drawing.Point(488, 328);
            this.grdProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.RowHeadersVisible = false;
            this.grdProduct.RowHeadersWidth = 51;
            this.grdProduct.RowTemplate.Height = 25;
            this.grdProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProduct.Size = new System.Drawing.Size(510, 322);
            this.grdProduct.TabIndex = 3;
            // 
            // ctxGridProduct
            // 
            this.ctxGridProduct.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxGridProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem1,
            this.düzenleToolStripMenuItem1,
            this.toolStripSeparator2});
            this.ctxGridProduct.Name = "ctxGridProduct";
            this.ctxGridProduct.Size = new System.Drawing.Size(133, 58);
            // 
            // silToolStripMenuItem1
            // 
            this.silToolStripMenuItem1.Name = "silToolStripMenuItem1";
            this.silToolStripMenuItem1.Size = new System.Drawing.Size(132, 24);
            this.silToolStripMenuItem1.Text = "Sil";
            this.silToolStripMenuItem1.Click += new System.EventHandler(this.silToolStripMenuItem1_Click);
            // 
            // düzenleToolStripMenuItem1
            // 
            this.düzenleToolStripMenuItem1.Name = "düzenleToolStripMenuItem1";
            this.düzenleToolStripMenuItem1.Size = new System.Drawing.Size(132, 24);
            this.düzenleToolStripMenuItem1.Text = "Düzenle";
            this.düzenleToolStripMenuItem1.Click += new System.EventHandler(this.duzenleToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(129, 6);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtProductSellPrice);
            this.groupBox2.Controls.Add(this.cmbCategortList);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtProductBuyPrice);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtProductStock);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnSaveProduct);
            this.groupBox2.Controls.Add(this.txtProductName);
            this.groupBox2.Controls.Add(this.txtProductId);
            this.groupBox2.Location = new System.Drawing.Point(488, 43);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(510, 282);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Ürün";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Satış Fiyatı";
            // 
            // txtProductSellPrice
            // 
            this.txtProductSellPrice.Location = new System.Drawing.Point(170, 210);
            this.txtProductSellPrice.Name = "txtProductSellPrice";
            this.txtProductSellPrice.Size = new System.Drawing.Size(279, 27);
            this.txtProductSellPrice.TabIndex = 11;
            // 
            // cmbCategortList
            // 
            this.cmbCategortList.FormattingEnabled = true;
            this.cmbCategortList.Location = new System.Drawing.Point(170, 61);
            this.cmbCategortList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCategortList.Name = "cmbCategortList";
            this.cmbCategortList.Size = new System.Drawing.Size(277, 28);
            this.cmbCategortList.TabIndex = 1;
            this.cmbCategortList.Text = "Kategori Seçin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Kategori";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Alış Fiyatı";
            // 
            // txtProductBuyPrice
            // 
            this.txtProductBuyPrice.Location = new System.Drawing.Point(170, 171);
            this.txtProductBuyPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductBuyPrice.Name = "txtProductBuyPrice";
            this.txtProductBuyPrice.Size = new System.Drawing.Size(277, 27);
            this.txtProductBuyPrice.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Miktar";
            // 
            // txtProductStock
            // 
            this.txtProductStock.Location = new System.Drawing.Point(170, 136);
            this.txtProductStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductStock.Name = "txtProductStock";
            this.txtProductStock.Size = new System.Drawing.Size(277, 27);
            this.txtProductStock.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ürün Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ürün Id";
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Location = new System.Drawing.Point(361, 246);
            this.btnSaveProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(86, 31);
            this.btnSaveProduct.TabIndex = 5;
            this.btnSaveProduct.Text = "KAYDET";
            this.btnSaveProduct.UseVisualStyleBackColor = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(170, 101);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(277, 27);
            this.txtProductName.TabIndex = 2;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(170, 26);
            this.txtProductId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(277, 27);
            this.txtProductId.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnShopping);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cbbShopType);
            this.groupBox3.Controls.Add(this.txtShopProductPrice);
            this.groupBox3.Controls.Add(this.txtShopProductStock);
            this.groupBox3.Controls.Add(this.txtShopProductName);
            this.groupBox3.Location = new System.Drawing.Point(1019, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(405, 277);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alım-Satım";
            // 
            // btnShopping
            // 
            this.btnShopping.Location = new System.Drawing.Point(238, 217);
            this.btnShopping.Name = "btnShopping";
            this.btnShopping.Size = new System.Drawing.Size(144, 41);
            this.btnShopping.TabIndex = 8;
            this.btnShopping.Text = "KAYDET";
            this.btnShopping.UseVisualStyleBackColor = true;
            this.btnShopping.Click += new System.EventHandler(this.btnShopping_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "İşlem Tipi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Fiyat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Adet";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ürün";
            // 
            // cbbShopType
            // 
            this.cbbShopType.FormattingEnabled = true;
            this.cbbShopType.Items.AddRange(new object[] {
            "ALIŞ",
            "SATIŞ"});
            this.cbbShopType.Location = new System.Drawing.Point(103, 162);
            this.cbbShopType.Name = "cbbShopType";
            this.cbbShopType.Size = new System.Drawing.Size(279, 28);
            this.cbbShopType.TabIndex = 3;
            // 
            // txtShopProductPrice
            // 
            this.txtShopProductPrice.Location = new System.Drawing.Point(103, 119);
            this.txtShopProductPrice.Name = "txtShopProductPrice";
            this.txtShopProductPrice.Size = new System.Drawing.Size(279, 27);
            this.txtShopProductPrice.TabIndex = 2;
            // 
            // txtShopProductStock
            // 
            this.txtShopProductStock.Location = new System.Drawing.Point(103, 79);
            this.txtShopProductStock.Name = "txtShopProductStock";
            this.txtShopProductStock.Size = new System.Drawing.Size(279, 27);
            this.txtShopProductStock.TabIndex = 1;
            // 
            // txtShopProductName
            // 
            this.txtShopProductName.Location = new System.Drawing.Point(103, 30);
            this.txtShopProductName.Name = "txtShopProductName";
            this.txtShopProductName.Size = new System.Drawing.Size(279, 27);
            this.txtShopProductName.TabIndex = 0;
            // 
            // grgShoppingInfo
            // 
            this.grgShoppingInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grgShoppingInfo.Location = new System.Drawing.Point(1019, 333);
            this.grgShoppingInfo.Name = "grgShoppingInfo";
            this.grgShoppingInfo.RowHeadersWidth = 51;
            this.grgShoppingInfo.RowTemplate.Height = 29;
            this.grgShoppingInfo.Size = new System.Drawing.Size(405, 322);
            this.grgShoppingInfo.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 685);
            this.Controls.Add(this.grgShoppingInfo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grdProduct);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grdCategory);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).EndInit();
            this.ctxGrdCategoryMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            this.ctxGridProduct.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grgShoppingInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button btnSaveCategory;
        private TextBox txtCategoryName;
        private TextBox txtCategoryId;
        private DataGridView grdCategory;
        private ContextMenuStrip ctxGrdCategoryMenu;
        private ToolStripMenuItem silToolStripMenuItem;
        private ToolStripMenuItem düzenleToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private DataGridView grdProduct;
        private GroupBox groupBox2;
        private Label label3;
        private Label label4;
        private Button btnSaveProduct;
        private TextBox txtProductName;
        private TextBox txtProductId;
        private Label label5;
        private TextBox txtProductStock;
        private Label label7;
        private Label label6;
        private TextBox txtProductBuyPrice;
        private ComboBox cmbCategortList;
        private ContextMenuStrip ctxGridProduct;
        private ToolStripMenuItem silToolStripMenuItem1;
        private ToolStripMenuItem düzenleToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator2;
        private GroupBox groupBox3;
        private TextBox txtShopProductPrice;
        private TextBox txtShopProductStock;
        private TextBox txtShopProductName;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private ComboBox cbbShopType;
        private Button btnShopping;
        private Label label12;
        private TextBox txtProductSellPrice;
        private DataGridView grgShoppingInfo;
    }
}