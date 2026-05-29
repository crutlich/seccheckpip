using SecurityUpdateCheckerMVP.Models;

namespace SecurityUpdateCheckerMVP.Services;

public static class DisplayHelpers
{
    public static string SoftwareTypeLabel(SoftwareType type) => type switch
    {
        SoftwareType.Proprietary => "Проприетарное",
        SoftwareType.Freeware => "Свободно распространяемое",
        SoftwareType.OpenSource => "С открытым исходным кодом",
        _ => ""
    };

    public static string EnvironmentLabel(TestEnvironment env) => env switch
    {
        TestEnvironment.ResearchBench => "Исследовательский стенд",
        TestEnvironment.Sandbox => "Песочница",
        TestEnvironment.ProductionSystem => "Продуктивная система",
        _ => ""
    };
}