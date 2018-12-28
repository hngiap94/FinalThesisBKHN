void WallFollowMovement()
{
  if(findWall)
  {
    FindWall();
  }
  else
  {
    FollowWall();
  }
}


void FindWall()
{
  if(IsObstacleDetected())
  {
    do
    {
      SpinRight();
      GetObstacleDistance(trigWallSensor, echoWallSensor, wallDistance);
    }
    while(wallDistance > 5);
    //skip = 500;
    findWall = 0;
  }
  else
  {
    MoveForward();
  }
}


void FollowWall()
{
  GetObstacleDistance(trigFront, echoFront, frontDistance);
  delay(20);
  if(frontDistance < 3)
  {
    do
    {
      SpinRight();
      GetObstacleDistance(trigWallSensor, echoWallSensor, wallDistance);
    }
    while(wallDistance > 4);
  }
  else
  {
    myPID.Compute();
    pwmL = defaultPWML - output;
    pwmR = defaultPWMR + output;
    MoveForward();
  }
}
