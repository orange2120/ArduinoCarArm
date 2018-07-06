/*********************************
Library of Car Motor
*********************************/

#ifndef CarMotor_h
#define CarMotor_h

#include <stdint.h>
#include <Arduino.h>

class CarMotor
{
	private:
		uint8_t _pin_IN1,_pin_IN2,_pin_IN3,_pin_IN4;
		uint8_t _pin_ENA,_pin_ENB;
		int _pwm_A = 0;
		int _pwm_B = 0;
	
	public:
		CarMotor(uint8_t IN1, uint8_t IN2, uint8_t IN3, uint8_t IN4, uint8_t pin_A, uint8_t pin_B);
		void init();
		
		void set_motorA_speed(int speed_A);
		void set_motorB_speed(int speed_B);
		
		int get_motorA_speed();
		int get_motorB_speed();
		
		void forward();
		void backward();
		void turnLeft();
		void turnRight();
		void stop();
		void brake();
};

#endif