/**
 * Author: : Louise Acosta
 * Date: March 27, 2019
 **/

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
    public partial class Form1 : Form
    {
        List<Package> packages = PackageDB.GetPackages();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            packageBindingSource.DataSource = packages;
        }

        // display list of products included in selected package
        private void packageBindingSource_CurrentChanged(object sender, EventArgs e)
        {

            if (cmbPackageId.Text == "") { return; }
            int packageID = Convert.ToInt32(cmbPackageId.Text);
            //List<Products> listProducts = ProductsDB.GetProductsFromPackage(packageID);

            productsBindingSource.DataSource = ProductsDB.GetProductsFromPackage(packageID);

        }

        private void tabPackageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPackageId.Text == "") { return; }
            int packageID = Convert.ToInt32(cmbPackageId.Text);
            //List<Products> listProducts = ProductsDB.GetProductsFromPackage(packageID);

            productsBindingSource.DataSource = ProductsDB.GetProductsFromPackage(packageID);
        }
    }
}
