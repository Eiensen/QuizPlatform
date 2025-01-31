var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.QuizPlatform_Api>("quizplatform-api");

builder.Build().Run();
