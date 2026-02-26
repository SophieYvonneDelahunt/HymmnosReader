# HymmnosReader .NET 10.0 Upgrade Tasks

## Overview

This document tracks the execution of the upgrade of the `HymmnosReader` project from .NET Framework to `net10.0-windows`. Project file conversion, package updates, and compilation fixes will be performed together in a single coordinated operation and verified.

**Progress**: 2/2 tasks complete (100%) ![0%](https://progress-bar.xyz/100)

---

## Tasks

### [✓] TASK-001: Verify prerequisites *(Completed: 2026-02-26 21:36)*
**References**: Plan §Project-by-Project Plans (HymmnosReader\HymmnosReader.csproj), Plan §Migration Strategy (Phase 0)

- [✓] (1) Verify required .NET 10 SDK is installed on the build machine(s) per Plan §Prerequisites
- [✓] (2) Runtime/SDK version meets minimum requirements (**Verify**)
- [✓] (3) Check for `global.json` presence and update or remove it as appropriate per Plan §Prerequisites
- [✓] (4) `global.json` is compatible with the target SDK or removed (**Verify**)

---

### [✓] TASK-002: Atomic framework and package upgrade with compilation fixes *(Completed: 2026-02-26 21:51)*
**References**: Plan §Project-by-Project Plans (HymmnosReader\HymmnosReader.csproj), Plan §Package Update Reference, Plan §Breaking Changes Catalog, Plan §Source Control Strategy

- [✓] (1) Convert `HymmnosReader.csproj` to SDK-style using `Microsoft.NET.Sdk.WindowsDesktop`, set `<TargetFramework>net10.0-windows</TargetFramework>` and `<UseWindowsForms>true</UseWindowsForms>`; migrate AssemblyName/RootNamespace and designer/resource entries per Plan §Project-by-Project Plans
- [✓] (2) Update package references per Plan §Package Update Reference (e.g., update `Microsoft.Extensions.Configuration` → `10.0.3`, align `Microsoft.Extensions.*` packages, remove explicit framework-provided `System.*` packages)
- [✓] (3) Restore dependencies (`dotnet restore`) per Plan §Package Update Reference
- [✓] (4) All dependencies restored successfully (**Verify**)
- [✓] (5) Build solution to identify compilation and WinForms API compatibility errors per Plan §Breaking Changes Catalog
- [✓] (6) Fix all compilation errors and API incompatibilities found (reference Plan §Breaking Changes Catalog for common hotspots)
- [✓] (7) Rebuild solution to verify fixes
- [✓] (8) Solution builds with 0 errors (**Verify**)
- [✓] (9) Commit changes with message: "TASK-002: Convert to SDK-style and upgrade to net10.0-windows"

---





