// var nomes = ['Luiz', 'Maria', 'João']
// nomes.push("Otávio") // adiciona um item no final do array
// console.log(nomes)
// nomes.unshift('Luiza') // adiciona o item no começo do array
// nomes.pop() // retira o valor do final
// nomes.shift() // reitara um valor do começo
// delete nomes[1] // tira o valor mas ainda ocupa umm espaço vazio no array
// var novos_nomes = nomes.slice(0,-2); // reparte o array

// --------------------------------------------//

// var nomes = 'Luiz,Maria, João,Otávio'
// var novos_nomes = nomes.split(',') // transformando uma string  em array
// console.log(nomes)
// console.log(novos_nomes)

// --------------------------------------------//

// var nomes = [ 'Luiz', 'Maria', ' João', 'Otávio' ]
// var novos_nomes = nomes.join(', ') // juntando os itens de um array por ,

// --------------------------------------------//

//array.splice(indice de comeco, numero de deletes, elemento para ser add no final1, elemento para ser add no final2)
// var nomes =  [ 'Luiz', 'Maria', ' João', 'Otávio', 'Wallace', "Rosana" ]
// var novo_nomes = nomes.splice(1,2, "Allan",'Carlo','Carlos') // exclui 2 valores apartir do indice 1 e  coloquei em outro array e no original eu coloquei 3 nomes
// console.log(novo_nomes)
// console.log(nomes)

// --------------------------------------------//

// var num1 = [1,2,3,4]
// var num2 = [5,6,7]
// console.log(num1+ num2) //estou juntando em uma string
// console.log(num1.concat(num2)) // junto os dois arrays
// var num3 = [ ...num1, ...num2] // juntei os dois arrays como se tivesse concatenado
// console.log( num3)

// --------------------------------------------//

// var nums = [ 1,5,8,3,48,456,2,10,56,3]
// var nums_filter = nums.filter(function(valor){ // filtra o valor de acordo com a funcao declarada 
//     return valor >=10
// });
// console.log(nums_filter)

// --------------------------------------------//


// var nums = [ 1,5,8,3,48,456,2,10,56,3]
// var total = nums.reduce((acumulador,valor)=> {
//     return acumulador + valor;
// })

// console.log(total)