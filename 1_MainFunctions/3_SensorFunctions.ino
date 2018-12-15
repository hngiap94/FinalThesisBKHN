// Function:
/*Get obstacle distance from ultrasonic sensor*/
void GetObstacleDistance(int trigPin, int echoPin, float& distance)
{
  unsigned long duration;
  /*Sets the trigPin states*/
  digitalWrite(trigPin, LOW); // Clears the trigPin
  delayMicroseconds(2);
  digitalWrite(trigPin, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin, LOW);

  /*Calculate the distance*/
  duration = pulseIn(echoPin, HIGH);
  distance = duration/2/29.412;
}

// Function:
/*Check if there is any obstacle near robot*/
bool IsObstacleDetected()
{
  /*Read distance from sensors*/
  GetObstacleDistance(trigRight, echoRight, rightDistance);
  delay(20);
  GetObstacleDistance(trigFront, echoFront, frontDistance);
  delay(20);
  GetObstacleDistance(trigLeft, echoLeft, leftDistance);
  delay(20);

  /*Check conditions if any obstacle detected or not*/
  if((frontDistance <= 3 && frontDistance != 0) || digitalRead(IRSensorRight) == 0 || digitalRead(IRSensorLeft) == 0)
  {
    obstaclePosition = 1;
    return true;
  }
  else if (leftDistance <= 3 && leftDistance != 0)
  {
    obstaclePosition = 2;
    return true;
  }
  else if (rightDistance <= 3 && rightDistance != 0)
  {
    obstaclePosition = 3;
    return true;
  }
  else
  {
    return false;
  }
}
