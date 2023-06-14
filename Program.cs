using hotchocolate_repro;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer("schema1")
    .AddQueryType<Query1>()
    .AddDiagnosticEventListener<ExampleDiagnosticsEventListener>();

builder.Services
    .AddGraphQLServer("schema2")
    .AddQueryType<Query2>()
    .AddDiagnosticEventListener<ExampleDiagnosticsEventListener>();

var app = builder.Build();

app
    .UseRouting()
    .UseEndpoints(endpoints =>
    {
        endpoints.MapGraphQL("/schema1", schemaName: "schema1");
        endpoints.MapGraphQL("/schema2", schemaName: "schema2");
    });

app.Run();