import sys
import glob
import atexit
import serial
import serial.tools.list_ports
from pynput.keyboard import Key, Controller, Listener
import threading
import time

### global constants ###
move_step = 5
switcher = {
        #Car
        'MOT_A_SPD':   'a',
        'MOT_B_SPD':   'c',
        'FORWARD_CMD': 'f',
        'BACK_CMD':    'b',
        'LEFT_CMD':    'l',
        'RIGHT_CMD':   'r',
        'STOP_CMD':    's',
                         'BRAKE_CMD':   'v',
        #Arm
        'BASE_CMD':    'x',
        'SHOULDER_CMD':'u',
        'ELBOW_CMD':   'e',
        'GRIPPER_CMD': 'g',
        'GRIPPER_OC':  'o'
}

### global variables ###
_base_deg = 100
_shoulder_deg = 100
_elbow_deg = 100
_gripper_deg = 100
ser = None
kill = False
lock = threading.Lock()

### method ###
def cmd_handler(arg1, arg2=None):
    ser.write(switcher[arg1].encode())
    if arg2:
        ser.write(str(arg2).encode())
    ser.write('\n'.encode())
	
#Courtesy by Thomas @ https://stackoverflow.com/questions/12090503/listing-available-com-ports-with-python
def get_serial_ports():
    """ Lists serial port names
 
        :raises EnvironmentError:
            On unsupported or unknown platforms
        :returns:
            A list of the serial ports available on the system
    """
    if sys.platform.startswith('win'):
        ports = ['COM%s' % (i + 1) for i in range(256)]
    elif sys.platform.startswith('linux') or sys.platform.startswith('cygwin'):
        # this excludes your current terminal "/dev/tty"
        ports = glob.glob('/dev/tty[A-Za-z]*')
    elif sys.platform.startswith('darwin'):
        ports = glob.glob('/dev/tty.*')
    else:
        raise EnvironmentError('Unsupported platform')
 
    result = []
    for port in ports:
        try:
            s = serial.Serial(port)
            s.close()
            result.append(port)
        except (OSError, serial.SerialException):
            pass
    return result

def get_ports_routine():
    while input("Scan ports?(y/n):") == 'y':
        print("Available serial ports:{}".format(get_serial_ports()))

def connect_routine():
    global ser
    
    port = input("Port(tty***/COM***):")
    baud = input("Baudrate:")

    try:
        ser = serial.Serial(port, baud, timeout=30)
        
    except ValueError:
        if input("Baudrate should be an integer. Continue?(y/n):") != 'y':
            access_kill(True)
            
    except serial.SerialException:
        if input("Connect error. Continue?(y/n):") != 'y':
            access_kill(True)

	
def check_bt():
    typer = Controller()
    
    while not access_kill():
        typer.press(Key.esc)
        time.sleep(1)
        
def access_kill(write=None):
    global kill
    lock.acquire()
    if write:
        kill = write
    _return = kill
    lock.release()
    return _return

def on_press(key):
    global _base_deg, _shoulder_deg, _elbow_deg

    if not ser or not ser.is_open:
        return False
    else:
        if key == Key.up:
            cmd_handler('FORWARD_CMD')
            print('Forward')
        elif key == Key.down:
            cmd_handler('BACK_CMD')
            print('Backward')
        elif key == Key.left:
            cmd_handler('LEFT_CMD')
            print('Turn left')
        elif key == Key.right:
            cmd_handler('RIGHT_CMD')
            print('Turn right')
        elif str(key)[1] == '.':
            cmd_handler('STOP_CMD')
            print("STOP")
        elif str(key)[1] == 'a':
            _base_deg -= move_step
            cmd_handler('BASE_CMD', _base_deg)
        elif str(key)[1] == 'd':
            _base_deg += move_step
            cmd_handler('BASE_CMD', _base_deg)
        elif str(key)[1] == 'w':
            _shoulder_deg += move_step
            cmd_handler('SHOULDER_CMD', _shoulder_deg)
        elif str(key)[1] == 's':
            _shoulder_deg -= move_step
            cmd_handler('SHOULDER_CMD', _shoulder_deg)
        elif str(key)[1] == 'q':
            _elbow_deg -= move_step
            cmd_handler('ELBOW_CMD', _elbow_deg)
        elif str(key)[1] == 'e':
            _elbow_deg += move_step
            cmd_handler('ELBOW_CMD', _elbow_deg)
        elif str(key)[1] == 'o':
            cmd_handler('GRIPPER_OC')
        elif str(key)[1] == 'f':
            _pwm_A = input("Motor A:")
            cmd_handler('MOT_A_SPD', _pwm_A)
        elif str(key)[1] == 'g':
            _pwm_B = input("Motor B:")
            cmd_handler('MOT_B_SPD', _pwm_B)
        elif str(key)[1] == 'x':
            access_kill(True)
            return False # Stop listener
            

def on_release(key):
    if key == Key.up:
        cmd_handler('STOP_CMD')
    elif key == Key.down:
        cmd_handler('STOP_CMD')
    elif key == Key.left:
        cmd_handler('STOP_CMD')
    elif key == Key.right:
        cmd_handler('STOP_CMD')

#atexit.register(cleanup)

#
#Main program start here
#
def main():
    checkthread = threading.Thread(target = check_bt)
    checkthread.start()

    while not access_kill():
        get_ports_routine()
        connect_routine()

        if access_kill():
                break
        
        with Listener(on_press = on_press, on_release = on_release) as listener:
            listener.join()

    checkthread.join()
    if ser:
        ser.close()

if __name__ == '__main__':
    main()
