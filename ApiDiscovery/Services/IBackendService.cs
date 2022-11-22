using ApiDiscovery.Models;

namespace ApiDiscovery.Services;

public interface IBackendService
{
    Task<PalmVeinVerifyAccountResponse> PalmVeinVerify(VerifyPalmUserAccountRequest request);
    Task<PalmVeinEnrollResponse> PalmVeinEnroll(string requestScanId, string requestUserCode, string requestPin);
}