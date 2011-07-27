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

    public partial class ProductDetail : Form
    {
        public ProductDetail(Uri uri)
        {
            InitializeComponent();

            ProductDetailAggregate pd = (RestUtils.getProductDetail(uri));
            productTextBox.Text = pd.product.Name;
            laboTextBox.Text = pd.product.CompanyName;
            foreach (Reco reco in pd.recos)
            {
                recosListBox.Items.Add(reco.Name);
            }
            TreeNode node = new TreeNode();
            

            VidalClassification parent = pd.vidalClassifications.FirstOrDefault<VidalClassification>(l => (l.id == "vidal://vidal_classification/0"));
            node.Name = parent.id.ToString();
            node.Text = parent.name;
            getClassifChildren(pd, parent,node);
          

            classifTreeView.Nodes.Add(node);
            classifTreeView.ExpandAll();
            SyndicationFeed mono = RestUtils.getFeedByUri(pd.product.productDocumentOpt);
            monoWebBrowser.DocumentText =( (TextSyndicationContent)mono.Items.First().Content).Text;

            vigiTextBox.Text = pd.product.vigilance;
            nurseTextBox.Text = pd.product.midwife;
            String moleculeLabel = "";
            foreach (Molecule molecule in pd.molecules)
            {
                moleculeLabel = moleculeLabel + molecule.name + ",";
            }
            eenTextBox.Text = moleculeLabel;

            if (pd.product.Liste != null)
            {
                prescriptionListBox.Items.Add(pd.product.Liste);
            }
            packDataGridView.DataSource = pd.packages;

            String genericLabel = "";
            foreach(GenericGroup group in pd.GenericGroups){
                genericLabel = genericLabel + group.name +",";
            }
            genGrpTextBox.Text = genericLabel;
            cngTextBox.Text = pd.product.vmp;

        }

        private static void getClassifChildren(ProductDetailAggregate pd, VidalClassification parent,TreeNode node)
        {
            IEnumerable<VidalClassification> children = pd.vidalClassifications.Where<VidalClassification>(l => ((l.parentLink != null ? l.parentLink.ToString() : null) == parent.id));
           
            foreach (VidalClassification child in children)
            {
                TreeNode childNode = new TreeNode();

                childNode.Name = child.id;
                childNode.Text = child.name;
                node.Nodes.Add(childNode);
                getClassifChildren(pd, child, childNode);
            }

            

        }      
    }
}
