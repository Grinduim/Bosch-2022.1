// const sequelize = require('sequelize')

// // * configuração da base de dados
// const database = new sequelize('master','dev','etsds10240305',
// {
//     dialect:'mssql',host:'JVLPC0497',port:1433
// });
// //  sincronizando com uma tabela existente
// database.sync();
// //
// module.exports = database;
var Connection = require('tedious').Connection;
var Request = require('tedious').Request;
var TYPES = require('tedious').TYPES;

const sqlConfig = {  
    server: 'JVLPC0497',
    authentication: {
        type: 'default',
        options: {
            userName: 'dev', //update me
            password:  'etsds10240305'  //update me
        }
    }, 
    options: {
        encrypt: true,
        database: 'teste',
    }        
}

var conn = new Connection(sqlConfig)
conn.on('connect', function(err) {  
    // If no error, then good to proceed.
    console.log("Connected"); 
    teste();
});
conn.connect();
async function teste() {
   
    try {    
       
        let request = new Request("select * from testejs", function(err) {  
            if (err) {  
                console.log(err);
            }  
        });  
        var result = "";  
        request.on('row', function(columns) {  
            columns.forEach(function(column) {  
                if (column.value === null) {  
                console.log('NULL');  
                } else {  
                result+= column.value + " ";  
                }  
            });  
            console.log(result);  
            result ="";  
        });  
    
        request.on('done', function(rowCount, more) {  
            console.log(rowCount + ' rows returned');  
        });  
        
        // Close the connection after the final event emitted by the request, after the callback passes
        request.on("requestCompleted", function (rowCount, more) {
            conn.close();
        });
        conn.execSql(request);  

    }catch(error){
        console.log(error);
    }
          
}
