using Core_To_React_Api.Core.ProjectAggregate.Entity;
using Core_To_React_Api.Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_To_React_Api.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        AppDbContext con;
        public ApiController(AppDbContext _con)
        {
            this.con = _con;
        }
        [Route("Occuption")]
        public IActionResult Occuption()
        {
            string[] data = { "Rajesh", "Lincon" };
            return Ok(data);

        }

        [HttpPost]

        [Route("Checklogin")]
        public IActionResult Checklogin([FromForm] data data1)
        {
            if (data1 != null)
            {
                var data = con.Manage_User.Where(x => x.User_Name == data1.username && x.Password == data1.password).FirstOrDefault();
                if (data != null)
                {
                    return Ok(data);
                }
                else
                {
                    return Ok(null);
                }
            }
            else
            {
                return Ok(null);
            }
        }


        //[HttpPost]

        //[Route("Fileupload")]
        //public IActionResult Fileupload([FromForm]IFormFile file)
        //{
        //    return Ok();
        //}


        [HttpGet]
        [Route("GetRole")]
        public IActionResult GetRole()
        {
            var data = con.Role.ToList();
            return Ok(data);
        }
        public class data
        {
            public string username { get; set; }
            public string password { get; set; }
        }


        public class Managedata
        {
            public string username { get; set; }
            public string password { get; set; }

            public int Role { get; set; }

    

        }



    }
}
