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
               
                //let compte_nom = req.body.nom;

               Model.SELECT(function(lignes, taille){
                        res.json({
                                taille: taille,
                                id: lignes,
                                }
                        );
                });
        },

        SELECTALL : (req, res) => {
               
                //let compte_nom = req.body.nom;

               Model.SELECTALL(function(lignes, taille){
                       console.log(lignes);
                        res.json({
                                taille: taille,
                                id: lignes,
                                }
                        );
                });
        },

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


        INSERT: (req, res) =>{


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

               console.log(num_serie, type, puissance, priorite, protection, lat, long);
               Model.INSERT(num_serie, type, puissance, priorite, protection, lat, long);
               res.render("./index");
              
        },


        UPDATE: (req, res) =>{
              
                let borneId = req.query['borneId'];
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
 
                console.log(borneId, type, puissance, priorite, protection, lat, long);
                Model.UPDATE(borneId, type, puissance, priorite, protection, lat, long);
                res.render("./index");
               
         },

        DELETE : (req, res) => {
               
                let borneId = req.query['borneId'];

               Model.DELETE(borneId);
                res.render("./index");
              
             
        },


}