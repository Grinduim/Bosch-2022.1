const sequelize = require('sequelize')

// * configuração da base de dados
const database = new sequelize('teste','dev','CVBm&@TKVw3YHxeSgmzm*%wHpb',
{
    dialect:'mssql',host:'JVLPC0497',port:1433
});
//  sincronizando com uma tabela existente
database.sync();
//
module.exports = database;