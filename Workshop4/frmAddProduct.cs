using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travel_Experts;

namespace Workshop4
{
    //--------------------------- LOUISE ACOSTA ------------------------------
    public partial class frmAddProduct : Form
    {
        public Package package;
        public BindingSource productsInPackageBindingSource;


        public frmAddProduct(BindingSource productsInPackageBindingSource)
        {
            this.productsInPackageBindingSource = productsInPackageBindingSource;
            InitializeComponent();
        }

        // bind list of products in package to gridview
        List<AvailableProducts> products = AvailableProductsDB.GetAvailableProducts();
        private void AddProduct_Load(object sender, EventArgs e)
        {
            availableProductsBindingSource.DataSource = products;
        }

        
        // Add products to package
        private void btnAddToPackage_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewAvailableProducts.SelectedRows)
            {
                // get selected 
                ProductsInPackage productsInPackage = new ProductsInPackage();
                productsInPackage.ProductSupplierId = Convert.ToInt32(row.Cells[0].Value);
                productsInPackage.ProdName = row.Cells[1].Value.ToString();
                productsInPackage.SupName = row.Cells[2].Value.ToString();

                // add to list
                this.productsInPackageBindingSource.Add(productsInPackage);
                
            }

            this.Close();
        }

        // search available products
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            // get search
            string search = txtSearch.Text.Trim();

            // get products filtered by search
            List<AvailableProducts> availableProducts = AvailableProductsDB.GetAvailableProducts(search);

            // update binding source
            availableProductsBindingSource.DataSource = availableProducts;
        }
    }
}
//--------------------------- LOUISE ACOSTA - END ------------------------------
