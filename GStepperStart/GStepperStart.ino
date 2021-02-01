// крутим мотор туда-сюда плавно с ускорением

#include "GyverStepper.h"
// подключим три мотора
// у первого и второго управление EN не подключаем
GStepper<STEPPER2WIRE> stepper1(200, 8, 7, 10);
GStepper<STEPPER2WIRE> stepper2(200, 6, 5, 11);

void setup() {
  // мотор 1 просто вращается
  stepper1.setRunMode(KEEP_SPEED);
  stepper1.setSpeed(300);

  // мотор 2 будет делать sweep по проверке tick
  stepper2.setRunMode(FOLLOW_POS);
  stepper2.setMaxSpeed(2500);
  stepper2.setAcceleration(300);
}

void loop() {
  // первый мотор
  stepper1.tick();
  
  // второй крутим туды-сюды (-1000, 1000)
  if (!stepper2.tick()) {
    static bool dir;
    dir = !dir;
    stepper2.setTarget(dir ? -20000 : 20000);
  }

}
