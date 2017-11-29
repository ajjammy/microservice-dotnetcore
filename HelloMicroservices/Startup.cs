namespace HelloMicroservices
{
    using Microsoft.AspNetCore.Builder;
    using Nancy.Owin;
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseOwin(buildFunc =>
            {
                buildFunc(next => env =>
                {
                    System.Console.WriteLine("Got request");
                    return next(env);
                });
                buildFunc.UseNancy();
            });
        }
    }
}
