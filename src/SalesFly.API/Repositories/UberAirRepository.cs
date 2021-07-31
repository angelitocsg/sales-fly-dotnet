using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using SalesFly.Shared.Models;

namespace SalesFly.API.Repositories
{
    public class UberAirRepository : IUberAirRepository
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

                var voo = new Voo()
                {
                    NumeroVoo = columns[(int)0],
                    Empresa = "UberAir",
                    Origem = columns[(int)1],
                    Destino = columns[(int)2],
                    DataSaida = Convert.ToDateTime(columns[(int)3]),
                    Saida = columns[(int)4],
                    Chegada = columns[(int)5],
                    Valor = Convert.ToDecimal(columns[(int)6].Replace(".", ",", false, CultureInfo.GetCultureInfo("en-US")))
                };
                voos.Add(voo);
            }

            return voos;
        }
    }
}
