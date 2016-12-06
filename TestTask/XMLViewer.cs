using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace TestTask
{
    public partial class XMLViewer : Form
    {
        public XMLViewer()
        {
            oXmlManager = new XMLManager(dataGridView1); 
            InitializeComponent();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            Stream xmlFileStream = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xmlFileStream = openFileDialog1.OpenFile();
                if (xmlFileStream == null)
                {
                    MessageBox.Show("Can not open file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            StreamReader xmlReader = new StreamReader(xmlFileStream);
            string sXmlContent = xmlReader.ReadToEnd();
            oXmlManager.createDataGridFromXml(dataGridView1, sXmlContent);
            xmlReader.Close(); 
         }
        

        private void Add_Click(object sender, EventArgs e)
        {
            oXmlManager.addNewTagsToXml(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            oXmlManager.markForDelete(dataGridView1, e.RowIndex);
        }

        private void SaveAll_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream xmlFileStream = saveFileDialog1.OpenFile();
                if (xmlFileStream != null)
                {
                    oXmlManager.saveChangesToXml(xmlFileStream);
                }
                else
                {
                    MessageBox.Show("Can not save file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private XMLManager oXmlManager;

        private void Edit_Click(object sender, EventArgs e)
        {
            bool rdWr;

            if (dataGridView1.Rows[0].Cells[0].ReadOnly)
            {
                rdWr = false;
            }
            else
            {
                rdWr = true;
            }

            foreach (DataGridViewBand band in dataGridView1.Columns)
            {
                band.ReadOnly = rdWr;
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            int numTegs = Convert.ToInt32(removeCount.Text);
            oXmlManager.removeXmlTags(dataGridView1, numTegs);
        }


        
    }
}
