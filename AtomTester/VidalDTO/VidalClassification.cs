using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtomTester
{
   public class VidalClassification
    {
        public String id;
        public String name;
        public Uri parentLink;

        public VidalClassification(String id, String name, Uri parentLink)
        {
            this.id = id;
            this.name = name;
            this.parentLink = parentLink;
        }
    }
}
