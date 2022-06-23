var displaytext = "";
var tag = 0;
function clickButton(number){
    if(this.tag == 1){
        limpar();
        number = ""+number
        this.displaytext = this.displaytext + number
        changeDisplay(this.displaytext)
        this.tag = 0;
    }
    else{
        number = "" + number
        this.displaytext = this.displaytext + number
        changeDisplay(this.displaytext)
    }  
}
function getDisplay(){
    let element = document.querySelector('#display')
    return element
}
function calculate(){
    try{
        displaytext = eval(displaytext);
    changeDisplay(displaytext)
    console.log(display)
    }
    catch{
        changeDisplay("Error")
        this.tag = 1
    }
}
function limpar(){
    console.log("PAssou")
    displaytext=""
    changeDisplay(displaytext)
}
function changeDisplay(text){
    let display = getDisplay();
    display.value = text;
}