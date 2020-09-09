using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\Student\Documents",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {                
                path = openFileDialog1.FileName;
                using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                {
                    richTextBox2.Text = reader.ReadToEnd();
                    reader.Close();
                }
            }            
        } 

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Convert f = new TextFormat(path);
            f.EmailConverter();
        }

        private void SaveXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Convert f = new XMLFormat(path);
            f.EmailConverter();
        }
        private void RichTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox2 != null) {
                saveXMLToolStripMenuItem.Visible = true;
                saveTXTToolStripMenuItem.Visible = true;
            }
        }
        string path;
    }
}
