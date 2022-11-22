namespace ApiDiscovery.Models;

public class VerifyPalmUserAccountRequest
{
    public string Pin { get; set; }
    public string UserId { get; set; }
    public string UserCode { get; set; }
}