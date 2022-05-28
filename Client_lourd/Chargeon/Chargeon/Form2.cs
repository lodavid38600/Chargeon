using Newtonsoft.Json.Linq;
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

namespace Chargeon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // **/** Fonction Ajout borne **/** //

        private void AddBorne(object sender, EventArgs e)
        {

            /* Mise en variable des récuperation des valeurs des combobox  */
            string type = cbType.SelectedItem.ToString();
            string puissance = cbPuissance.SelectedItem.ToString();
            string priorite = cbPriorite.SelectedItem.ToString();

            string latitude = tbLat.Text;
            string longitude = tbLong.Text;
            /*--------------------*/


            /* REGEX Textbox latitude et Longitude + MessageBox si non respect des REGEX */
            if (!Regex.Match(latitude, @"^(\+|-)?((\d((\.)|\.\d{1,6})?)|(0?[0-8]\d((\.)|\.\d{1,6})?)|(0?90((\.)|\.0{1,6})?))$").Success)
            {
                // first name was incorrect
                MessageBox.Show("Invalid latitude");
                return;
            }
 
            if (!Regex.Match(longitude, @"^(\+|-)?((\d((\.)|\.\d{1,6})?)|(0?\d\d((\.)|\.\d{1,6})?)|(0?1[0-7]\d((\.)|\.\d{1,6})?)|(0*?180((\.)|\.0{1,6})?))$").Success)
            {
                
                MessageBox.Show("Invalid longitude");
                return;
            }
            /*------------------------*/


            /* Appel de l'URL à l'API avec paramètres pour insertion de borne en BDD */
            HttpClient client = new HttpClient();


            var responseTask = client.GetAsync("http://127.0.0.1:3000/insert?type="+ type + "&puissance="+ puissance + "&priorite="+ priorite + "&lat=" + latitude + "&long=" + longitude);
            responseTask.Wait();


            // MessageBox pour avertir l'utilisateur de l'insertion avec succès  + fermer la form2 (insertion) //
            MessageBox.Show("Borne Créer !");
            this.Close();
            /*-------------------------*/
        }


        // Méthode de fermeture de la fenetre quand l'utilisateur clic sur le bouton retour
        private void CloseForm2(object sender, EventArgs e)
        {
            this.Close();

        }
        /*---------------------*/
    }
}
