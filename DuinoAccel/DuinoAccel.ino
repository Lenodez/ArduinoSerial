
#include <AccelStepper.h>



//User-defined values
long receivedSteps = 0; //Number of steps
long receivedSpeed = 0; //Steps / second
long receivedAcceleration = 0; //Steps / second^2
char receivedCommand;
//-------------------------------------------------------------------------------

int directionMultiplier = 1; // = 1: positive direction, = -1: negative direction
bool newData, runallowed, runallowed1, needcool = false, needcool1 = false; // booleans for new data from serial, and runallowed flag
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
  //Constantly looping through these 2 functions.
  //We only use non-blocking commands, so something else (should also be non-blocking) can be done during the movement of the motor

  checkSerial(); //check serial port for new commands
  RunTheMotor(); //function to handle the motor
  cooling(); //cool the motor
  RunTheMotor1(); //function to handle the motor
  cooling1(); //cool the motor
}


void RunTheMotor() //function for the motor
{
  if (runallowed == true)
  {
    stepper.enableOutputs(); //enable pins
    stepper.run(); //step the motor (this will step the motor by 1 step at each loop)
  }
  else //program enters this part if the runallowed is FALSE, we do not do anything
  {
    stepper.disableOutputs(); //disable outputs
    return;
  }
}
void RunTheMotor1() //function for the motor
{
  if (runallowed1 == true)
  {
    stepper1.enableOutputs(); //enable pins
    stepper1.run(); //step the motor (this will step the motor by 1 step at each loop)
  }
  else //program enters this part if the runallowed is FALSE, we do not do anything
  {
    stepper1.disableOutputs(); //disable outputs
    return;
  }
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

        case 'P': //P uses the move() function of the AccelStepper library, which means that it moves relatively to the current position.

          receivedSteps = Serial.parseInt(); //value for the steps
          receivedSpeed = Serial.parseInt(); //value for the speed
          directionMultiplier = 1; //We define the direction
          Serial.println("Positive direction."); //print the action
          RotateRelative(); //Run the function

          //example: P2000 400 - 2000 steps (5 revolution with 400 step/rev microstepping) and 400 steps/s speed

          break;

        case 'N': //N uses the move() function of the AccelStepper library, which means that it moves relatively to the current position.

          receivedSteps = Serial.parseInt(); //value for the steps
          receivedSpeed = Serial.parseInt(); //value for the speed
          directionMultiplier = -1; //We define the direction
          Serial.println("Negative direction."); //print action
          RotateRelative(); //Run the function

          //example: N2000 400 - 2000 steps (5 revolution with 400 step/rev microstepping) and 500 steps/s speed; will rotate in the other direction

          break;

        case 'R':

          receivedSteps = Serial.parseInt(); //value for the steps
          receivedSpeed = Serial.parseInt(); //value for the speed
          directionMultiplier = -1; //We define the direction
          Serial.println("Negative direction."); //print action
          RotateRelative1(); //Run the function
          //example: R800 400 - It moves to the position which is located at +800 steps away from 0.
          break;

        case 'r':

          receivedSteps = Serial.parseInt(); //value for the steps
          receivedSpeed = Serial.parseInt(); //value for the speed
          directionMultiplier = 1; //We define the direction
          Serial.println("Positive direction."); //print the action
          RotateRelative1(); //Run the function

          //example: r800 400 - It moves to the position which is located at -800 steps away from 0.
          break;

        case 'S': // Stops the motor

          stepper.stop(); //stop motor
          stepper.disableOutputs(); //disable power
          Serial.println("Stopped."); //print action
          runallowed = false; //disable running
          runallowed1 = false;
          break;

        case 'A': // Updates acceleration

          runallowed = false; //we still keep running disabled, since we just update a variable
          runallowed1 = false;
          stepper.disableOutputs(); //disable power
          stepper1.disableOutputs(); //disable power
          receivedAcceleration = Serial.parseInt(); //receive the acceleration from serial
          stepper.setAcceleration(receivedAcceleration); //update the value of the variable
          stepper1.setAcceleration(receivedAcceleration); //update the value of the variable
          Serial.print("New acceleration value: "); //confirm update by message
          Serial.println(receivedAcceleration); //confirm update by message
          break;

        case 'U':

          runallowed = false; //we still keep running disabled
          runallowed1 = false;
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
    //after we went through the above tasks, newData is set to false again, so we are ready to receive new commands again.
    newData = false;
  }
}


void GoHome()
{
  if (stepper.currentPosition() == 0)
  {
    Serial.println("We are at the home position.");
    stepper.disableOutputs(); //disable power
  }
  else
  {
    stepper.setMaxSpeed(400); //set speed manually to 400. In this project 400 is 400 step/sec = 1 rev/sec.
    stepper.moveTo(0); //set abolute distance to move
  }
}

void RotateRelative()
{
  //We move X steps from the current position of the stepper motor in a given direction.
  //The direction is determined by the multiplier (+1 or -1)

  runallowed = true; //allow running - this allows entering the RunTheMotor() function.
  stepper.setMaxSpeed(receivedSpeed); //set speed
  stepper.move(directionMultiplier * receivedSteps); //set relative distance and direction

}

void RotateRelative1()
{
  //We move X steps from the current position of the stepper motor in a given direction.
  //The direction is determined by the multiplier (+1 or -1)

  runallowed1 = true; //allow running - this allows entering the RunTheMotor() function.
  stepper1.setMaxSpeed(receivedSpeed); //set speed
  stepper1.move(directionMultiplier * receivedSteps); //set relative distance and direction

}

void RotateAbsolute()
{
  //We move to an absolute position.
  //The AccelStepper library keeps track of the position.
  //The direction is determined by the multiplier (+1 or -1)


  runallowed = true; //allow running - this allows entering the RunTheMotor() function.
  stepper.setMaxSpeed(receivedSpeed); //set speed
  stepper.moveTo(directionMultiplier * receivedSteps); //set relative distance
}
