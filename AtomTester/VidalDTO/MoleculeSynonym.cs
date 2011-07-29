using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtomTester
{
   public class MoleculeSynonym
    {
        public readonly int moleculeId;
        private readonly String moleculeName;
        private readonly String fullName;

        public String FullName
        {
            get { return fullName; }
        } 


        public String MoleculeName
        {
            get { return moleculeName; }
        }

        private readonly List<String> synonyms;

        public List<String> Synonym
        {
            get { return synonyms; }
        } 

        public readonly Uri productsLink;
        
        
        public MoleculeSynonym(int moleculeId, String name,List<String> synonyms,Uri productsLink,String fullName){
            this.moleculeId=moleculeId;
            this.moleculeName = name;
            this.synonyms = synonyms;
            this.productsLink = productsLink;
            this.fullName = fullName;
        }
    }
}
