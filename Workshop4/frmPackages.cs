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
    public partial class frmPackages : Form
    {
        List<Package> packages = PackageDB.GetPackages();


        public frmPackages()
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
            List<ProductsInPackage> products = ProductsInPackageDB.GetProductsFromPackage(packageID);
            productsInPackageBindingSource.DataSource = products;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            //    public Package package; // current package
            //Package newPackage = new Package(); // new package
            //newPackage.PackageId = package.PackageID;
            //    this.PutPackageData(newPackage);

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            frmAddProduct addNewProduct = new frmAddProduct();
                addNewProduct.ShowDialog();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddProduct addNewProduct = new frmAddProduct();
            addNewProduct.ShowDialog();
        }



        //private void PutPackageData(Package package)
        //    {
        //        package.PkgName = txtPkgName.Text;
        //        package.PkgStartDate = txtPkgStart.SelectedValue.ToString();
        //        package.PkgEndDate = txtPkgEnd.SelectedValue.ToString();
        //        package.PkgDesc = txtPkgDesc.Text;
        //        package.PkgBasePrice = Convert.ToDecimal(txtPkgPrice.Text);
        //        package.PkgAgencyCommission = Convert.ToDecimal(txtPkgCommission.Text);
        //    }
    }
}



