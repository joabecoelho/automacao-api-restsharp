using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio.base2.testes.crosscutting.environment.Base
{
    public class MensagemErro
    {
        public MensagemErro()
        {
            Erros = new List<Erro>();
        }
        [JsonProperty("erros")]
        public List<Erro> Erros { get; set; }
    }
}
