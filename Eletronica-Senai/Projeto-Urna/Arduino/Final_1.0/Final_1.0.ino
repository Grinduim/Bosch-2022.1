#include <WiFi.h>

#include <Firebase.h>
#include <FirebaseESP32.h>

#include <LiquidCrystal_I2C.h>
#include <Ultrasonic.h>
#include <Keypad.h> // lib para a leitura do teclado
#include <string.h>
#include <Wire.h>
// lib para usar o 20/4 com o i2c

const int echoPin = 19;
const int trigPin = 18; // configuração do modulo ultrasonico
Ultrasonic ultrasonic(trigPin, echoPin);


//Inicializa o display no endereco 0x27
LiquidCrystal_I2C lcd(0x27, 20, 4); // quatidade de linhas e colunas com a porta q o i2c usa

#define WIFI_SSID "espteste" // definindo o nome do wifi
#define WIFI_PASS "teste123" // definindo o a senha do wifi

#define API_KEY "BqDSZa96Q2wUqiZ0ziywmaVXPLEshMIYqsbNm0NN"
#define URL_FIREBASE "https://urnaeletronica-c4da3-default-rtdb.firebaseio.com/" // dados para o firebase

FirebaseData firebaseData;
FirebaseJson json;

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
byte PinosLin[QtdLin] = {13, 12, 14, 27}; // os 4 pinos da esquerda
byte PinosCol[QtdCol] = {26, 25, 5, 4}; // os 4 pinos da direita

//criando o objeto do meu teclado, mapiamento das teclas da minha matriz, pinos linha e coluna, quantidade de linha e coluna
Keypad MyKeyboard = Keypad(makeKeymap(matriz_keypad), PinosLin, PinosCol, QtdLin, QtdCol);

const int PinPir = 32;

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

int TAG = 0;

void setup()
{
  lcd.init();
  lcd.setBacklight(HIGH);

  Serial.begin(9600);
  pinMode(PinPir, INPUT);

  pinMode(echoPin, INPUT);
  pinMode(trigPin, OUTPUT);
  Serial.println("Tentando conectar ao Wifi");
  WiFi.begin(WIFI_SSID, WIFI_PASS);
  while (WiFi.status() != WL_CONNECTED) {
    Serial.print(".");
    delay(300);
  }
  Serial.println();
  Serial.println("Conectado");

  Firebase.begin(URL_FIREBASE,API_KEY);
  Firebase.reconnectWiFi(true);
  Firebase.setReadTimeout( firebaseData, 10 * 60);
  Firebase.setwriteSizeLimit(firebaseData, "tiny");
}

void loop()
{
  lcd.setCursor(0, 0);


  if (digitalRead(PinPir)) {
    long tempo = ultrasonic.timing();
    float DistanciaInicio = (ultrasonic.convert(tempo, Ultrasonic::CM)) * 0.8;

    voto[0] = '\0';// limpando o array do C
    voto[1] = '\0';
    voto[2] = '\0';

    InserirPresidente();
    delay(1000);
    bool verificacao;
    verificacao = VerificarVoto();
    if (verificacao) {
      Serial.println("Enviando dados firebase");
      TAG++;
      String auxvoto;
      for (int i = 0; i < QtdDigitos; i++) {
        auxvoto[i] = voto[i];
      }

      json.set("/Voto", (voto));
      json.set("/Tag", TAG);
      Firebase.updateNode(firebaseData, "/Urna1", json);
      Serial.println("Dados enviado");
      lcd.clear();
      while (true) {
        lcd.setCursor(0, 0);
        lcd.print("Afaste da Urna para");
        lcd.setCursor(0, 1);
        lcd.print("encerrar sessao");

        tempo = ultrasonic.timing();
        float DistanciaAtual = ultrasonic.convert(tempo, Ultrasonic::CM);
        Serial.println(DistanciaAtual);
        if (DistanciaAtual > 1) {
          break;
        }
        else {
          continue;
        }
      }

      delay(2500);
    }

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

    char ReadKeypad = MyKeyboard.getKey();//leitura do teclado
    if (ReadKeypad && isdigit(ReadKeypad)) // se tiver leitura e for um digito
    {
      voto[pos] = ReadKeypad;
      pos++;
      //      Serial.println("Leitura: ");
      //      Serial.print(ReadKeypad);
      delay(800);
      continue;
    }
    else {
      i = i - 1;
      continue;
    }
  }
}

bool VerificarVoto()
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
        char Tecla = MyKeyboard.getKey();


        if (Tecla != NULL) {
          Serial.println(Tecla);
        }



        if (Tecla == 'A' || Tecla == 'a' ) {
          delay(800);
          lcd.clear();
          lcd.setCursor(0, 1);
          lcd.print("Voto Confirmado");

          return true;
        }
        else if (Tecla == 'B'  || Tecla == 'b') {
          //          Voltar para o MENU!
          delay(800);
          lcd.clear();
          lcd.setCursor(0, 1);
          lcd.print("Retornando ...");
          return false;

        }
      }

    }
    else if (candidato == (sizeof(ArrayofCandidatos) / sizeof(ArrayofCandidatos[0])) - 1) {
      lcd.clear();
      lcd.setCursor(0, 0);
      lcd.print("Candidado nao identi");
      lcd.setCursor(0, 1);
      lcd.print("ficado deseja votar ");
      lcd.setCursor(0, 2);
      lcd.print("em branco?");
      lcd.setCursor(0, 3);
      lcd.print("A - Confir B - Canc");

      while (true) {
        char Tecla = MyKeyboard.getKey();

        if (Tecla != NULL) {
          Serial.println(Tecla);
        }

        if (Tecla == 'A' || Tecla == 'a' ) {
          delay(800);
          lcd.clear();
          lcd.setCursor(0, 1);
          lcd.print("Voto Confirmado");
          voto[0] = '0';
          voto[1] = '0';
          return true;
        }
        else if (Tecla == 'B'  || Tecla == 'b') {
          delay(800);
          lcd.clear();
          lcd.setCursor(0, 1);
          lcd.print("Retornando ...");
          return false;
        }
      }
    }
  }
}
