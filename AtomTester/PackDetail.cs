using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel.Syndication;
using AtomTester.VidalDTO;

namespace AtomTester
{
    public partial class PackDetail : Form
    {
        public PackDetail(Uri uri)
        {
            InitializeComponent();
            PackageDetailAggregate packDetail = RestUtils.getDetailAggregatePackageByUri(uri);
            libelleTextBox.Text = packDetail.package.Name;
            companyTextBox.Text = packDetail.package.companyName;
            marcketLabel.Text = packDetail.package.marketStatus;


            TreeNode node = new TreeNode();


            SaumonClassification parent = packDetail.saumons.FirstOrDefault<SaumonClassification>(l => (l.id == "vidal://saumon_classification/0"));
            node.Name = parent.id.ToString();
            node.Text = parent.name;
            getClassifChildren(packDetail, parent, node);


            saumonTreeView.Nodes.Add(node);
            saumonTreeView.ExpandAll();

            if (packDetail.lpprs != null)
            {
                lpprDataGridView.DataSource = packDetail.lpprs;

            }
            
            SyndicationFeed mono = RestUtils.getFeedByUri(packDetail.package.monoRelativeUri);
            if (mono != null && mono.Items.First().Content != null)
            {
                monographWebBrowser.DocumentText = ((TextSyndicationContent)mono.Items.First().Content).Text;
            }

        }

        private static void getClassifChildren(PackageDetailAggregate pd, SaumonClassification parent, TreeNode node)
        {
            IEnumerable<SaumonClassification> children = pd.saumons.Where<SaumonClassification>(l => ((l.parentLink != null ? l.parentLink.ToString() : null) == parent.id));

            foreach (SaumonClassification child in children)
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
