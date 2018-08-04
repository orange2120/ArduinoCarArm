/*********************************
Definition of pins and commands
*********************************/

#ifndef DEFINITION_h
#define DEFINITION_h

//Serial port name(Serial,Serial1...etc)
auto &SR = Serial1;
#define BAUD_RATE 115200

//Commands definition
//Car
#define MOT_A_SPD   'a' //Motor A PWM
#define MOT_B_SPD   'c' //Motor B PWM
#define FORWARD_CMD 'f'
#define BACK_CMD    'b'
#define LEFT_CMD    'l'
#define RIGHT_CMD   'r'
#define STOP_CMD    's'
#define BRAKE_CMD   'v' //Soft stop

//Arm
#define BASE_CMD    'x'
#define SHOULDER_CMD 'u'
#define ELBOW_CMD   'e'
#define GRIPPER_CMD 'g'
#define GRIPPER_OC  'o' //Gripper open/close

//Pins definition
//L298N module
#define ENA 3
#define ENB 5
#define IN1 13
#define IN2 12
#define IN3 11
#define IN4 10

//Servo motor                       
#define SV1_PIN 7 //Base
#define SV2_PIN 2 //Shoulder
#define SV3_PIN 6 //Elbow
#define SV4_PIN 4 //Gripper

#endif
