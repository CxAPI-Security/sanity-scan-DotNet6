using Microsoft.AspNetCore.Mvc;
using Sanity_Scan_CSharp.Models;
using Sanity_Scan_CSharp.Services;

namespace Sanity_Scan_CSharp.Controllers
{

    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;


        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        [Route("/country/get/byId/{id}")]
        public Country GetCountryById([FromRoute] int id)
        {
            return _countryService.GetCountryById(id);
        }

        [HttpGet]
        [Route("/country/get/governmentForm/{id}")]
        public GovernmentForm GetGovernmentFormById([FromRoute] int id)
        {
            return _countryService.GetGovernmentForms(id);
        }
    }
}