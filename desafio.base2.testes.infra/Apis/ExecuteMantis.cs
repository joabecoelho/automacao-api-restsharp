using desafio.base2.testes.crosscutting.environment;
using desafio.base2.testes.crosscutting.environment.Base;
using desafio.base2.testes.infra.Apis.Interface;
using desafio.base2.testes.infra.Apis.Interface.Base;

namespace desafio.base2.testes.infra.Apis
{
    public class ExecuteMantis : IExecuteMantis
    {
        private readonly IRestManagerMantis _restManagerMantis;
        private readonly AppSettings _appSettings;


        public ExecuteMantis(IRestManagerMantis restManagerMantis,
                              AppSettings appSettings)
        {
            _restManagerMantis = restManagerMantis;
            _appSettings = appSettings;
        }

       /* public async Task<BaseRequest<ListarCartoesFisicos>> ListarDadosCartaoFisicoBit55(int idPessoa)
        {
            var urlCartaoFisico = $"{_appSettings.ProxyMantis}cartao?idPessoa={idPessoa}";
            var requestBit55CartaoFisico = await _restManagerMantis.Get<ListarCartoesFisicos>(urlCartaoFisico);

            return requestBit55CartaoFisico;
        }*/
    }
}