namespace ApiFuncional.Configuration
{
    public static class CorsConfig
    {
        public static WebApplicationBuilder AddCorsConfig(this WebApplicationBuilder builder)
        {
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("Development", builder =>
                            builder
                                 .WithOrigins()
                                 .WithMethods()
                                 .AllowAnyHeader());

                options.AddPolicy("Production", builder =>
                            builder
                                 .WithOrigins("https://localgost:9000")
                                 .WithMethods("POST")
                                 .AllowAnyHeader());
            });
            return builder;
        }
    }
}