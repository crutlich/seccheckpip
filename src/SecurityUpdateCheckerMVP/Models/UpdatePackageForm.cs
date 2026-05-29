using System.ComponentModel.DataAnnotations;

namespace SecurityUpdateCheckerMVP.Models;

public class UpdatePackageForm
{
    [Required(ErrorMessage = "Укажите наименование")]
    [StringLength(200, MinimumLength = 3, ErrorMessage = "От 3 до 200 символов")]
    public string Name { get; set; } = "";

    [Required(ErrorMessage = "Укажите описание")]
    public string Description { get; set; } = "";

    [Required(ErrorMessage = "Укажите URL")]
    [Url(ErrorMessage = "Некорректный URL")]
    public string Url { get; set; } = "";

    [Required(ErrorMessage = "Укажите контрольную сумму")]
    public string Checksum { get; set; } = "";

    public DateOnly ReleaseDate { get; set; } = DateOnly.FromDateTime(DateTime.Today);

    [Required(ErrorMessage = "Укажите разработчика")]
    public string Vendor { get; set; } = "";

    [Required(ErrorMessage = "Укажите версию")]
    public string Version { get; set; } = "";

    public string CveIdsRaw { get; set; } = "";

    public SoftwareType SoftwareType { get; set; }

    public void LoadFrom(UpdatePackage pkg)
    {
        Name = pkg.Name;
        Description = pkg.Description;
        Url = pkg.Url;
        Checksum = pkg.Checksum;
        ReleaseDate = pkg.ReleaseDate;
        Vendor = pkg.Vendor;
        Version = pkg.Version;
        CveIdsRaw = string.Join(", ", pkg.CveIds);
        SoftwareType = pkg.SoftwareType;
    }

    public void ApplyTo(UpdatePackage pkg)
    {
        pkg.Name = Name;
        pkg.Description = Description;
        pkg.Url = Url;
        pkg.Checksum = Checksum;
        pkg.ReleaseDate = ReleaseDate;
        pkg.Vendor = Vendor;
        pkg.Version = Version;
        pkg.CveIds = CveIdsRaw
            .Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
            .ToList();
        pkg.SoftwareType = SoftwareType;
    }
}