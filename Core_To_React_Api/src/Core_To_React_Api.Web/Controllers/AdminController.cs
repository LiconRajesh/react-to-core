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
    public class AdminController : ControllerBase
    {
        AppDbContext con;

        public AdminController(AppDbContext _con)
        {
            this.con = _con;
        }
        [Route("ManageUserlist")]
        [HttpGet]
        public IActionResult ManageUserlist()
        {
            var data = con.Manage_User.ToList();
            return Ok(data);
        }


        [HttpPost]

        [Route("ManageUser")]
        public IActionResult ManageUser([FromForm] Managedata d)
        {


            Status s = new Status();
            try
            {
                if(d.User_Id!=0)
                {
                    var data = con.Manage_User.Where(x => x.User_Id == d.User_Id).FirstOrDefault();
                    data.User_Name = d.username;
                    data.Password = d.password;
                    data.Role_Id = d.Role;
                    data.Is_Active = true;
     
                    con.SaveChanges();

                    s.statusmsg = "Update";
                    return Ok(s);

                }
                else
                {
                    Manage_User m = new Manage_User();
                    m.User_Name = d.username;
                    m.Password = d.password;
                    m.Role_Id = d.Role;
                    m.Is_Active = true;
                    con.Manage_User.Add(m);
                    con.SaveChanges();

                    s.statusmsg = "Sucess";
                    return Ok(s);
                }
                
            }
            catch
            {
                s.statusmsg = "Fails";

                return Ok(s);

            }
        }
        public class Managedata
        {
            public string username { get; set; }
            public string password { get; set; }

            public int Role { get; set; }

            public int User_Id { get; set; }

            public string Status { get; set; }

        }


        [HttpGet]

        [Route("DeleteManageuser")]
        public IActionResult DeleteManageuser([FromQuery] int id)
        {
            Status s = new Status();
            var data = con.Manage_User.Where(x => x.User_Id == id).FirstOrDefault();
            con.Manage_User.Remove(data);
            con.SaveChanges();
            s.statusmsg = "Delete Susessfully";
            return Ok(s);
        }


        [HttpGet]

        [Route("EditManageuser")]
        public IActionResult EditManageuser([FromQuery] int id)
        {
            Status s = new Status();
            var data = con.Manage_User.Where(x => x.User_Id == id).FirstOrDefault();
           
            return Ok(data);
        }



        public class Status
        {
            public string statusmsg { get; set; }
        }
    }
}
