# Example Minimal API for SystemTextJsonPatch Library

Example project on how to use [`SystemTextJsonPatch`](https://github.com/Havunen/SystemTextJsonPatch) library to provide HTTP PATCH support for your API.

This example is written using Minimal API and targets .NET 6.

To get this working in your project:

1. Install `SystemTextJsonPatch` library.
    ```
    dotnet add package SystemTextJsonPatch
    ```
2. Add the Converter to System.Text.Json in `Program.cs` via (e.g. see [Program.cs](/Program.cs)):
    ```cs
    using SystemTextJsonPatch.Converters;
    ...
    
    builder.Services.Configure<JsonOptions>(o =>
        o.SerializerOptions.Converters.Add(new JsonPatchDocumentConverterFactory()));
    ```

## Examples

Check [examples.http](/examples.http) for examples of the HTTP Patch calls.

You can actually run the examples, by opening [examples.http](/examples.http) in VS Code using the [Rest Client Extension](https://marketplace.visualstudio.com/items?itemName=humao.rest-client).


## Notes

* HTTP Patch support in Minimal API is provided by the `MapPatch` endpoint registration method.  In .NET 6 that is using an extension method (see [Extensions.cs](/Extensions.cs)).  This is a built-in method from .NET 7.
* HTTP Patch support is provided by the built-in `[HttpPatch]` attribute for Controller based action methods.
