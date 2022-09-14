namespace PatchExample;

public static class EndpointRouteBuilderExtensions
{
    private static readonly string[] PatchVerb = { HttpMethods.Patch };

    /// <summary>
    /// Adds MapPatch extension to existing MapGet, MapPost, etc.  It is built-in in .NET 7.
    /// </summary>
    public static RouteHandlerBuilder MapPatch(
        this IEndpointRouteBuilder endpoints,
        string pattern,
        Delegate handler)
    {
        return endpoints.MapMethods(pattern, PatchVerb, handler);
    }
}
