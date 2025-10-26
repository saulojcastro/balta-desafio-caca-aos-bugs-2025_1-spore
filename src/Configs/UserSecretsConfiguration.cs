namespace BugStore.Configs
{
    public static class UserSecretsConfiguration
    {
        public static WebApplicationBuilder AddUserSecretsConfiguration(this WebApplicationBuilder builder)
        {
            // Adiciona suporte a User Secrets (somente em Development)
            if (builder.Environment.IsDevelopment())
            {
                builder.Configuration.AddUserSecrets<Program>();
            }

            return builder;
        }
    }
}
