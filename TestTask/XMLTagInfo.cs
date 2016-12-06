using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TestTask
{
    class XMLTagInfo
    {
        public XMLTagInfo(string sXmlFileName, bool bIsActive) 
        {
            sComponent = sXmlFileName;
            isAllow = bIsActive;
            isDeleted = false;

        }

        public string sComponent { get; set; }
        public bool isAllow { get; set; }
        public bool isDeleted { get; set; }

    }
}
