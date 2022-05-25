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

        private void cbNumSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvSelectAll.Items.Clear();

            string str = new WebClient().DownloadString("http://127.0.0.1:3000/selectborne?borneId=" + cbNumSerie.Text);
            JObject jo = JObject.Parse(str);



            JToken typejson = jo["id"][0]["type"];
            string type = typejson.ToObject<string>();

            JToken protectionjson = jo["id"][0]["puissance"];
            string protection = protectionjson.ToObject<string>();

            JToken puissancejson = jo["id"][0]["puissance"];
            string puissance = puissancejson.ToObject<string>();

            JToken prioritejson = jo["id"][0]["priorite"];
            string priorite = prioritejson.ToObject<string>();

            JToken latitudejson = jo["id"][0]["latitude"];
            string latitude = latitudejson.ToObject<string>();

            JToken longitudejson = jo["id"][0]["longitude"];
            string longitude = longitudejson.ToObject<string>();

            ListViewItem it = new ListViewItem(cbNumSerie.Text);
            it.SubItems.Add(type);
            it.SubItems.Add(protection);
            it.SubItems.Add(puissance);
            it.SubItems.Add(priorite);
            it.SubItems.Add(latitude);
            it.SubItems.Add(longitude);
            lvSelectAll.Items.Add(it);
        }
    }  
}
