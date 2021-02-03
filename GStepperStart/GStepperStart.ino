// крутим мотор туда-сюда плавно с ускорением

#include "GyverStepper.h"
// подключим три мотора
byte R = 0;
long move_on_x = 0;
long dx = 0;
long ud = 0;
long move_on_y = 0;
long dy = 0;
long posx = 0;
long posy = 0;
char receivedCommand;
bool newData;
GStepper<STEPPER2WIRE> stepper1(200, 8, 7, 10);
GStepper<STEPPER2WIRE> stepper2(200, 6, 5, 11);

void setup() {
  // мотор 1 просто вращается
  Serial.begin(115200);
  stepper1.setRunMode(FOLLOW_POS);
  stepper1.setMaxSpeed(600);
  stepper1.setAcceleration(300);
  stepper1.autoPower(true);

  // мотор 2 будет делать sweep по проверке tick
  stepper2.setRunMode(FOLLOW_POS);
  stepper2.setMaxSpeed(600);
  stepper2.setAcceleration(300);
  stepper1.autoPower(true);
}
void checkSerial() //function for receiving the commands
{
  if (Serial.available() > 0) //if something comes from the computer
  {
    receivedCommand = Serial.read(); // pass the value to the receivedCommad variable
    newData = true; //indicate that there is a new data by setting this bool to true

    if (newData == true) //we only enter this long switch-case statement if there is a new command from the computer
    {

      switch (receivedCommand) //we check what is the command
      {

        case 'O':

          R = Serial.parseInt(); // количество повторений
          move_on_x = Serial.parseInt(); // количество смещений по X
          dx = Serial.parseInt(); // Длина смещения по X
          ud = Serial.parseInt(); // Задержка между смещениями
          move_on_y = Serial.parseInt(); // Количество смещений по Y
          dy = Serial.parseInt(); // Длина смещения по Y

          break;

        default:

          break;
      }
    }
    newData = false;
  }
}



void loop() {
  stepper1.tick();
  stepper2.tick();

  checkSerial();

}
