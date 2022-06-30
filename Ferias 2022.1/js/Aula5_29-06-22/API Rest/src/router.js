const express = require('express');
const controllerProduto = require('./controllers/ProdutoController');
//Criando uma instância router da classe express
const routes = express.Router();
//Definindo rotas para os métodos dentro da controller
// routes.get('/List', controllerProduto.List);
routes.post('/Create', controllerProduto.Create);
// routes.post('/Update', controllerProduto.Update);
// routes.get('/GetOne', controllerProduto.GetOne);
routes.post('/Delete', controllerProduto.Delete);
module.exports = routes;

