namespace SecurityUpdateCheckerMVP.Models;

public enum TestId { T001, T002, T003, T004, T005, T006 }
public enum TestStatus { Pending, Running, Skipped, Passed, Warning, Failed }
public enum SoftwareType { Proprietary, Freeware, OpenSource }
public enum Verdict { Safe, SafeWithRestrictions, Unsafe }
public enum TestEnvironment { ResearchBench, Sandbox, ProductionSystem }
