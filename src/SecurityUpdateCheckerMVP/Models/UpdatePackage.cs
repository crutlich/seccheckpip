namespace SecurityUpdateCheckerMVP.Models;

public class UpdatePackage
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public string Url { get; set; } = "";
    public string Checksum { get; set; } = "";
    public DateOnly ReleaseDate { get; set; }
    public string Vendor { get; set; } = "";
    public string Version { get; set; } = "";
    public List<string> CveIds { get; set; } = new();
    public SoftwareType SoftwareType { get; set; }
}
