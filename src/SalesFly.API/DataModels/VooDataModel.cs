using System;

namespace SalesFly.API.DataModels
{
    public class VooDataModel
    {  public string voo { get; set; }
        public string origem { get; set; }
        public string destino { get; set; }
        public string data_saida { get; set; }
        public string saida { get; set; }
        public string chegada { get; set; }
        public decimal valor { get; set; }
    }
}
