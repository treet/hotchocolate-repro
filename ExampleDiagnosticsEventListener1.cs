using HotChocolate.AspNetCore.Instrumentation;

namespace hotchocolate_repro;

internal sealed class ExampleDiagnosticsEventListener1 : ServerDiagnosticEventListener
{
    private readonly ILogger<ExampleDiagnosticsEventListener1> logger;

    public ExampleDiagnosticsEventListener1(ILogger<ExampleDiagnosticsEventListener1> logger)
    {
        this.logger = logger;
    }

    public override IDisposable ExecuteHttpRequest(HttpContext context, HttpRequestKind kind)
    {
        logger.LogInformation("Listener1: ExecuteHttpRequest of kind {Kind}", kind);

        return EmptyScope;
    }
}
