# SecurityUpdateCheckerMVP

Веб-приложение для проверки безопасности обновлений. Позволяет запускать пайплайн тестов над пакетами обновлений, отслеживать прогресс выполнения и получать итоговый вердикт.

## Стек

- .NET 8 / ASP.NET Core
- Blazor Server (Interactive SSR)
- MudBlazor 9.5

## Требования

- [.NET SDK 8.0+](https://dotnet.microsoft.com/download/dotnet/8.0)

## Быстрый старт

```bash
# Клонировать репозиторий
git clone <repo-url>
cd SecurityUpdateCheckerMVP

# Восстановить зависимости
dotnet restore

# Запустить в режиме разработки
dotnet run --project src/SecurityUpdateCheckerMVP
```

Приложение будет доступно по адресу: **http://localhost:5125**

## Структура проекта

```
├── src/
│   └── SecurityUpdateCheckerMVP/
│       ├── Components/
│       │   ├── Layout/          # MainLayout, NavMenu
│       │   ├── Pages/           # Home, Pipeline, Results, Report, Error
│       │   └── Shared/          # LogTicker, StatusBadge, TestCard, VerdictBanner
│       ├── Models/              # UpdatePackage, TestDefinition, TestResult, TestRun
│       ├── Services/            # AppState, MockTestRunner, VerdictCalculator и др.
│       └── wwwroot/             # Статические файлы (CSS, favicon)
├── tests/                       # Тесты (в разработке)
├── docs/                        # Документация
├── scripts/                     # Скрипты сборки и деплоя
└── docker/                      # Docker-конфигурация
```

## Разработка

```bash
# Сборка
dotnet build

# Запуск с hot-reload
dotnet watch --project src/SecurityUpdateCheckerMVP

# Запуск тестов (когда появятся)
dotnet test
```

## Лицензия

TBD
