using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Net;

namespace AtomTester
{
    public partial class OrdoForm : Form
    {
        public OrdoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prescription ordo = new Prescription();
            Patient pat = new Patient();
            PrescriptionLine line = new PrescriptionLine();
            line.drugId = 4002;
            line.drugType = "PRODUCT";
            List<PrescriptionLine> lines = new List<PrescriptionLine>();
            lines.Add(line);
            ordo.patient = pat;
            ordo.prescriptionlines = lines;
            XmlSerializer xs = new XmlSerializer(typeof(Prescription));
            
            StringWriter serial = new Utf8StringWriter();
            xs.Serialize(serial, ordo);
            
            string data = serial.ToString();
            byte[] dataByte = Encoding.UTF8.GetBytes(data);
             
                HttpWebRequest httpWReq = (HttpWebRequest)WebRequest.Create("http://apirest-beta.vidal.fr/rest/api/alerts");
                httpWReq.Method = "POST";
                httpWReq.ContentType = "text/xml";
                httpWReq.ContentLength = dataByte.Length;
            
                using (Stream newStream = httpWReq.GetRequestStream())
               {
                    newStream.Write(dataByte, 0, dataByte.Length);
                    newStream.Close();
                }
                
                    WebResponse response = httpWReq.GetResponse();

                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    string ResponseMessage = reader.ReadToEnd();
                    response.Close();
        }
    }

    public class Utf8StringWriter : StringWriter
    {
        public override Encoding Encoding
        {
            get { return Encoding.UTF8; }
        }
    }
}
