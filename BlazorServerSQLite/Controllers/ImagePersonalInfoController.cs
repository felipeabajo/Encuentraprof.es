using BlazorServerSQLite.Data;
//using ImageProcessor.Plugins.WebP.Imaging.Formats;
//using ImageProcessor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using Syncfusion.Blazor.Inputs;
using System.Drawing.Imaging;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace BlazorServerSQLite.Controllers
{
    [Route("[controller]/[action]")]
    public class ImagePersonalInfoController : Controller
    {
        private Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnv;
        static string userId;
        public ImagePersonalInfoController(Microsoft.AspNetCore.Hosting.IWebHostEnvironment env)
        {
            this.hostingEnv = env;
        }
        public void SetUserId([FromBody] string Id)
        {
            userId = Id;
        }

        public void Save(IList<IFormFile> UploadFiles, string Id)
        {
            try
            {
                foreach (var file in UploadFiles)
                {
                    if (UploadFiles != null)
                    {
                        var uploadedFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim();
                        var uploadedFileformat = Path.GetExtension(uploadedFileName).ToString().ToLower();
                        var fullFolderName = hostingEnv.WebRootPath + "/img/users/";
                        string[] fullPaths = {fullFolderName, userId + uploadedFileformat };

                        DirectoryInfo dir = new DirectoryInfo(fullFolderName);
                        System.IO.FileInfo[] files = dir.GetFiles(userId + ".*");

                        if(files.Length > 0)
                        {
                            //File exists
                            foreach (System.IO.FileInfo file2 in files) {
                                System.IO.File.Delete(file2.FullName);
                            }
                        }
                        var fullFilePath = Path.Combine(fullPaths);
                        using (FileStream fs = System.IO.File.Create(fullFilePath))
                        {
                            file.CopyTo(fs);
                            fs.Flush();
                        }
                    }
                }
            }
            catch (Exception ex) { throw; }
        }
        public bool IsUserImagePathURLNull (string Id)
        {
            bool isUserImagePathURLNull = true;
            try
            {
                //var uploadedFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim();
                //var uploadedFileformat = Path.GetExtension(uploadedFileName).ToString().ToLower();

                var folderName = hostingEnv.WebRootPath + "/img/users/";
                //string[] fullPaths = { fullFolderName, userId + ".jpg" };
                string fileName = Id + ".jpg";

                DirectoryInfo dir = new DirectoryInfo(folderName);
                //System.IO.FileInfo[] files = dir.GetFiles(userId + ".*");
                //private Boolean ExistsFile(string filePath)
                //{
                //    if (File.Exists(filePath)) return true;
                //    else return false;
                //}

                string newFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments), folderName,
                    fileName);

                if (System.IO.File.Exists(newFilePath))
                {
                    isUserImagePathURLNull = false;
                }

                //    if (files.Length > 0)
                //{
                //    //File exists
                //    isUserImagePathURLNull = false;
                //    //foreach (System.IO.FileInfo file2 in files)
                //    //{
                //    //    System.IO.File.Delete(file2.FullName);
                //    //}
                //}
                //var fullFilePath = Path.Combine(fullPaths);
                //using (FileStream fs = System.IO.File.Create(fullFilePath))
                //{
                //    fs.Flush();
                //}
            }
            catch (Exception ex) { throw; }
            return isUserImagePathURLNull;
        }
    }
}
