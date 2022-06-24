function getRndInteger(min, max) {
    return Math.floor(Math.random() * (max - min) ) + min;
  }

function GeneratePassword(Qtd,Numbers,UpperCase,LowCase,Symbols){
    let char = ''
    if(Numbers)
        char += '1234567890'
    if(UpperCase)
        char +='abcdefghijklmnopqrstuvwxyz'
    if(LowCase)
        char +='ABCDEFGHIJLMNOPQRSTUVWXYZ'
    if(Symbols)
        char += '!@#$%^&*()+?><:{}[].,;'
    var password = ''
    if(char == '')
    return ''
    for(let i = 0; i < Qtd; i++){
        password += char[getRndInteger(0,char.length-1)]
    }

    return password
}

function clickButton(){
   let qtd = this.getElement('qtd').value
   let numberBool = this.getElement('numero').checked
   let UpperCaseBool = this.getElement('maiscula').checked
   let LowCaseBool = this.getElement('minuscula').checked
   let SymbolsBool = this.getElement('simbolo').checked

   if(numberBool || UpperCaseBool || LowCaseBool || SymbolsBool && qtd >= 4 ){
    let element = this.getElement('error')
    element.classList.add('hidden')
    element.textContent = ''
    let password = this.GeneratePassword(qtd,numberBool,UpperCaseBool,LowCaseBool,SymbolsBool);
    putPasswordInScreen(password)
   }
   else{
       let element = this.getElement('error')
       error.textContent = "A senha deve ter mais de 4 caracter e pelo menos uma caixa deve ser selecionada"
       element.classList.remove('hidden')
   }
   
}

function getElement(id){
    let element = document.querySelector('#'+id)
    return element
}

function putPasswordInScreen(password){
    let container = this.getElement('passwordcontainer')
    let h2 = this.getElement('senha')
    container.classList.remove('hidden')
    h2.textContent = password
}

function ClipBoard(){
   /* Get the text field */
  var copyText = document.getElementById("senha").textContent;
 navigator.clipboard.writeText(copyText).then(function() {
    console.log('Async: Copying to clipboard was successful!');
  }, function(err) {
    console.error('Async: Could not copy text: ', err);
  });
};
