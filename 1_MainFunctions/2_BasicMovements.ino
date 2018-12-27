//Move in forward direction
void MoveForward()
{
  analogWrite(inA, pwmL);
  digitalWrite(inB, LOW);
  analogWrite(inC, pwmR);
  digitalWrite(inD, LOW);
}

//Move in backward direction
void MoveBackward()
{
  digitalWrite(inA, LOW);
  analogWrite(inB, pwmL);
  digitalWrite(inC, LOW);
  analogWrite(inD, pwmR);
}

//Turn left
void SpinLeft()
{
  digitalWrite(inA, LOW);
  analogWrite(inB, pwmL);
  analogWrite(inC, pwmR);
  digitalWrite(inD, LOW);
}

//Turn right
void SpinRight()
{
  analogWrite(inA, pwmL);
  digitalWrite(inB, LOW);
  digitalWrite(inC, LOW);
  analogWrite(inD, pwmR);
}

//Stop
void Stop()
{
  digitalWrite(inA, LOW);
  digitalWrite(inB, LOW);
  digitalWrite(inC, LOW);
  digitalWrite(inD, LOW);
}
