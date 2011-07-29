using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtomTester
{
    public class Company
    {
        private readonly String name;

        public String Name
        {
            get { return name; }
        } 

        public readonly int id;
        public readonly Uri packagesLink;
        public readonly Uri productsLink;
        
        public Company(int id, String name, Uri packagesLink, Uri productsLink){
            this.id = id;
            this.name = name;
            this.packagesLink = packagesLink;
            this.productsLink = productsLink;
        }


    }
}
