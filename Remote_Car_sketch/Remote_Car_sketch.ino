/*
 * L298N H-bridge motor controller test program
 *
 */
#include <Servo.h>
#include "Definition.h"
#include "CarMotor.h"
#include "ArmControl.h"

CarMotor mt(IN1, IN2, IN3, IN4, ENA, ENB);

Arm arm(SV1_PIN, SV2_PIN, SV3_PIN, SV4_PIN);

//Command & Character ...
#define MAX_NUM_LEN 3
char incoming = '0';
char cmd = '0';
int num= 0;
int i = 0;

void setup()
{	
	SR.begin(115200);
	
	mt.init();
	arm.init();
}

void loop()
{
	if(SR.available())
	{
		cmd = SR.read();
		while((incoming = SR.read()) != '\n')
		{
			if(incoming != -1 && incoming >= '0' && incoming <= '9' && i<MAX_NUM_LEN)
			{
				num *= 10;
				num += (incoming-'0');
				//SR.println(incoming-'0');
				i++;
			}
		}
		i = 0;
		
		//SR.print(cmd);
		
		switch(cmd)
		{
			case MOT_A_SPD:
				{
					mt.set_motorA_speed(num);
					SR.print("A");
					SR.print(mt.get_motorA_speed());
				}
			break;
			case MOT_B_SPD:
				{
					mt.set_motorB_speed(num);
					SR.print("B");
					SR.print(mt.get_motorB_speed());
				}
			break;
			case FORWARD_CMD:
				mt.forward();
				SR.print("Forward");
			break;
			case BACK_CMD:
				mt.backward();
				SR.print("Backward");
			break;
			case LEFT_CMD:
				mt.turnLeft();
				SR.print("turnLeft");
			break;
			case RIGHT_CMD:
				mt.turnRight();
				SR.print("turnRight");
			break;
			case STOP_CMD:
				mt.stop();
				SR.print("STOP");
			break;
			case BRAKE_CMD:
				mt.brake();
				SR.print("Brake");
			break;
			//TODO:
			case BASE_CMD:
				arm.set_base_angle(num);
				SR.print(arm.get_base_angle());
			break;
			
			case SHOULDER_CMD:
				arm.set_shoulder_angle(num);
				SR.print(arm.get_shoulder_angle());
			break;
			
			case ELBOW_CMD:
				arm.set_elbow_angle(num);
				SR.print(arm.get_elbow_angle());
			break;
			
			case GRIPPER_CMD:
				arm.set_gripper_angle(num);
				SR.print(arm.get_gripper_angle());
			break;

		}
		SR.println("");
		
		num = 0;
	}
}