using RestSharp;
using System.Net;

namespace desafio.base2.testes.crosscutting.environment.Base
{
    public class BaseRequest<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public T Response { get; set; }
        public RestRequest Request { get; set; }
        public RestClient RestClient { get; set; }
        public MensagemErro Exception { get; set; }
        public string ErrorRequest { get; set; }
    }
}

