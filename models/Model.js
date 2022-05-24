

//Importation de la connexion à la bdd
var db = require('../database')



//Exportation du model mysql (requêtes...)
module.exports={

    SELECT:function(callback){
  
        var sql='SELECT count(num_serie) as taille FROM chargeur ';
        db.query(sql, function (err, data, fields){
            if (err) throw err;
            console.log(data);
            let taille = data;

            var sql1='SELECT num_serie FROM chargeur ';
            db.query(sql1, function (err1, data1, fields1){
            if (err1) throw err1;
            console.log(data1);
            return callback(data1, taille);
        });
        });
    
        
        
    },

    SELECTALL :function(callback){
  
        var sql='SELECT count(num_serie) as taille FROM chargeur ';
        db.query(sql, function (err, data, fields){
            if (err) throw err;
            //console.log(data);
            let taille = data;

            var sql1='SELECT * FROM chargeur ';
            db.query(sql1, function (err1, data1, fields1){
            if (err1) throw err1;
            //console.log(data1);
            return callback(data1, taille);
        });
        });
    
        
        
    },

    INSERT:function(type, puissance, priorite, protection, lat, long){

        var sql="INSERT INTO chargeur (type, puissance, priorite, protection, latitude, longitude) Values ('"+type+"', '"+puissance+"', '"+priorite+"', '"+protection+"' , '"+lat+"', '"+long+"') ";
        db.query(sql, function (err, result) {
            if (err) throw err;
            console.log(result.affectedRows + " record(s) created");
          });
    },



    DELETE:function(borneId){

        var sql="DELETE FROM chargeur where num_serie = '"+borneId+"'";
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
