using HotChocolate.AspNetCore.Instrumentation;

namespace hotchocolate_repro;

internal sealed class ExampleDiagnosticsEventListener : ServerDiagnosticEventListener
{
    private readonly ILogger<ExampleDiagnosticsEventListener> logger;

    public ExampleDiagnosticsEventListener(ILogger<ExampleDiagnosticsEventListener> logger)
    {
        this.logger = logger;
    }

    public override IDisposable ExecuteHttpRequest(HttpContext context, HttpRequestKind kind)
    {
        logger.LogInformation("ExecuteHttpRequest of kind {Kind}", kind);

        return EmptyScope;
    }
}
