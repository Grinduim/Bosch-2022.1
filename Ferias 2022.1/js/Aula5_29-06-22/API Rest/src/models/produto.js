const sequelize = require('sequelize')
const database = require('../')
const schema = '';

class Produto extends sequelize.Model { }

Produto.init(
    {
        //campos da tabela
        Codigo: {
            type: sequelize.INTEGER,
            autoIncrement: true,
            allowNull: false,
            primaryKey: true
        },
        Descricao: {
            type: sequelize.STRING,
            allowNull: true
        },
        DataCriacao:
        {
            type: sequelize.DATE,
            allowNull: false
        },
        DataAtualizacao:
        {
            type: sequelize.DATE,
            allowNull: true
        }
    },
    {
        sequelize: database,modelName:'tblProduto',schema
    }
)

module.exports = Produto;