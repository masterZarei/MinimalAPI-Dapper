namespace MinimalAPIDemo;

public static class API
{
    public static void ConfugureAPI(this WebApplication app)
    {
        // All my API endpoint mapping here
        app.MapGet("/Users", GetUsers);
        app.MapGet("/Users/{id}", GetUser);
        app.MapPost("/Users", InsertUser);
        app.MapPut("/Users", UpdatetUser);
        app.MapDelete("/Users", DeleteUser);
    }
    private static async Task<IResult> GetUsers(IUserData data)
    {
        try
        {
            return Results.Ok(await data.GetUsers());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.ToString());
        }
    }
    private static async Task<IResult> GetUser(int id, IUserData data)
    {
        try
        {
            var results = await data.GetUser(id);
            if (results is null) return Results.NotFound();

            return Results.Ok(results);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.ToString());
        }
    }
    private static async Task<IResult> InsertUser(UserModel user, IUserData data)
    {
        try
        {
            await data.InsertUser(user);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.ToString());
        }
    }
    private static async Task<IResult> UpdatetUser(UserModel user, IUserData data)
    {
        try
        {
            await data.UpdateUser(user);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.ToString());
        }
    }
    private static async Task<IResult> DeleteUser(int id, IUserData data)
    {
        try
        {
            await data.DeleteUser(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.ToString());
        }
    }
}
