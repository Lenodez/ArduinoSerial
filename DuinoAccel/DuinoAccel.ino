
#include <AccelStepper.h>



//User-defined values
long receivedSteps = 0; //Number of steps
long receivedSpeed = 0; //Steps / second
long receivedAcceleration = 0; //Steps / second^2
char receivedCommand;
//-------------------------------------------------------------------------------

int directionMultiplier = 1; // = 1: positive direction, = -1: negative direction
bool newData, needcool = false, needcool1 = false; 
AccelStepper stepper(AccelStepper::DRIVER, 8, 7);
AccelStepper stepper1(AccelStepper::DRIVER, 6, 5);
const int enblpin = 10;
const int enblpin1 = 11;
void setup()
{
  Serial.begin(115200); //define baud rate

  pinMode(enblpin, OUTPUT);
  pinMode(enblpin1, OUTPUT);

  //setting up some default values for maximum speed and maximum acceleration

  stepper.setMaxSpeed(3200); //SPEED = Steps / second
  stepper.setAcceleration(1600); //ACCELERATION = Steps /(second)^2
  stepper.setEnablePin(10);
  stepper.setPinsInverted(false, false, true);
  stepper.disableOutputs(); //disable outputs

  stepper1.setMaxSpeed(3200); //SPEED = Steps / second
  stepper1.setAcceleration(1600); //ACCELERATION = Steps /(second)^2
  stepper1.setEnablePin(11);
  stepper1.setPinsInverted(false, false, true);
  stepper1.disableOutputs(); //disable outputs
}

void loop()
{
  checkSerial(); //check serial port for new commands
  RunTheMotor(); //function to handle the motor
  RunTheMotor1(); //function to handle the motor
}

void RunTheMotor() //function for the motor
{
    stepper.enableOutputs(); 
    stepper.run(); 
}
void RunTheMotor1() //function for the motor
{
    stepper1.enableOutputs(); 
    stepper1.run(); 
}

void cooling() // function for the cooling
{
  if (needcool == true)
  {
  if (stepper.isRunning() == false) // check is motor moving or not
  {
    stepper.disableOutputs();
    needcool = false;
  }
  else
  {
    return;
  }
  }
  else
  {
    return;
  }
}
void cooling1() // function for the cooling
{
  if (needcool == true)
  {
  if (stepper1.isRunning() == false) // check is motor moving or not
  {
    stepper1.disableOutputs();
    needcool1 = false;
  }
  else
  {
    return;
  }
  }
  else
  {
    return;
  }
}



void checkSerial() //function for receiving the commands
{
  if (Serial.available() > 0) //if something comes from the computer
  {
    receivedCommand = Serial.read(); // pass the value to the receivedCommad variable
    newData = true; //indicate that there is a new data by setting this bool to true

    if (newData == true) //we only enter this long switch-case statement if there is a new command from the computer
    {
      needcool = true;
      needcool1 = true;
      switch (receivedCommand) //we check what is the command
      {

        case 'P': 
          receivedSteps = Serial.parseInt(); //value for the steps
          receivedSpeed = Serial.parseInt(); //value for the speed
          directionMultiplier = 1; //We define the direction
          Serial.println("Positive direction."); //print the action
          RotateRelative(); //Run the function

          break;

        case 'N': 

          receivedSteps = Serial.parseInt(); //value for the steps
          receivedSpeed = Serial.parseInt(); //value for the speed
          directionMultiplier = -1; //We define the direction
          Serial.println("Negative direction."); //print action
          RotateRelative(); //Run the function
          break;

        case 'R': 

          receivedSteps = Serial.parseInt(); //value for the steps
          receivedSpeed = Serial.parseInt(); //value for the speed
          directionMultiplier = -1; //We define the direction
          Serial.println("Negative direction."); //print action
          RotateRelative1(); 
          break;

        case 'r': 

          receivedSteps = Serial.parseInt(); //value for the steps
          receivedSpeed = Serial.parseInt(); //value for the speed
          directionMultiplier = 1; //We define the direction
          Serial.println("Positive direction."); //print the action
          RotateRelative1(); //Run the function
          break;

        case 'S': // Stops the motor

          stepper.stop(); //stop motor
          stepper.disableOutputs(); //disable power
          Serial.println("Stopped."); //print action

          break;

        case 'A': // Updates acceleration

          stepper.disableOutputs(); //disable power
          stepper1.disableOutputs(); //disable power
          receivedAcceleration = Serial.parseInt(); //receive the acceleration from serial
          stepper.setAcceleration(receivedAcceleration); //update the value of the variable
          stepper1.setAcceleration(receivedAcceleration); //update the value of the variable
          Serial.print("New acceleration value: "); //confirm update by message
          Serial.println(receivedAcceleration); //confirm update by message
          break;

        case 'U':
          stepper.disableOutputs(); //disable power
          stepper1.disableOutputs(); //disable power
          stepper.setCurrentPosition(0); //Reset current position. "new home"
          stepper1.setCurrentPosition(0); //Reset current position. "new home"
          Serial.print("The current position is updated to: "); //Print message
          Serial.println(stepper.currentPosition()); //Check position after reset.
          break;
          
        default:

          break;
      }
    }
    newData = false;
  }
}


void RotateRelative()
{
  stepper.setMaxSpeed(receivedSpeed); //set speed
  stepper.move(directionMultiplier * receivedSteps); //set relative distance and direction
}

void RotateRelative1()
{
  stepper1.setMaxSpeed(receivedSpeed); //set speed
  stepper1.move(directionMultiplier * receivedSteps); //set relative distance and direction
}
