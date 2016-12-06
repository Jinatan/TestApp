using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace TestTask
{
    class XMLFormatter
    {
        public int AddFileTagsToList(List<XMLTagInfo> tagInfo)
        {
            Random rand = new Random();
            int randNumOftags = rand.Next(100);
            string randName;
            XMLTagInfo info;

            for (int i = 0; i < randNumOftags; ++i)
            {
                randName = generateName();
                info = new XMLTagInfo(randName, false);
                tagInfo.Add(info);
            }

            return randNumOftags;
        }
        
        private string generateName()
        {
            string[] letters = {"a","A","b","B","c","C","d","D","e","E","f","F","g","G","h","H","j","J","k","K","l","L","m","M",
                                 "n","N","o","O","p","P","q","Q","r","R","s","S","t","T","u","U","v","V","w","W","x","X","y","Y","z","Z", "_"};

            Random rName = new Random();
            int lenName = rName.Next(3, 13);
            string resName = "";

            for (int i = 0; i < lenName; ++i )
            {

                resName += letters[rName.Next(0, 50)];
            }

            return resName;
        }

        public void removeTagsFromList(List<XMLTagInfo> tagInfo, int count)
        {
            for (int i = tagInfo.Count - 1; i > count; --i)
            {
                tagInfo.RemoveAt(i);
            }
        }
    }

}
