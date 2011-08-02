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
    public partial class RecoView : Form
    {
        public RecoView(Uri recoLink)
        {
            InitializeComponent();
            SyndicationFeed reco = RestUtils.getFeedByUri(recoLink);
                //you have to rerouting the url if you want to have img and css like in the Browser;
            recoWebBrowser.DocumentText = ((TextSyndicationContent)reco.Items.First().Content).Text;

        }
    }
}
