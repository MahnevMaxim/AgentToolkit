# AgentShared

Canonical source of truth for the code shared by the three agent hosts:

- RPAWriter2 (`C:\Users\Maxxx\source\repos\RPAWriter2`)
- VibeCoder (`C:\Users\Maxxx\source\repos\VibeCoder`)
- AI-RPA (`C:\Users\Maxxx\Desktop\AI-RPA`)

Shared surface (UI-free, netstandard2.0):

- `Agent.Mvvm` — MVVM base (`BaseModel`, `BaseViewModel`, `IView`, `RelayCommand`, `ViewMode`, `NotifyLevel`)
- `Agent.Core` — agent core (tool framework, checkpoints, context, contracts, data models `ChatMessage`/`ChatPayloads`/…, prompt library, provider, markdown, memory bank)

Per-project (NOT shared): hosts, thin WPF view models, WPF controls, host services,
project-specific tool catalogs (registered into the shared `AgentToolRegistry`).

The RPAWriter2 tab models (`ChatModel`, `SettingsModel`, `LogAnalyzer`, `KnowledgeBaseModel`,
`SpecTabModel`) and RPA services (robot generation, Pix/Mwf/UiPath converters, production-log
analysis) live in `Agent.Rpa` inside the RPAWriter2 solution — they are coupled to RPA specifics
and are not shared with VibeCoder / AI-RPA.

## Publishing

```
.\pack.ps1
```

writes `.nupkg` files into `feed\`. Consumers add this folder as a NuGet package source:

```xml
<add key="AgentShared" value="C:\Users\Maxxx\source\repos\AgentShared\feed" />
```
