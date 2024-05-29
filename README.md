# SvelteKit-Aspire

> Run [Svelte](https://kit.svelte.dev/) using [.NET Aspire](https://aka.ms/aspireannouncement)

## Requires

* [Docker](https://www.docker.com/)
* [.NET Core](https://learn.microsoft.com/en-us/dotnet/core/install/windows)

You will also need the [Aspire dotnet workload](https://learn.microsoft.com/en-us/dotnet/aspire/fundamentals/setup-tooling) installed locally if you wish to work with the code.

```shell
dotnet workload install aspire
```

## Getting Started

To build and run the applications using the [DotNet CLI](https://learn.microsoft.com/en-us/dotnet/core/tools/) run the following commands:

```shell
dotnet restore
dotnet run --project SvelteKit-Aspire.AppHost/
```
