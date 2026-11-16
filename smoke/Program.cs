using System;
using Agent.Core.AgentTools;
using Agent.Core.Contracts;
using Agent.Models;
using Agent.Mvvm;

// Smoke test: proves the Agent.* packages restore from the local feed and
// their types resolve across all three shared assemblies (Mvvm, Core, Models).
Console.WriteLine(typeof(NotifyLevel).FullName);
Console.WriteLine(typeof(AgentToolCatalogEntry).FullName);
Console.WriteLine(typeof(ChatModel).FullName);
Console.WriteLine(typeof(SettingsModel).FullName);
Console.WriteLine(typeof(IChatChildModel).FullName);
Console.WriteLine("OK");
