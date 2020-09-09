using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TemplateMethod
{
    public class XMLFormat:Convert
    {
        public XMLFormat(string path) : base(path) { }
        
        public override void Save(List<string> l)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                FileName = "unknown.xml",
                Filter = "XML Files|*.xml",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (XmlWriter writer = XmlWriter.Create(saveFileDialog1.FileName))
                {
                    writer.WriteStartElement("e-mail");
                    writer.WriteElementString("to", l[0]);
                    writer.WriteElementString("from", l[1]);
                    writer.WriteElementString("subject", l[2]);
                    writer.WriteElementString("body", l[3]);
                    writer.WriteEndElement();
                    writer.Flush();
                }                
            }  
        }
    }
}
