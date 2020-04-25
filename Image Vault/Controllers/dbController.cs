using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_Vault.Controllers
{
    class dbController
    {

        ////Database hase Follwoing Tables
        /// -tblFiles
        ///     -ID PRimary Key Identity
        ///     -OriginalFilePath
        ///     -LockedFileName 

        private string connString;

        public dbController( )
        {
            this.connString = sysController.connString;
        }

        public DataTable getQueryList(string sql)
        {
            DataTable tbl = new DataTable();
            using (SQLiteConnection con = new SQLiteConnection(connString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    con.Open();
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    tbl.Load(reader);
                }
            }
            return tbl;
        }

        public object getQueryScaller(string sql)
        {
            object value = null;
            using (SQLiteConnection con = new SQLiteConnection(connString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    con.Open();
                    value = cmd.ExecuteScalar();
                }
            }
            return value;
        }
    }
}
