
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

int pwmL = 100, pwmR = 100;
float leftDistance, frontDistance, rightDistance;
int obstaclePosition;
//==============================================//
//==========    SET UP COMPONENTS    ===========//
//==============================================//
void setup() {
  Serial.begin(9600);
  // put your setup code here, to run once:
  pinMode(trigRight, OUTPUT);
  pinMode(echoRight, INPUT);
  pinMode(trigFront, OUTPUT);
  pinMode(echoFront, INPUT);
  pinMode(trigLeft, OUTPUT);
  pinMode(echoLeft, INPUT);

  pinMode(IRSensorRight, INPUT_PULLUP);
  pinMode(IRSensorLeft, INPUT_PULLUP);
}

//==============================================//
//==============    MAIN LOOP    ===============//
//==============================================//
void loop() {
  // put your main code here, to run repeatedly:
  if(IsObstacleDetected())
  {
    switch (obstaclePosition)
    {
      case 1:
        Serial.println("Front");
        break;
      case 2:
        Serial.println("Left");
        break;
      case 3:
        Serial.println("Right");
        break;
      default:
        Serial.println("Error!!!");
      
    }
    Serial.println(obstaclePosition);
  }
}
