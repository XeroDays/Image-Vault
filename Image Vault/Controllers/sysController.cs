using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_Vault.Controllers
{
    public static class sysController
    {
        public static string connString { get { return ConfigurationManager.ConnectionStrings["connectionCode"].ConnectionString; } }

        public static void AddRecord(string OrignalFileName,string LockedFile)
	    {
            string sql = "Insert into tblFiles (OriginalFilePath,LockedFileName) Values ('"+OrignalFileName+"','"+LockedFile+"')";
            dbController db = new dbController();
            db.getQueryScaller(sql);
	    }

    }
}
