using Microsoft.AspNetCore.Mvc;
using Sanity_Scan_CSharp.Models;
using Sanity_Scan_CSharp.Services;

namespace Sanity_Scan_CSharp.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpPost]
        [Route(template:"/user/insert")]
        public User CreateUser([FromBody] User user)
        {
            _userService.InsertUser(user);
            return user;
        }

        [HttpPost]
        [Route("/user/create/password")]
        public User CreateUserVar([FromBody] User user, [FromQuery] string password)
        {
            user.Info = "OK";
            return user;
        }

        [HttpGet]
        [Route("/user/get/byEmail/{email}")]
        public ActionResult GetUserByEmail([FromRoute(Name = "email")] string email)
        {
            var user = _userService.GetUserByLiame(email);
            if (user == null)
            {
                return NotFound();

            }
            
            return Ok(user);
        }
        
        [HttpGet]
        [Route("/user/get/byId/{id:long}")]
        public ActionResult  GetUSerById([FromRoute(Name = "id")] long id)
        {
            var user = _userService.GetUSerById(id);
            if (user == null) return NotFound();
            return Ok(user);
        }

        [HttpPost]
        [Route("/user/update")]
        public void UpdateUser([FromBody] User user)
        {
            _userService.UpdateUser(user);
        }

        [HttpGet]
        [Route("/user/get/firstName/byEmail/{email}")]
        public string GetUserFirstName([FromRoute] string email)
        {
            return "LioR";
        }

        [HttpPost]
        [Route("/user/updateMe")]
        public void UpdateUserMe([FromBody] User user)
        {
            Console.WriteLine(user);
            _userService.UpdateUser(user);
        }

        [HttpPost]   
        [Route("/user/update/name")]
        public void UpdateUserName([FromQuery] string name, [FromQuery] string id)
        {
            _userService.UpdateUserName(id, name);
        }

        [HttpPost]
        [Route("/user/create/cart")]
        public void CreateUserCart(
            [FromBody] User user,
            [FromQuery] ISet<string> productIds,
            [FromQuery] ISet<int> quantities)
        {
            _userService.CreateUserCart(user, productIds, quantities);
        }

        [HttpPost]
        [Route("/user/create/mapCart")]
        public void CreateUserMapCart([FromBody] User user, [FromQuery] Dictionary<string, int> mapCart)
        {
            _userService.CreateUserMapCart(user, mapCart);
        }
           
    }
}