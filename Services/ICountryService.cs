using Sanity_Scan_CSharp.Models;

namespace Sanity_Scan_CSharp.Services;

public interface ICountryService
{
    GovernmentForm GetGovernmentForms(int id);
    Country GetCountryById(int id);
}