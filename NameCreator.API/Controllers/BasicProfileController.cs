using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NameCreator.Model.ViewModel;
using NameCreator.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NameCreator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasicProfileController : ControllerBase
    {
        private readonly IBasicProfileService _basicProfileService;

        public BasicProfileController(IBasicProfileService basicProfileService)
        {
            _basicProfileService = basicProfileService;
        }

        [HttpPost("CreateProfile")]
        public IActionResult CreateProfile(BasicProfileRequestViewModel model)
        {
            var result = _basicProfileService.CreateProfile(model);
            return Ok(result);

        }
    }   
}
