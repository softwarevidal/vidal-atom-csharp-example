using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtomTester
{
   public class AtcClassification
    {
        public String feedid;
        public String name;
        public Uri parentLink;
        public int id;
        public Uri productsLink;

        public AtcClassification(int id,String feedid, String name, Uri parentLink, Uri productsLink)
        {
            this.feedid = feedid;
            this.name = name;
            this.parentLink = parentLink;
            this.id = id;
            this.productsLink = productsLink;
        }
    }
}
