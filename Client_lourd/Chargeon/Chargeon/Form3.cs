using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Chargeon
{
    public partial class Form3 : Form
    {
        HttpClient client = new HttpClient();


        public Form3()
        {
            InitializeComponent();
        }

        
        private class Item
        {
            public string _Id;

            public Item( string id)
            {
                _Id = id;
            }
            public string Id
            {
                get { return _Id; }
                set { _Id = value; }
            }
        }
        
        // Action au chargement de la page, ici le remplissage de la combobox avec les numéros de série des bornes de la BDD
        private void Form3_Load(object sender, EventArgs e)
        {
           
        
            string str = new WebClient().DownloadString("http://127.0.0.1:3000/select");
            JObject jo = JObject.Parse(str);
            Console.WriteLine(jo["taille"][0]["taille"]);

            JToken taillejson = jo["taille"][0]["taille"];
            int taille = taillejson.ToObject<int>();

            
            for (int i = 0; i < taille; i++)
            {
                cbNumSerie.ValueMember = "Id";
                cbNumSerie.Items.Add(jo["id"][i]["num_serie"]);
            }

        }

        public void btn_delete(object sender, EventArgs e)
        {
            string borneId = cbNumSerie.SelectedItem.ToString();

            var responseTask = client.GetAsync("http://127.0.0.1:3000/delete?borneId=" + borneId);
            responseTask.Wait();
            MessageBox.Show("Borne supprimé !");
            this.Close();
        }
       
    }  
}
