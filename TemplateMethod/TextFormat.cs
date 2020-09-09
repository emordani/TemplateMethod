using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TemplateMethod
{
    public class TextFormat : Convert
    {
        public TextFormat(string path):base(path){ }

        public override void Save(List<string> l)
        {
            string text="To: "+l[0]+"\n"+"From: " + l[1] + "\n" +"Subject: " + l[2] + "\n" +"Body: " + l[3] + "\n";            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                FileName = "unknown.txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    sw.WriteLine(text);             
            }
        }

        
    }
}
