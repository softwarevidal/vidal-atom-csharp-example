using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace AtomTester
{
    [XmlRoot("prescription")]
    public class Prescription
    {
        [XmlElement("patient")]
        public Patient patient { get; set; }

        [XmlArray("prescription-lines")]
        [XmlArrayItem("prescription-line")]
        public List<PrescriptionLine> prescriptionlines { get; set; }
    } 
}
