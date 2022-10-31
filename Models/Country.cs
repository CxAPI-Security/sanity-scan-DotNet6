namespace Sanity_Scan_CSharp.Models;

public class Country
{
    public int Id { get; set; }
    public string? CountryName { get; set; }
    public string? Definition { get; set; }
    public string? A2 { get; set; }
    public string? A3 { get; set; }
    public string? PhoneCode { get; set; }
    public string? DisplayName { get; set; }
    public string? GmtOffset { get; set; }
    public GovernmentForm GovernmentForm { get; set; }
    public string? Language { get; set; }
}