using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_Vault.Controllers
{
    public class FileController
    {
        private static string folderName = "ImageVault";
        private static string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + folderName; 

        public FileController()
        {
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            } 
        }

        /// <summary>
        /// This will take File to the Vault Folder and Chanegs its NAme to GUID and Return the GUID Key.
        /// </summary>
        /// <param name="imageFilePath">File you want to Copy to Vault</param>
        public string Move_To_Vault(FileInfo imageFilePath)
	    {  
            string newName =  Guid.NewGuid().ToString();
            File.Move(imageFilePath.FullName, filePath+"\\"+ newName);

            return newName;
	    }


        public string VaultFolderPath()
        {
            return filePath + @"\";
        }

        public List<string> GetAllImagesGUID()
	    {
            string sql = "Select LockedFileName From tblFiles";
            dbController db = new dbController();
            DataTable FileNamesTbl = db.getQueryList(sql);
            List<string> files = new List<string>();
            foreach (DataRow row in FileNamesTbl.Rows)
            {
                files.Add(row["LockedFileName"].ToString());
            }

            return files;
	    }

        public void RestoreFile(string fileGUID)
	    {
           
            string sql = "Select OriginalFilePath from tblFiles Where LockedFileName ='"+fileGUID+"'";
            string originalPath = new dbController().getQueryScaller(sql).ToString();
            sql = "Delete from tblFiles Where LockedFileName ='" + fileGUID + "'";
            try
            {
                File.Move(VaultFolderPath() + fileGUID, originalPath);
            }
            catch (Exception e )
            {
                Console.WriteLine(e);
            }
          
        
	    }
    }
}
