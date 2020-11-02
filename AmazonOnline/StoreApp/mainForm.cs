using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Catalog;
namespace StoreApp
{
    public partial class mainForm : Form
    {
        private List<Product> allProducts = new List<Product>();
        public mainForm()
        {
            InitializeComponent();
            loginForm frm = new loginForm();
            frm.ShowDialog();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void onInsert(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtProductID.Text);
            string title = this.txtProductTitle.Text;
            string description = this.txtProductDescription.Text;
            float unitPrice = float.Parse(this.txtProductPrice.Text);
            int quantity = int.Parse(this.txtProductQuantity.Text);

            Product theProduct = new Product
            {
                Id = id,
                Title = title,
                Description = description,
                UnitPrice = unitPrice,
                Quantity = quantity
            };

            this.allProducts.Add(theProduct);
            this.dataProductsGridView.DataSource = null;
            this.dataProductsGridView.DataSource = allProducts;

        }

        private void onUpdate(object sender, EventArgs e)
        {

        }

        private void onDelete(object sender, EventArgs e)
        {

        }
    }
}
