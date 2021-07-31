using System;
using System.Text.Json.Serialization;

namespace SalesFly.Shared.Models
{
    public class Voo
    {
        public string Empresa { get; set; }
        
        [JsonPropertyName("numero_voo")]
        public string NumeroVoo { get; set; }

        [JsonPropertyName("aeroporto_origem")]
        public string Origem { get; set; }

        [JsonPropertyName("aeroporto_destino")]
        public string Destino { get; set; }

        [JsonPropertyName("data")]
        public DateTime DataSaida { get; set; }

        [JsonPropertyName("horario_saida")]
        public string Saida { get; set; }

        [JsonPropertyName("horario_chegada")]
        public string Chegada { get; set; }

        [JsonPropertyName("preco")]
        public decimal Valor { get; set; }
    }
}
