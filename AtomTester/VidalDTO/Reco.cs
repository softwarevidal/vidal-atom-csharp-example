using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtomTester
{
    public class Reco
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private String name;
        public Uri recolink;

        public Reco(int id, String name, Uri recolink)
        {
            this.id = id;
            this.name = name;
            this.recolink = recolink;
         }
        public String Name
        {
            get { return name; }
        }
    }
}
