using Sanity_Scan_CSharp.Models;

namespace Sanity_Scan_CSharp.Services;

public class CountryService : ICountryService
{
    public GovernmentForm GetGovernmentForms(int id)
    {
        return (GovernmentForm)id;
    }

    public Country GetCountryById(int id)
    {
        var country = new Country();
        country.Id = id;
        country.GovernmentForm = (GovernmentForm)id;

        return country;
    }
}