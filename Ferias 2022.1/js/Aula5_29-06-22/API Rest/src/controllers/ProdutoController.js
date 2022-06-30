const ModelProduto = require('../models/produto');

module.exports =
{
    async Create(req, res) {
        try {
            const prod = await ModelProduto.create(
                {
                    Descricao: req.body.Descricao,
                    DataCriacao: req.body.DataCriacao,
                    DataAtualizacao: null
                }
            );
            return res.json(prod);
        }
        catch (erro) {
            return console.error("Error na Create :", erro);
        }
    },
    async Delete(req, res) {
        try {
            const prod = await ModelProduto.findByPk(req.body.Codigo);
            await prod.destroy();
        }
        catch (erro) {
            return console.error("Error na Update :", erro);
        }
    }
}