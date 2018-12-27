void RandomWalk()
{
  if (IsObstacleDetected())
  {
    switch (obstaclePosition)
    {
      // Obstacle detected on the front
      case 1:
        GetObstacleDistance(trigLeft, echoLeft, leftDistance);
        delay(20);
        GetObstacleDistance(trigRight, echoRight, rightDistance);
        delay(20);
        if (leftDistance <= rightDistance)
        {
          SpinRight();
          skip = random(800, 1500);
        }
        else
        {
          SpinLeft();
          skip = random(800, 1500);
        }
        break;
      // Obstacle detected on the left
      case 2:
        SpinRight();
        skip = random(800, 1500);
        timeCheckStuck = millis();
        break;
      // Obstacle detected on the right
      case 3:
        SpinLeft();
        skip = random(800, 1500);
        timeCheckStuck = millis();
        break;
    }
  }
  else
  {
    MoveForward();
  }
}

void CheckCornerStuck()
{
  switch (obstaclePosition)
  {
    case 2:
      GetObstacleDistance(trigRight, echoRight, rightDistance);
      if (rightDistance <= 3)
      {
        SpinRight();
        skip = 1500;
      }
      break;
    case 3:
      GetObstacleDistance(trigLeft, echoLeft, leftDistance);
      if (leftDistance <= 3)
      {
        SpinLeft();
        skip = 1500;
      }
      break;
  }
}
