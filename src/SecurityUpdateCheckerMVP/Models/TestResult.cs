namespace SecurityUpdateCheckerMVP.Models;

public class TestResult
{
    public TestId Id { get; set; }
    public TestStatus Status { get; set; } = TestStatus.Pending;
    public TestEnvironment Environment { get; set; }
    public int DurationMs { get; set; }
    public List<string> LogLines { get; set; } = new();
    public List<string> Findings { get; set; } = new();
    public bool RoutedToManualAnalysis { get; set; }
}
