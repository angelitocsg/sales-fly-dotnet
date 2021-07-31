using System.Text.Json.Serialization;

namespace SalesFly.Shared.Models
{
    public class Aeroporto
    {
        public Aeroporto(string nome, string sigla, string cidade)
        {
            Nome = nome;
            Sigla = sigla;
            Cidade = cidade;
        }

        public string Nome { get; set; }
        
        [JsonPropertyName("aeroporto")]
        public string Sigla { get; set; }
        public string Cidade { get; set; }
    }
}
