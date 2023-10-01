using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_To_React_Api.Core.Model
{
  public   class MainModel
    {

        public static string FileUpload(IFormFile pdf_attachment, string fileextenstion, string folderName)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", folderName);
            if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }
            var filepath = new PhysicalFileProvider(path).Root;
            var attachileName = GenerateFileName(fileextenstion);
            var filepath_Attach = filepath + $@"\{attachileName}";
            var stream = new FileStream(filepath_Attach, FileMode.Create);
            pdf_attachment.CopyTo(stream);
            return "/Upload/" + folderName + "/" + attachileName;
        }

        public static string GenerateFileName(string fileextenstion)
        {
            if (fileextenstion == null) throw new ArgumentNullException(nameof(fileextenstion));
            return $"{Guid.NewGuid():N}_{DateTime.Now:yyyyMMddHHmmssfff}{fileextenstion}";
        }

    }
}
