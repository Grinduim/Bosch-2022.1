const path = require('path');
const caminhoArquivo = path.resolve(__dirname, 'teste.json');
const escreve = require('./modules/escrever');
const ler = require('./modules/ler');

const pessoas = [
    { nome: "João" },
    { nome: "Thiago" },
    { nome: "Carlota" },
    { nome: "Maria" },
    { nome: "Luiza" },
];

const json = JSON.stringify(pessoas, '', 2);

escreve(caminhoArquivo, json);

async function lerArquivo(caminho) {
    const dados = await ler(caminho);
    transformaEmObjeto(dados);
}

function transformaEmObjeto(dados) {
    dados = JSON.parse(dados);
    dados.forEach(val => console.log("Nome:",val.nome));
}

lerArquivo(caminhoArquivo);