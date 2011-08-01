using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel.Syndication;

namespace AtomTester
{
    public partial class ProductsByMoleculeForm : Form
    {
        private ProductDetail productDetailForm;
        private SyndicationFeed productsFeedSearched;
        private Uri uri;
        private static String ONLY = "ONLY";
        private static String ASSOCIATED = "ASSOCIATED";

        public ProductsByMoleculeForm(Uri uri)
        {
            InitializeComponent();
            this.uri = uri;
            searchProducts(ONLY, productResultLabel, productDataGridView,(int)numericUpDown1.Value,(int)numericUpDown2.Value);
            searchProducts(ASSOCIATED, productMolecAssociatedResultLabel,productMolecAssociatedGridView,(int)productMolecAssociatedPage.Value,(int)productMolecAssociatedResult.Value);
            
        }


        private void searchProducts(String type,Label label, DataGridView gridView,int startPage, int maxPerPage)
        {
            productsFeedSearched = RestUtils.getFeedByUri(new Uri(RestUtils.getAbsoluteUri(this.uri) +"&association-type="+type+ "&start-page=" + startPage + "&page-size=" + maxPerPage));
            int max = productsFeedSearched.ElementExtensions.ReadElementExtensions<int>("totalResults", "http://a9.com/-/spec/opensearch/1.1/")[0];
            int page = productsFeedSearched.ElementExtensions.ReadElementExtensions<int>("startIndex", "http://a9.com/-/spec/opensearch/1.1/")[0];
            int itemPerPage = productsFeedSearched.ElementExtensions.ReadElementExtensions<int>("itemsPerPage", "http://a9.com/-/spec/opensearch/1.1/")[0];
            label.Text = ((page - 1) * itemPerPage + productsFeedSearched.Items.ToArray<SyndicationItem>().Length) + "/" + max;
            gridView.DataSource = RestUtils.getProductsBySyndicationFeed(productsFeedSearched);
        }



        private void nextButton_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = numericUpDown1.Value + 1;
            searchProducts(ONLY, productResultLabel, productDataGridView, (int)numericUpDown1.Value, (int)numericUpDown2.Value);
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 1)
                numericUpDown1.Value = numericUpDown1.Value - 1;
            searchProducts(ONLY, productResultLabel, productDataGridView, (int)numericUpDown1.Value, (int)numericUpDown2.Value);
        }


        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Product product = (Product)productDataGridView.Rows[e.RowIndex].DataBoundItem;

                productDetailForm = new ProductDetail(product.ProductRelativeUri);
                productDetailForm.Visible = true;

            }
        }

        private void productMolecAssociatedNutton_Click(object sender, EventArgs e)
        {
            productMolecAssociatedPage.Value = productMolecAssociatedPage.Value + 1;
            searchProducts(ASSOCIATED, productMolecAssociatedResultLabel, productMolecAssociatedGridView, (int)productMolecAssociatedPage.Value, (int)productMolecAssociatedResult.Value);
        }

        private void productMolecAssociatedPreviousButton_Click(object sender, EventArgs e)
        {
            if (productMolecAssociatedPage.Value > 1)
                productMolecAssociatedPage.Value = productMolecAssociatedPage.Value - 1;
            searchProducts(ASSOCIATED, productMolecAssociatedResultLabel, productMolecAssociatedGridView, (int)productMolecAssociatedPage.Value, (int)productMolecAssociatedResult.Value);
        }

        private void productMolecAssociatedGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Product product = (Product)productMolecAssociatedGridView.Rows[e.RowIndex].DataBoundItem;

                productDetailForm = new ProductDetail(product.ProductRelativeUri);
                productDetailForm.Visible = true;

            }
        }

      
    }
}
