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
        List<Package> packages;
        public Package package; // current package


        public frmPackages()
        {
            this.packages = PackageDB.GetPackages();
            InitializeComponent();
        }

        // form load
        private void Form1_Load(object sender, EventArgs e)
        {
            packageBindingSource.DataSource = this.packages;
            //cmbPackageId.SelectedIndex = 0;

            // get first object
            Package firstPackage = this.packages.First();

            List<ProductsInPackage> products = ProductsInPackageDB.GetProductsFromPackage(firstPackage.PackageId);
            productsInPackageBindingSource.DataSource = products;

        }

        // display list of products included in selected package
        private void packageBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (cmbPackageId.Text == "") { return; }
            int packageID = Convert.ToInt32(cmbPackageId.SelectedValue);

            List<ProductsInPackage> products = ProductsInPackageDB.GetProductsFromPackage(packageID);
            productsInPackageBindingSource.DataSource = products;
        }

        // update Package
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // get current package from database
            int packageId = Convert.ToInt32(cmbPackageId.SelectedValue);
            List <Package> oldPackageList = PackageDB.GetPackages(packageId);
            Package oldPackage = oldPackageList.First();

            // set new values
            Package newPackage = new Package();
            newPackage.PackageId = packageId;
            this.PutPackageData(newPackage);

            // save package
            package = newPackage;
            PackageDB.UpdatePackage(oldPackage, newPackage);

            // get current product suppliers
            List <int> productSupplierIds = new List<int>();
            foreach (var product in ProductsInPackageDB.GetProductsFromPackage(packageId))
            {
                productSupplierIds.Add(product.ProductSupplierId);
            }

            // delete products suppliers linked to package
            Packages_products_suppliersDB.Delete(packageId);

            // add products supliers to package
            List <ProductsInPackage> productsInPackages = (List<ProductsInPackage>)productsInPackageBindingSource.DataSource;
            foreach (var productsInPackage in productsInPackages)
            {
                Packages_products_suppliersDB.Add(packageId, productsInPackage.ProductSupplierId);
            }

            MessageBox.Show("Changes saved for Package ID " + packageId);
        }

        // delete Package
        private void btnDeletePackage_Click(object sender, EventArgs e)
        {
            // get selected package
            int packageId = Convert.ToInt32(cmbPackageId.SelectedValue);
            List<Package> packageList = PackageDB.GetPackages(packageId);
            Package package = packageList.First();

            DialogResult result = MessageBox.Show("Delete Package " + package.PackageId + "?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // get current product suppliers
                List<int> productSupplierIds = new List<int>();
                foreach (var product in ProductsInPackageDB.GetProductsFromPackage(packageId))
                {
                    productSupplierIds.Remove(product.ProductSupplierId);
                }

                // delete products suppliers linked to package
                Packages_products_suppliersDB.Delete(packageId);

                foreach (DataGridViewRow item in this.grdProductList.SelectedRows)
                {
                    grdProductList.Rows.RemoveAt(item.Index);
                }
                

                // delete package
                PackageDB.DeletePackage(package);
                    MessageBox.Show("Package " + packageId + " deleted successfully");

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
            package.PkgDesc = txtPkgDesc.Text;
            package.PkgStartDate = Convert.ToDateTime(txtPkgStart.Value);
            package.PkgEndDate = Convert.ToDateTime(txtPkgEnd.Value);
            package.PkgBasePrice = Convert.ToDecimal(txtPkgPrice.Text);
            package.PkgAgencyCommission = Convert.ToDecimal(txtPkgCommission.Text);

        }


        // Design Views
        private void btnCreate_Click(object sender, EventArgs e)
        {
            tabPackageList.SelectTab(2);
        }

        // go back to list
        private void btnBackList2_Click(object sender, EventArgs e)
        {
            tabPackageList.SelectTab(0);
        }


        // 4 Main Navigation Buttons

        private void btnPackages_Click(object sender, EventArgs e)
        {
            tabMain.SelectedIndex = 0;
        }

        private void btnProdSupp_Click(object sender, EventArgs e)
        {
            tabMain.SelectedIndex = 1;
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            tabMain.SelectedIndex = 2;
        }


        private void btnSupplier_Click(object sender, EventArgs e)
        {
            tabMain.SelectedIndex = 3;
        }

        // delete selected products
        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in productsInPackageDataGridView.SelectedRows)
            {
                int rowIndex = productsInPackageDataGridView.CurrentCell.RowIndex;
                productsInPackageDataGridView.Rows.RemoveAt(rowIndex);

            }
        }

        // add product in package
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddProduct addNewProduct = new frmAddProduct(productsInPackageBindingSource);
            addNewProduct.ShowDialog();
        }

        // go back to list
        private void btnBackList_Click(object sender, EventArgs e)
        {
            tabPackageList.SelectTab(0);
        }

        // go to create new package tab
        private void btnNewPackage_Click(object sender, EventArgs e)
        {
            tabPackageList.SelectTab(2);
        }
        private void btnSaveNewPackage_Click(object sender, EventArgs e)
        {

        }
    

        // go to details of selected package on double click
        private void grdProductList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabPackageList.SelectedIndex = 1;

        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            tabPackageList.SelectedIndex = 1;
        }

        private void btnCreate1_Click(object sender, EventArgs e)
        {
            tabPackageList.SelectedIndex = 2;
        }
    }
}



