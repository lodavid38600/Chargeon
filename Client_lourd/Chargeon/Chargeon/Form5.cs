using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chargeon
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        /* Au chargement de la fenêtre rempli la ComboBox des numéros de séries */
        private void Form5_Load(object sender, EventArgs e)
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
        /*-------------------------*/

        
        /* Apple de l'URL à l'API pour récuperer les données de la borne choisi par l'utilisateur puis remplir les inputs avec ces données*/
        private void cbNumSerie_SelectedIndexChanged(object sender, EventArgs e)
        {


            string str = new WebClient().DownloadString("http://127.0.0.1:3000/selectborne?borneId="+ cbNumSerie.Text);
            JObject jo = JObject.Parse(str);



                JToken typejson = jo["id"][0]["type"];
                string type = typejson.ToObject<string>();

                JToken puissancejson = jo["id"][0]["puissance"];
                string puissance = puissancejson.ToObject<string>();

                JToken prioritejson = jo["id"][0]["priorite"];
                string priorite = prioritejson.ToObject<string>();

                JToken latitudejson = jo["id"][0]["latitude"];
                string latitude = latitudejson.ToObject<string>();

                JToken longitudejson = jo["id"][0]["longitude"];
                string longitude = longitudejson.ToObject<string>();

                cbType.DisplayMember = type;
                cbPuissance.DisplayMember = puissance;
                cbPriorite.DisplayMember = priorite;

                cbType.Text = type;
                cbPuissance.Text = puissance;
                cbPriorite.Text = priorite;

                tbLat.Text = latitude;

            tbLong.Text = longitude;
            if (!Regex.Match(longitude, @"^(\+|-)?((\d((\.)|\.\d{1,6})?)|(0?\d\d((\.)|\.\d{1,6})?)|(0?1[0-7]\d((\.)|\.\d{1,6})?)|(0*?180((\.)|\.0{1,6})?))$").Success)
            {
                // first name was incorrect
                MessageBox.Show("Invalid longitude");
                return;
            }
        }
        /*------------------------------------------------*/

        /* Appel de l'URL à l'API  avec les paramètres de la borne pour la modification */
        private void updateBorne(object sender, EventArgs e)
        {

            HttpClient client = new HttpClient();

            if (!Regex.Match(tbLat.Text, @"^(\+|-)?((\d((\.)|\.\d{1,6})?)|(0?[0-8]\d((\.)|\.\d{1,6})?)|(0?90((\.)|\.0{1,6})?))$").Success)
            {
                MessageBox.Show("Invalid latitude");
                return;
            }

            if (!Regex.Match(tbLong.Text, @"^(\+|-)?((\d((\.)|\.\d{1,6})?)|(0?\d\d((\.)|\.\d{1,6})?)|(0?1[0-7]\d((\.)|\.\d{1,6})?)|(0*?180((\.)|\.0{1,6})?))$").Success)
            {
                MessageBox.Show("Invalid longitude");
                return;
            }


            var responseTask = client.GetAsync("http://127.0.0.1:3000/update?borneId="+ cbNumSerie.Text +"&type=" + cbType.Text + "&puissance=" + cbPuissance.Text + "&priorite=" + cbPriorite.Text + "&lat=" + tbLat.Text + "&long=" + tbLong.Text);
            responseTask.Wait();
            //MessageBox.Show("http://127.0.0.1:3000/update?borneId="+ cbNumSerie.Text +"&type=" + cbType.Text + "&puissance=" + cbPuissance.Text + "&priorite=" + cbPriorite.Text + "&lat=" + tbLat.Text + "&long=" + tbLong.Text);
            MessageBox.Show("Borne Modifié !");

        }
        /*------------------------------------*/

       // Méthode de fermeture de la fenetre quand l'utilisateur clic sur le bouton retour
        private void CloseForm5(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
