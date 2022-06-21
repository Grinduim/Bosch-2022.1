var response = prompt("Insira 5 valores separados por viegula").split(',')
console.log(response)
var pares = response.filter(function(valor)
{
    if(valor %2 == 0)
    return valor
});
console.log(pares)

var impares = response.filter(function(valor)
{
    if(valor %2 != 0)
    return valor
});
console.log(impares)
impares.push(pares.shift())
console.log(impares)
console.log(pares)

console.log();
var array = response.filter(function(valor,index){
    if(valor% index == 0)
    return valor
})

console.log(array)