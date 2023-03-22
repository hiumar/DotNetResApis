using Microsoft.AspNetCore.Mvc;
using UserRegistrationForm.Interfaces;
using UserRegistrationForm.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserRegistrationForm.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _user;
        public UserController( IUser user)
        {
            _user = user;

        }
       
        // POST api/<ValuesController>
        [HttpPost]
        [Route("add-posts")]
        public async Task<bool> AddPost([FromBody] UserRegistrationReqVM user)
        {
            UserRegistration userRegistration = new UserRegistration();
            if (user != null)
            {
                userRegistration.Email = user.Email;
                userRegistration.Message= user.Message;
                userRegistration.Name= user.Name;

            }
            var response =  await _user.Register(userRegistration);
            return response;
        }

   
    }
}
