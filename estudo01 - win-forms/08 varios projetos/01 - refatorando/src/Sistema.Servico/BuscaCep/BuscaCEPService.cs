using Sistema.Negocio;
using System.Text.Json;

namespace Sistema.Servico.BuscaCep
{
    public class BuscaCEPService
    {
        private string enderecoJson; 
        public string EndPoint { get; set; }

        public BuscaCEPService()
        {
            EndPoint = "http://viacep.com.br/ws/";
        }

        public BuscaCEPService(string cEndPoint)
        {
           EndPoint = cEndPoint;             
        }

        private void BuscaLogradouro(string cCep)
        {

            RestClient client = new RestClient();
            client.EndPoint = this.EndPoint; 

            client.Request(cCep.Trim());

            enderecoJson = client.Response();

        }

        public CepModel CepModel(string cCep)
        {
            BuscaLogradouro(cCep); 

            return JsonSerializer.Deserialize<CepModel>(json: enderecoJson);

        }

        public string CepJson(string cCep)
        {           
            BuscaLogradouro(cCep);

            return enderecoJson; 

        }
    }
}
