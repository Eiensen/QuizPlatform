var builder = DistributedApplication.CreateBuilder(args);

var postgres = builder.AddPostgres("QuizPlatform-postgres");

builder.AddProject<Projects.QuizPlatform_Api>("quizplatform-api")
    .WithReference(postgres)
    .WaitFor(postgres);

await builder.Build().RunAsync();
