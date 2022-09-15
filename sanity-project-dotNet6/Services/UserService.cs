using sanity_project_csharp.Models;

namespace sanity_project_csharp.Services;

public class UserService: IUserService
{
    public void CreateUserCart(User user, ISet<string> productIds, ISet<int> quantities)
    {
        throw new NotImplementedException();
    }

    public void CreateUserMapCart(User user, Dictionary<string, int> mapCart)
    {
        throw new NotImplementedException();
    }
}