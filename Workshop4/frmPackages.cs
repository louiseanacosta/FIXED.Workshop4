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
        Package package; // current package


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

        // Update changes
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Package newPackage = new Package(); // new package
            
            newPackage.PackageId = package.PackageId;
            this.PutPackageData(newPackage);

            try
            {
                if (!PackageDB.UpdatePackage(package, newPackage))
                {
                    MessageBox.Show("Another user has updated or " +
                        "deleted that customer.", "Database Error");
                    this.DialogResult = DialogResult.Retry;
                }
                else // successfully updated
                {
                    package = newPackage;
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }


        // Show Add Product form
        private void btnAddOld_Click(object sender, EventArgs e)
        {
            frmAddProduct addNewProduct = new frmAddProduct(productsInPackageBindingSource);
            addNewProduct.ShowDialog();
        }

        private void PutPackageData(Package package)
        {
            package.PkgName = txtPkgName.Text;
            package.PkgStartDate = Convert.ToDateTime(txtPkgStart.Value);
            package.PkgEndDate = Convert.ToDateTime(txtPkgEnd.Value);
            package.PkgDesc = txtPkgDesc.Text;
            package.PkgBasePrice = Convert.ToDecimal(txtPkgPrice.Text);
            package.PkgAgencyCommission = Convert.ToDecimal(txtPkgCommission.Text);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            tabPackageList.SelectTab(2);
        }


        private void btnBackList2_Click(object sender, EventArgs e)
        {
            tabPackageList.SelectTab(0);
        }
    }
}



