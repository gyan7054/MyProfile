using Microsoft.EntityFrameworkCore;
using MyProfile.Models.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.Data
{
    public class ProfileContext:DbContext
    {
        public ProfileContext(DbContextOptions<ProfileContext> options):base(options)
        {

        }
        public DbSet<Profile> MyProfile { get; set; }
    }
}
