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
        public static async Task<Correntista> LoginAsync(Correntista c)
        {
            var json_a_enviar = JsonConvert.SerializeObject(c);

            Console.WriteLine(json_a_enviar);


            string json = await DataService.PostDataToService(json_a_enviar, "/correntista/entrar");

            return JsonConvert.DeserializeObject<Correntista>(json);
        }

        public static async Task<Correntista> SaveAsync(Correntista c)
        {
            var json_a_enviar = JsonConvert.SerializeObject(c);

            Console.WriteLine(json_a_enviar);
       

            string json = await DataService.PostDataToService(json_a_enviar, "/correntista/salvar");

            return JsonConvert.DeserializeObject<Correntista>(json);
        }
    }
}
