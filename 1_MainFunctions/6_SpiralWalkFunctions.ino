void SpiralMovement()
{
  if (IsObstacleDetected())
  {
    Stop();
    pwmL = defaultPWML;
    pwmR = defaultPWMR;
    automaticMode = 2;
  }
  else
  {
    MoveForward();
  }
}
