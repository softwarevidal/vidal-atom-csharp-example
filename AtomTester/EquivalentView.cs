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
    public partial class EquivalentView : Form
    {
        private SyndicationFeed productsFeedSearched;
        private ProductDetailView productDetailForm;
        private Uri productsUri;
 
        public EquivalentView(Uri productsUri,String title)
        {
            this.productsUri = productsUri;
            InitializeComponent();
            titleLabel.Text = title;
            searchHumanDrug();
        }


        private void searchHumanDrug()
        {
            productsFeedSearched = RestUtils.getFeedByUri(new Uri(RestUtils.getAbsoluteUri(productsUri) + "start-page=" + (int)numericUpDown1.Value + "&page-size=" + (int)numericUpDown2.Value));
            int max = productsFeedSearched.ElementExtensions.ReadElementExtensions<int>("totalResults", "http://a9.com/-/spec/opensearch/1.1/")[0];
            int page = productsFeedSearched.ElementExtensions.ReadElementExtensions<int>("startIndex", "http://a9.com/-/spec/opensearch/1.1/")[0];
            int itemPerPage = productsFeedSearched.ElementExtensions.ReadElementExtensions<int>("itemsPerPage", "http://a9.com/-/spec/opensearch/1.1/")[0];
            productResultLabel.Text = ((page - 1) * itemPerPage + productsFeedSearched.Items.ToArray<SyndicationItem>().Length) + "/" + max;
            productDataGridView.DataSource = RestUtils.getProductsBySyndicationFeed(productsFeedSearched);
        }

        private void productBackbutton_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 1)
                numericUpDown1.Value = numericUpDown1.Value - 1;
            searchHumanDrug();
        }

        private void productNextButton_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = numericUpDown1.Value + 1;
            searchHumanDrug();
        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Product product = (Product)productDataGridView.Rows[e.RowIndex].DataBoundItem;

                productDetailForm = new ProductDetailView(product.ProductRelativeUri);
                productDetailForm.Visible = true;

            }
        }

    }
}
