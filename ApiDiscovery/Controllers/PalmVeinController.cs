using System.Web.Http;
using System.Web.Http.Description;
using ApiDiscovery.Models;
using ApiDiscovery.Services;

namespace ApiDiscovery.Controllers
{

    public class PalmVeinController : ApiController
    {
        private readonly IBackendService _backedBackendService;

        public PalmVeinController(IBackendService backedBackendService)
        {
            _backedBackendService = backedBackendService;
        }

        [HttpPost]
        [Route("~/api/palmvein/accounts/verify")]
        [ResponseType(typeof(PalmVeinVerifyAccountResponse))]
        public async Task<IHttpActionResult> VerifyAccount(VerifyPalmUserAccountRequest request)
        {
            var response = await _backedBackendService.PalmVeinVerify(request);

            return Ok(response);
        }

        [HttpPost]
        [ResponseType(typeof(PalmVeinEnrollResponse))]
        [Route("~/api/palmvein/accounts")]
        public async Task<IHttpActionResult> AddAccount(AddPalmUserAccountRequest request)
        {
            var response = await _backedBackendService.PalmVeinEnroll(request.ScanId, request.UserCode, request.Pin);

            return Ok(response);
        }
    }
}