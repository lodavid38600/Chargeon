

//Importation de la connexion à la bdd
const mysqlconnexion = require('../database');
var db = require('../database')



//Exportation du model mysql (requêtes...)
module.exports={

    SELECT:function(callback){
  
    
        var sql='SELECT cli_Id, cli_secu, cli_nom, cli_prenom FROM client ';
        db.query(sql, function (err, data, fields){
            if (err) throw err;
            return callback(data);
        });
        
    },

    INSERT:function(type, puissance, priorite, protection, lat, long){

        var sql="INSERT INTO chargeur (type, puissance, priorite, protection, latitude, longitude) Values ('"+type+"', '"+puissance+"', '"+priorite+"', '"+protection+"' , '"+lat+"', '"+long+"') ";
        db.query(sql, function (err, result) {
            if (err) throw err;
            console.log(result.affectedRows + " record(s) created");
          });
    },

    Delete_Client:function(cli_Id){

        var sql="DELETE FROM client where cli_Id = '"+cli_Id+"'";
        console.log(sql);
        db.query(sql, function (err, result) {
            if (err) throw err;
            console.log(result.affectedRows + " record(s) Deleted");
          });
    },


    Medocs_update_stock: (medoc, mois, medoc_Id) =>{

        let sql = "UPDATE medicament SET medoc_stock"+mois+" = '"+medoc+"' WHERE medoc_Id = '"+medoc_Id+"'";
        console.log(sql);
        db.query(sql, function (err, result) {
          if (err) throw err;
          console.log(result.affectedRows + " record(s) updated");
        });

    },





}
