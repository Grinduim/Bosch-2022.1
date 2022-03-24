#include <Ultrasonic.h>
#include <Keypad.h> // lib para a leitura do teclado
#include <string.h>
#include <Wire.h>
#include <LiquidCrystal_I2C.h>// lib para usar o 20/4 com o i2c

const int echoPin = 32;
const int trigPin = 30; // configuração do modulo ultrasonico
Ultrasonic ultrasonic(trigPin,echoPin);


//Inicializa o display no endereco 0x27
LiquidCrystal_I2C lcd(0x27, 20, 4); // quatidade de linhas e colunas com a porta q o i2c usa



const byte QtdLin = 4;
const byte QtdCol = 4;
// quantidade de linhas e colunas

//matriz de caracteres
char matriz_keypad[QtdLin][QtdCol] = {
  {'1', '2', '3', 'A'},
  {'4', '5', '6', 'B'},
  {'7', '8', '9', 'C'},
  {'*', '0', '#', 'D'}
};

// declaração de pinos
byte PinosLin[QtdLin] = {3, 4, 5, 6}; // os 4 pinos da esquerda
byte PinosCol[QtdCol] = {8, 9, 10, 11}; // os 4 pinos da direita

//criando o objeto do meu teclado, mapiamento das teclas da minha matriz, pinos linha e coluna, quantidade de linha e coluna
Keypad MyKeyboard = Keypad(makeKeymap(matriz_keypad), PinosLin, PinosCol, QtdLin, QtdCol);

const int PinPir = 52;

//char acesso[14];

#define QtdCandidatos 2 // dados sobre os candidatos
#define QtdDigitos  2
char TodosCandidatos[QtdCandidatos][QtdDigitos] =
{
  {'1', '3'},
  {'1', '7'}
};

char voto[QtdDigitos];

struct candidato {
  String Numero;
  String Nome;
};



void setup()
{
  lcd.init();
  lcd.setBacklight(HIGH);

  Serial.begin(9600);
  pinMode(PinPir, INPUT);

  pinMode(echoPin,INPUT);
  pinMode(trigPin,OUTPUT);
}

void loop()
{
  lcd.setCursor(0, 0);


  if (digitalRead(PinPir)) {
    long tempo = ultrasonic.timing();
    float DistanciaInicio = ultrasonic.convert(tempo,Ultrasonic::CM);
    
    voto[0] = '\0';// limpando o array do C
    voto[1] = '\0';
    voto[2] = '\0';

    InserirPresidente();
    delay(1000);
    bool verificacao = VerificarVoto();
    if(verificacao){
      //enviar dados firebase
      lcd.clear();
      while(true){
        lcd.setCursor(0,0);
        lcd.print("Afaste da Urna para");
         lcd.setCursor(0,1);
        lcd.print("encerrar sessão");
        
        tempo = ultrasonic.timing();
        float DistanciaAtual = ultrasonic.convert(tempo,Ultrasonic::CM);
        Serial.println(DistanciaAtual);
        if(DistanciaAtual > DistanciaInicio*1.3){
          break;
        }
        else{
          continue;
        }
      }
    }
    // SE ACHAR ENVIAR DADOS PARA FIREBASE E ATUALIZAR TAG DE ENVIO
    // CASO NÃO DAR MSG DE ERRO E ENVIAR VOLTAR A TELA DE INSERÇÃO DE USUARIOSS ----> 00 NULO

  }
}


void InserirPresidente() {
  lcd.clear();
  int pos = 0;
  for (int i = 0; i < QtdDigitos ; i++) {// for para percorrer o array de presidente e imprimir os dados
    lcd.setCursor(0, 0);
    lcd.print("Insira dois digitos");
    lcd.setCursor(0, 1);
    lcd.print("Para Presidente :");
    Serial.println(" ");
    lcd.setCursor(0, 2);
    for (int j = 0; j < QtdDigitos + 1; j++) { // para imprimir os digitos ja inseridos
      if (voto[j] == '\0') {
        lcd.print(" ");
      }
      else {
        lcd.print(voto[j]);
        //      Serial.print(voto[j]);,
      }
    }
    lcd.print(" ");

    char ReadKeypad = "v";
    ReadKeypad = MyKeyboard.getKey();//leitura do teclado
    if (ReadKeypad && isdigit(ReadKeypad)) // se tiver leitura e for um digito
    {
      voto[pos] = ReadKeypad;
      pos++;
      //      Serial.println("Leitura: ");
      //      Serial.print(ReadKeypad);
      delay(1000);
      continue;
    }
    else {
      i = i - 1;
      continue;
    }
  }
}

bool VerificarVoto() // eu aprei aquitenho q verificar sobre  strcomp https://www.delftstack.com/howto/c/compare-char-in-c/
{
  struct candidato Lula;

  Lula.Numero = "13";
  Lula.Nome = "Lulindo";

  struct candidato Bolzo;

  Bolzo.Nome = "Bolzonaro";
  Bolzo.Numero = "17";

  candidato ArrayofCandidatos[QtdCandidatos] = {Lula, Bolzo};


  for (int candidato = 0; candidato < QtdCandidatos; candidato++) {
    if (ArrayofCandidatos[candidato].Numero[0] == voto[0] && TodosCandidatos[candidato][1] == voto[1]) {
      lcd.clear();
      lcd.setCursor(0, 0);
      lcd.print("Candidato inserido:");
      lcd.setCursor(0, 1);
      lcd.print(ArrayofCandidatos[candidato].Nome);
      lcd.setCursor(0, 2);
      lcd.print("Digito: ");
      lcd.print(ArrayofCandidatos[candidato].Numero);
      lcd.setCursor(0, 3);
      lcd.print("A - Confir B - Canc");
      while (true) {
        char Tecla= MyKeyboard.getKey();
        
        if(Tecla != " "){
          Serial.println(Tecla);
        }
        if (Tecla == 'A' || Tecla == 'a' ) {
          delay(1500);
          lcd.clear();
          lcd.setCursor(0, 1);
          lcd.print("Voto Confirmado");
          return true;
        }
        else if (Tecla == 'B'  || Tecla == 'b') {
          //          Voltar para o MENU!
          delay(1500);
          lcd.clear();
          lcd.setCursor(0, 1);
          lcd.print("Retornando ...");
          return false;

        }
      }

    }
  }
}
