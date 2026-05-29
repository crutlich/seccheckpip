using SecurityUpdateCheckerMVP.Models;

namespace SecurityUpdateCheckerMVP.Services;

public class MockTestRunner
{
    private readonly MockDataProvider _dataProvider;

    public MockTestRunner(MockDataProvider dataProvider)
    {
        _dataProvider = dataProvider;
    }

    public async Task RunAsync(TestRun run, Dictionary<TestId, MockDataProvider.ScenarioTestData> scenarioData,
        Action onProgress, CancellationToken ct)
    {
        run.StartedAt = DateTime.Now;

        foreach (var result in run.Results)
        {
            ct.ThrowIfCancellationRequested();

            if (!scenarioData.TryGetValue(result.Id, out var testData))
                continue;

            result.Environment = testData.Environment;

            if (testData.FinalStatus == TestStatus.Skipped)
            {
                result.Status = TestStatus.Skipped;
                if (testData.LogLines.Count > 0)
                    result.LogLines.AddRange(testData.LogLines);
                onProgress();
                await Task.Delay(300, ct);
                continue;
            }

            result.Status = TestStatus.Running;
            onProgress();
            await Task.Delay(400, ct);

            foreach (var logLine in testData.LogLines)
            {
                ct.ThrowIfCancellationRequested();
                result.LogLines.Add(logLine);
                onProgress();
                var delay = Random.Shared.Next(250, 450);
                await Task.Delay(delay, ct);
            }

            result.Status = testData.FinalStatus;
            result.Findings.AddRange(testData.Findings);
            result.RoutedToManualAnalysis = testData.RoutedToManualAnalysis;
            result.DurationMs = testData.LogLines.Count * 350;
            onProgress();
            await Task.Delay(300, ct);
        }

        run.FinishedAt = DateTime.Now;
        onProgress();
    }
}
