using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace AtomTester
{
    [XmlRoot("patient")]
    public class Patient
    {
        public List<string> allergies { get; set; }
        public List<string> molecules { get; set; }
        public List<string> pathologies { get; set; }

        public string breastFeeding { get; set; }
        public int weeksOfAmenorrhea{ get; set; }
        public float weight { get; set; }
        public int creatin{ get; set; }
        public string gender { get; set; }
        public int height { get; set; }
        public string hepaticInsufficiency { get; set; }
        public string dateOfBirth { get; set; }



        public Patient()
        {

            this.allergies = new List<string>();
            this.molecules = new List<string>(); 
            this.pathologies = new List<string>();

            this.breastFeeding = "NONE";
            this.weeksOfAmenorrhea = 0;
            this.weight = 80f;
            this.creatin = 100;
            this.gender = "MALE";
            this.height = 180;
            this.hepaticInsufficiency = "NONE";
            this.dateOfBirth = "2012-11-08T15: 44:50.980+01:00";
        }

    }

   

}
