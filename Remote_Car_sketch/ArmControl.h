/*********************************
Library of Arm Servo motor control
*********************************/

#ifndef ArmControl_h
#define ArmControl_h

#include <stdint.h>
#include <Arduino.h>
#include <Servo.h>

#define MAX_BASE_DEG     180
#define MIN_BASE_DEG     0
#define HOME_BASE_DEG    100

#define MAX_SHOULDER_DEG 180
#define MIN_SHOULDER_DEG 0
#define HOME_SHOULDER_DEG 100

#define MAX_ELBOW_DEG    180
#define MIN_ELBOW_DEG    0
#define HOME_ELBOW_DEG   100

#define MAX_GRIPPER_DEG  150
#define MIN_GRIPPER_DEG  50
#define HOME_GRIPPER_DEG 100

#define GRIPPER_OPEN_DEG 150
#define GRIPPER_CLOSE_DEG 30


class Arm
{
	private:
		Servo _sv_base, _sv_shoulder, _sv_elbow, _sv_gripper;
		
		uint8_t _pin_base, _pin_shoulder, _pin_elbow, _pin_gripper;
		int _deg_base = 100, _deg_shoulder = 100, _deg_elbow = 100, _deg_gripper =100;

		bool gripper_open = false;
		
	
	public:
		Arm(uint8_t pin_base, uint8_t pin_shoulder, uint8_t pin_elbow, uint8_t pin_gripper);
		void init();
		void detach();
		
		void set_base_angle(int angle);
		void set_shoulder_angle(int angle);
		void set_elbow_angle(int angle);
		void set_gripper_angle(int angle);
		
		int get_base_angle();
		int get_shoulder_angle();
		int get_elbow_angle();
		int get_gripper_angle();
		
		void home_base();
		void home_shoulder();
		void home_elbow();
		void home_gripper();

		void gripper_open();
		void gripper_close();
		bool gripper_IsOpen();
};

#endif