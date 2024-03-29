using AppNET.App;
using AppNET.Domain.Entities;
using AppNET.Infrastructure;
using AppNET.Infrastructure.Controls;
using System.Net.Mail;

namespace AppNET.Presentation.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ICategoryService categoryService = IOCContainer.Resolve<ICategoryService>();
        IProductService productService = IOCContainer.Resolve<IProductService>();
        IInvoiceService invoiceService= IOCContainer.Resolve<IInvoiceService>();
        CashService cashService= IOCContainer.Resolve<CashService>();
        ShoppingService shoppingService= IOCContainer.Resolve<ShoppingService>();
        SendInfoMailService sendInfoMailService = IOCContainer.Resolve<SendInfoMailService>();


        private void FillProductGrid()
        {
            grdProduct.DataSource = productService.GetAllProduct();
        }
        private void FillCategoryGrid()
        {
            grdCategory.DataSource = categoryService.GetAllCategory();
        }
        private void FillInvoiceGrid()
        {
            grgShoppingInfo.DataSource = invoiceService.GetInvoices();
        }
        private void FillCombobox()
        {
            var data = categoryService.GetAllCategory().ToList();
            cmbCategortList.DataSource = data;
            cmbCategortList.DisplayMember = nameof(Category.Name);
            cmbCategortList.Text = "";

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FillProductGrid();
            FillCategoryGrid();
            FillCombobox();
            FillInvoiceGrid();
        }


        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            if (btnSaveCategory.Text == "KAYDET")
            {
                int id = Convert.ToInt32(txtCategoryId.Text);
                categoryService.Created(id, txtCategoryName.Text);
            }
            else
            {
                categoryService.Update(Convert.ToInt32(txtCategoryId.Text), txtCategoryName.Text);
                btnSaveCategory.Text = "KAYDET";
                groupBox1.Text = "Yeni Kategori";
                txtCategoryId.Enabled = true;
            }
            txtCategoryId.Text = "";
            txtCategoryName.Text = "";

            FillCombobox();
            FillCategoryGrid();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string categoryName = grdCategory.CurrentRow.Cells["Name"].Value?.ToString() ?? "";
            var categoryId = Convert.ToInt32(grdCategory.CurrentRow.Cells["Id"].Value);
            if (string.IsNullOrEmpty(categoryName)) return;
            

            var data = productService.GetAllProduct().Where(x => x.CategoryName == categoryName);

            var userMsg = "";
            if (data.Count() != 0)
            {
                userMsg = $"{categoryName} �simli Kategori ve Ona Ba�l� {data.Count()} Adet �r�n Silinecektir.";
            }
            else
            {
                userMsg = $"{categoryName} �simli Kategori Silinecek. Bu kategoriye ba�l� �r�n bulunmamaktad�r.";
            }


            DialogResult result = MessageBox.Show($"{userMsg} {Environment.NewLine} Devam Etmek istiyormusunu?", "Silme Onay�", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) return;
            
            #region Category Delete
            bool x = categoryService.Delete(categoryId);
            FillCategoryGrid();
            FillCombobox();
            #endregion Category Delete

            #region Product Delete
            if (data.Count()!=0)
            {
                var isDeleted = productService.DeleteProductsByCategory(categoryName);
                FillProductGrid();
            }


           


            #endregion Product Delete
        }

        private void duzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = grdCategory.CurrentRow.Cells["Id"].Value.ToString();
            string categoryName = grdCategory.CurrentRow.Cells["Name"].Value.ToString();

            txtCategoryId.Text = id;
            txtCategoryName.Text = categoryName;

            txtCategoryId.Enabled = false;
            btnSaveCategory.Text = "G�NCELLE";
            groupBox1.Text = "Kategori G�ncelle";


        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            if (btnSaveProduct.Text == "KAYDET")
            {
                int id = Convert.ToInt32(txtProductId.Text);
                //string selectedCategoryName =Convert.ToString(cmbCategortList.SelectedValue);
                var selectedCategoryName = cmbCategortList.Text;

                productService.Created(id, selectedCategoryName, Convert.ToString(MyExtensions.FirstLetterUppercase(txtProductName.Text)), Convert.ToInt32(txtProductStock.Text), Convert.ToDecimal(txtProductBuyPrice.Text),Convert.ToDecimal(txtProductSellPrice.Text));

            }
            else
            {
                productService.Update(Convert.ToInt32(txtProductId.Text), cmbCategortList.Text, MyExtensions.FirstLetterUppercase(txtProductName.Text), Convert.ToInt32(txtProductStock.Text), Convert.ToDecimal(txtProductBuyPrice.Text),Convert.ToDecimal(txtProductSellPrice.Text));

                btnSaveProduct.Text = "KAYDET";
                groupBox2.Text = "Yeni �r�n";
                txtProductId.Enabled = true;
            }

            txtProductId.Text = "";
            txtProductName.Clear();
            txtProductBuyPrice.Clear();
            txtProductSellPrice.Clear();
            txtProductStock.Clear();

            
            FillProductGrid();
        }

        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string productName = grdProduct.CurrentRow.Cells["Name"].Value.ToString();
            DialogResult result = MessageBox.Show($"{productName} �r�n�n� silmek istedi�inizden emin misiniz?", "Silme Onay�", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            int id = Convert.ToInt32(grdProduct.CurrentRow.Cells["Id"].Value);
            productService.Deleted(id);
            FillProductGrid();
        }

        private void duzenleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string id = grdProduct.CurrentRow.Cells["Id"].Value.ToString();
            var categoryName = grdProduct.CurrentRow.Cells["CategoryName"].Value.ToString();
            string productName = grdProduct.CurrentRow.Cells["Name"].Value.ToString();
            var stock = Convert.ToInt32(grdProduct.CurrentRow.Cells["Stock"].Value.ToString());
            var buyPrice = Convert.ToDecimal(grdProduct.CurrentRow.Cells["BuyPrice"].Value.ToString());
            var sellPrice = Convert.ToDecimal(grdProduct.CurrentRow.Cells["SellPrice"].Value.ToString());

            txtProductId.Text = id;
            txtProductName.Text = productName;
            cmbCategortList.Text = categoryName;
            txtProductStock.Text = Convert.ToString(stock);
            txtProductBuyPrice.Text = Convert.ToString(buyPrice);
            txtProductSellPrice.Text = Convert.ToString(sellPrice);



            txtProductId.Enabled = false;
            btnSaveProduct.Text = "G�NCELLE";
            groupBox2.Text = "�r�n G�ncelle";
        }

        private void btnShopping_Click(object sender, EventArgs e)
        {
            string name = txtShopProductName.Text;
            int stock = Convert.ToInt32(txtShopProductStock.Text.ToString());
            if (cbbShopType.Text == "ALI�")
            {
                decimal buyPrice = Convert.ToDecimal(txtShopProductPrice.Text);
                shoppingService.BuyProduct(name, stock, buyPrice);
                invoiceService.SaveInvoice(999, "Gider", buyPrice, $"{name} �r�n�nden {stock} adet al�nd�.");
                sendInfoMailService.SendMail("melihunal2560@gmail.com", $"{name} �r�n�nden {stock} adet al�nd�.");

            }
            else
            {
                decimal sellPrice = Convert.ToDecimal(txtShopProductPrice.Text);
                shoppingService.SellProduct(name, stock, sellPrice);
                invoiceService.SaveInvoice(333, "Gelir", sellPrice, $"{name} �r�n�nden {stock} adet sat�ld�.");
                sendInfoMailService.SendMail("melihunal2560@gmail.com", $"{name} �r�n�nden {stock} adet sat�ld�.");
            }

            FillInvoiceGrid();
            FillProductGrid();
        }
    }
}