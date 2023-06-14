using HotChocolate.AspNetCore.Instrumentation;

namespace hotchocolate_repro;

internal sealed class ExampleDiagnosticsEventListener2 : ServerDiagnosticEventListener
{
    private readonly ILogger<ExampleDiagnosticsEventListener2> logger;

    public ExampleDiagnosticsEventListener2(ILogger<ExampleDiagnosticsEventListener2> logger)
    {
        this.logger = logger;
    }

    public override IDisposable ExecuteHttpRequest(HttpContext context, HttpRequestKind kind)
    {
        logger.LogInformation("Listener2: ExecuteHttpRequest of kind {Kind}", kind);

        return EmptyScope;
    }
}
