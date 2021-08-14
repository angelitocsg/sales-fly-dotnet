using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesFly.Shared.Models
{
    public class Carrinho
    {
        public int Ticket { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public List<CarrinhoItems> Items {get;set;}

        public decimal Total
        {
            get { return Items.Select(it => it.Valor).Sum(); }
        }

        public Carrinho(string nome)
        {
            Data = DateTime.Now;
            Ticket = new Random().Next(10000, 99999);
            Nome = nome;
            Items = new List<CarrinhoItems>();
        }

        public void AdicionaItem(Voo voo)
        {
            Items.Add(new CarrinhoItems(
                lineId: Items.Count() + 1,
                voo.Empresa,
                voo.NumeroVoo,
                voo.Valor,
                voo.Origem,
                voo.Destino
            ));
        }

        public void RemoveItem(int lineId)
        {
            Items = Items.Where(it => !it.LineId.Equals(lineId)).ToList();
        }
    }
}
