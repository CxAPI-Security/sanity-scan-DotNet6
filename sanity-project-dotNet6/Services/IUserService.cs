using sanity_project_csharp.Models;

namespace sanity_project_csharp.Services;

public interface IUserService
{
    void CreateUserCart(User user, ISet<string> productIds, ISet<int> quantities);
    void CreateUserMapCart(User user, Dictionary<string, int> mapCart);
}