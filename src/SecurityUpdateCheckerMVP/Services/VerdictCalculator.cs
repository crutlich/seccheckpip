using SecurityUpdateCheckerMVP.Models;

namespace SecurityUpdateCheckerMVP.Services;

public class VerdictCalculator
{
    public Verdict Calculate(IEnumerable<TestResult> results)
    {
        var evaluated = results
            .Where(r => r.Status is not (TestStatus.Skipped or TestStatus.Pending))
            .ToList();

        if (evaluated.Any(r => r.Status == TestStatus.Failed))
            return Verdict.Unsafe;

        if (evaluated.Any(r => r.Status == TestStatus.Warning))
            return Verdict.SafeWithRestrictions;

        return Verdict.Safe;
    }
}
