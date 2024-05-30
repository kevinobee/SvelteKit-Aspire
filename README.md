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

## Common Issues

* Trust the ASP.NET Core HTTPS development certificate

  If you are developing on Linux or WSL you may need to [trust HTTPS certificate with linux-dev-certs](https://learn.microsoft.com/en-gb/aspnet/core/security/enforcing-ssl?view=aspnetcore-8.0&tabs=visual-studio%2Clinux-ubuntu#trust-the-aspnet-core-https-development-certificate-on-windows-and-macos).
