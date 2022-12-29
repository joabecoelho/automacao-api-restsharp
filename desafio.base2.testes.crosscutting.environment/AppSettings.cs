using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio.base2.testes.crosscutting.environment
{
    public class AppSettings
    {
        public Uri UrlBaseMantis { get; set; }
        public Oauth Oauth { get; set; }
        public Autorizacao Autorizacao { get; set; }
        public string ApiKey { get; set; }
        public string AppUsed { get; set; }
        public string MagIdentifier { get; set; }
        public string ProxyMantis => "api/rest/";

        public AppSettings()
        {
            UrlBaseMantis = new Uri(Environment.GetEnvironmentVariable("URL_BASE") ?? "");
            ApiKey = Environment.GetEnvironmentVariable("APIKEY");

            Autorizacao = new Autorizacao
            {
                Usuario = Environment.GetEnvironmentVariable("USUARIO_AUTORIZACAO"),
                Senha = Environment.GetEnvironmentVariable("SENHA_AUTORIZACAO")
            };

            Oauth = new Oauth
            {
                GrantType = "client_credentials",
                Scope = "api/read api/write",
                ClientId = Environment.GetEnvironmentVariable("CLIENT_ID"),
                ClientSecret = Environment.GetEnvironmentVariable("CLIENT_SECRET")
            };

            MagIdentifier = Environment.GetEnvironmentVariable("MAG_IDENTIFIER") ?? "";
            AppUsed = Environment.GetEnvironmentVariable("APP_USED");
        }

    }
}