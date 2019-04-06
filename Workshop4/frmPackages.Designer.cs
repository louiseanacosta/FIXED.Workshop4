namespace Workshop4
{
    partial class frmPackages
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label pkgAgencyCommissionLabel1;
            System.Windows.Forms.Label pkgBasePriceLabel1;
            System.Windows.Forms.Label pkgDescLabel1;
            System.Windows.Forms.Label pkgEndDateLabel1;
            System.Windows.Forms.Label pkgNameLabel1;
            System.Windows.Forms.Label pkgStartDateLabel1;
            System.Windows.Forms.Label packageIdLabel;
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label pkgEndDateLabel;
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label pkgStartDateLabel;
            System.Windows.Forms.Label prodNameLabel;
            System.Windows.Forms.Label productSupplierIdLabel;
            System.Windows.Forms.Label supNameLabel;
            System.Windows.Forms.Label prodNameLabel1;
            System.Windows.Forms.Label supNameLabel1;
            System.Windows.Forms.Label prodNameLabel2;
            System.Windows.Forms.Label productIdLabel;
            System.Windows.Forms.Label label8;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPackages));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnProdSupp = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnPackages = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPackages = new System.Windows.Forms.TabPage();
            this.tabPackageList = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grdProductList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkgNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkgStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkgEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkgDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkgBasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkgAgencyCommissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreate1 = new System.Windows.Forms.Button();
            this.btnViewDetail = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmbPackageId = new System.Windows.Forms.ComboBox();
            this.btnDeletePackage = new System.Windows.Forms.Button();
            this.btnBackList = new System.Windows.Forms.Button();
            this.productsInPackageDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsInPackageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddOld = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtPkgCommission = new System.Windows.Forms.TextBox();
            this.txtPkgPrice = new System.Windows.Forms.TextBox();
            this.txtPkgDesc = new System.Windows.Forms.TextBox();
            this.txtPkgEnd = new System.Windows.Forms.DateTimePicker();
            this.txtPkgName = new System.Windows.Forms.TextBox();
            this.txtPkgStart = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnBackList2 = new System.Windows.Forms.Button();
            this.btnSaveNewPackage = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.productsToAddDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPkgCommission2 = new System.Windows.Forms.TextBox();
            this.txtPkgPrice2 = new System.Windows.Forms.TextBox();
            this.txtPkgDesc2 = new System.Windows.Forms.TextBox();
            this.txtPkgEnd2 = new System.Windows.Forms.DateTimePicker();
            this.txtPkgName2 = new System.Windows.Forms.TextBox();
            this.txtPkgStart2 = new System.Windows.Forms.DateTimePicker();
            this.tabProdSupp = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.twoBtnViewAll = new System.Windows.Forms.Button();
            this.twoBtnEdit = new System.Windows.Forms.Button();
            this.twoBtnAdd = new System.Windows.Forms.Button();
            this.twoBtnSave = new System.Windows.Forms.Button();
            this.twoTab = new System.Windows.Forms.TabControl();
            this.twoTabAll = new System.Windows.Forms.TabPage();
            this.twoGrdAll = new System.Windows.Forms.DataGridView();
            this.productSupplierWithNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.twoTabEdit = new System.Windows.Forms.TabPage();
            this.twoCmbProdName = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.twoTxtProdSuppId = new System.Windows.Forms.TextBox();
            this.twoCmbSupName = new System.Windows.Forms.ComboBox();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.twoTabAdd = new System.Windows.Forms.TabPage();
            this.twoCmbAddProdName = new System.Windows.Forms.ComboBox();
            this.twoCmbAddSuppName = new System.Windows.Forms.ComboBox();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.threeTab = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.threeTxtProdName = new System.Windows.Forms.TextBox();
            this.threeTxtEditProdId = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.threeTxtAddProdName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.threeBtnAll = new System.Windows.Forms.Button();
            this.threeBtnEdit = new System.Windows.Forms.Button();
            this.threeBtnAdd = new System.Windows.Forms.Button();
            this.threeBtnSave = new System.Windows.Forms.Button();
            this.tabSupplier = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            pkgAgencyCommissionLabel1 = new System.Windows.Forms.Label();
            pkgBasePriceLabel1 = new System.Windows.Forms.Label();
            pkgDescLabel1 = new System.Windows.Forms.Label();
            pkgEndDateLabel1 = new System.Windows.Forms.Label();
            pkgNameLabel1 = new System.Windows.Forms.Label();
            pkgStartDateLabel1 = new System.Windows.Forms.Label();
            packageIdLabel = new System.Windows.Forms.Label();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            prodNameLabel = new System.Windows.Forms.Label();
            productSupplierIdLabel = new System.Windows.Forms.Label();
            supNameLabel = new System.Windows.Forms.Label();
            prodNameLabel1 = new System.Windows.Forms.Label();
            supNameLabel1 = new System.Windows.Forms.Label();
            prodNameLabel2 = new System.Windows.Forms.Label();
            productIdLabel = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPackages.SuspendLayout();
            this.tabPackageList.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsInPackageDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsInPackageBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsToAddDataGridView)).BeginInit();
            this.tabProdSupp.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.twoTab.SuspendLayout();
            this.twoTabAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.twoGrdAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierWithNameBindingSource)).BeginInit();
            this.twoTabEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            this.twoTabAdd.SuspendLayout();
            this.tabProducts.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.threeTab.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pkgAgencyCommissionLabel1
            // 
            pkgAgencyCommissionLabel1.AutoSize = true;
            pkgAgencyCommissionLabel1.Location = new System.Drawing.Point(19, 208);
            pkgAgencyCommissionLabel1.Name = "pkgAgencyCommissionLabel1";
            pkgAgencyCommissionLabel1.Size = new System.Drawing.Size(160, 20);
            pkgAgencyCommissionLabel1.TabIndex = 2;
            pkgAgencyCommissionLabel1.Text = "Agency Commission:";
            // 
            // pkgBasePriceLabel1
            // 
            pkgBasePriceLabel1.AutoSize = true;
            pkgBasePriceLabel1.Location = new System.Drawing.Point(19, 175);
            pkgBasePriceLabel1.Name = "pkgBasePriceLabel1";
            pkgBasePriceLabel1.Size = new System.Drawing.Size(89, 20);
            pkgBasePriceLabel1.TabIndex = 4;
            pkgBasePriceLabel1.Text = "Base Price:";
            // 
            // pkgDescLabel1
            // 
            pkgDescLabel1.AutoSize = true;
            pkgDescLabel1.Location = new System.Drawing.Point(19, 85);
            pkgDescLabel1.Name = "pkgDescLabel1";
            pkgDescLabel1.Size = new System.Drawing.Size(95, 20);
            pkgDescLabel1.TabIndex = 6;
            pkgDescLabel1.Text = "Description:";
            // 
            // pkgEndDateLabel1
            // 
            pkgEndDateLabel1.AutoSize = true;
            pkgEndDateLabel1.Location = new System.Drawing.Point(19, 146);
            pkgEndDateLabel1.Name = "pkgEndDateLabel1";
            pkgEndDateLabel1.Size = new System.Drawing.Size(80, 20);
            pkgEndDateLabel1.TabIndex = 8;
            pkgEndDateLabel1.Text = "End Date:";
            // 
            // pkgNameLabel1
            // 
            pkgNameLabel1.AutoSize = true;
            pkgNameLabel1.Location = new System.Drawing.Point(19, 55);
            pkgNameLabel1.Name = "pkgNameLabel1";
            pkgNameLabel1.Size = new System.Drawing.Size(57, 20);
            pkgNameLabel1.TabIndex = 10;
            pkgNameLabel1.Text = "Name:";
            // 
            // pkgStartDateLabel1
            // 
            pkgStartDateLabel1.AutoSize = true;
            pkgStartDateLabel1.Location = new System.Drawing.Point(19, 116);
            pkgStartDateLabel1.Name = "pkgStartDateLabel1";
            pkgStartDateLabel1.Size = new System.Drawing.Size(85, 20);
            pkgStartDateLabel1.TabIndex = 12;
            pkgStartDateLabel1.Text = "Start Date:";
            // 
            // packageIdLabel
            // 
            packageIdLabel.AutoSize = true;
            packageIdLabel.Location = new System.Drawing.Point(15, 95);
            packageIdLabel.Name = "packageIdLabel";
            packageIdLabel.Size = new System.Drawing.Size(100, 20);
            packageIdLabel.TabIndex = 15;
            packageIdLabel.Text = "Package ID:";
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(15, 279);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(160, 20);
            pkgAgencyCommissionLabel.TabIndex = 17;
            pkgAgencyCommissionLabel.Text = "Agency Commission:";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Location = new System.Drawing.Point(15, 249);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(89, 20);
            pkgBasePriceLabel.TabIndex = 19;
            pkgBasePriceLabel.Text = "Base Price:";
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Location = new System.Drawing.Point(15, 158);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(95, 20);
            pkgDescLabel.TabIndex = 21;
            pkgDescLabel.Text = "Description:";
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.Location = new System.Drawing.Point(15, 220);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(80, 20);
            pkgEndDateLabel.TabIndex = 23;
            pkgEndDateLabel.Text = "End Date:";
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Location = new System.Drawing.Point(15, 127);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(57, 20);
            pkgNameLabel.TabIndex = 25;
            pkgNameLabel.Text = "Name:";
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.Location = new System.Drawing.Point(15, 191);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(85, 20);
            pkgStartDateLabel.TabIndex = 27;
            pkgStartDateLabel.Text = "Start Date:";
            // 
            // prodNameLabel
            // 
            prodNameLabel.AutoSize = true;
            prodNameLabel.Location = new System.Drawing.Point(112, 75);
            prodNameLabel.Name = "prodNameLabel";
            prodNameLabel.Size = new System.Drawing.Size(71, 20);
            prodNameLabel.TabIndex = 0;
            prodNameLabel.Text = "Product:";
            // 
            // productSupplierIdLabel
            // 
            productSupplierIdLabel.AutoSize = true;
            productSupplierIdLabel.Location = new System.Drawing.Point(32, 24);
            productSupplierIdLabel.Name = "productSupplierIdLabel";
            productSupplierIdLabel.Size = new System.Drawing.Size(151, 20);
            productSupplierIdLabel.TabIndex = 2;
            productSupplierIdLabel.Text = "Product Supplier Id:";
            // 
            // supNameLabel
            // 
            supNameLabel.AutoSize = true;
            supNameLabel.Location = new System.Drawing.Point(113, 126);
            supNameLabel.Name = "supNameLabel";
            supNameLabel.Size = new System.Drawing.Size(70, 20);
            supNameLabel.TabIndex = 4;
            supNameLabel.Text = "Supplier:";
            // 
            // prodNameLabel1
            // 
            prodNameLabel1.AutoSize = true;
            prodNameLabel1.Location = new System.Drawing.Point(79, 38);
            prodNameLabel1.Name = "prodNameLabel1";
            prodNameLabel1.Size = new System.Drawing.Size(71, 20);
            prodNameLabel1.TabIndex = 0;
            prodNameLabel1.Text = "Product:";
            // 
            // supNameLabel1
            // 
            supNameLabel1.AutoSize = true;
            supNameLabel1.Location = new System.Drawing.Point(79, 90);
            supNameLabel1.Name = "supNameLabel1";
            supNameLabel1.Size = new System.Drawing.Size(70, 20);
            supNameLabel1.TabIndex = 4;
            supNameLabel1.Text = "Supplier:";
            // 
            // prodNameLabel2
            // 
            prodNameLabel2.AutoSize = true;
            prodNameLabel2.Location = new System.Drawing.Point(60, 62);
            prodNameLabel2.Name = "prodNameLabel2";
            prodNameLabel2.Size = new System.Drawing.Size(95, 20);
            prodNameLabel2.TabIndex = 0;
            prodNameLabel2.Text = "Prod Name:";
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Location = new System.Drawing.Point(60, 20);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new System.Drawing.Size(90, 20);
            productIdLabel.TabIndex = 2;
            productIdLabel.Text = "Product Id:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(76, 38);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(95, 20);
            label8.TabIndex = 2;
            label8.Text = "Prod Name:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.btnProdSupp);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.btnSupplier);
            this.splitContainer1.Panel1.Controls.Add(this.btnPackages);
            this.splitContainer1.Panel1.Controls.Add(this.btnProducts);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.Black;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.tabMain);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1480, 594);
            this.splitContainer1.SplitterDistance = 178;
            this.splitContainer1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 45);
            this.label5.TabIndex = 12;
            this.label5.Text = "PRODUCT SUPPLIER";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Ivory;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(43, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 66);
            this.button1.TabIndex = 1;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnProdSupp
            // 
            this.btnProdSupp.BackgroundImage = global::Workshop4.Properties.Resources.hot_air_balloon;
            this.btnProdSupp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProdSupp.FlatAppearance.BorderSize = 0;
            this.btnProdSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdSupp.ForeColor = System.Drawing.Color.Ivory;
            this.btnProdSupp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProdSupp.Location = new System.Drawing.Point(12, 207);
            this.btnProdSupp.Name = "btnProdSupp";
            this.btnProdSupp.Size = new System.Drawing.Size(149, 89);
            this.btnProdSupp.TabIndex = 11;
            this.btnProdSupp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProdSupp.UseVisualStyleBackColor = true;
            this.btnProdSupp.Click += new System.EventHandler(this.btnProdSupp_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(47, 563);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "SUPPLIER";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(39, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "PACKAGES";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "PRODUCTS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackgroundImage = global::Workshop4.Properties.Resources.enterprise;
            this.btnSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.ForeColor = System.Drawing.Color.Ivory;
            this.btnSupplier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSupplier.Location = new System.Drawing.Point(12, 469);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(149, 89);
            this.btnSupplier.TabIndex = 3;
            this.btnSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnPackages
            // 
            this.btnPackages.BackgroundImage = global::Workshop4.Properties.Resources.donation;
            this.btnPackages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPackages.FlatAppearance.BorderSize = 0;
            this.btnPackages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPackages.ForeColor = System.Drawing.Color.Ivory;
            this.btnPackages.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPackages.Location = new System.Drawing.Point(16, 99);
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.Size = new System.Drawing.Size(133, 70);
            this.btnPackages.TabIndex = 5;
            this.btnPackages.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPackages.UseVisualStyleBackColor = true;
            this.btnPackages.Click += new System.EventHandler(this.btnPackages_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackgroundImage = global::Workshop4.Properties.Resources.supplies;
            this.btnProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.ForeColor = System.Drawing.Color.Ivory;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProducts.Location = new System.Drawing.Point(15, 352);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(149, 89);
            this.btnProducts.TabIndex = 6;
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRAVEL EXPERTS";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPackages);
            this.tabMain.Controls.Add(this.tabProdSupp);
            this.tabMain.Controls.Add(this.tabProducts);
            this.tabMain.Controls.Add(this.tabSupplier);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 44);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1298, 550);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabMain.TabIndex = 2;
            // 
            // tabPackages
            // 
            this.tabPackages.Controls.Add(this.tabPackageList);
            this.tabPackages.Location = new System.Drawing.Point(4, 28);
            this.tabPackages.Name = "tabPackages";
            this.tabPackages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPackages.Size = new System.Drawing.Size(1290, 518);
            this.tabPackages.TabIndex = 0;
            this.tabPackages.Text = "PACKAGES";
            this.tabPackages.UseVisualStyleBackColor = true;
            // 
            // tabPackageList
            // 
            this.tabPackageList.Controls.Add(this.tabPage1);
            this.tabPackageList.Controls.Add(this.tabPage2);
            this.tabPackageList.Controls.Add(this.tabPage3);
            this.tabPackageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPackageList.Location = new System.Drawing.Point(3, 3);
            this.tabPackageList.Name = "tabPackageList";
            this.tabPackageList.SelectedIndex = 0;
            this.tabPackageList.Size = new System.Drawing.Size(1284, 512);
            this.tabPackageList.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabPackageList.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1276, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grdProductList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1270, 474);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grdProductList
            // 
            this.grdProductList.AllowUserToAddRows = false;
            this.grdProductList.AllowUserToDeleteRows = false;
            this.grdProductList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.grdProductList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdProductList.AutoGenerateColumns = false;
            this.grdProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProductList.BackgroundColor = System.Drawing.Color.White;
            this.grdProductList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdProductList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdProductList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.pkgNameDataGridViewTextBoxColumn,
            this.pkgStartDateDataGridViewTextBoxColumn,
            this.pkgEndDateDataGridViewTextBoxColumn,
            this.pkgDescDataGridViewTextBoxColumn,
            this.pkgBasePriceDataGridViewTextBoxColumn,
            this.pkgAgencyCommissionDataGridViewTextBoxColumn});
            this.grdProductList.DataSource = this.packageBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdProductList.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProductList.EnableHeadersVisualStyles = false;
            this.grdProductList.Location = new System.Drawing.Point(3, 39);
            this.grdProductList.Name = "grdProductList";
            this.grdProductList.ReadOnly = true;
            this.grdProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProductList.Size = new System.Drawing.Size(1264, 432);
            this.grdProductList.TabIndex = 33;
            this.grdProductList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProductList_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "PackageId";
            this.Column1.FillWeight = 34.32074F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 48;
            // 
            // pkgNameDataGridViewTextBoxColumn
            // 
            this.pkgNameDataGridViewTextBoxColumn.DataPropertyName = "PkgName";
            this.pkgNameDataGridViewTextBoxColumn.FillWeight = 63.9096F;
            this.pkgNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.pkgNameDataGridViewTextBoxColumn.Name = "pkgNameDataGridViewTextBoxColumn";
            this.pkgNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pkgStartDateDataGridViewTextBoxColumn
            // 
            this.pkgStartDateDataGridViewTextBoxColumn.DataPropertyName = "PkgStartDate";
            this.pkgStartDateDataGridViewTextBoxColumn.FillWeight = 88.97629F;
            this.pkgStartDateDataGridViewTextBoxColumn.HeaderText = "Start Date";
            this.pkgStartDateDataGridViewTextBoxColumn.Name = "pkgStartDateDataGridViewTextBoxColumn";
            this.pkgStartDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pkgEndDateDataGridViewTextBoxColumn
            // 
            this.pkgEndDateDataGridViewTextBoxColumn.DataPropertyName = "PkgEndDate";
            this.pkgEndDateDataGridViewTextBoxColumn.FillWeight = 91.60652F;
            this.pkgEndDateDataGridViewTextBoxColumn.HeaderText = "End Date";
            this.pkgEndDateDataGridViewTextBoxColumn.Name = "pkgEndDateDataGridViewTextBoxColumn";
            this.pkgEndDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pkgDescDataGridViewTextBoxColumn
            // 
            this.pkgDescDataGridViewTextBoxColumn.DataPropertyName = "PkgDesc";
            this.pkgDescDataGridViewTextBoxColumn.FillWeight = 122.4418F;
            this.pkgDescDataGridViewTextBoxColumn.HeaderText = "Description";
            this.pkgDescDataGridViewTextBoxColumn.Name = "pkgDescDataGridViewTextBoxColumn";
            this.pkgDescDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pkgBasePriceDataGridViewTextBoxColumn
            // 
            this.pkgBasePriceDataGridViewTextBoxColumn.DataPropertyName = "PkgBasePrice";
            this.pkgBasePriceDataGridViewTextBoxColumn.FillWeight = 109.884F;
            this.pkgBasePriceDataGridViewTextBoxColumn.HeaderText = "Base Price";
            this.pkgBasePriceDataGridViewTextBoxColumn.Name = "pkgBasePriceDataGridViewTextBoxColumn";
            this.pkgBasePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pkgAgencyCommissionDataGridViewTextBoxColumn
            // 
            this.pkgAgencyCommissionDataGridViewTextBoxColumn.DataPropertyName = "PkgAgencyCommission";
            this.pkgAgencyCommissionDataGridViewTextBoxColumn.FillWeight = 188.861F;
            this.pkgAgencyCommissionDataGridViewTextBoxColumn.HeaderText = "Agency Commission";
            this.pkgAgencyCommissionDataGridViewTextBoxColumn.Name = "pkgAgencyCommissionDataGridViewTextBoxColumn";
            this.pkgAgencyCommissionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(Travel_Experts.Package);
            this.packageBindingSource.CurrentChanged += new System.EventHandler(this.packageBindingSource_CurrentChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnCreate1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnViewDetail, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(280, 30);
            this.tableLayoutPanel2.TabIndex = 34;
            // 
            // btnCreate1
            // 
            this.btnCreate1.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCreate1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnCreate1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate1.ForeColor = System.Drawing.Color.White;
            this.btnCreate1.Location = new System.Drawing.Point(3, 3);
            this.btnCreate1.Name = "btnCreate1";
            this.btnCreate1.Size = new System.Drawing.Size(134, 28);
            this.btnCreate1.TabIndex = 34;
            this.btnCreate1.Text = "&Create New";
            this.btnCreate1.UseVisualStyleBackColor = false;
            this.btnCreate1.Click += new System.EventHandler(this.btnCreate1_Click);
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.BackColor = System.Drawing.Color.DarkCyan;
            this.btnViewDetail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnViewDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetail.ForeColor = System.Drawing.Color.White;
            this.btnViewDetail.Location = new System.Drawing.Point(143, 3);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(134, 28);
            this.btnViewDetail.TabIndex = 34;
            this.btnViewDetail.Text = "&View Detail";
            this.btnViewDetail.UseVisualStyleBackColor = false;
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.bindingNavigator1);
            this.tabPage2.Controls.Add(this.cmbPackageId);
            this.tabPage2.Controls.Add(this.btnDeletePackage);
            this.tabPage2.Controls.Add(this.btnBackList);
            this.tabPage2.Controls.Add(this.productsInPackageDataGridView);
            this.tabPage2.Controls.Add(this.btnAddOld);
            this.tabPage2.Controls.Add(this.btnCreate);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(packageIdLabel);
            this.tabPage2.Controls.Add(pkgAgencyCommissionLabel);
            this.tabPage2.Controls.Add(this.txtPkgCommission);
            this.tabPage2.Controls.Add(pkgBasePriceLabel);
            this.tabPage2.Controls.Add(this.txtPkgPrice);
            this.tabPage2.Controls.Add(pkgDescLabel);
            this.tabPage2.Controls.Add(this.txtPkgDesc);
            this.tabPage2.Controls.Add(pkgEndDateLabel);
            this.tabPage2.Controls.Add(this.txtPkgEnd);
            this.tabPage2.Controls.Add(pkgNameLabel);
            this.tabPage2.Controls.Add(this.txtPkgName);
            this.tabPage2.Controls.Add(pkgStartDateLabel);
            this.tabPage2.Controls.Add(this.txtPkgStart);
            this.tabPage2.Controls.Add(this.btnUpdate);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1276, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.packageBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1253, 25);
            this.bindingNavigator1.TabIndex = 38;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cmbPackageId
            // 
            this.cmbPackageId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPackageId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPackageId.DataSource = this.packageBindingSource;
            this.cmbPackageId.DisplayMember = "PackageId";
            this.cmbPackageId.FormattingEnabled = true;
            this.cmbPackageId.Location = new System.Drawing.Point(206, 88);
            this.cmbPackageId.Name = "cmbPackageId";
            this.cmbPackageId.Size = new System.Drawing.Size(121, 27);
            this.cmbPackageId.TabIndex = 37;
            this.cmbPackageId.ValueMember = "PackageId";
            // 
            // btnDeletePackage
            // 
            this.btnDeletePackage.BackColor = System.Drawing.Color.White;
            this.btnDeletePackage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDeletePackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePackage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePackage.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnDeletePackage.Location = new System.Drawing.Point(161, 48);
            this.btnDeletePackage.Name = "btnDeletePackage";
            this.btnDeletePackage.Size = new System.Drawing.Size(153, 28);
            this.btnDeletePackage.TabIndex = 36;
            this.btnDeletePackage.Text = "&Delete Package";
            this.btnDeletePackage.UseVisualStyleBackColor = false;
            this.btnDeletePackage.Click += new System.EventHandler(this.btnDeletePackage_Click);
            // 
            // btnBackList
            // 
            this.btnBackList.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBackList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnBackList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackList.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackList.ForeColor = System.Drawing.Color.White;
            this.btnBackList.Location = new System.Drawing.Point(602, 46);
            this.btnBackList.Name = "btnBackList";
            this.btnBackList.Size = new System.Drawing.Size(117, 30);
            this.btnBackList.TabIndex = 35;
            this.btnBackList.Text = "&Back To List";
            this.btnBackList.UseVisualStyleBackColor = false;
            this.btnBackList.Click += new System.EventHandler(this.btnBackList_Click);
            // 
            // productsInPackageDataGridView
            // 
            this.productsInPackageDataGridView.AllowUserToAddRows = false;
            this.productsInPackageDataGridView.AllowUserToDeleteRows = false;
            this.productsInPackageDataGridView.AutoGenerateColumns = false;
            this.productsInPackageDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsInPackageDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productsInPackageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsInPackageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.productsInPackageDataGridView.DataSource = this.productsInPackageBindingSource;
            this.productsInPackageDataGridView.Location = new System.Drawing.Point(17, 342);
            this.productsInPackageDataGridView.Name = "productsInPackageDataGridView";
            this.productsInPackageDataGridView.ReadOnly = true;
            this.productsInPackageDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsInPackageDataGridView.Size = new System.Drawing.Size(598, 188);
            this.productsInPackageDataGridView.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductSupplierId";
            this.dataGridViewTextBoxColumn1.FillWeight = 30F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProdName";
            this.dataGridViewTextBoxColumn2.FillWeight = 50F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Product";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SupName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Supplier";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // productsInPackageBindingSource
            // 
            this.productsInPackageBindingSource.DataSource = typeof(Travel_Experts.ProductsInPackage);
            // 
            // btnAddOld
            // 
            this.btnAddOld.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAddOld.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddOld.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOld.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOld.ForeColor = System.Drawing.Color.White;
            this.btnAddOld.Location = new System.Drawing.Point(635, 342);
            this.btnAddOld.Name = "btnAddOld";
            this.btnAddOld.Size = new System.Drawing.Size(84, 32);
            this.btnAddOld.TabIndex = 33;
            this.btnAddOld.Text = "&Add";
            this.btnAddOld.UseVisualStyleBackColor = false;
            this.btnAddOld.Click += new System.EventHandler(this.btnAddOld_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(320, 48);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(136, 28);
            this.btnCreate.TabIndex = 31;
            this.btnCreate.Text = "&Create New";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Products:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnDelete.Location = new System.Drawing.Point(635, 380);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 32);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtPkgCommission
            // 
            this.txtPkgCommission.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgAgencyCommission", true));
            this.txtPkgCommission.Location = new System.Drawing.Point(206, 277);
            this.txtPkgCommission.Name = "txtPkgCommission";
            this.txtPkgCommission.Size = new System.Drawing.Size(174, 25);
            this.txtPkgCommission.TabIndex = 18;
            // 
            // txtPkgPrice
            // 
            this.txtPkgPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgBasePrice", true));
            this.txtPkgPrice.Location = new System.Drawing.Point(206, 246);
            this.txtPkgPrice.Name = "txtPkgPrice";
            this.txtPkgPrice.Size = new System.Drawing.Size(174, 25);
            this.txtPkgPrice.TabIndex = 20;
            // 
            // txtPkgDesc
            // 
            this.txtPkgDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgDesc", true));
            this.txtPkgDesc.Location = new System.Drawing.Point(206, 155);
            this.txtPkgDesc.Name = "txtPkgDesc";
            this.txtPkgDesc.Size = new System.Drawing.Size(409, 25);
            this.txtPkgDesc.TabIndex = 22;
            // 
            // txtPkgEnd
            // 
            this.txtPkgEnd.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgEndDate", true));
            this.txtPkgEnd.Location = new System.Drawing.Point(206, 216);
            this.txtPkgEnd.Name = "txtPkgEnd";
            this.txtPkgEnd.Size = new System.Drawing.Size(174, 25);
            this.txtPkgEnd.TabIndex = 24;
            // 
            // txtPkgName
            // 
            this.txtPkgName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgName", true));
            this.txtPkgName.Location = new System.Drawing.Point(206, 124);
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.Size = new System.Drawing.Size(409, 25);
            this.txtPkgName.TabIndex = 26;
            // 
            // txtPkgStart
            // 
            this.txtPkgStart.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgStartDate", true));
            this.txtPkgStart.Location = new System.Drawing.Point(206, 187);
            this.txtPkgStart.Name = "txtPkgStart";
            this.txtPkgStart.Size = new System.Drawing.Size(174, 25);
            this.txtPkgStart.TabIndex = 28;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkCyan;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(19, 48);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 28);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "&Save Package";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.btnBackList2);
            this.tabPage3.Controls.Add(this.btnSaveNewPackage);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.btnAddNew);
            this.tabPage3.Controls.Add(this.productsToAddDataGridView);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(pkgAgencyCommissionLabel1);
            this.tabPage3.Controls.Add(this.txtPkgCommission2);
            this.tabPage3.Controls.Add(pkgBasePriceLabel1);
            this.tabPage3.Controls.Add(this.txtPkgPrice2);
            this.tabPage3.Controls.Add(pkgDescLabel1);
            this.tabPage3.Controls.Add(this.txtPkgDesc2);
            this.tabPage3.Controls.Add(pkgEndDateLabel1);
            this.tabPage3.Controls.Add(this.txtPkgEnd2);
            this.tabPage3.Controls.Add(pkgNameLabel1);
            this.tabPage3.Controls.Add(this.txtPkgName2);
            this.tabPage3.Controls.Add(pkgStartDateLabel1);
            this.tabPage3.Controls.Add(this.txtPkgStart2);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1276, 480);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Create New";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnBackList2
            // 
            this.btnBackList2.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBackList2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnBackList2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackList2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackList2.ForeColor = System.Drawing.Color.White;
            this.btnBackList2.Location = new System.Drawing.Point(612, 15);
            this.btnBackList2.Name = "btnBackList2";
            this.btnBackList2.Size = new System.Drawing.Size(101, 28);
            this.btnBackList2.TabIndex = 37;
            this.btnBackList2.Text = "&Back To List";
            this.btnBackList2.UseVisualStyleBackColor = false;
            this.btnBackList2.Click += new System.EventHandler(this.btnBackList2_Click);
            // 
            // btnSaveNewPackage
            // 
            this.btnSaveNewPackage.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSaveNewPackage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveNewPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNewPackage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewPackage.ForeColor = System.Drawing.Color.White;
            this.btnSaveNewPackage.Location = new System.Drawing.Point(23, 15);
            this.btnSaveNewPackage.Name = "btnSaveNewPackage";
            this.btnSaveNewPackage.Size = new System.Drawing.Size(130, 28);
            this.btnSaveNewPackage.TabIndex = 36;
            this.btnSaveNewPackage.Text = "&Create New";
            this.btnSaveNewPackage.UseVisualStyleBackColor = false;
            this.btnSaveNewPackage.Click += new System.EventHandler(this.btnSaveNewPackage_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.DarkCyan;
            this.button5.Location = new System.Drawing.Point(629, 317);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 32);
            this.button5.TabIndex = 35;
            this.button5.Text = "&Delete";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAddNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(629, 279);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(84, 32);
            this.btnAddNew.TabIndex = 34;
            this.btnAddNew.Text = "&Add";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // productsToAddDataGridView
            // 
            this.productsToAddDataGridView.AllowUserToAddRows = false;
            this.productsToAddDataGridView.AllowUserToDeleteRows = false;
            this.productsToAddDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productsToAddDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsToAddDataGridView.Location = new System.Drawing.Point(23, 279);
            this.productsToAddDataGridView.Name = "productsToAddDataGridView";
            this.productsToAddDataGridView.ReadOnly = true;
            this.productsToAddDataGridView.Size = new System.Drawing.Size(577, 201);
            this.productsToAddDataGridView.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Products:";
            // 
            // txtPkgCommission2
            // 
            this.txtPkgCommission2.Location = new System.Drawing.Point(211, 205);
            this.txtPkgCommission2.Name = "txtPkgCommission2";
            this.txtPkgCommission2.Size = new System.Drawing.Size(184, 25);
            this.txtPkgCommission2.TabIndex = 3;
            // 
            // txtPkgPrice2
            // 
            this.txtPkgPrice2.Location = new System.Drawing.Point(211, 172);
            this.txtPkgPrice2.Name = "txtPkgPrice2";
            this.txtPkgPrice2.Size = new System.Drawing.Size(184, 25);
            this.txtPkgPrice2.TabIndex = 5;
            // 
            // txtPkgDesc2
            // 
            this.txtPkgDesc2.Location = new System.Drawing.Point(211, 82);
            this.txtPkgDesc2.Name = "txtPkgDesc2";
            this.txtPkgDesc2.Size = new System.Drawing.Size(389, 25);
            this.txtPkgDesc2.TabIndex = 7;
            // 
            // txtPkgEnd2
            // 
            this.txtPkgEnd2.Location = new System.Drawing.Point(211, 142);
            this.txtPkgEnd2.Name = "txtPkgEnd2";
            this.txtPkgEnd2.Size = new System.Drawing.Size(184, 25);
            this.txtPkgEnd2.TabIndex = 9;
            // 
            // txtPkgName2
            // 
            this.txtPkgName2.Location = new System.Drawing.Point(211, 52);
            this.txtPkgName2.Name = "txtPkgName2";
            this.txtPkgName2.Size = new System.Drawing.Size(389, 25);
            this.txtPkgName2.TabIndex = 11;
            // 
            // txtPkgStart2
            // 
            this.txtPkgStart2.Location = new System.Drawing.Point(211, 112);
            this.txtPkgStart2.Name = "txtPkgStart2";
            this.txtPkgStart2.Size = new System.Drawing.Size(184, 25);
            this.txtPkgStart2.TabIndex = 13;
            // 
            // tabProdSupp
            // 
            this.tabProdSupp.Controls.Add(this.tableLayoutPanel3);
            this.tabProdSupp.Location = new System.Drawing.Point(4, 22);
            this.tabProdSupp.Name = "tabProdSupp";
            this.tabProdSupp.Padding = new System.Windows.Forms.Padding(3);
            this.tabProdSupp.Size = new System.Drawing.Size(1290, 524);
            this.tabProdSupp.TabIndex = 1;
            this.tabProdSupp.Text = "PROD | SUPP";
            this.tabProdSupp.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.twoTab, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1284, 518);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel4.Controls.Add(this.twoBtnViewAll, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.twoBtnEdit, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.twoBtnAdd, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.twoBtnSave, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(330, 34);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // twoBtnViewAll
            // 
            this.twoBtnViewAll.AutoSize = true;
            this.twoBtnViewAll.Location = new System.Drawing.Point(3, 3);
            this.twoBtnViewAll.Name = "twoBtnViewAll";
            this.twoBtnViewAll.Size = new System.Drawing.Size(78, 28);
            this.twoBtnViewAll.TabIndex = 0;
            this.twoBtnViewAll.Text = "ALL";
            this.twoBtnViewAll.UseVisualStyleBackColor = true;
            this.twoBtnViewAll.Click += new System.EventHandler(this.twoBtnViewAll_Click);
            // 
            // twoBtnEdit
            // 
            this.twoBtnEdit.AutoSize = true;
            this.twoBtnEdit.Location = new System.Drawing.Point(87, 3);
            this.twoBtnEdit.Name = "twoBtnEdit";
            this.twoBtnEdit.Size = new System.Drawing.Size(75, 28);
            this.twoBtnEdit.TabIndex = 0;
            this.twoBtnEdit.Text = "EDIT";
            this.twoBtnEdit.UseVisualStyleBackColor = true;
            this.twoBtnEdit.Click += new System.EventHandler(this.twoBtnEdit_Click);
            // 
            // twoBtnAdd
            // 
            this.twoBtnAdd.AutoSize = true;
            this.twoBtnAdd.Location = new System.Drawing.Point(168, 3);
            this.twoBtnAdd.Name = "twoBtnAdd";
            this.twoBtnAdd.Size = new System.Drawing.Size(75, 28);
            this.twoBtnAdd.TabIndex = 0;
            this.twoBtnAdd.Text = "ADD";
            this.twoBtnAdd.UseVisualStyleBackColor = true;
            this.twoBtnAdd.Click += new System.EventHandler(this.twoBtnAdd_Click);
            // 
            // twoBtnSave
            // 
            this.twoBtnSave.AutoSize = true;
            this.twoBtnSave.Location = new System.Drawing.Point(249, 3);
            this.twoBtnSave.Name = "twoBtnSave";
            this.twoBtnSave.Size = new System.Drawing.Size(75, 28);
            this.twoBtnSave.TabIndex = 0;
            this.twoBtnSave.Text = "SAVE";
            this.twoBtnSave.UseVisualStyleBackColor = true;
            this.twoBtnSave.Visible = false;
            this.twoBtnSave.Click += new System.EventHandler(this.twoBtnSave_Click);
            // 
            // twoTab
            // 
            this.twoTab.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.twoTab.Controls.Add(this.twoTabAll);
            this.twoTab.Controls.Add(this.twoTabEdit);
            this.twoTab.Controls.Add(this.twoTabAdd);
            this.twoTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twoTab.ItemSize = new System.Drawing.Size(50, 25);
            this.twoTab.Location = new System.Drawing.Point(3, 43);
            this.twoTab.Multiline = true;
            this.twoTab.Name = "twoTab";
            this.twoTab.SelectedIndex = 0;
            this.twoTab.Size = new System.Drawing.Size(1278, 472);
            this.twoTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.twoTab.TabIndex = 2;
            this.twoTab.SelectedIndexChanged += new System.EventHandler(this.twoTab_SelectedIndexChanged);
            // 
            // twoTabAll
            // 
            this.twoTabAll.Controls.Add(this.twoGrdAll);
            this.twoTabAll.Location = new System.Drawing.Point(4, 29);
            this.twoTabAll.Name = "twoTabAll";
            this.twoTabAll.Padding = new System.Windows.Forms.Padding(3);
            this.twoTabAll.Size = new System.Drawing.Size(1270, 439);
            this.twoTabAll.TabIndex = 0;
            this.twoTabAll.Text = "ALL";
            this.twoTabAll.UseVisualStyleBackColor = true;
            // 
            // twoGrdAll
            // 
            this.twoGrdAll.AllowUserToAddRows = false;
            this.twoGrdAll.AllowUserToDeleteRows = false;
            this.twoGrdAll.AutoGenerateColumns = false;
            this.twoGrdAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.twoGrdAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.twoGrdAll.DataSource = this.productSupplierWithNameBindingSource;
            this.twoGrdAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.twoGrdAll.Location = new System.Drawing.Point(3, 3);
            this.twoGrdAll.MultiSelect = false;
            this.twoGrdAll.Name = "twoGrdAll";
            this.twoGrdAll.ReadOnly = true;
            this.twoGrdAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.twoGrdAll.Size = new System.Drawing.Size(714, 433);
            this.twoGrdAll.TabIndex = 0;
            // 
            // twoTabEdit
            // 
            this.twoTabEdit.AutoScroll = true;
            this.twoTabEdit.Controls.Add(prodNameLabel);
            this.twoTabEdit.Controls.Add(this.twoCmbProdName);
            this.twoTabEdit.Controls.Add(productSupplierIdLabel);
            this.twoTabEdit.Controls.Add(this.twoTxtProdSuppId);
            this.twoTabEdit.Controls.Add(supNameLabel);
            this.twoTabEdit.Controls.Add(this.twoCmbSupName);
            this.twoTabEdit.Location = new System.Drawing.Point(4, 29);
            this.twoTabEdit.Name = "twoTabEdit";
            this.twoTabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.twoTabEdit.Size = new System.Drawing.Size(1270, 439);
            this.twoTabEdit.TabIndex = 1;
            this.twoTabEdit.Text = "EDIT";
            this.twoTabEdit.UseVisualStyleBackColor = true;
            // 
            // twoCmbProdName
            // 
            this.twoCmbProdName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.twoCmbProdName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.twoCmbProdName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productSupplierWithNameBindingSource, "ProdName", true));
            this.twoCmbProdName.DataSource = this.productsBindingSource;
            this.twoCmbProdName.DisplayMember = "ProdName";
            this.twoCmbProdName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.twoCmbProdName.FormattingEnabled = true;
            this.twoCmbProdName.Location = new System.Drawing.Point(231, 69);
            this.twoCmbProdName.Name = "twoCmbProdName";
            this.twoCmbProdName.Size = new System.Drawing.Size(230, 27);
            this.twoCmbProdName.TabIndex = 15;
            this.twoCmbProdName.ValueMember = "ProductId";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(Travel_Experts.Products);
            // 
            // twoTxtProdSuppId
            // 
            this.twoTxtProdSuppId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productSupplierWithNameBindingSource, "ProductSupplierId", true));
            this.twoTxtProdSuppId.Enabled = false;
            this.twoTxtProdSuppId.Location = new System.Drawing.Point(231, 19);
            this.twoTxtProdSuppId.Name = "twoTxtProdSuppId";
            this.twoTxtProdSuppId.Size = new System.Drawing.Size(121, 25);
            this.twoTxtProdSuppId.TabIndex = 3;
            // 
            // twoCmbSupName
            // 
            this.twoCmbSupName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.twoCmbSupName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.twoCmbSupName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productSupplierWithNameBindingSource, "SupName", true));
            this.twoCmbSupName.DataSource = this.suppliersBindingSource;
            this.twoCmbSupName.DisplayMember = "SupName";
            this.twoCmbSupName.DropDownWidth = 330;
            this.twoCmbSupName.FormattingEnabled = true;
            this.twoCmbSupName.Location = new System.Drawing.Point(231, 121);
            this.twoCmbSupName.Name = "twoCmbSupName";
            this.twoCmbSupName.Size = new System.Drawing.Size(230, 27);
            this.twoCmbSupName.TabIndex = 15;
            this.twoCmbSupName.ValueMember = "SupplierId";
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataSource = typeof(Travel_Experts.Suppliers);
            // 
            // twoTabAdd
            // 
            this.twoTabAdd.Controls.Add(this.twoCmbAddProdName);
            this.twoTabAdd.Controls.Add(this.twoCmbAddSuppName);
            this.twoTabAdd.Controls.Add(prodNameLabel1);
            this.twoTabAdd.Controls.Add(supNameLabel1);
            this.twoTabAdd.Location = new System.Drawing.Point(4, 29);
            this.twoTabAdd.Name = "twoTabAdd";
            this.twoTabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.twoTabAdd.Size = new System.Drawing.Size(1270, 439);
            this.twoTabAdd.TabIndex = 2;
            this.twoTabAdd.Text = "ADD";
            this.twoTabAdd.UseVisualStyleBackColor = true;
            // 
            // twoCmbAddProdName
            // 
            this.twoCmbAddProdName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.twoCmbAddProdName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.twoCmbAddProdName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productSupplierWithNameBindingSource, "ProdName", true));
            this.twoCmbAddProdName.DataSource = this.productsBindingSource;
            this.twoCmbAddProdName.DisplayMember = "ProdName";
            this.twoCmbAddProdName.FormattingEnabled = true;
            this.twoCmbAddProdName.Location = new System.Drawing.Point(191, 35);
            this.twoCmbAddProdName.Name = "twoCmbAddProdName";
            this.twoCmbAddProdName.Size = new System.Drawing.Size(230, 27);
            this.twoCmbAddProdName.TabIndex = 7;
            this.twoCmbAddProdName.ValueMember = "ProductId";
            // 
            // twoCmbAddSuppName
            // 
            this.twoCmbAddSuppName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.twoCmbAddSuppName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.twoCmbAddSuppName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productSupplierWithNameBindingSource, "SupName", true));
            this.twoCmbAddSuppName.DataSource = this.suppliersBindingSource;
            this.twoCmbAddSuppName.DisplayMember = "SupName";
            this.twoCmbAddSuppName.FormattingEnabled = true;
            this.twoCmbAddSuppName.Location = new System.Drawing.Point(191, 87);
            this.twoCmbAddSuppName.Name = "twoCmbAddSuppName";
            this.twoCmbAddSuppName.Size = new System.Drawing.Size(230, 27);
            this.twoCmbAddSuppName.TabIndex = 8;
            this.twoCmbAddSuppName.ValueMember = "SupplierId";
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.tableLayoutPanel5);
            this.tabProducts.Location = new System.Drawing.Point(4, 22);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducts.Size = new System.Drawing.Size(1290, 524);
            this.tabProducts.TabIndex = 2;
            this.tabProducts.Text = "PRODUCTS";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.threeTab, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1284, 518);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // threeTab
            // 
            this.threeTab.Controls.Add(this.tabPage4);
            this.threeTab.Controls.Add(this.tabPage5);
            this.threeTab.Controls.Add(this.tabPage6);
            this.threeTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.threeTab.Location = new System.Drawing.Point(3, 53);
            this.threeTab.Name = "threeTab";
            this.threeTab.SelectedIndex = 0;
            this.threeTab.Size = new System.Drawing.Size(1278, 462);
            this.threeTab.TabIndex = 0;
            this.threeTab.SelectedIndexChanged += new System.EventHandler(this.threeTab_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.productsDataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1270, 430);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "ALL";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AllowUserToDeleteRows = false;
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.productsDataGridView.DataSource = this.productsBindingSource;
            this.productsDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.productsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.productsDataGridView.MultiSelect = false;
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDataGridView.Size = new System.Drawing.Size(552, 424);
            this.productsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ProductId";
            this.dataGridViewTextBoxColumn7.FillWeight = 50.76142F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Product Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ProdName";
            this.dataGridViewTextBoxColumn8.FillWeight = 149.2386F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(prodNameLabel2);
            this.tabPage5.Controls.Add(this.threeTxtProdName);
            this.tabPage5.Controls.Add(productIdLabel);
            this.tabPage5.Controls.Add(this.threeTxtEditProdId);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1270, 436);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "EDIT";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // threeTxtProdName
            // 
            this.threeTxtProdName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProdName", true));
            this.threeTxtProdName.Location = new System.Drawing.Point(161, 59);
            this.threeTxtProdName.Name = "threeTxtProdName";
            this.threeTxtProdName.Size = new System.Drawing.Size(100, 25);
            this.threeTxtProdName.TabIndex = 1;
            // 
            // threeTxtEditProdId
            // 
            this.threeTxtEditProdId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductId", true));
            this.threeTxtEditProdId.Enabled = false;
            this.threeTxtEditProdId.Location = new System.Drawing.Point(161, 17);
            this.threeTxtEditProdId.Name = "threeTxtEditProdId";
            this.threeTxtEditProdId.Size = new System.Drawing.Size(100, 25);
            this.threeTxtEditProdId.TabIndex = 3;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(label8);
            this.tabPage6.Controls.Add(this.threeTxtAddProdName);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1270, 436);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "ADD";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // threeTxtAddProdName
            // 
            this.threeTxtAddProdName.Location = new System.Drawing.Point(191, 35);
            this.threeTxtAddProdName.Name = "threeTxtAddProdName";
            this.threeTxtAddProdName.Size = new System.Drawing.Size(126, 25);
            this.threeTxtAddProdName.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.threeBtnAll, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.threeBtnEdit, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.threeBtnAdd, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.threeBtnSave, 3, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(402, 44);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // threeBtnAll
            // 
            this.threeBtnAll.AutoSize = true;
            this.threeBtnAll.Location = new System.Drawing.Point(3, 3);
            this.threeBtnAll.Name = "threeBtnAll";
            this.threeBtnAll.Size = new System.Drawing.Size(75, 30);
            this.threeBtnAll.TabIndex = 0;
            this.threeBtnAll.Text = "ALL";
            this.threeBtnAll.UseVisualStyleBackColor = true;
            this.threeBtnAll.Click += new System.EventHandler(this.threeBtnAll_Click);
            // 
            // threeBtnEdit
            // 
            this.threeBtnEdit.AutoSize = true;
            this.threeBtnEdit.Location = new System.Drawing.Point(84, 3);
            this.threeBtnEdit.Name = "threeBtnEdit";
            this.threeBtnEdit.Size = new System.Drawing.Size(75, 30);
            this.threeBtnEdit.TabIndex = 0;
            this.threeBtnEdit.Text = "EDIT";
            this.threeBtnEdit.UseVisualStyleBackColor = true;
            this.threeBtnEdit.Click += new System.EventHandler(this.threeBtnEdit_Click);
            // 
            // threeBtnAdd
            // 
            this.threeBtnAdd.AutoSize = true;
            this.threeBtnAdd.Location = new System.Drawing.Point(165, 3);
            this.threeBtnAdd.Name = "threeBtnAdd";
            this.threeBtnAdd.Size = new System.Drawing.Size(75, 30);
            this.threeBtnAdd.TabIndex = 0;
            this.threeBtnAdd.Text = "ADD";
            this.threeBtnAdd.UseVisualStyleBackColor = true;
            this.threeBtnAdd.Click += new System.EventHandler(this.threeBtnAdd_Click);
            // 
            // threeBtnSave
            // 
            this.threeBtnSave.AutoSize = true;
            this.threeBtnSave.Location = new System.Drawing.Point(246, 3);
            this.threeBtnSave.Name = "threeBtnSave";
            this.threeBtnSave.Size = new System.Drawing.Size(75, 30);
            this.threeBtnSave.TabIndex = 0;
            this.threeBtnSave.Text = "SAVE";
            this.threeBtnSave.UseVisualStyleBackColor = true;
            this.threeBtnSave.Click += new System.EventHandler(this.threeBtnSave_Click);
            // 
            // tabSupplier
            // 
            this.tabSupplier.Location = new System.Drawing.Point(4, 22);
            this.tabSupplier.Name = "tabSupplier";
            this.tabSupplier.Padding = new System.Windows.Forms.Padding(3);
            this.tabSupplier.Size = new System.Drawing.Size(1290, 524);
            this.tabSupplier.TabIndex = 3;
            this.tabSupplier.Text = "SUPPLIER";
            this.tabSupplier.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 44);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Ivory;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(735, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "SIGN OUT";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 594);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPackages";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabPackages.ResumeLayout(false);
            this.tabPackageList.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsInPackageDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsInPackageBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsToAddDataGridView)).EndInit();
            this.tabProdSupp.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.twoTab.ResumeLayout(false);
            this.twoTabAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.twoGrdAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierWithNameBindingSource)).EndInit();
            this.twoTabEdit.ResumeLayout(false);
            this.twoTabEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            this.twoTabAdd.ResumeLayout(false);
            this.twoTabAdd.PerformLayout();
            this.tabProducts.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.threeTab.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabPackageList;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtPkgCommission2;
        private System.Windows.Forms.TextBox txtPkgPrice2;
        private System.Windows.Forms.TextBox txtPkgDesc2;
        private System.Windows.Forms.DateTimePicker txtPkgEnd2;
        private System.Windows.Forms.TextBox txtPkgName2;
        private System.Windows.Forms.DateTimePicker txtPkgStart2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPkgCommission;
        private System.Windows.Forms.TextBox txtPkgPrice;
        private System.Windows.Forms.TextBox txtPkgDesc;
        private System.Windows.Forms.DateTimePicker txtPkgEnd;
        private System.Windows.Forms.TextBox txtPkgName;
        private System.Windows.Forms.DateTimePicker txtPkgStart;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnAddOld;
        private System.Windows.Forms.DataGridView productsInPackageDataGridView;
        private System.Windows.Forms.DataGridView productsToAddDataGridView;
        public System.Windows.Forms.BindingSource productsInPackageBindingSource;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSaveNewPackage;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnBackList;
        private System.Windows.Forms.Button btnDeletePackage;
        private System.Windows.Forms.Button btnBackList2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnPackages;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnProdSupp;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPackages;
        private System.Windows.Forms.TabPage tabProdSupp;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.TabPage tabSupplier;
        private System.Windows.Forms.ComboBox cmbPackageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView grdProductList;
        private System.Windows.Forms.Button btnCreate1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnViewDetail;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button twoBtnViewAll;
        private System.Windows.Forms.Button twoBtnEdit;
        private System.Windows.Forms.Button twoBtnAdd;
        private System.Windows.Forms.TabControl twoTab;
        private System.Windows.Forms.TabPage twoTabAll;
        private System.Windows.Forms.TabPage twoTabEdit;
        private System.Windows.Forms.BindingSource productSupplierWithNameBindingSource;
        private System.Windows.Forms.TabPage twoTabAdd;
        private System.Windows.Forms.DataGridView twoGrdAll;
        private System.Windows.Forms.ComboBox twoCmbProdName;
        private System.Windows.Forms.TextBox twoTxtProdSuppId;
        private System.Windows.Forms.ComboBox twoCmbSupName;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private System.Windows.Forms.Button twoBtnSave;
        private System.Windows.Forms.ComboBox twoCmbAddProdName;
        private System.Windows.Forms.ComboBox twoCmbAddSuppName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TabControl threeTab;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button threeBtnAll;
        private System.Windows.Forms.Button threeBtnEdit;
        private System.Windows.Forms.Button threeBtnAdd;
        private System.Windows.Forms.Button threeBtnSave;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox threeTxtProdName;
        private System.Windows.Forms.TextBox threeTxtEditProdId;
        private System.Windows.Forms.TextBox threeTxtAddProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgBasePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkgAgencyCommissionDataGridViewTextBoxColumn;
    }
}

