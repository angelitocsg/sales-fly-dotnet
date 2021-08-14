using System;

namespace SalesFly.Shared.Models
{
    public class CarrinhoItems
    {
        public int LineId { get; set; }
        public string Empresa { get; private set; }
        public string Origem { get; private set; }
        public string Destino { get; private set; }
        public string NumeroVoo { get; private set; }
        public decimal Valor { get; private set; }

        public CarrinhoItems(int lineId, string empresa, string numeroVoo, decimal valor, string origem, string destino)
        {
            LineId = lineId;
            Empresa = empresa;
            NumeroVoo = numeroVoo;
            Valor = valor;
            Origem = origem;
            Destino = destino;
        }
    }
}
