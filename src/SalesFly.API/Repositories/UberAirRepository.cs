using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using SalesFly.API.DataModels;
using SalesFly.Shared.Models;

namespace SalesFly.API.Repositories
{
    public class UberAirRepository : IVoosRepository
    {
        private async Task<string> Load()
        {
            var url = "https://raw.githubusercontent.com/tegraoss/desafio-tegra/master/uberair.csv";
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = await httpClient.GetAsync(url);

            var data = await responseMessage.Content.ReadAsStringAsync();

            return data;
        }

        public async Task<IEnumerable<Voo>> GetAsync()
        {
            string uberair = await Load();
            var lines = uberair.Split("\r\n");

            List<Voo> voos = new List<Voo>();

            for (int i = 0; i < lines.Count(); i++)
            {
                if (i == 0) { continue; }

                var columns = lines[i].Split(',');

                var voo = new Voo(
                    empresa: "Uber Air",
                    numeroVoo: columns[0],
                    origem: columns[1],
                    destino: columns[2],
                    dataSaida: Convert.ToDateTime(columns[(int)3]),
                    saida: columns[4],
                    chegada: columns[5],
                    valor: Convert.ToDecimal(columns[6].Replace(".", ",", false, CultureInfo.GetCultureInfo("en-US")))
                );
                voos.Add(voo);
            }

            return voos;
        }
    }
}
