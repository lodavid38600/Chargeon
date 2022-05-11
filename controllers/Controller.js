//Importation de la connexion à la bdd
const bodyParser = require('body-parser');
const iniparser = require('iniparser');
var db = require('../database');
//Importation du fichier models
var Model = require('../models/Model');

//Exportation des fonctions du controller
module.exports = {

        // Redirection vers l'accueil
        Accueil : (req, res) => {
                res.render("./index");
        },


        SELECT : (req, res) => {
                let medoc_Id = req.query['type'];
                //let compte_nom = req.body.nom;
                Model.SELECT(medoc, mois, medoc_Id)
           
        },


        INSERT: (req, res) =>{
              
               let type = req.query['type'];
               let puissance = req.query['puissance'];
               let priorite = req.query['priorite'];
               let lat = req.query['lat'];
               let long = req.query['long'];

               let protection = "";
               if(type == "Exterieur"){
                protection = "IP42";
               }
               else if(type == "Interieur"){
                protection = "IP55";
               }
               else{

               }

               console.log(type, puissance, priorite, protection, lat, long);
               Model.INSERT(type, puissance, priorite, protection, lat, long);
               res.render("./index");
              
        }

}