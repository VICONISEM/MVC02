namespace MVC02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello From master");
                });







                endpoints.MapGet("/Home", async context =>
                {
                    await context.Response.WriteAsync("Hello From Home");
                });


                //endpoints.MapGet("/Products", async context =>
                //{
                //    await context.Response.WriteAsync("Hello From Products");
                //});



                endpoints.MapGet("/Products/{ID:int?}", async context =>
                {
                    await context.Response.WriteAsync($"Hello From Products id =>{context.Request.RouteValues["ID"]??"Null ID"}");
                });






                endpoints.MapGet("/Books/{Auther:alpha}/{ID:int?}", async context =>
                {
                    await context.Response.WriteAsync($"Book with id=>{context.Request.RouteValues["ID"]??"Null ID"} , Aother => {context.Request.RouteValues["Auther"]}");
                });
            });

            app.Run(async (HttpContext) => { await HttpContext.Response.WriteAsync("This Page not Exsite"); });
            app.Run();

         
        }
    }
}
