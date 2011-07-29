using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AtomTester
{
    public partial class ProductsAndPacksByCompanyForm : Form
    {
        public ProductsAndPacksByCompanyForm(Uri productsUri, Uri packagesUri)
        {
            InitializeComponent();
        }
    }
}
