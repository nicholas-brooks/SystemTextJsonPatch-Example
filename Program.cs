using FluentValidation;
using Microsoft.AspNetCore.Http.Json;
using PatchExample;
using SystemTextJsonPatch.Converters;

var builder = WebApplication.CreateBuilder(args);

// Register the SystemTextJsonPatch Json Converter.
builder.Services.Configure<JsonOptions>(o =>
    o.SerializerOptions.Converters.Add(new JsonPatchDocumentConverterFactory()));

// Register Fluent Validator types
builder.Services.AddValidatorsFromAssembly(typeof(Program).Assembly);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/profile", Handlers.Get);

app.MapPatch("/profile", Handlers.PatchProfile);

app.MapPatch("/obj", Handlers.PatchObject);

app.Run();
