using FluentValidation;
using SystemTextJsonPatch;

namespace PatchExample;

public class Handlers
{
    public static Profile Get()
    {
        return GetProfile();
    }
    
    /// <summary>
    /// Strongly typed JSON Patch. 
    /// </summary>
    public static IResult PatchProfile(JsonPatchDocument<Profile> request, IValidator<Profile> validator)
    {
        var profile = GetProfile();
            
        request.ApplyTo(profile);

        var result = validator.Validate(profile);

        return !result.IsValid ? Results.ValidationProblem(result.ToDictionary()) : Results.Ok(profile);
    }
    

    /// <summary>
    /// Patch the Profile but using a non-typed JsonPatchDocument to do so.
    /// </summary>
    public static IResult PatchObject(JsonPatchDocument request, IValidator<Profile> validator)
    {
        var profile = GetProfile();

        request.ApplyTo(profile);

        var result = validator.Validate(profile);
        
        return !result.IsValid ? Results.ValidationProblem(result.ToDictionary()) : Results.Ok(profile);
    }

    private static Profile GetProfile()
    {
        return new Profile
        {
            FirstName = "Bob",
            LastName = "Jane",
            Age = 78,
            Registered = new DateTime(2018, 10, 23)
        };
    }
    
}