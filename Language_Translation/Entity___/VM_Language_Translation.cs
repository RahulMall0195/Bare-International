using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace BusinessLayer.Entity
{
    public class VM_Language_Translation
    {
        public List<VM_Translation_List> Translation_List { get; set; }
        public string EnglishWord { get; set; }
    }

    public class VM_Translation_List
    {
        public string English { get; set; }
        public string Hungarian { get; set; }
        public string Spanish { get; set; }
        public string Chinese { get; set; }
        public string Portuguese { get; set; }
        public string ERRORMSG { get; set; }
    }

}

