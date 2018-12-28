#include <PID_v1.h>
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

#define trigWallSensor 50
#define echoWallSensor 51

#define IRSensorRight 42
#define IRSensorLeft 43

RF24 radio(6,7); // ardware configuration: Set up nRF24L01 radio on SPI bus plus pins 7 & 8
const uint64_t pipes[2] = {0xE8E8F0F0E1LL, 0xA7A7C9C9E1LL}; // Set addresses of the 2 pipes for read and write
char dataRead, dataWrite; // Variables to store data

int pwmL = 100, pwmR = 100; // PWM input to control motor
int defaultPWML = 100, defaultPWMR = 100; // PWM set by default
int spiralPWML = 100, spiralPWMR = 50; // PWM input in Spiral movement
int automaticMode = 1; // Mode of automatic: Spiral - 1, Random - 2, Wall Follow - 3
double leftDistance, frontDistance, rightDistance, wallDistance; // Distance read from sensor
int obstaclePosition; // Position of obstacle has been sensed: Front - 1, Left - 2, Right - 3
long pmillis = 0; // Time to track in skip function
long timeCheckStuck = 0; // Time to check if robot get stuck at corner
bool manual = 1; // Manual mode or Automatic mode
unsigned int skip = 61000; // Skip to avoid using delay
long defaultAutoTime = 180000; // default time to run automatic mode
long startAutoTime, stopAutoTime; // start and stop time of automatic mode
int findWall;

double input, output, setpoint;
float kp = 0;
float ki = 0;
float kd = 0;
PID myPID(&input, &output, &setpoint, kp, ki, kd, DIRECT);

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
  /*PID set up*/
  setpoint = 4;
  myPID.SetMode(AUTOMATIC);
  myPID.SetSampleTime(1);
  myPID.SetOutputLimits(-70, 70);
}

//==============================================//
//==============    MAIN LOOP    ===============//
//==============================================//
void loop() 
{
  // put your main code here, to run repeatedly:
  /*Read data from RF station*/
  if (radio.available())
  {
    while (radio.available())
    {
      radio.read(&dataRead, sizeof(dataRead));
      delay(100);
      Serial.println(dataRead);
    }
  }
  /*Mode selections*/
  switch (dataRead)
  {
    case 'M':
      manual = 1;
      Stop();
      dataRead = ' ';
      break;
    case 'A':
      manual = 0;
      dataRead = ' ';
      pwmL = spiralPWML;
      pwmR = spiralPWMR;
      automaticMode = 1;
      startAutoTime = millis();
      stopAutoTime = defaultAutoTime;
      break;
  }

  if (millis() - pmillis > 5)
  {
    if (skip < 60000)
    {
      skip = skip - 5;
      if (millis() - timeCheckStuck < 500)
      {
        CheckCornerStuck();
      }
    }
    pmillis = millis();
  }
  
  //skip: end the loop here. to avoid using delay
  if (skip >= 1 && skip < 60000)
  {
    return;
  }

/*MAIN PROGRAM*/
  if (manual)
  {
    ManualControl();
  }
  else
  {
    switch(automaticMode)
    {
      case 1:
        SpiralMovement();
        break;
      case 2:
        RandomWalk();
        break;
      case 3:
        break;
    }
  }
}
