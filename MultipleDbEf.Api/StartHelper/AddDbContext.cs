using MultipleDbEf.Data;

namespace MultipleDbEf.Api.StartHelper;

internal static class AddDbContextExtensions
{
    internal static void AddDbContexts(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.AddSqlServer<StudentContext>(configuration.GetConnectionString("StudentConstr"));
        services.AddSqlServer<PersonContext>(configuration.GetConnectionString("PersonConstr"));
    }
}