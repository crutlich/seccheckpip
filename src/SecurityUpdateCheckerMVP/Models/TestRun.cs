namespace SecurityUpdateCheckerMVP.Models;

public class TestRun
{
    public UpdatePackage Package { get; set; } = new();
    public List<TestResult> Results { get; set; } = new();
    public DateTime StartedAt { get; set; }
    public DateTime? FinishedAt { get; set; }
}
