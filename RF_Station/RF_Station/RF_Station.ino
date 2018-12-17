#include <SPI.h>
#include "RF24.h"
 

RF24 radio(7,8); // ardware configuration: Set up nRF24L01 radio on SPI bus plus pins 7 & 8
const uint64_t pipes[2] = {0xE8E8F0F0E1LL, 0xA7A7C9C9E1LL}; // Set addresses of the 2 pipes for read and write
char dataRead, dataWrite; // Variables to store data
 
void setup()
{ 
  Serial.begin(9600);
  Serial.println("Setting up RF station...");
  radio.begin();
  radio.setAutoAck(1);                // Enable auto-acknowlede packets
  radio.setRetries(2,15);             // Set the number and delay of retries upon failed submit
  radio.setDataRate(RF24_250KBPS);    // Set the transmission data rate
  radio.setPALevel(RF24_PA_LOW);      // Set the PA Level low to prevent power supply related issues
  radio.setChannel(10);               // Set RF communication channel
  radio.openWritingPipe(pipes[0]);    // Open a pipe for writing
  radio.openReadingPipe(1, pipes[1]); // Open a pipe for reading
  radio.startListening();             // Start listening on the pipes opened for reading.
  Serial.println("Ready!");
}
 
void loop()
{
  /*Read data from serial monitor then send to RF receiver*/
  if(Serial.available())
  {
    dataWrite = Serial.read();
    radio.stopListening();
    Serial.println("Sending...");
    if(radio.write(&dataWrite, sizeof(dataWrite)))
    {
      Serial.println("OK!");
    }
    else
    {
      Serial.println("Failed");
    }
    radio.startListening();
  }
  
  /*Read data from RF response*/
  if(radio.available())
  {
    while(radio.available())
    {
      radio.read(&dataRead, sizeof(dataRead));
      delay(100);
      Serial.println(dataRead);
    }
  }
}
