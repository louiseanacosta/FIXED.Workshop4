

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
            // display all packages in data grid view
            packageBindingSource.DataSource = this.packages;
            grdProductList.Columns[5].DefaultCellStyle.Format = "c";
            grdProductList.Columns[6].DefaultCellStyle.Format = "c";
            grdProductList.Columns[2].DefaultCellStyle.Format = "d";
            grdProductList.Columns[3].DefaultCellStyle.Format = "d";

            // display products included in selected package
            if (cmbPackageId.Text == "") { return; }
            int packageID = Convert.ToInt32(cmbPackageId.Text);

            List<ProductsInPackage> products = ProductsInPackageDB.GetProductsFromPackage(packageID);
            productsInPackageBindingSource.DataSource = products;

            // add products supliers to new package
            List<ProductsInPackage> productsIncluded;
            productsIncluded = ProductsInPackageDB.GetProducts();
            newProductPackageBindingSource.DataSource = products;
        }

        // details view - display list of products included in selected package
        private void packageBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (cmbPackageId.Text == "") { return; }
            int packageID = Convert.ToInt32(cmbPackageId.Text);

            List<ProductsInPackage> products = ProductsInPackageDB.GetProductsFromPackage(packageID);
            productsInPackageBindingSource.DataSource = products;
        }

        // update Package
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // get current package from database
            if (cmbPackageId.Text == "") { return; }

            int packageId = Convert.ToInt32(cmbPackageId.Text);
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
            int packageId = Convert.ToInt32(cmbPackageId.Text);
            List<Package> packageList = PackageDB.GetPackages(packageId);
            Package package = packageList.First();

            // confirm to delete
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

        // create new package
        private void btnSaveNewPackage_Click(object sender, EventArgs e)
        {
            // set new values
            Package newPackage = new Package();
            this.NewPackageData(newPackage);

            // save package
            int packageId = PackageDB.AddPackage(newPackage);


            List<ProductsInPackage> productsInPackages = (List<ProductsInPackage>)newProductPackageBindingSource.DataSource;
            foreach (var productsInPackage in productsInPackages)
            {
                Packages_products_suppliersDB.Add(packageId, productsInPackage.ProductSupplierId);
            }

            MessageBox.Show("New package added succesfully");
            ClearControls();
        }

        // control values for adding new package
        private void NewPackageData(Package package)
        {
            package.PkgName = txtPkgName2.Text;
            package.PkgDesc = txtPkgDesc2.Text;
            package.PkgStartDate = Convert.ToDateTime(txtPkgStart2.Value);
            package.PkgEndDate = Convert.ToDateTime(txtPkgEnd2.Value);
            package.PkgBasePrice = Convert.ToDecimal(txtPkgPrice2.Text);
            package.PkgAgencyCommission = Convert.ToDecimal(txtPkgCommission2.Text);
        }


        // Show Add Product form
        private void btnAddOld_Click(object sender, EventArgs e)
        {
            frmAddProduct addNewProduct = new frmAddProduct(productsInPackageBindingSource);
            addNewProduct.ShowDialog();
        }

        // control values for modifying package
        private void PutPackageData(Package package)
        {
            package.PkgName = txtPkgName.Text;
            package.PkgDesc = txtPkgDesc.Text;
            package.PkgStartDate = Convert.ToDateTime(txtPkgStart.Value);
            package.PkgEndDate = Convert.ToDateTime(txtPkgEnd.Value);
            package.PkgBasePrice = Convert.ToDecimal(txtPkgPrice.Text);
            package.PkgAgencyCommission = Convert.ToDecimal(txtPkgCommission.Text);

        }

        private void ClearControls()
        {
            txtPkgName2.Text = "";
            txtPkgDesc2.Text = "";
            txtPkgPrice2.Text = "";
            txtPkgCommission2.Text = "";

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
            this.packages = PackageDB.GetPackages();
            packageBindingSource.DataSource = this.packages;
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
            frmAddProduct addNewProduct = new frmAddProduct(newProductPackageBindingSource);
            addNewProduct.ShowDialog();
        }

        // go back to list
        private void btnBackList_Click(object sender, EventArgs e)
        {
            tabPackageList.SelectTab(0);
            this.packages = PackageDB.GetPackages();
            packageBindingSource.DataSource = this.packages;
        }

        // go to create new package tab
        private void btnNewPackage_Click(object sender, EventArgs e)
        {
            tabPackageList.SelectTab(2);
        }

    

        // go to details of selected package on double click
        private void grdProductList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabPackageList.SelectedIndex = 1;
            if (cmbPackageId.Text == "") { return; }
            int packageID = Convert.ToInt32(cmbPackageId.Text);

            List<ProductsInPackage> products = ProductsInPackageDB.GetProductsFromPackage(packageID);
            productsInPackageBindingSource.DataSource = products;

        }

        // view detail or modify 
        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            tabPackageList.SelectedIndex = 1;
            if (cmbPackageId.Text == "") { return; }
            int packageID = Convert.ToInt32(cmbPackageId.Text);

            List<ProductsInPackage> products = ProductsInPackageDB.GetProductsFromPackage(packageID);
            productsInPackageBindingSource.DataSource = products;

        }

        private void btnCreate1_Click(object sender, EventArgs e)
        {
            tabPackageList.SelectedIndex = 2;
        }
        //--------------------------- END - LOUISE ACOSTA ------------------------------



        //--------------------------- DongMing Hu -----------------------------------

        // ----- 4 MAIN Nav Buttons -----
        // Nav Btn 1: move to Packages
        private void btnPackages_Click(object sender, EventArgs e)
        {
            tabMain.SelectedIndex = 0;
        }
        // Nav Btn 2: move to Product Supplier
        private void btnProdSupp_Click(object sender, EventArgs e)
        {
            tabMain.SelectedIndex = 1;
            // click ALL btn, change tab index to 0
            twoBtnViewAll_Click(sender, e);
            // tab index changed to 0 (view all), show all data
            twoTab_SelectedIndexChanged(sender, e);
            // databinding for combo boxes
            suppliersBindingSource.DataSource = SuppliersDB.GetSuppliers().OrderBy(s=>s.SupName);
            productsBindingSource.DataSource = ProductsDB.GetProducts();
        }
        // Nav Btn 3: move to Products
        private void btnProducts_Click(object sender, EventArgs e)
        {
            tabMain.SelectedIndex = 2;
            // click ALL btn, change tab index to 0
            threeBtnAll_Click(sender, e);
            // tab index changed to 0 (view all), show all products
            threeTab_SelectedIndexChanged(sender, e);
        }
        // Nav Btn 4: move to Suppliers
        private void btnSupplier_Click(object sender, EventArgs e)
        {
            tabMain.SelectedIndex = 3;
        }


        // ----- 2ND NAV ITEM: Product_Supplier -----
        private List<ProductSupplierWithName> _psList = new List<ProductSupplierWithName>();

        private void twoTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            twoBtnSave.Visible = true;
            if (twoTab.SelectedIndex == 0)
            {
                twoBtnSave.Visible = false;
                // 'ALL' tab, load all Product Supplier data and fill DataSource
                _psList = Products_suppliersDB.GetAllProductSupplierWithNames();
                productSupplierWithNameBindingSource.DataSource = _psList;
            }
            else if(twoTab.SelectedIndex == 2)
            {
                // 'ADD' tab, change add combobox to empty
                twoCmbAddProdName.SelectedIndex = -1;
                twoCmbAddSuppName.SelectedIndex = -1;
            }
            // 'EDIT' tab, show details
        }
        // nav btn ALL, click change color
        private void twoBtnViewAll_Click(object sender, EventArgs e)
        {
            twoTab.SelectedIndex = 0;
            twoBtnViewAll.BackColor = Color.DarkOrange; ;
            twoBtnEdit.BackColor = Color.Transparent;
            twoBtnAdd.BackColor = Color.Transparent;
        }
        // nav btn EDIT
        private void twoBtnEdit_Click(object sender, EventArgs e)
        {
            twoTab.SelectedIndex = 1;
            twoBtnViewAll.BackColor = Color.Transparent; ;
            twoBtnEdit.BackColor = Color.DarkOrange;
            twoBtnAdd.BackColor = Color.Transparent;
        }
        // nav btn ADD
        private void twoBtnAdd_Click(object sender, EventArgs e)
        {
            twoTab.SelectedIndex = 2;
            twoBtnViewAll.BackColor = Color.Transparent; ;
            twoBtnEdit.BackColor = Color.Transparent;
            twoBtnAdd.BackColor = Color.DarkOrange;
        }

        // save btn clicked: update or add new
        private void twoBtnSave_Click(object sender, EventArgs e)
        {
            if (twoTab.SelectedIndex == 1)  // edit mode
            {
                // get the current Product_supplier obj in order to compare with new one
                var currentPS = Products_suppliersDB.GetProductsSuppliers()
                    .SingleOrDefault(ps => ps.ProductSupplierId == Convert.ToInt32(twoTxtProdSuppId.Text));
                // create new Product_supplier obj using user's change
                var newProdSupp = new Products_suppliers
                {
                    ProductId = Convert.ToInt32(twoCmbProdName.SelectedValue),
                    SupplierId = Convert.ToInt32(twoCmbSupName.SelectedValue)
                };
                // compare old and new, see if there is any change
                if (currentPS.ProductId == newProdSupp.ProductId &&
                    currentPS.SupplierId == newProdSupp.SupplierId)
                    // no change, show message
                    MessageBox.Show("No change were found.", "Please make changes");
                else
                {
                    //  have change, try to update database
                    try
                    {
                        var rowsAffected = Products_suppliersDB.UpdateProductSupplier(currentPS, newProdSupp);
                        MessageBox.Show(rowsAffected + " record is successfully updated.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (twoTab.SelectedIndex == 2) // add mode
            {
                // do validation, make sure user select Product and Supplier
                if (twoCmbAddProdName.SelectedIndex < 0 ||
                    twoCmbAddSuppName.SelectedIndex < 0)
                {
                    MessageBox.Show("Required data missing.", "Please choose Product and Supplier");
                    twoCmbAddProdName.SelectedIndex = -1;
                    twoCmbAddSuppName.SelectedIndex = -1;
                    return;
                }

                // create new Product_supplier obj using user's choices
                var newProdSupp = new Products_suppliers
                {
                    ProductId = Convert.ToInt32(twoCmbAddProdName.SelectedValue),
                    SupplierId = Convert.ToInt32(twoCmbAddSuppName.SelectedValue)
                };
                // try to insert new obj
                try
                {
                    var newId = Products_suppliersDB.AddProductSupplier(newProdSupp);
                    MessageBox.Show($"Product Supplier was successfully added, new record id: {newId}.", "Congratulations");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // ----- 3RD NAV ITEM: Products -----
        // nav btn ALL, click change color
        private void threeBtnAll_Click(object sender, EventArgs e)
        {
            threeTab.SelectedIndex = 0;
            threeBtnAll.BackColor = Color.DarkOrange;
            threeBtnEdit.BackColor = Color.Transparent;
            threeBtnAdd.BackColor = Color.Transparent;
        }
        // nav btn EDIT
        private void threeBtnEdit_Click(object sender, EventArgs e)
        {
            threeTab.SelectedIndex = 1;
            threeBtnAll.BackColor = Color.Transparent;
            threeBtnEdit.BackColor = Color.DarkOrange;
            threeBtnAdd.BackColor = Color.Transparent;
        }
        // nav btn ADD
        private void threeBtnAdd_Click(object sender, EventArgs e)
        {
            threeTab.SelectedIndex = 2;
            threeBtnAll.BackColor = Color.Transparent;
            threeBtnEdit.BackColor = Color.Transparent;
            threeBtnAdd.BackColor = Color.DarkOrange;
        }

        private void threeTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            threeBtnSave.Visible = true;
            if (threeTab.SelectedIndex == 0)
            {
                // hide save button when in view all mode
                threeBtnSave.Visible = false;
                // bind data to grid view
                productsBindingSource.DataSource = ProductsDB.GetProducts();
            }
        }

        private void threeBtnSave_Click(object sender, EventArgs e)
        {
            if (threeTab.SelectedIndex == 1) // edit mode
            {
                // get current displaying product obj
                var currentProd = ProductsDB.GetProducts().
                    SingleOrDefault(p=>p.ProductId==Convert.ToInt32(threeTxtEditProdId.Text));
                // initiate new product obj
                Products newProd;
                if (Validator.TBIsEmpty(threeTxtProdName, "Product Name") ||
                    threeTxtProdName.Text == currentProd.ProdName)
                {
                    // name is empty or same as old, do not perform update
                    threeTxtProdName.Text = currentProd.ProdName;
                    threeTxtProdName.SelectAll();
                    return;
                }
                else
                    // name is valid, create new Product obj
                    newProd = new Products{ ProdName = threeTxtProdName.Text };
                // try to perform update
                try
                {
                    Console.WriteLine("Old prod name is: " + currentProd.ProdName);
                    var rowsAffected = ProductsDB.UpdateProduct(currentProd, newProd);
                    MessageBox.Show($"{rowsAffected} record was updated.", "Congratulations");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (threeTab.SelectedIndex == 2) // add mode
            {
                // validate input, check if empty or have same name of an existing product
                if (!Validator.TBIsEmpty(threeTxtAddProdName, "Product Name") &&
                    ProductsDB.GetProducts().Find(p => p.ProdName == threeTxtAddProdName.Text) == null)
                {
                    // validation passed, create new product using user input
                    var newProd = new Products{ ProdName = threeTxtAddProdName.Text};
                    // try to insert into DB
                    try
                    {
                        var id = ProductsDB.AddProduct(newProd);
                        MessageBox.Show($"New product {newProd.ProdName} is added, product id is: {id}.", "Congratulations");
                        threeTxtAddProdName.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void txtSearchPackage_KeyUp(object sender, KeyEventArgs e)
        {
            // get search
            string search = txtSearchPackage.Text.Trim();

            // get products filtered by search
            int packageId = 0;
            List<Package> packages = PackageDB.GetPackages(packageId,search);

            // update binding source
            packageBindingSource.DataSource = packages;
        }



        //--------------------------- END - DongMing Hu ------------------------------

    }
}


