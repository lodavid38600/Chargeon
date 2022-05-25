

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

    
    SELECTBORNE :function(callback, borneId){

        var sql="SELECT * FROM chargeur WHERE num_serie = '"+borneId+"' ";
        db.query(sql, function (err, data, fields){
        if (err) throw err;
        return callback(data);
        });
    },

    INSERT:function(num_serie, type, puissance, priorite, protection, lat, long){


        var sql='SELECT count(*) as semaine FROM chargeur WHERE semaine = "'+num_serie+'" ';
        db.query(sql, function (err, data, fields){
            if (err) throw err;
            
            let num = data[0]['semaine'];
            console.log(num);
            num = num + 1;

            if(num < 10){
                num = "00"+num+"";
            }else if(num <100){
                num = "0"+num+"";
            }else if(num >= 100){
                num = num;
            }

            num = ""+num_serie+"-"+num+"";
       
        var sql="INSERT INTO chargeur (num_serie, type, puissance, priorite, protection, latitude, longitude, semaine) Values ('"+num+"', '"+type+"', '"+puissance+"', '"+priorite+"', '"+protection+"' , '"+lat+"', '"+long+"', '"+num_serie+"') ";
        db.query(sql, function (err, result) {
            if (err) throw err;
            console.log(result.affectedRows + " record(s) created");
          });
        });
    },


    UPDATE:function(borneID, type, puissance, priorite, protection, lat, long){

        var sql="UPDATE chargeur SET type = '"+type+"', puissance = '"+puissance+"', protection = '"+protection+"', priorite = '"+priorite+"', latitude = '"+lat+"' , longitude = '"+long+"' WHERE num_serie = "+borneID+" ";
        db.query(sql, function (err, result) {
            if (err) throw err;
            console.log(result.affectedRows + " record(s) updated");
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
