using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Windows.Forms;


namespace TestTask
{
    class XMLManager
    {
        public XMLManager(DataGridView viewGrid)
        {
            xmlTagInfoList = new List<XMLTagInfo>();
        }
        
        public void createDataGridFromXml( DataGridView gridView, string sXmlContent)
        {
            string sTemp;
            XMLTagInfo info;
            XmlReader reader = XmlReader.Create(new StringReader(sXmlContent));

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Text:
                        sTemp = (reader.Value).Replace(".xml", "");
                        info = new XMLTagInfo(sTemp, false);
                        xmlTagInfoList.Add(info);
                        break;
                    case XmlNodeType.Comment:
                        sTemp = (reader.Value).Replace(".xml", "");
                        sTemp = sTemp.Replace("<file>","");
                        sTemp = sTemp.Replace("</file>", "");
                        info = new XMLTagInfo(sTemp, true);
                        xmlTagInfoList.Add(info);
                        break;
                    case XmlNodeType.XmlDeclaration:
                        sXmlVersion = reader.Value;
                        break;
                }
            }

            PopilateGridView(gridView, 0);
        }

        private void PopilateGridView(DataGridView gridView, int pos)
        {
            for (int i = pos; i < xmlTagInfoList.Count-1; ++i)
            {
                int n = gridView.Rows.Add();
                gridView.Rows[n].Cells[0].ReadOnly = true;
                gridView.Rows[n].Cells[1].ReadOnly = true;
                gridView.Rows[n].Cells[0].Value = xmlTagInfoList[i].sComponent;
                gridView.Rows[n].Cells[1].Value = xmlTagInfoList[i].isAllow;
                gridView.Rows[n].Cells[BUTTON_INDEX].Value = "Delete";
            }
        }

        public void markForDelete(DataGridView gridView, int index)
        {
            if (!xmlTagInfoList[index + 1].isDeleted)
            {
                xmlTagInfoList[index + 1].isDeleted = true;
                gridView.Rows[index].Cells[BUTTON_INDEX].Value = "Restore";
            }
            else
            {
                xmlTagInfoList[index + 1].isDeleted = false;
                gridView.Rows[index].Cells[BUTTON_INDEX].Value = "Delete";
            }
            
        }

        public void addNewTagsToXml(DataGridView gridView)
        {
            XMLFormatter formatter = new XMLFormatter();
            int currentTagsCount = xmlTagInfoList.Count;

            int randAdded = formatter.AddFileTagsToList(xmlTagInfoList);
            PopilateGridView(gridView, currentTagsCount);

            MessageBox.Show(randAdded.ToString(), "Added new Items", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public bool saveChangesToXml(Stream xmlStream)
        {
            for (int i = 0; i < xmlTagInfoList.Count; ++i)
            {
                if (xmlTagInfoList[i].isDeleted)
                {
                    xmlTagInfoList.RemoveAt(i);
                }
            }

            StreamWriter xmlWriter = new StreamWriter(xmlStream);
            string xmlVersionTag = "<?xml " + sXmlVersion + " ?>";
            xmlWriter.WriteLine(xmlVersionTag);
            xmlWriter.WriteLine("<testlist>");
            string sXmlPathrootTag = "<pathroot>" + xmlTagInfoList[0] + "</pathroot>";
            xmlWriter.WriteLine(sXmlPathrootTag);
            for(int i = 1; i < xmlTagInfoList.Count; i++)
            {
                string tegComponent;
                if (xmlTagInfoList[i].isAllow)
                {
                    tegComponent = "<!--<file>" + xmlTagInfoList[i].sComponent + ".xml</file>-->";
                }
                else
                {
                    tegComponent = "<file>" + xmlTagInfoList[i].sComponent + ".xml</file>";
                }
                xmlWriter.WriteLine(tegComponent);
            }
            xmlWriter.WriteLine("</testlist>");
            xmlWriter.Close();
            return true;
        }

        public void removeXmlTags(DataGridView gridView, int count)
        {
            try
            {
                XMLFormatter formatter = new XMLFormatter();
                formatter.removeTagsFromList(xmlTagInfoList, count);

                for (int i = gridView.RowCount - 2; i > count - 1; --i)
                {
                    gridView.Rows.RemoveAt(i);
                }
            }
            catch { }
        }

        private List<XMLTagInfo> xmlTagInfoList;
        private const int BUTTON_INDEX = 2;
        private string sXmlVersion;
    }
}
