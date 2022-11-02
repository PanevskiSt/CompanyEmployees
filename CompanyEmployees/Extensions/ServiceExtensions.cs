namespace CompanyEmployees.Extensions
{
    public static class ServiceExtensions
    {
        //configuring CORS to allow sending requests from different domain to our applicaton

        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()            //should later be changed to be more specific with security in mind
                .AllowAnyMethod()                   //can specify concrete methods such as "POST", "GET" e.t.c.
                .AllowAnyHeader());                 //can be specific as for exmaple with "accept", "content-type" e.t.c
            });

        //configure IIS integration

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {
                        //default options suffice for the time being therefore no property is being initialised
            });
    }
}
