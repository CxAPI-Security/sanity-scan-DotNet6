using Microsoft.AspNetCore.Mvc;
using sanity_project_csharp.Models;
using sanity_project_csharp.Services;

namespace sanity_project_csharp.Controllers;

[Route("user")]
public class UserController : Controller
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("create/cart")]
    public void CreateUserCart(
        [FromBody] User user,
        [FromRoute] ISet<string> productIds,
        [FromRoute] ISet<int> quantities)
    {
        _userService.CreateUserCart(user, productIds, quantities);
    }

    [HttpPost("create/mapCart")]
    public void CreateUserMapCart([FromBody] User user, [FromRoute] Dictionary<string, int> mapCart)
    {
        _userService.CreateUserMapCart(user, mapCart);
    }
}