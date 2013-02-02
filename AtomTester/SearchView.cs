using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel.Syndication;
using System.Diagnostics;

namespace AtomTester
{
    public partial class SearchView : Form
    {
        private SyndicationFeed productsFeedSearched;
        
       
        private readonly IList<Product> productsPrescription = new List<Product>();
        
        private ProductDetailView productDetailForm;
        private PackDetailView packDetailForm;
        private ProductsByMoleculeView productByMoleculeForm;
        private ProductsAndPacksByCompanyView productsAndPacksByCompanyForm;
        private RecoView recoForm;
        private TreeForm treeForm;

        public SearchView()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            RestUtils.setServerParameters(comboBox1.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            launchsearchbyname();
        }

        private void launchsearchbyname()
        {
            searchHumanDrug();
            searchAccessory();
            searchDietetic();
            searchNonPharma();
            searchBalneo();
            searchRecos();
            searchMolecules();
            searchCompanies();

            SyndicationFeed indicationTreeFeed = RestUtils.getFeedByUri(new Uri(comboBox1.SelectedItem.ToString() + "rest/api/indications?q=" + searchBox.Text));

            IEnumerable<SyndicationItem> parents = indicationTreeFeed.Items.Where(l => (l.Categories[0].Name == "INDICATION_GROUP"));
            foreach (SyndicationItem parent in parents)
            {
                TreeNode node = new TreeNode();
                node.Name = parent.Id.ToString();
                node.Text = parent.Title.Text;
                getClassifChildren(indicationTreeFeed.Items, parent, node);
                indicationTreeView.Nodes.Add(node);
            }

            indicationTreeView.ExpandAll();
            
        }

        private void searchHumanDrug()
        {
            productsFeedSearched = RestUtils.getProductsFeedsByName(searchBox.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value);
            int max = productsFeedSearched.ElementExtensions.ReadElementExtensions<int>("totalResults", "http://a9.com/-/spec/opensearch/1.1/")[0];
            int page = productsFeedSearched.ElementExtensions.ReadElementExtensions<int>("startIndex", "http://a9.com/-/spec/opensearch/1.1/")[0];
            int itemPerPage = productsFeedSearched.ElementExtensions.ReadElementExtensions<int>("itemsPerPage", "http://a9.com/-/spec/opensearch/1.1/")[0];
            productResultLabel.Text = ((page - 1) * itemPerPage + productsFeedSearched.Items.ToArray<SyndicationItem>().Length) + "/" + max;
            productDataGridView.DataSource = RestUtils.getProductsBySyndicationFeed(productsFeedSearched);
        }

        private void searchAccessory()
        {
            SyndicationFeed accessoryFeedSearched = RestUtils.getPackageFeedsByName(searchBox.Text, (int)accessoryPage.Value, (int)accessoryResultSet.Value,"ACCESSORY");
            int max = accessoryFeedSearched.ElementExtensions.ReadElementExtensions<int>("totalResults", "http://a9.com/-/spec/opensearch/1.1/")[0];
            int page = accessoryFeedSearched.ElementExtensions.ReadElementExtensions<int>("startIndex", "http://a9.com/-/spec/opensearch/1.1/")[0];
            int itemPerPage = accessoryFeedSearched.ElementExtensions.ReadElementExtensions<int>("itemsPerPage", "http://a9.com/-/spec/opensearch/1.1/")[0];
            accessoryResultLabel.Text = ((page - 1) * itemPerPage + accessoryFeedSearched.Items.ToArray<SyndicationItem>().Length) + "/" + max;
            accessoryDataGridView.DataSource = RestUtils.getPackagesBySyndicationFeed(accessoryFeedSearched.Items);
        }

        private void searchDietetic()
        {
            SyndicationFeed dieteticFeedSearched = RestUtils.getPackageFeedsByName(searchBox.Text, (int)dieteticPage.Value, (int)dieteticResultSet.Value, "DIETETIC");
            int max = dieteticFeedSearched.ElementExtensions.ReadElementExtensions<int>("totalResults", "http://a9.com/-/spec/opensearch/1.1/")[0];
            int page = dieteticFeedSearched.ElementExtensions.ReadElementExtensions<int>("startIndex", "http://a9.com/-/spec/opensearch/1.1/")[0];
            int itemPerPage = dieteticFeedSearched.ElementExtensions.ReadElementExtensions<int>("itemsPerPage", "http://a9.com/-/spec/opensearch/1.1/")[0];
            dieteticResultlabel.Text = ((page - 1) * itemPerPage + dieteticFeedSearched.Items.ToArray<SyndicationItem>().Length) + "/" + max;
            dieteticDataGridView.DataSource = RestUtils.getPackagesBySyndicationFeed(dieteticFeedSearched.Items);
        }

        private void searchBalneo()
        {
            SyndicationFeed balneoFeedSearched = RestUtils.getPackageFeedsByName(searchBox.Text, (int)balneoPage.Value, (int)balneoResultSet.Value, "BALNEOLOGY");
            int max = balneoFeedSearched.ElementExtensions.ReadElementExtensions<int>("totalResults", "http://a9.com/-/spec/opensearch/1.1/")[0];
            int page = balneoFeedSearched.ElementExtensions.ReadElementExtensions<int>("startIndex", "http://a9.com/-/spec/opensearch/1.1/")[0];
            int itemPerPage = balneoFeedSearched.ElementExtensions.ReadElementExtensions<int>("itemsPerPage", "http://a9.com/-/spec/opensearch/1.1/")[0];
            balneoresultLabel.Text = ((page - 1) * itemPerPage + balneoFeedSearched.Items.ToArray<SyndicationItem>().Length) + "/" + max;
            balneoDataGridView.DataSource = RestUtils.getPackagesBySyndicationFeed(balneoFeedSearched.Items);
        }

        private void searchNonPharma()
        {
            SyndicationFeed nonPharmaFeedSearched = RestUtils.getPackageFeedsByName(searchBox.Text, (int)nonPharmaPage.Value, (int)nonPharmaResultSet.Value, "NON_PHARMACEUTICAL");
            int max = nonPharmaFeedSearched.ElementExtensions.ReadElementExtensions<int>("totalResults", "http://a9.com/-/spec/opensearch/1.1/")[0];
            int page = nonPharmaFeedSearched.ElementExtensions.ReadElementExtensions<int>("startIndex", "http://a9.com/-/spec/opensearch/1.1/")[0];
            int itemPerPage = nonPharmaFeedSearched.ElementExtensions.ReadElementExtensions<int>("itemsPerPage", "http://a9.com/-/spec/opensearch/1.1/")[0];
            nonPharmaResultLabel.Text = ((page - 1) * itemPerPage + nonPharmaFeedSearched.Items.ToArray<SyndicationItem>().Length) + "/" + max;
            nonPharma1DataGridView.DataSource = RestUtils.getPackagesBySyndicationFeed(nonPharmaFeedSearched.Items);
        }

        private void searchRecos()
        {
            SyndicationFeed recosFeedSearched = RestUtils.getRecosFeedsByName(searchBox.Text, (int)recosPage.Value, (int)recosResultSet.Value);
            int max = recosFeedSearched.ElementExtensions.ReadElementExtensions<int>("totalResults", "http://a9.com/-/spec/opensearch/1.1/")[0];
            int page = recosFeedSearched.ElementExtensions.ReadElementExtensions<int>("startIndex", "http://a9.com/-/spec/opensearch/1.1/")[0];
            int itemPerPage = recosFeedSearched.ElementExtensions.ReadElementExtensions<int>("itemsPerPage", "http://a9.com/-/spec/opensearch/1.1/")[0];
            recosResultLabel.Text = ((page - 1) * itemPerPage + recosFeedSearched.Items.ToArray<SyndicationItem>().Length) + "/" + max;
            recosDataGridView.DataSource = RestUtils.getRecosBySyndicationFeed(recosFeedSearched.Items);
        }

        private void searchMolecules()
        {
            SyndicationFeed moleculesFeedSearched = RestUtils.getMoleculeFeedsByName(searchBox.Text, (int)moleculesPage.Value, (int)moleculeResultSet.Value);
            int max = moleculesFeedSearched.ElementExtensions.ReadElementExtensions<int>("totalResults", "http://a9.com/-/spec/opensearch/1.1/")[0];
            int page = moleculesFeedSearched.ElementExtensions.ReadElementExtensions<int>("startIndex", "http://a9.com/-/spec/opensearch/1.1/")[0];
            int itemPerPage = moleculesFeedSearched.ElementExtensions.ReadElementExtensions<int>("itemsPerPage", "http://a9.com/-/spec/opensearch/1.1/")[0];
            moleculeResultLabel.Text = ((page - 1) * itemPerPage + moleculesFeedSearched.Items.ToArray<SyndicationItem>().Length) + "/" + max;
            moleculesDataGridView.DataSource = RestUtils.getMoleculesBySyndicationFeed(moleculesFeedSearched.Items);
        }

        private void searchCompanies()
        {
            SyndicationFeed companiesFeedSearched = RestUtils.getCompaniesFeedsByName(searchBox.Text, (int)companyPage.Value, (int)companyResultSet.Value);
            int max = companiesFeedSearched.ElementExtensions.ReadElementExtensions<int>("totalResults", "http://a9.com/-/spec/opensearch/1.1/")[0];
            int page = companiesFeedSearched.ElementExtensions.ReadElementExtensions<int>("startIndex", "http://a9.com/-/spec/opensearch/1.1/")[0];
            int itemPerPage = companiesFeedSearched.ElementExtensions.ReadElementExtensions<int>("itemsPerPage", "http://a9.com/-/spec/opensearch/1.1/")[0];
            companyresultLabel.Text = ((page - 1) * itemPerPage + companiesFeedSearched.Items.ToArray<SyndicationItem>().Length) + "/" + max;
            companyDataGridView.DataSource = RestUtils.getCompaniesBySyndicationFeed(companiesFeedSearched.Items);
        }




        private static void getClassifChildren(IEnumerable<SyndicationItem> items, SyndicationItem parent, TreeNode node)
        {
            
            IEnumerable<SyndicationItem> children = from item in items where item.Links.Count(l => l.Uri.ToString() == parent.Id ) >0 select item;
            
            foreach (SyndicationItem child in children)
            {
                TreeNode childNode = new TreeNode();

                childNode.Name = child.Id;
                childNode.Text = child.Title.Text;
                node.Nodes.Add(childNode);
                getClassifChildren(items, child, childNode);
            }

            

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

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            RestUtils.setServerParameters(comboBox1.SelectedItem.ToString());
        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1){
               Product product =  (Product)productDataGridView.Rows[e.RowIndex].DataBoundItem;
              
               productDetailForm = new ProductDetailView(product.ProductRelativeUri);
                productDetailForm.Visible = true;

        }
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

        private void moleculePrevButton_Click(object sender, EventArgs e)
        {
            if (moleculesPage.Value > 1)
                moleculesPage.Value--;
            searchMolecules();
        }

        private void moleucleNextButton_Click(object sender, EventArgs e)
        {
            moleculesPage.Value++;
            searchMolecules();
        }



        private void companyPrevButton_Click(object sender, EventArgs e)
        {
            if (companyPage.Value > 1)
                companyPage.Value--;
            searchCompanies();
        }

        private void companyNextButton_Click(object sender, EventArgs e)
        {
            companyPage.Value++;
            searchCompanies();
        }



        private void accessoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Package pack = (Package)accessoryDataGridView.Rows[e.RowIndex].DataBoundItem;

                packDetailForm = new PackDetailView(pack.packageRelativeUri);
                packDetailForm.Visible = true;

            }
        }

        private void nonPharma1DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Package pack = (Package)nonPharma1DataGridView.Rows[e.RowIndex].DataBoundItem;

                packDetailForm = new PackDetailView(pack.packageRelativeUri);
                packDetailForm.Visible = true;

            }
        }

        private void dieteticDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Package pack = (Package)dieteticDataGridView.Rows[e.RowIndex].DataBoundItem;

                packDetailForm = new PackDetailView(pack.packageRelativeUri);
                packDetailForm.Visible = true;

            }
        }

        private void balneoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Package pack = (Package)balneoDataGridView.Rows[e.RowIndex].DataBoundItem;

                packDetailForm = new PackDetailView(pack.packageRelativeUri);
                packDetailForm.Visible = true;

            }
        }

        private void recosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
               Reco reco = (Reco)recosDataGridView.Rows[e.RowIndex].DataBoundItem;

                recoForm = new RecoView(reco.recolink);
                recoForm.Visible = true;

            }
        }

        private void moleculesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                MoleculeSynonym molec = (MoleculeSynonym)moleculesDataGridView.Rows[e.RowIndex].DataBoundItem;

                productByMoleculeForm = new ProductsByMoleculeView(molec.productsLink);
                productByMoleculeForm.Visible = true;

            }
        }

      

        private void companyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                Company company = (Company)companyDataGridView.Rows[e.RowIndex].DataBoundItem;

                productsAndPacksByCompanyForm = new ProductsAndPacksByCompanyView(company.productsLink,company.packagesLink);
                productsAndPacksByCompanyForm.Visible = true;

            }
        }

        private void SearchView_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeForm = new TreeForm();
            treeForm.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RestUtils.setServerParameters(comboBox1.SelectedItem.ToString());
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            OrdoForm ordo = new OrdoForm();
            ordo.Visible = true;

        }

       
          }
}
