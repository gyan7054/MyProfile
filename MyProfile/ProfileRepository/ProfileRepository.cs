using Microsoft.EntityFrameworkCore;
using MyProfile.Data;
using MyProfile.Models.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.ProfileRepository
{
    public class ProfileRepository:IProfileRepository
    {

        private readonly ProfileContext db;
        public ProfileRepository(ProfileContext _db)
        {
            db = _db;
        }

        public async Task AddProfile(Profile profile)
        {
             db.MyProfile.Add(profile);
           await db.SaveChangesAsync();
            


        }

    }
}
