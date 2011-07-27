using System;

public class Package
{
    public readonly int id;
    public readonly String name;
    public readonly String companyName;
    public readonly String marketStatus;
    public readonly String lppr;
    public readonly float refundingBase;
    public readonly String cip13;
    public readonly String cip;
    public readonly String liste;
    public readonly float pharmacistPrice;
    public readonly Uri packageRelativeUri;
    public readonly String refundRate;
    public readonly Uri monoRelativeUri;

    public Package(Uri packageRelativeUri, int id, String name, String companyName, String marketStatus, String lppr, String cip, String cip13, String liste, float pharmacistPrice, String refundRate, float refundingBase, Uri monoRelativeUri)
    {
        this.packageRelativeUri = packageRelativeUri;
        this.id = id;
        this.name = name;
        this.companyName = companyName;
        this.lppr = lppr;
        this.cip = cip;
        this.cip13 = cip13;
        this.liste = liste;
        this.pharmacistPrice = pharmacistPrice;
        this.refundRate = refundRate;
        this.refundingBase=refundingBase;
        this.marketStatus = marketStatus;
        this.monoRelativeUri = monoRelativeUri;
    }

    

    public int Id
    {
        get { return id; }
    }
    public  String Name
    {
        get { return name; }
    }

    public  String CompanyName
{
        get { return companyName; }
    }
    public  String MarketStatus
{
        get { return marketStatus; }
    }
    public  Uri PackageRelativeUri
{
    get { return packageRelativeUri; }
    }
    public String Lppr
    {
        get { return lppr; }
    }

    public String Cip13
    {
        get { return cip13; }
    }
    public String Cip
    {
        get { return cip; }
    }
    public String Liste
    {
        get { return liste; }
    }


    public float RefundingBase
    {
        get { return refundingBase; }
    }
    public float PharmacistPrice
    {
        get { return PharmacistPrice; }
    }
    public String RefundRate
    {
        get { return refundRate; }
    }
   
    
    public override string ToString()
    {

        return this.id +" : " +this.name;
    }

}