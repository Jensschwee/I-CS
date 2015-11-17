using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTest.Models
{
    public class NameList
    {
        private static NameList nameList;

        public List<String> ListOFNames;


        private NameList()
        {
            ListOFNames = new List<string>();
            ListOFNames.Add("rghre");
            ListOFNames.Add("sdg");
            ListOFNames.Add("rghsgrre");

        }

        public static NameList Instance
        {
            get
            {
                if (nameList == null)
                {
                    nameList = new NameList();
                }
                return nameList;
            }
        }


        public List<string> ListOfNames
        {
            get { return ListOFNames; }
            set { ListOFNames = value; }
        }
    }
}