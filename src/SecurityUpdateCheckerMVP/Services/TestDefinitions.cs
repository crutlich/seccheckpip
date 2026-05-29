using SecurityUpdateCheckerMVP.Models;

namespace SecurityUpdateCheckerMVP.Services;

public static class TestDefinitions
{
    public static readonly IReadOnlyDictionary<TestId, TestDefinition> All =
        new Dictionary<TestId, TestDefinition>
        {
            [TestId.T001] = new(TestId.T001, "T001", "Сверка идентичности обновлений",
                "Проверка целостности и идентичности обновления путём сравнения из нескольких источников"),
            [TestId.T002] = new(TestId.T002, "T002", "Проверка подлинности обновлений",
                "Проверка электронной подписи и сертификата разработчика"),
            [TestId.T003] = new(TestId.T003, "T003", "Антивирусный контроль",
                "Сканирование обновления несколькими антивирусными средствами"),
            [TestId.T004] = new(TestId.T004, "T004", "Поиск опасных конструкций",
                "Поиск потенциально опасных конструкций в обновлении с помощью YARA и IoC"),
            [TestId.T005] = new(TestId.T005, "T005", "Мониторинг активности в среде тестирования",
                "Установка и мониторинг поведения обновления в изолированной среде"),
            [TestId.T006] = new(TestId.T006, "T006", "Ручной анализ",
                "Экспертный анализ: дизассемблирование, декомпиляция, ручная верификация")
        };
}
