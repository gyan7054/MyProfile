using MyProfile.Models.DbModel;
using MyProfile.ProfileRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.Service
{
    public interface IProfileService
    {
         Task AddUserProfile(Profile profile);

    }
    public class ProfileService: IProfileService
    {

       
           
        public readonly IProfileRepository profileRepository;
        public ProfileService(IProfileRepository _profileRepository)
        {
           this.profileRepository= _profileRepository;
        }
        public async Task AddUserProfile(Profile profile)
        {
            await profileRepository.AddProfile(profile);
        }
    }
}
