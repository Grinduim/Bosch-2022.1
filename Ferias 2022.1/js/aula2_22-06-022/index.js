///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

 // Funcão com tempo //

// function fucao1(callback) {
//   setTimeout(function () {
//     console.log("Função 1");
//     if (callback) callback();
//   }, 2500);
// }

// function funcao2(callback) {
//   setTimeout(function () {
//     console.log("Função 2");
//     if (callback) callback();
//   }, 2000);
// }

// function funcao3(callback) {
//   setTimeout(function () {
//     console.log("Função 3");
//     if (callback) callback();
//   }, 1000);
// }

// function fim(){
//     console.log("Acabou")
// }

// fucao1(funcao2(funcao3(fim)))

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Objetos com funções //

// function CriarPessoa(name,heigh,weight){
//     return{
//         nome:name,
//         altura:heigh,
//         peso:weight,
//         imc(assunto){
//             let indice = (this.peso / this.altura**2).toFixed(2);
//             return `${ this.nome } tem o IMC de  ${indice}`;
//         }
//     }
// }

// const pessoa = CriarPessoa("Aderbal",1.75,187)
// console.log(pessoa)

// console.log(pessoa.imc("Assunto"))

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Funções Geradores, construturas e recursivas //

// Começo contruturoda // 

// function Pessoa(nome,sobrenome){
//     this.nome = nome;
//     this.sobrenome = sobrenome;
//     const metodoPrivado= () => console.log("Esse metodo nao aparee para ser chamado");

//     this.metodo = () => {
//         console.log("Esse metodopode ser chamado!")
//         metodoPrivado();
//     }
// }  

// const pessoa = new Pessoa("Gabriel","Santos")
// pessoa.metodo()

// Fim Contruturas // 

//  Começo recursivas //

// function Recursiva(i){
//     if(i > 10) return;
//     console.log(i);
//     i++;
//     Recursiva(i);
// }

// Recursiva(0);


//  Fim recursivas //


//  Começo Geradoras //

//gerador finito
// function * geradorFinito(){ // o * indica que é uma funcao do tipo gerador

//     yield "Valor 1";
//     yield "Valor 2";
//     yield "Valor 3";
// }

// const gerador = geradorFinito(); // pode ser usado um for na gerador tbm, caso usado ele para no ultimo campo
// console.log(gerador.next());
// console.log(gerador.next());
// console.log(gerador.next());
// console.log(gerador.next());

//gerador infinito

function * geradorInfinito(){
    let i = 0;
    while(true){
        yield i;
        i++;
    };
}

const gerador = geradorInfinito()
console.log(gerador.next())
console.log(gerador.next())
console.log(gerador.next())
console.log(gerador.next())
console.log(gerador.next())
console.log(gerador.next())
console.log(gerador.next())