//Move in forward direction
void MoveForward()
{
  analogWrite(inA, pwmR);
  digitalWrite(inB, LOW);
  analogWrite(inC, pwmL);
  digitalWrite(inD, LOW);
}

//Move in backward direction
void MoveBackward()
{
  digitalWrite(inA, LOW);
  analogWrite(inB, pwmR);
  digitalWrite(inC, LOW);
  analogWrite(inD, pwmL);
}

//Turn left
void SpinLeft()
{
  digitalWrite(inA, LOW);
  analogWrite(inB, pwmR);
  analogWrite(inC, pwmL);
  digitalWrite(inD, LOW);
}

//Turn right
void SpinRight()
{
  analogWrite(inA, pwmR);
  digitalWrite(inB, LOW);
  digitalWrite(inC, LOW);
  analogWrite(inD, pwmL);
}

//Stop
void Stop()
{
  digitalWrite(inA, LOW);
  digitalWrite(inB, LOW);
  digitalWrite(inC, LOW);
  digitalWrite(inD, LOW);
}
