
#include <AccelStepper.h>
// The X Stepper pins
#define STEPPER1_DIR_PIN 7
#define STEPPER1_STEP_PIN 8
// The Y stepper pins
#define STEPPER2_DIR_PIN 5
#define STEPPER2_STEP_PIN 6
// Define some steppers and the pins the will use
AccelStepper stepper1(AccelStepper::DRIVER, STEPPER1_STEP_PIN, STEPPER1_DIR_PIN);
AccelStepper stepper2(AccelStepper::DRIVER, STEPPER2_STEP_PIN, STEPPER2_DIR_PIN);
void setup()
{  
    stepper1.setMaxSpeed(800.0);
    stepper1.setAcceleration(200.0);
    stepper1.moveTo(10000);
    
    stepper2.setMaxSpeed(800.0);
    stepper2.setAcceleration(200.0);
    stepper2.moveTo(10000);
}
void loop()
{
    // Change direction at the limits
    if (stepper1.distanceToGo() == 0)
        stepper1.moveTo(-stepper1.currentPosition());
    if (stepper2.distanceToGo() == 0)
        stepper2.moveTo(-stepper2.currentPosition());
    stepper1.run();
    stepper2.run();
}
