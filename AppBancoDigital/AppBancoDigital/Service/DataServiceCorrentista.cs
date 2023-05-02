using AppBancoDigital.Model;
using AppBancoDigital.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppBancoDigital.Service
{
    public class DataServiceCorrentista : DataService
    {
        public static async Task<List<Correntista>> GetCorrentistasAsync()
        {
            string json = await DataService.GetDataFromService("/correntista");

            List<Correntista> arr_pessoas = JsonConvert.DeserializeObject<List<Correntista>>(json);

            return arr_correntista;
        }

        public static async Task<Correntista> Cadastrar(Correntista c)
        {
            var json_a_enviar = JsonConvert.SerializeObject(c);

            string json = await DataService.PostDataToService(json_a_enviar, "/Correntista/salvar");

            Correntista correntista = JsonConvert.DeserializeObject<Correntista>(json);

            return c;
        }

        public static async Task<List<Correntista>> SearchAsync(string q)
        {
            var json_a_enviar = JsonConvert.SerializeObject(q);

            string json = await DataService.PostDataToService(json_a_enviar, "/correntista/buscar");

            List<Correntista> arr_correntista = JsonConvert.DeserializeObject<List<Correntista>>(json);

            return arr_correntista;
        }

        public static async Task<List<Correntista>> DeleteAsync(int id)
        {
            var json_a_enviar = JsonConvert.SerializeObject(id);

            string json = await DataService.PostDataToService(json_a_enviar, "/correntista/delete");

            List<Correntista> arr_correntista = JsonConvert.DeserializeObject<List<Correntista>>(json);

            return arr_correntista;
        }

    }
}
