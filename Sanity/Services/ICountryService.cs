using Sanity.Models;

namespace Sanity.Services
{
    public interface ICountryService
    {
        GovernmentForm GetGovernmentForms(int id);
        Country GetCountryById(int id);
    }
}