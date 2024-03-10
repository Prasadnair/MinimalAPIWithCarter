using Carter;

namespace MinimalAPIWithCarter.Modules
{
    public class SampleModule : CarterModule
    {
        public override void AddRoutes(IEndpointRouteBuilder app)
        {

            app.MapGet("/hello", () =>
            {
                return "Hello, World!";
                
            });

        }
    }
}
