using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
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
            string sql = "Insert into tblFiles (OriginalFilePath,LockedFileName,Status) Values ('"+OrignalFileName+"','"+LockedFile+"',1)";
            dbController db = new dbController();
            db.getQueryScaller(sql);
	    }

        public static void DeleteOldFiles()
        {
            dbController db = new dbController();
            string sql = "Select LockedFileName From tblFiles Where Status = 0";
            DataTable tbl = db.getQueryList(sql);
            FileController fileC = new FileController();
            foreach (DataRow row in tbl.Rows)
            {
                string FilePathToDelete = fileC.VaultFolderPath() + row["LockedFileName"].ToString();
                File.Delete(FilePathToDelete);
            }

            sql = "Delete From tblFiles Where Status = 0";
            db.getQueryScaller(sql);
        }

    }
}
