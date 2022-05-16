# Workshop: Asp .NET Core para Iniciantes por Glaucia Lemos

## Documentação

```bash
# Criação do projeto
dotnet new razor -o FilmesCRUDRazor
```

`Startup.cs` configuração geral da aplicação
`Program.cs` o arquivo principal da aplicação
`/Pages` manipulação de páginas
`/wwwroot` arquivos estáticos

### Tecnologia 
> Dotnet 5.0.4

* Linguagens:
    * C#
    * CSS
    * JS
    * Razor

* VSCode Extensions
    * C# by Microsoft
    * C# Extensions by jchannon
    * Version Lens by pflannery

#### [Nuget](https://www.nuget.org)

```bash
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet restore
```

```bash
# gerar as tabelas, deu erro 26:12 aula 4/15
dotnet tool install --global dotnet-ef
dotnet ef migrations add InitialCreate
```

## Referência
[Workshop: Asp .NET Core para Iniciantes por Glaucia Lemos](https://www.youtube.com/watch?v=njlmcXxSHE4&list=PLb2HQ45KP0WtBPZ7VbDz1WtavPFQm3Jj-)