/*********************************
Library of Arm Servo motor control
*********************************/

#include "ArmControl.h"

Arm::Arm(uint8_t pin_base, uint8_t pin_shoulder, uint8_t pin_elbow, uint8_t pin_gripper)
{
	_pin_base = pin_base;
	_pin_shoulder = pin_shoulder;
	_pin_elbow = pin_elbow;
	_pin_gripper = pin_gripper;
}

void Arm::init()
{
	_sv_base.attach(_pin_base);
	_sv_shoulder.attach(_pin_shoulder);
	_sv_elbow.attach(_pin_elbow);
	_sv_gripper.attach(_pin_gripper);
}

void Arm::detach()
{
	_sv_base.detach();
	_sv_shoulder.detach();
	_sv_elbow.detach();
	_sv_gripper.detach();
}

void Arm::set_base_angle(int angle)
{
	if(angle <= MAX_BASE_DEG && angle >= MIN_BASE_DEG)
	{
		_sv_base.write(angle);
		_deg_base = angle;
	}
}

void Arm::set_shoulder_angle(int angle)
{
	if(angle <= MAX_SHOULDER_DEG && angle >= MIN_SHOULDER_DEG)
	{
		_sv_shoulder.write(angle);
		_deg_shoulder = angle;
	}
}

void Arm::set_elbow_angle(int angle)
{
	if(angle <= MAX_ELBOW_DEG && angle >= MIN_ELBOW_DEG)
	{
		_sv_elbow.write(angle);
		_deg_elbow = angle;
	}
}

void Arm::set_gripper_angle(int angle)
{
	if(angle <= MAX_GRIPPER_DEG && angle >= MIN_GRIPPER_DEG)
	{
		_sv_gripper.write(angle);
		_deg_gripper = angle;
	}
}

int Arm::get_base_angle()
{
	return _deg_base;
}

int Arm::get_shoulder_angle()
{
	return _deg_shoulder;
}

int Arm::get_elbow_angle()
{
	return _deg_elbow;
}

int Arm::get_gripper_angle()
{
	return _deg_gripper;
}

void Arm::home_base()
{
	_sv_base.write(HOME_BASE_DEG);
	_deg_base = HOME_BASE_DEG;
}

void Arm::home_shoulder()
{
	_sv_shoulder.write(HOME_SHOULDER_DEG);
	_deg_shoulder = HOME_SHOULDER_DEG;
}

void Arm::home_elbow()
{
	_sv_elbow.write(HOME_ELBOW_DEG);
		_deg_elbow = HOME_ELBOW_DEG;
}

void Arm::home_gripper()
{
	_sv_gripper.write(HOME_GRIPPER_DEG);
	_deg_gripper = HOME_GRIPPER_DEG;
}