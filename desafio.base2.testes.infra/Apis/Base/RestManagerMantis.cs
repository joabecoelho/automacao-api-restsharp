using desafio.base2.testes.crosscutting.environment;
using desafio.base2.testes.crosscutting.environment.Base;
using desafio.base2.testes.infra.Apis.Interface.Base;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Authenticators.OAuth2;
using RestSharp.Serializers.NewtonsoftJson;
using System.Net;

namespace desafio.base2.testes.infra.Apis.Base
{
    public class RestManagerMantis : RestManager, IRestManagerMantis
    {
        public RestManagerMantis(RestClientOptions restClientOptions, AppSettings appSettings) :
            base(restClientOptions, appSettings)
        {

        }

        protected override RestRequest Request(string uri, Method method)
        {
            CleanHeaders();
            DefaultHeaders();
            var url = $"{AppSettings.UrlBaseMantis}{uri}";
            AdicionarToken();
            var restRequest = new RestRequest
            {
                Resource = url,
                Method = method
            };
            return restRequest;
        }

        protected override RestRequest BodyRequest<T>(string uri, T body, Method method)
        {
            CleanHeaders();
            DefaultHeaders();
            var url = $"{AppSettings.UrlBaseMantis}{uri}";
            AdicionarToken();
            var restRequest = new RestRequest(url, method);
            if (body != null)
            {
                restRequest.AddJsonBody<object>(body);
            }
            return restRequest;
        }


        private void AdicionarToken()
        {
            CleanHeaders();
            DefaultHeaders();
            RestClient.Authenticator = null;

            var url = $"{AppSettings.UrlBaseMantis}oauth2/token";

            var request = new RestRequest(url, Method.Post);

            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddHeader("cache-control", "no-cache");
            request.AddParameter("application/x-www-form-urlencoded", $"grant_type={AppSettings.Oauth.GrantType}&scope={AppSettings.Oauth.Scope}&client_id={AppSettings.Oauth.ClientId}&client_secret={AppSettings.Oauth.ClientSecret}", ParameterType.RequestBody);
            var post = RestClient.Execute(request);
            if (!post.IsSuccessful)
                return;

            var json = JObject.Parse(post.Content);
            var token = json["access_token"].ToString();
            RestClient.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(token, "Bearer");
        }

        protected override void DefaultHeaders()
        {
            RestClient.AddDefaultHeader("apikey", AppSettings.ApiKey);
        }
        protected override void CleanHeaders()
        {
            RestClient.DefaultParameters.RemoveParameter("apikey");
        }

    }
}
