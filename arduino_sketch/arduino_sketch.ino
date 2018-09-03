/*Arduino code is here just to control stepper motor
and to send info about sensors state. Everything else is processed on the PC side*/
#include <Stepper.h>
//-------------------------------
int in1Pin = 4;
int in2Pin = 5;
int in3Pin = 6;
int in4Pin = 7;
int stepsPerRevol=200;
int motorSpeed=10;
int serialBaudRate=9600;
int steps=0;//number and direction of motor-steps
String str;
String str_steps;
String str_speed;
//-------------------------------
int frontSensor=2;
int rearSensor=3;
//-------------------------------
Stepper motor(stepsPerRevol, in1Pin, in2Pin, in3Pin, in4Pin);  
//-------------------------------
void setup()
{
  pinMode(in1Pin, OUTPUT);
  pinMode(in2Pin, OUTPUT);
  pinMode(in3Pin, OUTPUT);
  pinMode(in4Pin, OUTPUT);
  //-------------------------------
  // configure interrupt pins
  attachInterrupt(digitalPinToInterrupt(frontSensor),FrontSensorOn, RISING);
  attachInterrupt(digitalPinToInterrupt(rearSensor),RearSensorOn, RISING);
  //-------------------------------
  Serial.begin(serialBaudRate);
  str=String("_");
}
//------------------------------- 
// ISR pin 2, send message guide end reached
void FrontSensorOn()
{
    Serial.println("FrontSensorOn");
}
//------------------------------- 
// ISR pin 3, send message guide end reached
void RearSensorOn()
{
    Serial.println("RearSensorOn");
}
//------------------------------- 
void loop()
{
    if (Serial.available()>0)
    {
        //expect string like: "steps:speed&steps:speed&..."
        str_steps=Serial.readStringUntil(':');
        //Serial.println(str_steps);
        int stepsTemp=str_steps.toInt();
        if(steps!=stepsTemp)
        {
            steps=stepsTemp;//set our current step
        }
        str_speed=Serial.readStringUntil('&');
       //Serial.println(str_speed);
        int motorSpeedTemp=str_speed.toInt() ;
        if(motorSpeed!=motorSpeedTemp)
        {
           motor.setSpeed(motorSpeed);//set our current motor speed
        }
        motor.step(steps);
//        str=str_steps+':';
//        str+=str_speed+'&';
//        Serial.println(str);
//        str="";
Serial.println("done");
    }
    steps=0;
}

