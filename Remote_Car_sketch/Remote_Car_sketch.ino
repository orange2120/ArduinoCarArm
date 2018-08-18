/**
*
 *Arduino Car Arm
 *Copyright(c) 2018 NTU Maker
 * L298N H-bridge motor controller program
 *
 */
#include <Servo.h>
#include "Definition.h"
#include "CarMotor.h"
#include "ArmControl.h"

CarMotor mt(IN1, IN2, IN3, IN4, ENA, ENB); //Car object

Arm arm(SV1_PIN, SV2_PIN, SV3_PIN, SV4_PIN); //Arm object

//Command & Character ...
#define MAX_NUM_LEN 3 //MAX input command number length
char incoming = '0';  //Temp character storage
char cmd = '0';       //Command prefix
int num = 0;		  //Number command(PWM,angle...)
int i = 0;
char checksum = 'd';
unsigned long watchdog = 0;

//Serial object -> SR

void setup()
{	
	SR.begin(BAUD_RATE);
	
	mt.init();
	arm.init();
}

void loop()
{
	//Receiving characters and split commands
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

		//Judging commands and execute

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

			case GRIPPER_OC:
				if(arm.gripper_IsOpen())
				{
					arm.gripper_close();
					SR.print("Gripper close");
				}
				else
				{
					arm.gripper_open();
					SR.print("Gripper open");
				}
			break;

		}
		SR.println("");
		
		num = 0; //Reset number command
	}
	
	if(millis()-watchdog > KEEPALIVE_INTERVAL)
	{
		SR.println(checksum);
		watchdog = millis();
	}
}
