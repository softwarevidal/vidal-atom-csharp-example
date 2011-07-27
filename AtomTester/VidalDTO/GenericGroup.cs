using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtomTester
{
   public class GenericGroup
    {
       public int id;
       public String name;
       public String type;
       public Uri genTypeLink;

       public GenericGroup(int id, String name, String type, Uri genTypeLink)
       {
           this.id = id;
           this.name = name;
           this.type = type;
           this.genTypeLink = genTypeLink;
       }

    }
}
