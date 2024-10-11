using BusinessLayer;
using BusinessLayer.DAL;
using BusinessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq.Dynamic;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using NLog;
using System.Configuration;
using System.Net;


namespace eARC.Controllers
{
    public class Language_TranslationController : BaseController
    {
        Logger logger = LogManager.GetCurrentClassLogger();

        //
        // GET: /Language_Translation/
   
        #region Language_Translation      _____________________ ADDED BY RAHUL MALL   DATE - 11/10/2024

        public ActionResult Language_Translation (){
           VM_Language_Translation obj = new VM_Language_Translation();
           return View(obj);
        }


        [HttpPost]
        [SubmitButtonSelector(Name = "View")]
        [ActionName("Language_Translation")]
        public ActionResult Language_Translation(VM_Language_Translation obj)
        {
            ViewBag.Header = "Language Translation";
            VM_Translation_List tr = new VM_Translation_List();
            try
            {
                obj.Translation_List = new DAL_Language_Translation().GET_TRANSLATIONS_BY_ENGLISH(obj.EnglishWord);      
            } 
            catch (Exception ex)
            {
                Danger(string.Format("<b>Error : </b>" + ex.Message), true);
            }

            return View(obj);
        }

        #endregion

    }
}
