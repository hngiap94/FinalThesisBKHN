void ManualControl()
{
  switch (dataRead)
    {
      case 'F':
        MoveForward();
        break;
      case 'B':
        MoveBackward();
        break;
      case 'L':
        SpinLeft();
        break;
      case 'R':
        SpinRight();
        break;
      case 'S':
        Stop();
        break;
    }
    if (IsObstacleDetected())
    {
      MoveBackward();
      delay(500);
      Stop();
    }
}
