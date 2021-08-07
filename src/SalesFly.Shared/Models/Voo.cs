using System;
using System.Text.Json.Serialization;

namespace SalesFly.Shared.Models
{
    public class Voo
    {
        public Voo(string empresa, string numeroVoo, string origem, string destino, DateTime dataSaida, string saida, string chegada, decimal valor)
        {
            Empresa = empresa;
            NumeroVoo = numeroVoo;
            Origem = origem;
            Destino = destino;
            DataSaida = dataSaida;
            Saida = saida;
            Chegada = chegada;
            Valor = valor;
        }

        public string Empresa { get; private set; }
        public string NumeroVoo { get; private set; }
        public string Origem { get; private set; }
        public string Destino { get; private set; }
        public DateTime DataSaida { get; private set; }
        public string Saida { get; private set; }
        public string Chegada { get; private set; }
        public decimal Valor { get; private set; }
    }
}
