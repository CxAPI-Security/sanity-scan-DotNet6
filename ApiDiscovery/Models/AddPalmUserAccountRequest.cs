namespace ApiDiscovery.Models;

public class AddPalmUserAccountRequest
{
    public string Pin { get; set; }
    public string ScanId { get; set; }
    public string UserCode { get; set; }
}