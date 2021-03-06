//Importation du module express
var express = require('express');
//Importation du fichier de routage
const Routeur = require('./routes/Route')


//Déclaration, paramètrage et utilisation de l'app
let app = express()
app.set('view engine', 'ejs')
app.use(express.static('views'))
app.use(express.static('public'))
app.use('/', Routeur)


/* Lancement du serveur au port défini */

const port = 3000

app.listen(port, () => {
  console.log(`server running HTTP. Go to http://localhost:${port}`)
})


module.exports = app