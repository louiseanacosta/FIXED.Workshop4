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
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        List<AvailableProducts> products = AvailableProductsDB.GetAvailableProducts();
        private void AddProduct_Load(object sender, EventArgs e)
        {
            availableProductsBindingSource.DataSource = products;
        }
    }
}
