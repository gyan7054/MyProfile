using MyProfile.Models.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.ProfileRepository
{
    public interface IProfileRepository
    {
         Task AddProfile(Profile profile);
    }
}
