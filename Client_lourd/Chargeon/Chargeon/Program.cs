using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Chargeon
{
    static class Program
    {

        static void Main(String[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            /*
            HttpClient client = new HttpClient();
           // Console.WriteLine("Appel vers l'API...");

            // Appel à l'URL 
            var responseTask = client.GetAsync("https://api.scryfall.com/cards/random");
            responseTask.Wait();

            if (responseTask.IsCompleted)
            {
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    // messageTask contient tout le JSON
                    var messageTask = result.Content.ReadAsStringAsync();

                    //Stuff converti la string (MessageTask.Result) en JSON
                    dynamic stuff = JObject.Parse(messageTask.Result);

                    //Récupère la variable name du JSON
                    string name = stuff.name;
               

                    messageTask.Wait();
                  //  Console.WriteLine("Message de l'api : " + name);
                   // Console.ReadLine();
                }
            }*/
        }
     
    }
}

