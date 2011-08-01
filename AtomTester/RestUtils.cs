using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Linq;
using System.Xml.Linq;
using AtomTester;
using AtomTester.VidalDTO;
using System.Collections.ObjectModel;

public static class RestUtils
{

    public static Uri serverBaseUri;
    public static String vidalNameSpace = "http://api.vidal.net/-/spec/vidal-api/1.0/";
    

    public static void setServerParameters(String serverBaseUri)
    {
        RestUtils.serverBaseUri = new Uri(serverBaseUri);
    }

    public static Uri getAbsoluteUri(Uri uri)
    {
        return ((uri == null) || (uri.IsAbsoluteUri)) ? uri : new Uri(serverBaseUri, uri);
    }

    public static Uri getRelativeUri(Uri uri)
    {
        return ((uri == null) || !(uri.IsAbsoluteUri)) ? uri : new Uri(uri.PathAndQuery, UriKind.Relative);
    }

    

    public static SyndicationFeed AtomResultRequest(Uri uri)
    {
        try
        {
            return SyndicationFeed.Load(XmlReader.Create(getAbsoluteUri(uri).ToString()));
        }
        catch (WebException e)
        {
            if (e.Status == WebExceptionStatus.ProtocolError)
            {
                MessageBox.Show("A error have been raised.\r\n\r\n" + "Exception message:\r\n    " + e.Message + "\r\n\r\nException stack trace:\r\n" + e.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.Status == WebExceptionStatus.NameResolutionFailure)
            {
                MessageBox.Show("A error have been raised.\r\nPlease check you have put a valid server URL' .\r\n\r\n" + "Exception message:\r\n    " + e.Message + "\r\n\r\nException stack trace:\r\n" + e.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("A error have been raised.\r\n\r\n" + "Exception message:\r\n    " + e.Message + "\r\n\r\nException stack trace:\r\n" + e.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        return new SyndicationFeed();
    }

   
    public static SyndicationFeed getProductsFeedsByName(String name,int startedPage,int maxPerPage)
    {
        if (String.IsNullOrEmpty(name))
            return null;
        return AtomResultRequest(new Uri(serverBaseUri + "/rest/api/products?q=" + name + "&start-page=" + startedPage + "&page-size=" + maxPerPage));
    }
    public static SyndicationFeed getPackageFeedsByName(String name, int startedPage, int maxPerPage,String type)
    {
        if (String.IsNullOrEmpty(name))
            return null;
        return AtomResultRequest(new Uri(serverBaseUri+ "/rest/api/packages?q=" + name +"&type="+type +"&start-page=" + startedPage + "&page-size=" + maxPerPage));
    }

    public static SyndicationFeed getRecosFeedsByName(String name, int startedPage, int maxPerPage)
    {
        if (String.IsNullOrEmpty(name))
            return null;
        return AtomResultRequest(new Uri(serverBaseUri+ "/rest/api/recos?q=" + name + "&start-page=" + startedPage + "&page-size=" + maxPerPage));
    }

    public static SyndicationFeed getMoleculeFeedsByName(String name, int startedPage, int maxPerPage)
    {
        if (String.IsNullOrEmpty(name))
            return null;
        return AtomResultRequest(new Uri(serverBaseUri+ "/rest/api/molecules?q=" + name + "&start-page=" + startedPage + "&page-size=" + maxPerPage));
    }

    public static SyndicationFeed getCompaniesFeedsByName(String name, int startedPage, int maxPerPage)
    {
        if (String.IsNullOrEmpty(name))
            return null;
        return AtomResultRequest(new Uri(serverBaseUri+ "/rest/api/companies?q=" + name + "&start-page=" + startedPage + "&page-size=" + maxPerPage));
    }
   


    public static Uri getDocumentRelativeUriBySyndicationFeed(SyndicationFeed documentSyndicationFeed)
    {
        Uri documentUri = null;
        if (documentSyndicationFeed == null)
            return documentUri;
        //treatement of url
        if (documentSyndicationFeed.Items != null)
            //get only the first item of the collection    
            foreach (var documentSyndicationItem in documentSyndicationFeed.Items)
            {
                documentUri = getRelativeUri(documentSyndicationItem.Links[0].Uri);
                break;
            }
        return documentUri;
    }

    public static List<Product> getProductsBySyndicationFeed(SyndicationFeed productsFeed)
    {
        List<Product> products = new List<Product>();
        foreach (SyndicationItem productFeed in productsFeed.Items)
        {
        Product product = getProductByFeedItem(productFeed);
        products.Add(product);
        }    
        return products;
    }

    private static Product getProductByFeedItem(SyndicationItem productFeed)
    {
        String productName = "";
        if (productFeed != null)
        {
            productName = productFeed.Title.Text;



            //Uri productRelativeUri = RestUtils.getAbsoluteUri(productFeed.Links[0].Uri);
            Uri productRelativeUri = null;
            SyndicationLink productRelativeUriLink = (productFeed.Links.FirstOrDefault(l => (l.RelationshipType == "alternate")));

            if (productRelativeUriLink != null)
            {
                productRelativeUri = productRelativeUriLink.Uri;
            }

            int productId = productFeed.ElementExtensions.ReadElementExtensions<int>("id", vidalNameSpace).FirstOrDefault();
            String beCareful = productFeed.ElementExtensions.ReadElementExtensions<String>("beCareful", vidalNameSpace).FirstOrDefault();
            String genericType = productFeed.ElementExtensions.ReadElementExtensions<String>("genericType", vidalNameSpace).FirstOrDefault();
            String companyName = productFeed.ElementExtensions.ReadElementExtensions<String>("company", vidalNameSpace).FirstOrDefault();
            String dispensationPlace = productFeed.ElementExtensions.ReadElementExtensions<String>("dispensationPlace", vidalNameSpace).FirstOrDefault();
            String marketStatus = productFeed.ElementExtensions.ReadElementExtensions<String>("marketStatus", vidalNameSpace).FirstOrDefault();
            String refundRate = productFeed.ElementExtensions.ReadElementExtensions<String>("refundRate", vidalNameSpace).FirstOrDefault();
            String liste = productFeed.ElementExtensions.ReadElementExtensions<String>("list", vidalNameSpace).FirstOrDefault();
            String midwife = productFeed.ElementExtensions.ReadElementExtensions<String>("midwife", vidalNameSpace).FirstOrDefault();
            String vigilance = productFeed.ElementExtensions.ReadElementExtensions<String>("vigilance", vidalNameSpace).FirstOrDefault();
            SyndicationLink productDocumentOptLink = (productFeed.Links.FirstOrDefault(l => (l.Title == "OPT_DOCUMENT")));
            Uri productDocumentOpt = null;
            if (productDocumentOptLink != null)
            {
                productDocumentOpt = productDocumentOptLink.Uri;
            }
            String vmpName = productFeed.ElementExtensions.ReadElementExtensions<String>("vmp", vidalNameSpace).FirstOrDefault();
            Product product = new Product(productRelativeUri, productId, productName, beCareful, genericType, companyName, dispensationPlace, marketStatus, refundRate, liste, productDocumentOpt, midwife, vigilance, vmpName);
            return product;
        }
        else return null;
    }





    public static SyndicationFeed getFeedByUri(Uri uri)
    {
        if (uri == null)
            return null;
        return AtomResultRequest(uri);
    }

    public static ProductDetailAggregate getProductDetail(Uri productUri)
    {
        ProductDetailAggregate pd = getProductDetailByFeedItem(getProductDetailAggregateFeeds(getAbsoluteUri(productUri)));
        return pd;
    }

    private static SyndicationFeed getProductDetailAggregateFeeds(Uri uri)
    {
        if (uri == null)
            return null;
        Uri uriFinal = new Uri(getAbsoluteUri(uri) + "?aggregate=PACKAGES&aggregate=MOLECULES&aggregate=RECOS&aggregate=GENERIC_GROUPS&aggregate=VIDAL_CLASSIFICATION");
        return AtomResultRequest(uriFinal);
    }

    private static ProductDetailAggregate getProductDetailByFeedItem(SyndicationFeed productFeed)
    {
        Product product = getProductByFeedItem(productFeed.Items.SingleOrDefault(l => (l.Categories[0].Name == "PRODUCT")));
        IEnumerable<SyndicationItem> molecules = productFeed.Items.Where(l => (l.Categories[0].Name == "MOLECULE"));
        List<Molecule> moleculeList = new List<Molecule>();
        foreach (SyndicationItem item in molecules)
        {
            String moleculeName = item.Title.Text;
            int id = item.ElementExtensions.ReadElementExtensions<int>("id", vidalNameSpace).FirstOrDefault();

            Molecule molec = new Molecule(id,moleculeName);
            moleculeList.Add(molec);
        }

        IEnumerable<SyndicationItem> recos = productFeed.Items.Where(l => (l.Categories[0].Name == "RECO"));
        List<Reco> recoList = getRecosBySyndicationFeed(recos);

        IEnumerable<SyndicationItem> vidalClassifs = productFeed.Items.Where(l => (l.Categories[0].Name == "VIDAL_CLASSIFICATION"));
        List<VidalClassification> vidalList = new List<VidalClassification>();
        foreach (SyndicationItem item in vidalClassifs)
        {
            String classifName = item.Title.Text;
            String id = item.Id;
            SyndicationLink parentLink = (item.Links.FirstOrDefault(l => (l.RelationshipType == "inline")));
            Uri parentLinkUri = null;
            if (parentLink != null)
            {
                parentLinkUri = parentLink.Uri;
            }

            VidalClassification vidalClass = new VidalClassification(id, classifName, parentLinkUri);
            vidalList.Add(vidalClass);
        }

        IEnumerable<SyndicationItem> packages = productFeed.Items.Where(l => (l.Categories[0].Name == "PACKAGE"));
        List<Package> packList = getPackagesBySyndicationFeed(packages);

        IEnumerable<SyndicationItem> genGroups = productFeed.Items.Where(l => (l.Categories[0].Name == "GENERIC_GROUP"));
        List<GenericGroup> groups = new List<GenericGroup>();
        foreach (SyndicationItem group in genGroups)
        {
            int id =group.ElementExtensions.ReadElementExtensions<int>("id", vidalNameSpace).FirstOrDefault(); 
            String name =group.Title.Text ;
            String type = group.ElementExtensions.ReadElementExtensions<String>("genericType", vidalNameSpace).FirstOrDefault();
            SyndicationLink productSyndicationLink = group.Links.FirstOrDefault(l => (l.Title == "PRODUCT"));
            Uri productLink = null;
            if (productSyndicationLink != null)
            {
                productLink = productSyndicationLink.Uri;
            }
            groups.Add(new GenericGroup(id, name, type, productLink));
        }

        ProductDetailAggregate fullProduct = new ProductDetailAggregate();
        fullProduct.product = product;
        fullProduct.recos = recoList;
        fullProduct.vidalClassifications = vidalList;
        fullProduct.packages = packList;
        fullProduct.molecules = moleculeList;
        fullProduct.GenericGroups = groups;


        return fullProduct;
    }

    public static List<Reco> getRecosBySyndicationFeed(IEnumerable<SyndicationItem> recos)
    {
        List<Reco> recoList = new List<Reco>();
        foreach (SyndicationItem item in recos)
        {
            String recoName = item.Title.Text;
            int id = item.ElementExtensions.ReadElementExtensions<int>("id", vidalNameSpace).FirstOrDefault();

            Uri altLink = null;
            SyndicationLink altSyndicationLink = item.Links.FirstOrDefault(l => (l.RelationshipType == "alternate"));
            if (altSyndicationLink != null)
            {
                altLink = altSyndicationLink.Uri;
            }

            Reco reco = new Reco(id, recoName, altLink);
            recoList.Add(reco);
        }
        return recoList;
    }

    public static List<MoleculeSynonym> getMoleculesBySyndicationFeed(IEnumerable<SyndicationItem> molecules)
    {
        List<MoleculeSynonym> moleculeList = new List<MoleculeSynonym>();
        foreach (SyndicationItem item in molecules)
        {
            int moleculeId = item.ElementExtensions.ReadElementExtensions<int>("id", vidalNameSpace).FirstOrDefault();;
            String moleculeName = item.Title.Text;
            Uri productsLink = new Uri(serverBaseUri + "/rest/api/molecule/"+moleculeId+"/products?"+"substance-type=ACTIVE_PRINCIPLE");
            //fixMe : link is not good : /rest/api/molecule/2036/products?substanceType-type=ACTIVE_PRINCIPLE in place of "substance-type=ACTIVE_PRINCIPLE&association-type=ONLY"
            //SyndicationLink productsSyndicationLink = item.Links.FirstOrDefault(l => (l.Title == "PRODUCTS"));
            //if (productsSyndicationLink != null)
            //{
              //  productsLink = productsSyndicationLink.Uri;
            //}

            String fullName = item.ElementExtensions.ReadElementExtensions<String>("fullName", vidalNameSpace).FirstOrDefault(); ; ;

            MoleculeSynonym synonym = new MoleculeSynonym(moleculeId, moleculeName, null, productsLink, fullName);
            moleculeList.Add(synonym);
        }
        return moleculeList;
    }

    public static List<Company> getCompaniesBySyndicationFeed(IEnumerable<SyndicationItem> companies)
    {
        List<Company> companyList = new List<Company>();
        foreach (SyndicationItem item in companies)
        {
            int companyId = item.ElementExtensions.ReadElementExtensions<int>("id", vidalNameSpace).FirstOrDefault(); ;
            String companyName = item.Title.Text;
            Uri productsLink = null;
            SyndicationLink productsSyndicationLink = item.Links.FirstOrDefault(l => (l.Title == "PRODUCTS"));
            if (productsSyndicationLink != null)
            {
                productsLink = productsSyndicationLink.Uri;
            }
            Uri packagesLink = null;
            SyndicationLink packagesSyndicationLink = item.Links.FirstOrDefault(l => (l.Title == "PACKAGES"));
            if (packagesSyndicationLink != null)
            {
                packagesLink = packagesSyndicationLink.Uri;
            }
            Company company = new Company(companyId, companyName, packagesLink, productsLink);
            companyList.Add(company);
        }
        return companyList;
    }

    public static List<Package> getPackagesBySyndicationFeed(  IEnumerable<SyndicationItem> packagesFeed)
    {
        List<Package> packages = new List<Package>();
        foreach (SyndicationItem packageFeed in packagesFeed)
        {
            String packageName = packageFeed.Title.Text;
            
            Uri packageRelativeUri = null;
            SyndicationLink packageRelativeUriLink = (packageFeed.Links.FirstOrDefault(l => (l.RelationshipType == "alternate")));
            
            if (packageRelativeUriLink != null)
            {
                packageRelativeUri = packageRelativeUriLink.Uri;
            }

            int packageId = packageFeed.ElementExtensions.ReadElementExtensions<int>("id", vidalNameSpace).FirstOrDefault();
            String companyName = packageFeed.ElementExtensions.ReadElementExtensions<String>("company", vidalNameSpace).FirstOrDefault();
            String marketStatus = packageFeed.ElementExtensions.ReadElementExtensions<String>("marketStatus", vidalNameSpace).FirstOrDefault();

            String lppr="";
            String lpprCode="";
            Collection<XElement> nodes = packageFeed.ElementExtensions.ReadElementExtensions<XElement>("lppr", vidalNameSpace);
            if (nodes!=null && nodes.Count>0){
                lppr = nodes[0].Value;
                lpprCode = nodes[0].Attribute("code").Value;
            }
            String cip = packageFeed.ElementExtensions.ReadElementExtensions<String>("cip", vidalNameSpace).FirstOrDefault();
            
            String cip13 = packageFeed.ElementExtensions.ReadElementExtensions<String>("cip13", vidalNameSpace).FirstOrDefault();
            String liste = packageFeed.ElementExtensions.ReadElementExtensions<String>("list", vidalNameSpace).FirstOrDefault();
            float pharmacistPrice = packageFeed.ElementExtensions.ReadElementExtensions<float>("pharmacistPrice", vidalNameSpace).FirstOrDefault();
            String refundRate = packageFeed.ElementExtensions.ReadElementExtensions<String>("refunRate", vidalNameSpace).FirstOrDefault();
            float refundingBase = packageFeed.ElementExtensions.ReadElementExtensions<float>("refundingBase", vidalNameSpace).FirstOrDefault();

            SyndicationLink packageDocumentOptLink = (packageFeed.Links.FirstOrDefault(l => (l.Title == "OPT_DOCUMENT")));
            Uri packageDocumentOpt = null;
            if (packageDocumentOptLink != null)
            {
                packageDocumentOpt = packageDocumentOptLink.Uri;
            }

            Package pack = new Package(packageRelativeUri, packageId, packageName, companyName, marketStatus, lppr,lpprCode,cip,cip13,liste,pharmacistPrice,refundRate,refundingBase,packageDocumentOpt);
            packages.Add(pack);
        }
        return packages;
    }

    
    

    public static PackageDetailAggregate getDetailAggregatePackageByUri(Uri uri)
    {
       SyndicationFeed packageFeed =  getFeedByUri(new Uri(getAbsoluteUri(uri)+"?aggregate=LPPR&&aggregate=SAUMON_CLASSIFICATION"));   
        List<Package> packList = getPackagesBySyndicationFeed(packageFeed.Items);
        PackageDetailAggregate packDetail = new PackageDetailAggregate();
        packDetail.package = packList[0];

        //aggregate Saumon_classification information
        IEnumerable<SyndicationItem> saumonClassifs = packageFeed.Items.Where(l => (l.Categories[0].Name == "SAUMON_CLASSIFICATION"));
        List<SaumonClassification> saumonList = new List<SaumonClassification>();
        foreach (SyndicationItem item in saumonClassifs)
        {
            String classifName = item.Title.Text;
            String id = item.Id;
            SyndicationLink parentLink = (item.Links.FirstOrDefault(l => (l.RelationshipType == "inline")));
            Uri parentLinkUri = null;
            if (parentLink != null)
            {
                parentLinkUri = parentLink.Uri;
            }

            SaumonClassification saumonClass = new SaumonClassification(id, classifName, parentLinkUri);
            saumonList.Add(saumonClass);
        }
        packDetail.saumons = saumonList;

        //aggregate the Lppr informations
        IEnumerable<SyndicationItem> lpprItems = packageFeed.Items.Where(l => (l.Categories[0].Name == "LPPR"));
        List<Lppr> lpprList = new List<Lppr>();
        foreach (SyndicationItem item in lpprItems)
        {
            int id = item.ElementExtensions.ReadElementExtensions<int>("id", vidalNameSpace).FirstOrDefault();
            String name = item.Title.Text;
            String actCode = item.ElementExtensions.ReadElementExtensions<String>("act", vidalNameSpace).FirstOrDefault(); ;
            String code =  item.ElementExtensions.ReadElementExtensions<String>("code", vidalNameSpace).FirstOrDefault(); ;;
            int coef =  item.ElementExtensions.ReadElementExtensions<int>("coef", vidalNameSpace).FirstOrDefault(); ;;
            float refundBase = item.ElementExtensions.ReadElementExtensions<float>("refundingBase", vidalNameSpace).FirstOrDefault(); ; ;
            String service = item.ElementExtensions.ReadElementExtensions<String>("service", vidalNameSpace).FirstOrDefault(); ; ; ;
            Lppr lppr = new Lppr(id,name,actCode,code,coef,refundBase,service);
            lpprList.Add(lppr);
        }
        packDetail.lpprs = lpprList;
        return packDetail;
    }

    
}