namespace BugStore.Configs
{
    public static class UserSecretsConfiguration
    {
        public static WebApplicationBuilder AddUserSecretsConfiguration(this WebApplicationBuilder builder)
        {
            if (builder.Environment.IsDevelopment())
                builder.Configuration.AddUserSecrets<Program>();
            
            return builder;
        }
    }
}
