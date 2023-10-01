using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_To_React_Api.Core.ProjectAggregate.Entity
{
    public class Profile_Image
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string profilepic { get; set; }
    }
}
