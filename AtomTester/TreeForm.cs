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
    public partial class TreeForm : Form
    {
        public TreeForm()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void TreeForm_Load(object sender, EventArgs e)
        {
            DisplayTree();
            
        }

        private void DisplayTree()
        {
            classifTreeView.Nodes.Clear();
            TreeNode node = new TreeNode();
            if (comboBox1.SelectedItem == "ATC")
            {
                SyndicationFeed atcFeed = RestUtils.getAllAtcFeeds();
                List<AtcClassification> atcs = RestUtils.getAtcBySyndicationFeed(atcFeed.Items);
                AtcClassification parent = atcs.FirstOrDefault<AtcClassification>(l => (l.feedid == "vidal://atc_classification/0"));
                node.Name = parent.id.ToString();
                node.Text = parent.name;
                node.Tag = parent;
                getClassifChildren(atcs, parent, node);
                
            }
            else if (comboBox1.SelectedItem == "VIDAL")
            {
                SyndicationFeed vidalFeed = RestUtils.getAllVidalFeeds();
                List<VidalClassification> vidals = RestUtils.getVidalBySyndicationFeed(vidalFeed.Items);
                VidalClassification parent = vidals.FirstOrDefault<VidalClassification>(l => (l.id == "vidal://vidal_classification/0"));
                node.Name = parent.id.ToString();
                node.Text = parent.name;
                node.Tag = parent;
                getVidalClassifChildren(vidals, parent, node);
            }
            else if (comboBox1.SelectedItem == "SAUMON")
            {
                SyndicationFeed saumonFeed = RestUtils.getAllSaumonFeeds();
                List<SaumonClassification> saumons = RestUtils.getSaumonBySyndicationFeed(saumonFeed.Items);
                SaumonClassification parent = saumons.FirstOrDefault<SaumonClassification>(l => (l.id == "vidal://saumon_classification/0"));
                node.Name = parent.id.ToString();
                node.Text = parent.name;
                node.Tag = parent;
                getSaumonClassifChildren(saumons, parent, node);

            }
            else
            {
                
            }
          


            classifTreeView.Nodes.Add(node);
            classifTreeView.ExpandAll();

        }

        private static void getClassifChildren(List<AtcClassification> pd, AtcClassification parent, TreeNode node)
        {
            IEnumerable<AtcClassification> children = pd.Where<AtcClassification>(l => ((l.parentLink != null ? l.parentLink.ToString() : null) == parent.feedid));

            foreach (AtcClassification child in children)
            {
                TreeNode childNode = new TreeNode();

                childNode.Name = child.feedid;
                childNode.Text = child.name;
                childNode.Tag = child;
                node.Nodes.Add(childNode);
                getClassifChildren(pd, child, childNode);
            }



        }


        private static void getVidalClassifChildren(List<VidalClassification> pd, VidalClassification parent, TreeNode node)
        {
            IEnumerable<VidalClassification> children = pd.Where<VidalClassification>(l => ((l.parentLink != null ? l.parentLink.ToString() : null) == parent.id));

            foreach (VidalClassification child in children)
            {
                TreeNode childNode = new TreeNode();

                childNode.Name = child.id;
                childNode.Text = child.name;
                childNode.Tag = child;
                node.Nodes.Add(childNode);
                getVidalClassifChildren(pd, child, childNode);
            }



        }

        private static void getSaumonClassifChildren(List<SaumonClassification> pd, SaumonClassification parent, TreeNode node)
        {
            IEnumerable<SaumonClassification> children = pd.Where<SaumonClassification>(l => ((l.parentLink != null ? l.parentLink.ToString() : null) == parent.id));

            foreach (SaumonClassification child in children)
            {
                TreeNode childNode = new TreeNode();

                childNode.Name = child.id;
                childNode.Text = child.name;
                childNode.Tag = child;
                node.Nodes.Add(childNode);
                getSaumonClassifChildren(pd, child, childNode);
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayTree();
        }

        private void classifTreeView_DoubleClick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (classifTreeView.SelectedNode.Tag is VidalClassification)
            {
                SyndicationFeed productsFeedSearched = RestUtils.getFeedByUri(RestUtils.getAbsoluteUri(((VidalClassification)classifTreeView.SelectedNode.Tag).productsLink));

                List<Product> products = RestUtils.getProductsBySyndicationFeed(productsFeedSearched);
                listBox1.Items.AddRange(products.ToArray<Product>());
            }
            else if (classifTreeView.SelectedNode.Tag is SaumonClassification)
            {
                SyndicationFeed packagesFeedSearched = RestUtils.getFeedByUri(RestUtils.getAbsoluteUri(((SaumonClassification)classifTreeView.SelectedNode.Tag).productsLink));

                List<Product> products = RestUtils.getProductsBySyndicationFeed(packagesFeedSearched);
                listBox1.Items.AddRange(products.ToArray<Product>());
            }
            else if (classifTreeView.SelectedNode.Tag is AtcClassification)
            {
                SyndicationFeed productsFeedSearched = RestUtils.getFeedByUri(RestUtils.getAbsoluteUri(((AtcClassification)classifTreeView.SelectedNode.Tag).productsLink));

                List<Product> products = RestUtils.getProductsBySyndicationFeed(productsFeedSearched);
                listBox1.Items.AddRange(products.ToArray<Product>());
            }
        }
    }
}
