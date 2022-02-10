using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.Models.DbModel
{
    public class Profile
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public int age { get; set; }

        public String Address { get; set; }
        public String Landmark { get; set; }
        public String City { get; set; }
        public String State { get; set; }
    }
}
