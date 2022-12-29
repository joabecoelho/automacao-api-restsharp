using desafio.base2.testes.crosscutting.environment.Base;
using desafio.base2.testes.crosscutting.environment;
using desafio.base2.testes.infra.Apis.Interface.Base;
using RestSharp.Authenticators;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Serializers.NewtonsoftJson;

namespace desafio.base2.testes.infra.Apis.Base
{
    public class RestManager : IRestManager
    {
        protected readonly RestClient RestClient;
        protected readonly RestClientOptions RestClientOptions;
        protected readonly AppSettings AppSettings;
        public RestManager(RestClientOptions restClientOptions,
                           AppSettings appSettings)
        {
            RestClientOptions = restClientOptions;
            RestClient = new RestClient(RestClientOptions);
            AppSettings = appSettings;
        }

        public async Task<BaseRequest<TResponse>> Get<TResponse>(string uri)
        {
            var restRequest = Request(uri, Method.Get);
            return await GetContent<TResponse>(restRequest);
        }

        public async Task<BaseRequest<TResponse>> Post<TResponse, TBody>(string uri, TBody body)
        {
            var restRequest = BodyRequest(uri, body, Method.Post);
            return await GetContent<TResponse>(restRequest);
        }

        public async Task<BaseRequest<TResponse>> Post<TResponse>(string uri)
        {
            var restRequest = BodyRequest(uri, Method.Post);
            return await GetContent<TResponse>(restRequest);
        }

        public async Task<BaseRequest<TResponse>> Put<TResponse, TBody>(string uri, TBody body)
        {
            var restRequest = BodyRequest(uri, body, Method.Put);
            return await GetContent<TResponse>(restRequest);
        }

        public async Task<BaseRequest<TResponse>> Put<TResponse>(string uri)
        {
            var restRequest = Request(uri, Method.Put);
            return await GetContent<TResponse>(restRequest);
        }

        public async Task<BaseRequest<bool>> Put(string uri)
        {
            var restRequest = Request(uri, Method.Put);
            return await GetNoContent(restRequest);
        }

        public async Task<BaseRequest<bool>> Put<TBody>(string uri, TBody body)
        {
            var restRequest = BodyRequest(uri, body, Method.Put);
            return await GetNoContent(restRequest);
        }

        public async Task<BaseRequest<TResponse>> Delete<TResponse, TBody>(string uri, TBody body)
        {
            var restRequest = BodyRequest(uri, body, Method.Delete);
            return await GetContent<TResponse>(restRequest);
        }

        public async Task<BaseRequest<TResponse>> Delete<TResponse>(string uri)
        {
            var restRequest = BodyRequest(uri, Method.Delete);
            return await GetContent<TResponse>(restRequest);
        }

        public async Task<BaseRequest<TResponse>> Patch<TResponse, TBody>(string uri, TBody body)
        {
            var restRequest = BodyRequest(uri, body, Method.Patch);
            return await GetContent<TResponse>(restRequest);
        }

        public async Task<BaseRequest<TResponse>> Patch<TResponse>(string uri)
        {
            var restRequest = BodyRequest(uri, Method.Patch);
            return await GetContent<TResponse>(restRequest);
        }

        public async Task<BaseRequest<bool>> Patch(string uri)
        {
            var restRequest = Request(uri, Method.Patch);
            return await GetNoContent(restRequest);
        }

        public async Task<BaseRequest<bool>> Patch<TBody>(string uri, TBody body)
        {
            var restRequest = BodyRequest(uri, body, Method.Patch);
            return await GetNoContent(restRequest);
        }

        protected virtual RestRequest Request(string uri, Method method)
        {
            SetupClient();
            CleanHeaders();
            RestClientOptions.BaseUrl = AppSettings.UrlBaseMantis;
            DefaultHeaders();
            var url = $"{RestClientOptions.BaseUrl}{uri}";
            var restRequest = new RestRequest(url, method);
            Authenticator();

            return restRequest;
        }

        protected virtual RestRequest BodyRequest<T>(string uri, T body, Method method)
        {
            SetupClient();
            CleanHeaders();
            RestClient.UseNewtonsoftJson();
            RestClientOptions.BaseUrl = AppSettings.UrlBaseMantis;
            DefaultHeaders();
            var url = $"{RestClientOptions.BaseUrl}{uri}";
            Authenticator();
            var restRequest = new RestRequest(url, method);

            if (body != null)
                restRequest.AddJsonBody<object>(body);
            return restRequest;
        }

        protected virtual RestRequest BodyRequest(string uri, Method method)
        {
            SetupClient();
            CleanHeaders();
            RestClientOptions.BaseUrl = AppSettings.UrlBaseMantis;
            RestClient.UseNewtonsoftJson();
            DefaultHeaders();
            var url = $"{RestClientOptions.BaseUrl}{uri}";
            Authenticator();
            var restRequest = new RestRequest(url, method);

            return restRequest;
        }

        private async Task<BaseRequest<TResponse>> GetContent<TResponse>(RestRequest restRequest)
        {
            RestClient.UseNewtonsoftJson();
            var response = await RestClient.ExecuteAsync<TResponse>(restRequest);
            var result = GetResult<TResponse>(response);
            if (response.IsSuccessful)
                result.Response = response.Data;
            return result;
        }

        private async Task<BaseRequest<bool>> GetNoContent(RestRequest restRequest)
        {
            var response = await RestClient.ExecuteAsync(restRequest);
            var result = GetResult<bool>(response);

            return result;
        }

        private BaseRequest<TResponse> GetResult<TResponse>(RestResponse response)
        {
            var result = new BaseRequest<TResponse>
            {
                StatusCode = response.StatusCode,
                Request = response.Request,
                RestClient = RestClient
            };

            if (!response.IsSuccessful)
            {
                if (!String.IsNullOrEmpty(response.ErrorMessage))
                {
                    result.ErrorRequest = response.ErrorMessage;
                }
            }

            return result;
        }

        private void SetupClient()
        {
            CleanHeaders();

            RestClientOptions.BaseUrl = AppSettings.UrlBaseMantis;
            RestClient.UseNewtonsoftJson();

            RestClientOptions.Expect100Continue = false;
            RestClientOptions.Proxy = new WebProxy()
            {
                Credentials = CredentialCache.DefaultCredentials
            };
        }


        protected virtual void CleanHeaders()
        {
            RestClient.DefaultParameters.RemoveParameter("apikey");
            RestClient.DefaultParameters.RemoveParameter("x-bs2-correlation-id");
        }

        protected virtual void DefaultHeaders()
        {
            RestClient.AddDefaultHeader("apikey", AppSettings.ApiKey);
        }

        protected virtual void Authenticator()
        {
            RestClient.Authenticator = new HttpBasicAuthenticator(AppSettings.Autorizacao.Usuario, AppSettings.Autorizacao.Senha);
        }

        public async Task<BaseRequest<bool>> Post(string uri)
        {
            var restRequest = Request(uri, Method.Post);
            return await GetNoContent(restRequest);
        }

        public async Task<BaseRequest<bool>> Post<TBody>(string uri, TBody body)
        {
            var restRequest = BodyRequest(uri, body, Method.Post);
            return await GetNoContent(restRequest);
        }

        public async Task<BaseRequest<bool>> Delete(string uri)
        {
            var restRequest = Request(uri, Method.Delete);
            return await GetNoContent(restRequest);
        }

        public async Task<BaseRequest<bool>> Delete<TBody>(string uri, TBody body)
        {
            var restRequest = BodyRequest(uri, body, Method.Delete);
            return await GetNoContent(restRequest);
        }
    }
}
