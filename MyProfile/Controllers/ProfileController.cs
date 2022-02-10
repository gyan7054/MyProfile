using Microsoft.AspNetCore.Mvc;
using MyProfile.Data;
using MyProfile.Models.DbModel;
using MyProfile.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.Controllers
{
    [Route("api/profile")]
    
    public class ProfileController : ControllerBase
    {
        private readonly IProfileService profileService;
        public ProfileController(IProfileService _profileService)
        {
            profileService = _profileService;
        }

        [Route("addprofile")]
        [HttpPost]

        public async Task<IActionResult>AddProfile([FromBody]Profile profile)
        {
            await profileService.AddUserProfile(profile);
            return Ok();


        }
       
    }
}
