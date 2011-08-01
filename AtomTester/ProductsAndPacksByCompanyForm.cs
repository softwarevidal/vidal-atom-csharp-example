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
 
    public partial class ProductsAndPacksByCompanyForm : Form
    {
        private SyndicationFeed productsFeedSearched;
        private readonly IList<Product> productsPrescription = new List<Product>();
        
        private ProductDetail productDetailForm;
        private PackDetail packDetailForm;
        private Uri productsUri;
        private Uri packagesUri;
 
        public ProductsAndPacksByCompanyForm(Uri productsUri, Uri packagesUri)
        {
            InitializeComponent();
            this.productsUri = productsUri;
            this.packagesUri = packagesUri;

            searchHumanDrug();
            searchAccessory();
            searchDietetic();
            searchNonPharma();
            searchBalneo();
            
       
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

        private void searchAccessory()
        {
            SyndicationFeed accessoryFeedSearched = RestUtils.getFeedByUri(new Uri(RestUtils.getAbsoluteUri(packagesUri) + "type=ACCESSORY" + "&start-page=" + (int)accessoryPage.Value + "&page-size=" + (int)accessoryResultSet.Value));
            int max = accessoryFeedSearched.ElementExtensions.ReadElementExtensions<int>("totalResults", "http://a9.com/-/spec/opensearch/1.1/")[0];
            int page = accessoryFeedSearched.ElementExtensions.ReadElementExtensions<int>("startIndex", "http://a9.com/-/spec/opensearch/1.1/")[0];
            int itemPerPage = accessoryFeedSearched.ElementExtensions.ReadElementExtensions<int>("itemsPerPage", "http://a9.com/-/spec/opensearch/1.1/")[0];
            accessoryResultLabel.Text = ((page - 1) * itemPerPage + accessoryFeedSearched.Items.ToArray<SyndicationItem>().Length) + "/" + max;
            accessoryDataGridView.DataSource = RestUtils.getPackagesBySyndicationFeed(accessoryFeedSearched.Items);
        }

        private void searchDietetic()
        {
            SyndicationFeed dieteticFeedSearched = RestUtils.getFeedByUri(new Uri(RestUtils.getAbsoluteUri(packagesUri) + "type=DIETETIC" + "&start-page=" + (int)accessoryPage.Value + "&page-size=" + (int)accessoryResultSet.Value));
            int max = dieteticFeedSearched.ElementExtensions.ReadElementExtensions<int>("totalResults", "http://a9.com/-/spec/opensearch/1.1/")[0];
            int page = dieteticFeedSearched.ElementExtensions.ReadElementExtensions<int>("startIndex", "http://a9.com/-/spec/opensearch/1.1/")[0];
            int itemPerPage = dieteticFeedSearched.ElementExtensions.ReadElementExtensions<int>("itemsPerPage", "http://a9.com/-/spec/opensearch/1.1/")[0];
            dieteticResultlabel.Text = ((page - 1) * itemPerPage + dieteticFeedSearched.Items.ToArray<SyndicationItem>().Length) + "/" + max;
            dieteticDataGridView.DataSource = RestUtils.getPackagesBySyndicationFeed(dieteticFeedSearched.Items);
        }

        private void searchBalneo()
        {

            SyndicationFeed balneoFeedSearched = RestUtils.getFeedByUri(new Uri(RestUtils.getAbsoluteUri(packagesUri) + "type=BALNEOLOGY" + "&start-page=" + (int)accessoryPage.Value + "&page-size=" + (int)accessoryResultSet.Value));
            int max = balneoFeedSearched.ElementExtensions.ReadElementExtensions<int>("totalResults", "http://a9.com/-/spec/opensearch/1.1/")[0];
            int page = balneoFeedSearched.ElementExtensions.ReadElementExtensions<int>("startIndex", "http://a9.com/-/spec/opensearch/1.1/")[0];
            int itemPerPage = balneoFeedSearched.ElementExtensions.ReadElementExtensions<int>("itemsPerPage", "http://a9.com/-/spec/opensearch/1.1/")[0];
            balneoresultLabel.Text = ((page - 1) * itemPerPage + balneoFeedSearched.Items.ToArray<SyndicationItem>().Length) + "/" + max;
            balneoDataGridView.DataSource = RestUtils.getPackagesBySyndicationFeed(balneoFeedSearched.Items);
        }

        private void searchNonPharma()
        {
            SyndicationFeed nonPharmaFeedSearched = RestUtils.getFeedByUri(new Uri(RestUtils.getAbsoluteUri(packagesUri) + "type=NON_PHARMACEUTICAL" + "&start-page=" + (int)accessoryPage.Value + "&page-size=" + (int)accessoryResultSet.Value));
            int max = nonPharmaFeedSearched.ElementExtensions.ReadElementExtensions<int>("totalResults", "http://a9.com/-/spec/opensearch/1.1/")[0];
            int page = nonPharmaFeedSearched.ElementExtensions.ReadElementExtensions<int>("startIndex", "http://a9.com/-/spec/opensearch/1.1/")[0];
            int itemPerPage = nonPharmaFeedSearched.ElementExtensions.ReadElementExtensions<int>("itemsPerPage", "http://a9.com/-/spec/opensearch/1.1/")[0];
            nonPharmaResultLabel.Text = ((page - 1) * itemPerPage + nonPharmaFeedSearched.Items.ToArray<SyndicationItem>().Length) + "/" + max;
            nonPharma1DataGridView.DataSource = RestUtils.getPackagesBySyndicationFeed(nonPharmaFeedSearched.Items);
        }

       
        private void nextButton_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = numericUpDown1.Value +1;
            searchHumanDrug();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 1)
            numericUpDown1.Value = numericUpDown1.Value - 1;
            searchHumanDrug();
        }

      

     

        //Accessory pagination
        private void accessoryBackButton_Click(object sender, EventArgs e)
        {
            if (accessoryPage.Value > 1)
                accessoryPage.Value--;
            searchAccessory();
        }

        private void accessoryNextButton_Click(object sender, EventArgs e)
        {

            accessoryPage.Value++;
            searchAccessory();
        }

        //Non_Pharma pagination
        private void nonPharmaNextButton_Click(object sender, EventArgs e)
        {
            nonPharmaPage.Value ++;
            searchNonPharma();
        }

        private void nonPharmaPrevButton_Click(object sender, EventArgs e)
        {
            if (nonPharmaPage.Value > 1)
                nonPharmaPage.Value --;
            searchNonPharma();
        }

        //balneo pagination
        private void balneoNextButton_Click(object sender, EventArgs e)
        {
            balneoPage.Value ++;
            searchBalneo();
        }

        private void bamneoPrevButton_Click(object sender, EventArgs e)
        {
            if (balneoPage.Value > 1)
                balneoPage.Value ++;
            searchBalneo();
        }

        //dietetic pagination
        private void dieteticNextButton_Click(object sender, EventArgs e)
        {
            dieteticPage.Value++;
            searchDietetic();
        }

        private void dietetictPrevButton_Click(object sender, EventArgs e)
        {
            if(dieteticPage.Value >1)
                dieteticPage.Value--;
            searchDietetic();
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


        private void accessoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Package pack = (Package)accessoryDataGridView.Rows[e.RowIndex].DataBoundItem;

                packDetailForm = new PackDetail(pack.packageRelativeUri);
                packDetailForm.Visible = true;

            }
        }

        private void nonPharma1DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Package pack = (Package)nonPharma1DataGridView.Rows[e.RowIndex].DataBoundItem;

                packDetailForm = new PackDetail(pack.packageRelativeUri);
                packDetailForm.Visible = true;

            }
        }

        private void dieteticDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Package pack = (Package)dieteticDataGridView.Rows[e.RowIndex].DataBoundItem;

                packDetailForm = new PackDetail(pack.packageRelativeUri);
                packDetailForm.Visible = true;

            }
        }

        private void balneoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Package pack = (Package)balneoDataGridView.Rows[e.RowIndex].DataBoundItem;

                packDetailForm = new PackDetail(pack.packageRelativeUri);
                packDetailForm.Visible = true;

            }
        }


       
    }
}
