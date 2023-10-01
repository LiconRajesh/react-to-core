using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_To_React_Api.Core.ProjectAggregate.Entity
{
   public class Manage_User
    {
        [Key]
        public int User_Id { get; set; }
        public string User_Name { get; set; }
        public string Password { get; set; }
        public int? Role_Id { get; set; }
        public bool? Is_Active { get; set; }
    }
}
