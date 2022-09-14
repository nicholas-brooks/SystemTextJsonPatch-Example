# Example Minimal API for SystemTextJsonPatch Library

Example project on how to use [`SystemTextJsonPatch`](https://github.com/Havunen/SystemTextJsonPatch) library to provide PATCH support for your API.

This example is written using Minimal API and targets .NET 6.

To get this working in your project:

1. Install `SystemTextJsonPatch` library.
2. Add the Converter to System.Text.Json in `Program.cs` via:
    ```
    builder.Services.Configure<JsonOptions>(o =>
        o.SerializerOptions.Converters.Add(new JsonPatchDocumentConverterFactory()));
    ```

## Examples
Check `exmaples.http` for examples of the HTTP calls.  You can actually run the examples, by opening `examples.http` in VS Code using the [Rest Client Extension](https://marketplace.visualstudio.com/items?itemName=humao.rest-client).


## Notes

* `MapPatch` is provided using an extension method.  This is a built-in method from .NET 7.
* Patch support is provided by `[HttpPatch]` attribute for Controller based actions.
