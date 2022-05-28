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


        /* Renvoie les données en JSON du SELECT */
        SELECT : (req, res) => {
               

               Model.SELECT(function(lignes, taille){
                        res.json({
                                taille: taille,
                                id: lignes,
                                }
                        );
                });
        },

        /* Renvoie les données en JSON du SELECTALL*/
        SELECTALL : (req, res) => {
               

               Model.SELECTALL(function(lignes, taille){
                       console.log(lignes);
                        res.json({
                                taille: taille,
                                id: lignes,
                                }
                        );
                });
        },

        /* Renvoie les données en JSON du SELECTBORNE*/
        SELECTBORNE : (req, res) => {
               
                let borneId = req.query['borneId'];

               Model.SELECTBORNE(function(lignes){
                       console.log(lignes);
                        res.json({
                            
                                id: lignes,
                                }
                        );
                }, borneId);
        },


        /* Insertion d'une borne */
        INSERT: (req, res) =>{


                // Création d'une méthode à la classe Date pour obtenir le numéro de la semaine
                var year = new Date().getFullYear()
                Date.prototype.getWeekNumber = function(){
                        

                        var d = new Date(Date.UTC(this.getFullYear(), this.getMonth(), this.getDate()));
                        var dayNum = d.getUTCDay() || 7;
                        d.setUTCDate(d.getUTCDate() + 4 - dayNum);
                        var yearStart = new Date(Date.UTC(d.getUTCFullYear(),0,1));
                        var semaine = Math.ceil((((d - yearStart) / 86400000) + 1)/7)
                        return semaine;
                };
                //console.log(new Date().getWeekNumber())
                var num_serie = ""+year+"-"+new Date().getWeekNumber()+"";
                console.log(num_serie);
              
                // Récuperation des paramètres de l'URL pour insertion en base
               let type = req.query['type'];
               let puissance = req.query['puissance'];
               let priorite = req.query['priorite'];
               let lat = req.query['lat'];
               let long = req.query['long'];

               // Fixer la protection par rapport au type
               let protection = "";
               if(type == "Exterieur"){
                protection = "IP42";
               }
               else if(type == "Interieur"){
                protection = "IP55";
               }
               else{

               }

               console.log(num_serie, type, puissance, priorite, protection, lat, long);
               Model.INSERT(num_serie, type, puissance, priorite, protection, lat, long);
               res.render("./index");
              
        },


        /* Modification d'une borne */
        UPDATE: (req, res) =>{
              
                // Récuperation des paramètres de l'URL
                let borneId = req.query['borneId'];
                let type = req.query['type'];
                let puissance = req.query['puissance'];
                let priorite = req.query['priorite'];
                let lat = req.query['lat'];
                let long = req.query['long'];
 
                // Fixer la protection par rapport au type
                let protection = "";
                if(type == "Exterieur"){
                 protection = "IP42";
                }
                else if(type == "Interieur"){
                 protection = "IP55";
                }
                else{
 
                }
 
                console.log(borneId, type, puissance, priorite, protection, lat, long);
                Model.UPDATE(borneId, type, puissance, priorite, protection, lat, long);
                res.render("./index");
               
         },


        /* Supprimer une borne */ 
        DELETE : (req, res) => {
               
                // Récuperation du numéro de série de la borne en paramètre de l'URL
                let borneId = req.query['borneId'];

               Model.DELETE(borneId);
                res.render("./index");
              
             
        },


}