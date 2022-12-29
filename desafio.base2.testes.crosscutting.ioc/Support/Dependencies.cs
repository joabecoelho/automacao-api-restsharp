using desafio.base2.testes.crosscutting.environment;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using RestSharp;
using Autofac;
using desafio.base2.testes.infra.Apis.Base;
using desafio.base2.testes.infra.Apis.Interface.Base;
using desafio.base2.testes.infra.Apis.Interface;
using desafio.base2.testes.infra.Apis;

namespace desafio.base2.testes.crosscutting.ioc.Support
{
    public static class Dependencies
    { 
    public static ContainerBuilder CreateContainerBuilder()
    {
        LaunchSettingsFixture();
        var builder = new ContainerBuilder();
        builder.RegisterType<AppSettings>().SingleInstance();
        builder.RegisterType<RestClient>().As<RestClient>();
        builder.RegisterType<RestClientOptions>().As<RestClientOptions>();
        builder.RegisterType<RestManager>().As<IRestManager>();
        builder.RegisterType<RestManagerMantis>().As<IRestManagerMantis>();
        builder.RegisterType<ExecuteMantis>().As<IExecuteMantis>();
        builder.RegisterType<ServiceCollection>().As<IServiceCollection>();

        return builder;
    }

    private static void LaunchSettingsFixture()
    {
        using var file = File.OpenText("Properties\\launchSettings.json");
        var reader = new JsonTextReader(file);
        var jObject = JObject.Load(reader);
        var variables = jObject.GetValue("profiles")
            .SelectMany(profiles => profiles.Children())
            .SelectMany(profile => profile.Children<JProperty>())
            .ToList();

#if QA
            var variaveisQa = variables.Where(prop => prop.Path == "profiles['desafio.base2.testes:dsv'].environmentVariables")
                                .SelectMany(prop => prop.Value.Children<JProperty>())
                                .ToList();
            foreach (var variable in variaveisQa)
                Environment.SetEnvironmentVariable(variable.Name, variable.Value.ToString());
#endif
#if HML

            var variaveisHml = variables.Where(prop => prop.Path == "profiles['desafio.base2.testes:hml'].environmentVariables")
                .SelectMany(prop => prop.Value.Children<JProperty>())
                .ToList();
            foreach (var variable in variaveisHml)
                Environment.SetEnvironmentVariable(variable.Name, variable.Value.ToString());
#endif
        }
    }
}
