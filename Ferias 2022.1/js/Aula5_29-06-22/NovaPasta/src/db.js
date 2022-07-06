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


const sql = require('mssql')
const sqlConfig = {
    user: 'dev',
    password: 'etsds10240305',
    database: 'teste',
    server: 'localhost',
    port: 1433,
    //   pool: {
    //     max: 10,
    //     min: 0,
    //     idleTimeoutMillis: 30000
    //   },
      options: {
        encrypt: true, // for azure
        trustServerCertificate: true // change to true for local dev / self-signed certs
      }
}


async function teste() {
    try {
        var conn = new sql.ConnectionPool(sqlConfig)
        // make sure that any items are correctly URL encoded in the connection string
        var request = new sql.Request(conn);
        console.log("PAssou")
        const result = request.query("select * from testejs")
            .then(function (recordSet) {
                console.log(recordSet);
                conn.close();
            }).catch(function (err) {
                console.log("Erro aqui")
                console.log(err)
                conn.close();
            });

    }
    catch (err) {
        console.log("ERRO FDP")
        console.log(err)
    }
}
teste();