using SecurityUpdateCheckerMVP.Models;

namespace SecurityUpdateCheckerMVP.Services;

public class PipelineProfile
{
    public HashSet<TestId> GetMandatoryTests(SoftwareType type) => type switch
    {
        SoftwareType.Proprietary => new() { TestId.T001, TestId.T003, TestId.T005 },
        SoftwareType.Freeware => new() { TestId.T001, TestId.T003, TestId.T005 },
        SoftwareType.OpenSource => new() { TestId.T002, TestId.T003, TestId.T005, TestId.T006 },
        _ => new()
    };

    public bool IsMandatory(SoftwareType type, TestId testId) =>
        GetMandatoryTests(type).Contains(testId);
}
