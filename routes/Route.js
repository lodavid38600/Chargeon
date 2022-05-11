//Importation 

const express = require('express');

//Importation du fichier controller
const Controller = require('../controllers/Controller');
//création du routeur Express pour ce module
const routeur = express.Router();
routeur.use(express.urlencoded());

//Définition des routes et des fonctions controller associées
routeur.get('/select', Controller.SELECT);
routeur.get('/insert', Controller.INSERT);
routeur.get('/', Controller.Accueil);



//Exportation du module routeur
module.exports = routeur 