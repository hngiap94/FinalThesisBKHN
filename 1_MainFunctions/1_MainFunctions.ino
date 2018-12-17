#include <SPI.h>
#include "RF24.h"

//==============================================//
//======    DEFINE AND GLOBAL VARIABLES    =====//
//==============================================//

#define inA 8
#define inB 9
#define inC 10
#define inD 11

#define trigRight 44
#define echoRight 45
#define trigFront 46
#define echoFront 47
#define trigLeft 48
#define echoLeft 49

#define IRSensorRight 42
#define IRSensorLeft 43

RF24 radio(6,7); // ardware configuration: Set up nRF24L01 radio on SPI bus plus pins 7 & 8
const uint64_t pipes[2] = {0xE8E8F0F0E1LL, 0xA7A7C9C9E1LL}; // Set addresses of the 2 pipes for read and write
char dataRead, dataWrite; // Variables to store data

int pwmL = 100, pwmR = 100;
float leftDistance, frontDistance, rightDistance;
int obstaclePosition;
//==============================================//
//==========    SET UP COMPONENTS    ===========//
//==============================================//
void setup() 
{
  Serial.begin(9600);
  // put your setup code here, to run once:
  /*L298 set up*/
  digitalWrite(inA, LOW);
  digitalWrite(inB, LOW);
  digitalWrite(inC, LOW);
  digitalWrite(inD, LOW);
  /*Ultrasonic sensors set up*/
  pinMode(trigRight, OUTPUT);
  pinMode(echoRight, INPUT);
  pinMode(trigFront, OUTPUT);
  pinMode(echoFront, INPUT);
  pinMode(trigLeft, OUTPUT);
  pinMode(echoLeft, INPUT);
  /*IR sensors set up*/
  pinMode(IRSensorRight, INPUT_PULLUP);
  pinMode(IRSensorLeft, INPUT_PULLUP);
  /*RF module set up*/
  radio.begin();
  radio.setAutoAck(1);                // Enable auto-acknowlede packets
  radio.setRetries(2,15);             // Set the number and delay of retries upon failed submit
  radio.setDataRate(RF24_250KBPS);    // Set the transmission data rate
  radio.setPALevel(RF24_PA_LOW);      // Set the PA Level low to prevent power supply related issues
  radio.setChannel(10);               // Set RF communication channel
  radio.openWritingPipe(pipes[1]);    // Open a pipe for writing
  radio.openReadingPipe(1, pipes[0]); // Open a pipe for reading
  radio.startListening();             // Start listening on the pipes opened for reading.
}

//==============================================//
//==============    MAIN LOOP    ===============//
//==============================================//
void loop() 
{
  // put your main code here, to run repeatedly:
  /*Read data from RF station*/
  if(radio.available())
  {
    while(radio.available())
    {
      radio.read(&dataRead, sizeof(dataRead));
      delay(100);
      Serial.println(dataRead);
    }
  }

  switch(dataRead)
  {
    case 'F':
      MoveForward();
      delay(2000);
      Stop();
      break;
    case 'B':
      MoveBackward();
      delay(2000);
      Stop();
      break;
    case 'L':
      SpinLeft();
      delay(2000);
      Stop();
      break;
    case 'R':
      SpinRight();
      delay(2000);
      Stop();
      break;
  }
}
