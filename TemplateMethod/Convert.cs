using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class Convert
    {        
        public Convert(string path)
        {
            this.path = path;           
        }
        public void EmailConverter()
        {
            List<string> lines = new List<string>();
            using (var sr = new StreamReader(path))
            {
                lines.Add(sr.ReadLine());
                lines.Add(sr.ReadLine());
                lines.Add(sr.ReadLine());
                lines.Add(sr.ReadToEnd());
            }
            Save(lines);
        }

        public abstract void Save(List<string> lines);        

        private readonly string path;        
    }
}
    