#ArduinoCarArm

![image]https://github.com/orange2120/ArduinoCarArm/blob/master/DSC_1353.JPG

Arduino藍芽遙控車與arm的神奇組合

此專案包含C# Python 和 Arduino程式
* C#：ArduinoCarArm.sln
* Python：ArduinoCarArm.py
* Arduino：Remote_Car_sketch

## C# ArduinoCarArm

實作連線控制器，操作遙控車與手臂

* 連線控制：選擇Baud rate、COM port，並有`重新掃描`，`連線`、`斷線`按鈕(Serial monitor尚未實作)
* 遙控車控制：`前進`、`後退`、`左轉`、`右轉`
* 手臂控制：`前`、`後`、`左`、`右`、`上`、`下`、`夾起/放開`，`歸零`