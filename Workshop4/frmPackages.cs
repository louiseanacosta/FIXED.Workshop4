

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
            grdProductList.Columns[2].DefaultCellStyle.Format = "d";
            grdProductList.Columns[3].DefaultCellStyle.Format = "d";
            grdProductList.Columns[5].DefaultCellStyle.Format = "c";
            grdProductList.Columns[6].DefaultCellStyle.Format = "c";


            // add products supliers to new package
            List<ProductsInPackage> productsIncluded;
            productsIncluded = ProductsInPackageDB.GetProducts();
            newProductPackageBindingSource.DataSource = productsIncluded;

            // display products included in selected package
            if (cmbPackageId.Text == "") { return; }
            int packageID = Convert.ToInt32(cmbPackageId.Text);

            List<ProductsInPackage> products = ProductsInPackageDB.GetProductsFromPackage(packageID);
            productsInPackageBindingSource.DataSource = products;


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
            if (IsValidData())
            {
                // get current package from database
                if (cmbPackageId.Text == "") { return; }

                int packageId = Convert.ToInt32(cmbPackageId.Text);
                List<Package> oldPackageList = PackageDB.GetPackages(packageId);
                Package oldPackage = oldPackageList.First();

                // set new values
                Package newPackage = new Package();
                newPackage.PackageId = packageId;
                this.PutPackageData(newPackage);


                // save package
                try
                {
                    package = newPackage;
                    PackageDB.UpdatePackage(oldPackage, newPackage);

                    // get current product suppliers
                    List<int> productSupplierIds = new List<int>();
                    foreach (var product in ProductsInPackageDB.GetProductsFromPackage(packageId))
                    {
                        productSupplierIds.Add(product.ProductSupplierId);
                    }

                    // delete products suppliers linked to package
                    Packages_products_suppliersDB.Delete(packageId);

                    // add products supliers to package
                    List<ProductsInPackage> productsInPackages = (List<ProductsInPackage>)productsInPackageBindingSource.DataSource;
                    foreach (var productsInPackage in productsInPackages)
                    {
                        Packages_products_suppliersDB.Add(packageId, productsInPackage.ProductSupplierId);
                    }

                    MessageBox.Show("Changes saved for Package ID " + packageId);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
                try
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // create new package
        private void btnSaveNewPackage_Click(object sender, EventArgs e)
        {
            if (IsValidDataForCreate())
            {
                try
                {
                    // set new values
                    var test = newProductPackageBindingSource.DataSource;
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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

        // clear textboxes & gridview
        private void ClearControls()
        {
            txtPkgName2.Text = "";
            txtPkgDesc2.Text = "";
            txtPkgPrice2.Text = "";
            txtPkgCommission2.Text = "";
            grdProductsInNewPackage.DataSource = null;

        }

        private bool IsValidData()
        {
            return
                Validator.IsPresent(txtPkgName) &&
                Validator.IsPresent(txtPkgPrice) &&
                Validator.IsNonNegativeDouble(txtPkgPrice) &&
                Validator.IsNonNegativeDouble(txtPkgCommission);
        }

        private bool IsValidDataForCreate()
        {
            return
                Validator.IsPresent(txtPkgName2) &&
                Validator.IsPresent(txtPkgPrice2) &&
                Validator.IsNonNegativeDouble(txtPkgPrice2) &&
                Validator.IsNonNegativeDouble(txtPkgCommission2);
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
            // tab index changed to 0 (view all), show all data
            twoTab_SelectedIndexChanged(sender, e);
            // click ALL btn, change tab index to 0
            twoBtnViewAll_Click(sender, e);
            // databinding for combo boxes
            suppliersBindingSource.DataSource = SuppliersDB.GetSuppliers().OrderBy(s=>s.SupName);
            productsBindingSource.DataSource = ProductsDB.GetProducts();
        }
        // Nav Btn 3: move to Products
        private void btnProducts_Click(object sender, EventArgs e)
        {
            tabMain.SelectedIndex = 2;
            // tab index changed to 0 (view all), show all products
            threeTab_SelectedIndexChanged(sender, e);
            // click ALL btn, change tab index to 0
            threeBtnAll_Click(sender, e);
        }
        // Nav Btn 4: move to Suppliers
        private void btnSupplier_Click(object sender, EventArgs e)
        {
            tabMain.SelectedIndex = 3;
            // tab index changed to 0 (view all), show all suppliers
            fourTab_SelectedIndexChanged(sender, e);
            // click ALL btn, change tab index to 0
            fourBtnAll_Click(sender, e);
        }


        // ----- 2ND NAV ITEM: Product_Supplier -----
        private List<ProductSupplierWithName> _psList = new List<ProductSupplierWithName>();

        // Tab Two Changed (by using ALL, EDIT, ADD btn): change UI appearance accordingly
        private void twoTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            twoBtnViewAll.BackColor = Color.Transparent; ;
            twoBtnEdit.BackColor = Color.Transparent;
            twoBtnAdd.BackColor = Color.Transparent;
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
        }
        // nav btn EDIT
        private void twoBtnEdit_Click(object sender, EventArgs e)
        {
            twoTab.SelectedIndex = 1;
            twoBtnEdit.BackColor = Color.DarkOrange;
        }
        // nav btn ADD
        private void twoBtnAdd_Click(object sender, EventArgs e)
        {
            twoTab.SelectedIndex = 2;
            twoBtnAdd.BackColor = Color.DarkOrange;
        }

        // SAVE btn clicked: update or add new
        private void twoBtnSave_Click(object sender, EventArgs e)
        {
            if (twoTab.SelectedIndex == 1)  // EDIT MODE
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
            else if (twoTab.SelectedIndex == 2) // ADD MODE
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

        // Tab Three Changed (by using ALL, EDIT, ADD btn): change UI appearance accordingly
        private void threeTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            threeBtnSave.Visible = true;
            threeBtnAll.BackColor = Color.Transparent;
            threeBtnEdit.BackColor = Color.Transparent;
            threeBtnAdd.BackColor = Color.Transparent;
            if (threeTab.SelectedIndex == 0)
            {
                // view ALL mode: hide save button
                threeBtnSave.Visible = false;
                // bind data to grid view
                productsBindingSource.DataSource = ProductsDB.GetProducts();
            }
        }
        // nav btn ALL, click change color
        private void threeBtnAll_Click(object sender, EventArgs e)
        {
            threeTab.SelectedIndex = 0;
            threeBtnAll.BackColor = Color.DarkOrange;
        }
        // nav btn EDIT
        private void threeBtnEdit_Click(object sender, EventArgs e)
        {
            threeTab.SelectedIndex = 1;
            threeBtnEdit.BackColor = Color.DarkOrange;
        }
        // nav btn ADD
        private void threeBtnAdd_Click(object sender, EventArgs e)
        {
            threeTab.SelectedIndex = 2;
            threeBtnAdd.BackColor = Color.DarkOrange;
        }
        // btn SAVE: save edit (update) or save add (create)
        private void threeBtnSave_Click(object sender, EventArgs e)
        {
            if (threeTab.SelectedIndex == 1) // EDIT MODE
            {
                // get current displaying product obj
                var currentProd = ProductsDB.GetProducts().
                    SingleOrDefault(p=>p.ProductId==Convert.ToInt32(threeTxtEditProdId.Text));
                // initiate new product obj
                Products newProd;
                // validate: product name is empty or duplicated
                if (Validator.TBIsEmpty(threeTxtEditProdName, "Product Name") ||
                    FindDuplicatedProductName(threeTxtEditProdName.Text))
                {
                    // empty or same, do not perform update
                    threeTxtEditProdName.Text = currentProd.ProdName;
                    threeTxtEditProdName.SelectAll();
                    return;
                }
                else
                    // name is valid, create new Product obj
                    newProd = new Products{ ProdName = threeTxtEditProdName.Text };
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
            else if (threeTab.SelectedIndex == 2) // ADD MODE
            {
                // validate input, check if empty or have duplicated name
                if (!Validator.TBIsEmpty(threeTxtAddProdName, "Product Name") &&
                    !FindDuplicatedProductName(threeTxtAddProdName.Text))
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
        // Convenient Method: find if there is a duplicated product name in DB, return bool
        private bool FindDuplicatedProductName(string productName)
        {
            if (ProductsDB.GetProducts().Find(p => p.ProdName == productName) == null)
                return false;
            else
            {
                MessageBox.Show("The product you input already exists.", "Duplicated Name");
                return true;
            }
        }

        // ----- 4TH NAV ITEM: Suppliers -----
        // Tab Four Changed (by using ALL, EDIT, ADD btn): change UI appearance accordingly
        private void fourTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            fourBtnSave.Visible = true;
            fourBtnAll.BackColor = Color.Transparent;
            fourBtnEdit.BackColor = Color.Transparent;
            fourBtnAdd.BackColor = Color.Transparent;
            if (fourTab.SelectedIndex == 0)
            {
                // view ALL mode: hide save btn
                fourBtnSave.Visible = false;
                // bind data to gridview's binding source
                suppliersBindingSource.DataSource = SuppliersDB.GetSuppliers();
            }
        }
        // nav btn ALL: click change color
        private void fourBtnAll_Click(object sender, EventArgs e)
        {
            fourTab.SelectedIndex = 0;
            fourBtnAll.BackColor = Color.DarkOrange;
        }

        private void fourBtnEdit_Click(object sender, EventArgs e)
        {
            fourTab.SelectedIndex = 1;
            fourBtnEdit.BackColor = Color.DarkOrange;
        }

        private void fourBtnAdd_Click(object sender, EventArgs e)
        {
            fourTab.SelectedIndex = 2;
            fourBtnAdd.BackColor = Color.DarkOrange;
        }

        private void fourBtnSave_Click(object sender, EventArgs e)
        {
            if (fourTab.SelectedIndex == 1)  // EDIT MODE
            {
                // get current Supplier obj
                var currentSupplier = SuppliersDB.GetSuppliers()
                    .Find(s => s.SupplierId == Convert.ToInt32(fourTxtEditSuppId.Text));
                // initialize new Suppliers obj
                Suppliers newSupplier;
                // do validation: no empty name, no duplicated name
                if (Validator.TBIsEmpty(fourTxtEditSuppName, "Supplier Name") ||
                    FindDuplicatedSupplierName(fourTxtEditSuppName.Text))
                {
                    // validation failed, rollback to old name, do nothing
                    fourTxtEditSuppName.Text = currentSupplier.SupName;
                    fourTxtEditSuppName.SelectAll();
                    return;
                }
                else
                    // validation passed, create new Suppliers obj
                    newSupplier = new Suppliers { SupName = fourTxtEditSuppName.Text };

                // try update
                try
                {
                    int rowsAffected = SuppliersDB.UpdateSupplier(currentSupplier, newSupplier);
                    MessageBox.Show($"{rowsAffected} record was successfully updated.", "Congratulations");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Cannot complete update due to error: {ex.Message}.");
                }
            }
            else if (fourTab.SelectedIndex == 2)  // ADD MODE
            {
                // validate input: no empty name, no duplicated name
                if (!Validator.TBIsEmpty(fourTxtAddSuppName, "Supplier Name") &&
                    Validator.TBHasNonNegativeInt(fourTxtAddSuppId, "Supplier Id") &&
                    !FindDuplicatedSupplierName(fourTxtAddSuppName.Text))
                {
                    // validation passed, create new Suppliers obj
                    var newSupplier = new Suppliers
                    {
                        SupName = fourTxtAddSuppName.Text,
                        // PK SuppId is not auto-increment, need to assign an new id
                        SupplierId = Convert.ToInt32(fourTxtAddSuppId.Text)
                    };
                    // try to add to DB
                    try
                    {
                        int id = SuppliersDB.AddSupplier(newSupplier);
                        MessageBox.Show($"New supplier was successfully added, supplier id: {id}.",
                            "Congratulations");
                        fourTxtAddSuppId.Clear();
                        fourTxtAddSuppName.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Cannot add new supplier due to duplicated id. Error detail: {ex.Message}.");
                    }
                }
            }
        }
        // Convenient Method: find if there is a duplicated supplier name in DB, return bool
        private bool FindDuplicatedSupplierName(string supplierName)
        {
            if (SuppliersDB.GetSuppliers().Find(s => s.SupName == supplierName) == null)
                return false;
            else
            {
                MessageBox.Show("The supplier you input already exists.", "Duplicated Name");
                return true;
            }
        }
        // generate id btn clicked: generate a new supplier id, fill in textbox
        private void fourBtnGenerateSuppId_Click(object sender, EventArgs e)
        {
            int newId = SuppliersDB.GetSuppliers().Max(s => s.SupplierId) + 1;
            fourTxtAddSuppId.Text = newId.ToString();
        }


        //--------------------------- END - DongMing Hu ------------------------------

        // ----------- Louise Temp (plz move your code to your zone ↑) ------------------
        // ----------- (very neat search bar, by the way. ヾ(๑╹◡╹)ﾉ" )
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

    }
}


