using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace AtomTester
{
    [XmlRoot("prescription-line")]
    public class PrescriptionLine
    {
        public int drugId { get; set; }
        public string drugType { get; set; }
    }
}
