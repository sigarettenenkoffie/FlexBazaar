namespace FlexBazaar.API.Endpoints.GetWhatever;

public class GetWhateverEndpoint : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("/whatever", async context =>
        {
            await context.Response.WriteAsync("Whatever");
        });
    }
}
