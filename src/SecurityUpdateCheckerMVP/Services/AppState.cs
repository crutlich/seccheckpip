using SecurityUpdateCheckerMVP.Models;

namespace SecurityUpdateCheckerMVP.Services;

public class AppState
{
    public TestRun? CurrentRun { get; set; }
    public int SelectedScenarioIndex { get; set; } = -1;
    public Dictionary<TestId, MockDataProvider.ScenarioTestData>? CurrentScenarioData { get; set; }
}
