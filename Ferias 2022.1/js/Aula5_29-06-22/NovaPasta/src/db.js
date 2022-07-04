const sequelize = require('sequelize')

// * configuração da base de dados
const database = new sequelize('master','dev','etsds10240305',
{
    dialect:'mssql',host:'JVLPC0497',port:1433
});
//  sincronizando com uma tabela existente
database.sync();
//
module.exports = database;