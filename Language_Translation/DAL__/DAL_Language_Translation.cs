using BusinessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DAL 
{
    public class DAL_Language_Translation
    {
  
     #region Translation   
     
        public List<VM_Translation_List> GET_TRANSLATIONS_BY_ENGLISH(string EnglishWord)
        {
              SqlParameter[] param = {
             new SqlParameter("@EnglishWord", EnglishWord),
             new SqlParameter("@Message", SqlDbType.NVarChar, 255) { Direction = ParameterDirection.Output }  
         };

              DataTable dt = new DataAccess(sqlConnection.GetConnectionString()).GetDataTable("GetTranslationsByEnglish", CommandType.StoredProcedure, param);
            List<VM_Translation_List> _inc = new List<VM_Translation_List>();

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    _inc.Add(new VM_Translation_List
                    {
                        English = Convert.ToString(row["English"]),
                        Hungarian = Convert.ToString(row["Hungarian"]),
                        Spanish = Convert.ToString(row["Spanish"]),
                        Chinese = Convert.ToString(row["Chinese"]),
                        Portuguese = Convert.ToString(row["Portuguese"]),
                        ERRORMSG = "",                     
                    });
                }
            }
            return _inc;
        }
		
		
     #endregion


    }
}
