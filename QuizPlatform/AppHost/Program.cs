using QuizPlatform.AppHost;

var builder = DistributedApplication.CreateBuilder(args);

var password = builder.AddParameter("password", secret: true);

var postgres = builder.AddPostgres(AspireName.Postgres, password: password, port: 5432)
    .WithVolume("QuizPlatform_Postgres", "/var/lib/postgresql/data")
    .WithImageTag("16")
    .WithPgAdmin();

builder.AddProject(AspireName.QuizPlatformApi, "../QuizPlatform.Api/QuizPlatform.Api.csproj")
    .WithReference(postgres)
    .WaitFor(postgres);

await builder.Build().RunAsync();
