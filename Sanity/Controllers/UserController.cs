using Microsoft.AspNetCore.Mvc;
using Sanity.Models;
using Sanity.Services;

namespace Sanity.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route(template: "/user/findAll")]
        public List<User> FindAllUsers()
        {
            return new List<User>();
        }

        [HttpPost]
        [Route(template: "/user/insert")]
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
            Console.WriteLine(user);
            return user;
        }

        [HttpGet]
        [Route("/user/get/byEmail/{email}")]
        public ActionResult GetUserByEmail([FromRoute(Name = "email")] string email)
        {
            Console.WriteLine(email);
            var user = _userService.GetUserByEmail(email);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpGet]
        [Route("/user/get/byId/{id:long}")]
        public ActionResult GetUSerById([FromRoute(Name = "id")] long id)
        {
            Console.WriteLine(id);
            var user = _userService.GetUSerById(id);
            if (user == null) return NotFound();
            return Ok(user);
        }

        [HttpPost]
        [Route("/user/update")]
        public void UpdateUser([FromBody] User user)
        {
            Console.WriteLine(user);
            _userService.UpdateUser(user);
        }

        [HttpGet]
        [Route("/user/get/firstName/byEmail/{email}")]
        public string GetUserFirstName([FromRoute] string email)
        {
            return "LioR";
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