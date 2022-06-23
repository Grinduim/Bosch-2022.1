// validar um cpf
function ValidarCPF() {
  var cpf = "124.101.269-52";
  cpf = Array.from(cpf.replace(/\D+/g, ""));
  if ( DigitosNaoIguas(cpf) && PrimeiroDigito(cpf) && SegundoDigito(cpf)) {
      console.log("CPF Valido!")
  }
  else{
      console.log("CPF Invalido!")
  }
}

function PrimeiroDigito(cpf) {
  soma = 0;
  mult = 10;

  for (var i = 0; i < 9; i++) {
    soma = soma + cpf[i] * mult;
    mult--;
  }
  let digito = VerificaValorDigito(soma);

  if (cpf[9] == digito) {
    return true;
  } else {
    return false;
  }
}

function SegundoDigito(cpf) {
  soma = 0;
  mult = 11;
  for (var i = 0; i < 10; i++) {
    soma = soma + cpf[i] * mult;
    mult--;
  }
  let digito = VerificaValorDigito(soma);
  if (cpf[10] == digito) {
    return true;
  } else {
    return false;
  }
}

function VerificaValorDigito(SomaTotal) {
  let digito = 11 - (SomaTotal % 11);
  if (digito > 9) digito = 0;

  return digito;
}

function DigitosNaoIguas(cpf){
    let PrimeiroDigito = cpf[0];
    let flag = true
    for(let i = 0 ; i < 11; i++){
        if(cpf[i] == PrimeiroDigito){
            flag = false;
        }
        else{
            flag = true
        }
    }
    return flag;
}

ValidarCPF();
