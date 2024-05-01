using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExemplosExplorando.Models
{
    public class Venda
    {
        public Venda(int id, string produto, decimal preco, DateTime dataVenda) // Construtor: A propriedade vai receber o argumento
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = dataVenda;
        }


// Para deserializar, precisa criar uma class para ler o arquivo json onde os nomes das propriedades da class tem que ser os mesmos que os das chaves do json
        public int Id { get; set; }

        [JsonProperty("Nome_Produto")] // sera necessario adicionar essa assinatura caso a chave do json venha fora do padrao de escrita do C#, camelCase
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal? Desconto { get; set; } // propriedade que aceita receber valor null
    }
}