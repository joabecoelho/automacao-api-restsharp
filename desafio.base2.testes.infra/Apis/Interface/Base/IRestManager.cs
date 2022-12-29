using desafio.base2.testes.crosscutting.environment.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio.base2.testes.infra.Apis.Interface.Base
{
    public interface IRestManager
    {
        Task<BaseRequest<TResponse>> Get<TResponse>(string uri);
        Task<BaseRequest<TResponse>> Post<TResponse, TBody>(string uri, TBody body);
        Task<BaseRequest<TResponse>> Post<TResponse>(string uri);
        Task<BaseRequest<bool>> Post(string uri);
        Task<BaseRequest<bool>> Post<TBody>(string uri, TBody body);
        Task<BaseRequest<TResponse>> Put<TResponse, TBody>(string uri, TBody body);
        Task<BaseRequest<TResponse>> Put<TResponse>(string uri);
        Task<BaseRequest<bool>> Put(string uri);
        Task<BaseRequest<bool>> Put<TBody>(string uri, TBody body);
        Task<BaseRequest<TResponse>> Delete<TResponse, TBody>(string uri, TBody body);
        Task<BaseRequest<TResponse>> Delete<TResponse>(string uri);
        Task<BaseRequest<bool>> Delete(string uri);
        Task<BaseRequest<bool>> Delete<TBody>(string uri, TBody body);
        Task<BaseRequest<TResponse>> Patch<TResponse, TBody>(string uri, TBody body);
        Task<BaseRequest<TResponse>> Patch<TResponse>(string uri);
        Task<BaseRequest<bool>> Patch(string uri);
        Task<BaseRequest<bool>> Patch<TBody>(string uri, TBody body);
    }
}
