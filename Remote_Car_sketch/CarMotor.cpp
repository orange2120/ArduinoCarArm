/*********************************
Library of Car Motor
*********************************/

#include "CarMotor.h"

CarMotor::CarMotor(uint8_t _IN1, uint8_t _IN2, uint8_t _IN3, uint8_t _IN4, uint8_t pin_A, uint8_t pin_B)
{
	_pin_ENA = pin_A;
	_pin_ENB = pin_B;
	_pin_IN1 = _IN1;
	_pin_IN2 = _IN2;
	_pin_IN3 = _IN3;
	_pin_IN4 = _IN4;
}

void CarMotor::init()
{
	pinMode(_pin_IN1, OUTPUT);
	pinMode(_pin_IN2, OUTPUT);
	pinMode(_pin_IN3, OUTPUT);
	pinMode(_pin_IN4, OUTPUT);
}

void CarMotor::set_motorA_speed(int speed_A)
{
	if(speed_A <= 255 && speed_A >= 0) 
	{
		_pwm_A = speed_A;
		analogWrite(_pin_ENA, _pwm_A);
	}
}

void CarMotor::set_motorB_speed(int speed_B)
{
	if(speed_B <= 255 && speed_B >= 0)
	{
		_pwm_B = speed_B;
		analogWrite(_pin_ENB, _pwm_B);
	}
}

int CarMotor::get_motorA_speed()
{
	return _pwm_A;
}

int CarMotor::get_motorB_speed()
{
	return _pwm_B;
}

//ENA:Left motor(IN1,IN2),ENB:Right motor(IN3,IN4)

void CarMotor::forward()
{
	digitalWrite(_pin_IN1, LOW);
    digitalWrite(_pin_IN2, HIGH);
    digitalWrite(_pin_IN3, LOW);
    digitalWrite(_pin_IN4, HIGH);
}

void CarMotor::backward()
{
	digitalWrite(_pin_IN1, HIGH);
    digitalWrite(_pin_IN2, LOW);
    digitalWrite(_pin_IN3, HIGH);
    digitalWrite(_pin_IN4, LOW);
}

void CarMotor::turnLeft()
{
    digitalWrite(_pin_IN1, LOW);
    digitalWrite(_pin_IN2, LOW);
    digitalWrite(_pin_IN3, LOW);
    digitalWrite(_pin_IN4, HIGH);	
}
 
void CarMotor::turnRight()
{
    digitalWrite(_pin_IN1, LOW);
    digitalWrite(_pin_IN2, HIGH);
    digitalWrite(_pin_IN3, LOW);
    digitalWrite(_pin_IN4, LOW);
}
 
void CarMotor::stop()
{
    digitalWrite(_pin_IN1, LOW);
    digitalWrite(_pin_IN2, LOW);
    digitalWrite(_pin_IN3, LOW);
    digitalWrite(_pin_IN4, LOW);
}

void CarMotor::brake()
{
    digitalWrite(_pin_IN1, HIGH);
    digitalWrite(_pin_IN2, HIGH);
    digitalWrite(_pin_IN3, HIGH);
    digitalWrite(_pin_IN4, HIGH);
}