using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chargeon
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            //lvSelectAll.Visible = false;
        }

        /* Au chargement de la fenêtre  récupère le nombre de bornes puis boucle pour récupérer les données de chaque bornes */
        private void Form4_Load(object sender, EventArgs e)
        {
            string str = new WebClient().DownloadString("http://127.0.0.1:3000/selectall");
            JObject jo = JObject.Parse(str);
            Console.WriteLine(jo["taille"][0]["taille"]);

            JToken taillejson = jo["taille"][0]["taille"];
            int taille = taillejson.ToObject<int>();

            Console.WriteLine(taille);



            for (int i = 0; i < taille; i++)
            {

                JToken numjson = jo["id"][i]["num_serie"];
                string num = numjson.ToObject<string>();

                JToken typejson = jo["id"][i]["type"];
                string type = typejson.ToObject<string>();

                JToken protectionjson = jo["id"][i]["protection"];
                string protection = protectionjson.ToObject<string>();

                JToken puissancejson = jo["id"][i]["puissance"];
                string puissance = puissancejson.ToObject<string>();

                JToken prioritejson = jo["id"][i]["priorite"];
                string priorite = prioritejson.ToObject<string>();

                JToken latitudejson = jo["id"][i]["latitude"];
                string latitude = latitudejson.ToObject<string>();

                JToken longitudejson = jo["id"][i]["longitude"];
                string longitude = longitudejson.ToObject<string>();

                Console.WriteLine(num, type, protection, puissance, priorite, latitude, longitude);

                // Affichage de la borne[i] dans la liste view
                ListViewItem it = new ListViewItem(num);
                it.SubItems.Add(type);
                it.SubItems.Add(protection);
                it.SubItems.Add(puissance);
                it.SubItems.Add(priorite);
                it.SubItems.Add(latitude);
                it.SubItems.Add(longitude);
                lvSelectAll.Items.Add(it);
            }
        }
        /*----------------------------------*/

        /* Clear l'ancienne liste et affiche la nouvelle */
        private void btn_refresh(object sender, EventArgs e)
        {
        lvSelectAll.Items.Clear();

        string str = new WebClient().DownloadString("http://127.0.0.1:3000/selectall");
        JObject jo = JObject.Parse(str);
        Console.WriteLine(jo["taille"][0]["taille"]);

        JToken taillejson = jo["taille"][0]["taille"];
        int taille = taillejson.ToObject<int>();

        Console.WriteLine(taille);



            for (int i = 0; i < taille; i++)
            {

                JToken numjson = jo["id"][i]["num_serie"];
                string num = numjson.ToObject<string>();

                JToken typejson = jo["id"][i]["type"];
                string type = typejson.ToObject<string>();

                JToken protectionjson = jo["id"][i]["protection"];
                string protection = protectionjson.ToObject<string>();

                JToken puissancejson = jo["id"][i]["puissance"];
                string puissance = puissancejson.ToObject<string>();

                JToken prioritejson = jo["id"][i]["priorite"];
                string priorite = prioritejson.ToObject<string>();

                JToken latitudejson = jo["id"][i]["latitude"];
                string latitude = latitudejson.ToObject<string>();

                JToken longitudejson = jo["id"][i]["longitude"];
                string longitude = longitudejson.ToObject<string>();

                Console.WriteLine(num, type, protection, puissance, priorite, latitude, longitude);

                ListViewItem it = new ListViewItem(num);
                it.SubItems.Add(type);
                it.SubItems.Add(protection);
                it.SubItems.Add(puissance);
                it.SubItems.Add(priorite);
                it.SubItems.Add(latitude);
                it.SubItems.Add(longitude);
                lvSelectAll.Items.Add(it);
            }
        }
        /*------------------*/

        // Méthode de fermeture de la fenetre quand l'utilisateur clic sur le bouton retour
        private void CloseForm4(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
