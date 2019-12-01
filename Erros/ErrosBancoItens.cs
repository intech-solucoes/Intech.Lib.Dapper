using System.Collections.Generic;

namespace Intech.Lib.Dapper.Erros
{
    public class ErrosBancoItens
    {
        public string MensagemBase { get; set; }
        public List<KeyValuePair<string, string>> Itens { get; set; }
    }
}