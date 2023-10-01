using Core_To_React_Api.Core.Model;
using Core_To_React_Api.Core.ProjectAggregate.Entity;
using Core_To_React_Api.Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Core_To_React_Api.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileploadController : ControllerBase
    {

        AppDbContext con;

       public FileploadController(AppDbContext _con)
        {
            this.con = _con;
        }
        [HttpPost]

        [Route("Fileupload")]
        public IActionResult Fileupload([FromForm] Filemodel filemodel)
        {

            if (filemodel.file != null)
            {
                Profile_Image p = new Profile_Image();
                FileInfo fi = new FileInfo(filemodel.file.FileName);
                string img = MainModel.FileUpload(filemodel.file, fi.Extension, "FileUpload");
                p.profilepic = img;
                p.name = filemodel.username;
                con.Profile_Image.Add(p);
                con.SaveChanges();
                Status s = new Status();
                s.Statusmsg = "Sucess";
                return Ok(s);

            }
            return Ok();
        }
        [HttpGet]
        [Route("GetFileDetails")]
        public IActionResult GetFileDetails()
        {
            List<Details> m = new List<Details>();
            var data = con.Profile_Image.ToList();
            foreach(var item in data)
            {
                Details mm = new Details();
                mm.username = item.name;
                mm.file = "http://localhost:57678" + item.profilepic;
                m.Add(mm);
            }
            return Ok(m);
        }

        public class Filemodel
        {
            public string username { get; set; }

            public IFormFile file { get; set; }
        }

        public class Details
        {
            public string username { get; set; }

            public string file { get; set; }

        }


        public class Status
        {
            public string Statusmsg { get; set; }
        }
     

    }
}
