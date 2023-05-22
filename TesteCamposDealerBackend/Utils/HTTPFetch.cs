using Newtonsoft.Json;
using NuGet.Protocol;
using System.Text.Json;
using TesteCamposDealerBackend.Models;

namespace TesteCamposDealerBackend.Utils
{
    public class HTTPFetch
    {
        private readonly string url;
        private readonly HttpClient client;

        public HTTPFetch()
        {
            url = "https://camposdealer.dev/Sites/TesteAPI";
            client = new HttpClient();
        }

        private T Get<T>(string endpoint) where T : class
        {
            HttpResponseMessage response = client.GetAsync($"{url}/{endpoint}").Result;
            response.EnsureSuccessStatusCode();
            string result = response.Content.ReadAsStringAsync().Result.Replace("\\", "").Replace("\"[", "[").Replace("]\"", "]");
            var convertedObject = JsonConvert.DeserializeObject<T>(result);
            return convertedObject;
        }

        public IList<Cliente> ObterClientes()
        {
            return Get<IList<Cliente>>("cliente");
        }

        public IList<Produto> ObterProdutos()
        {
            return Get<IList<Produto>>("produto");
        }

        public IList<Venda> ObterVendas()
        {
            return Get<IList<Venda>>("venda");
        }
    }
}
