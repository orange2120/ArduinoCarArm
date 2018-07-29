import sys
import glob
import atexit
import serial
import serial.tools.list_ports
from pynput import keyboard

_base_deg = 100
_shoulder_deg = 100
_elbow_deg = 100
_gripper_deg = 100

move_step = 5

def cmd_handler(arg):
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
    ser.write(switcher.get(arg).encode())
    #return switcher.get(arg, "\n")

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
 
 
if __name__ == '__main__':
    print(get_serial_ports())

def cleanup():
    ser.close()
    print("Cleanup!")

def on_press(key):
    global _base_deg
    global _shoulder_deg
    global _elbow_deg

    if key == keyboard.Key.up:
        cmd_handler('FORWARD_CMD')
    elif key == keyboard.Key.down:
        cmd_handler('BACK_CMD')
    elif key == keyboard.Key.left:
        cmd_handler('LEFT_CMD')
    elif key == keyboard.Key.right:
        cmd_handler('RIGHT_CMD')
    elif key == ".":
        cmd_handler('STOP_CMD')
    elif key == "a":
        _base_deg -= move_step
        cmd_handler('BASE_CMD')
        ser.write(str(_base_deg).encode())
    elif key == "d":
        _base_deg += move_step
        cmd_handler('BASE_CMD')
        ser.write(str(_base_deg).encode())
    elif key == "w":
        _shoulder_deg += move_step
        cmd_handler('SHOULDER_CMD')
        ser.write(str(_shoulder_deg).encode())
    elif key == "s":
        _shoulder_deg -= move_step
        cmd_handler('SHOULDER_CMD')
        ser.write(str(_shoulder_deg).encode())
    elif key == "q":
        _elbow_deg -= move_step
        cmd_handler('ELBOW_CMD')
        ser.write(str(_elbow_deg).encode())
    elif key == "e":
        _elbow_deg += move_step
        cmd_handler('ELBOW_CMD')
        ser.write(str(_elbow_deg).encode())
    elif key == "o":
        cmd_handler('GRIPPER_OC')
    ser.write('\n'.encode())


def on_release(key):
    if key == keyboard.Key.up:
        cmd_handler('STOP_CMD')
    elif key == keyboard.Key.down:
        cmd_handler('STOP_CMD')
    elif key == keyboard.Key.left:
        cmd_handler('STOP_CMD')
    elif key == keyboard.Key.right:
        cmd_handler('STOP_CMD')
    ser.write('\n'.encode())

#atexit.register(cleanup)

print("Available serial ports:")

get_serial_ports()

port = input("Port(tty***):")
baud = input("Baudrate:")
port = "/dev/"+port

print("Port:"+port+",Baud:"+baud)

try:
    ser = serial.Serial(port, baud, timeout=1)
except serial.SerialException:
    print("Connect error")
    sys.exit(0)

while True:
    with keyboard.Listener(on_press = on_press, on_release = on_release) as listener:
        listener.join()
    #TODO:Print serial Rx message
    #if 
    print(ser.readline())
