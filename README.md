# ArduinoCarArm

![image]https://github.com/orange2120/ArduinoCarArm/raw/master/DSC_1353.JPG

Arduino藍芽遙控車與arm的神奇組合

此專案包含C#、Python 和 Arduino程式
* C#：ArduinoCarArm.sln
* Python：ArduinoCarArm.py
* Arduino：Remote_Car_sketch

## C# "ArduinoCarArm"

實作連線控制器，操作遙控車與手臂

* 連線控制：選擇Baud rate、COM port，並有重新掃描`Rescan`，連線`Connect`、斷線`Disconnect`按鈕(Serial monitor尚未實作)
* 遙控車控制：`前進`、`後退`、`左轉`、`右轉`
* 馬達調速：分別控制馬達A、B轉速（PWM）
* 手臂控制：`前`、`後`、`左`、`右`、`上`、`下`、`夾起/放開`，歸零`Homing`，及手動模式（分別控制伺服馬達角度）
* 連線狀態指示：斷線<font color=red>Disconnected</font>、已連線<font color=green>Connected</font>

有關操控的按鈕在連線成功後才會啟用
其中遙控車控制也接受keyboard interrupt輸入，使用`Up`、`Down`、`Left`、`Right`，煞車`.`
手臂控制為前`w`、後`s`、逆時針`a`、順時針`d`、上升`q`、下降`e`

## Python "ArduinoCarArm.py"

使用pynput library捕捉keyboard interrupt，功能與C#版本類似

程式執行會先顯示目前電腦上available的Serial Port，連線前會提示輸入Serial Port name及Baudrate

## Arduino sketch "Remote_Car_Arm"

遙控車端Arduino程式，採物件導向撰寫，架構分為以下部份

* Remote_Car_sketch.ino：Arduino主程式，包含Serial字串拆解、判斷
* Definition.h：Serial相關設定、遙控指令字元定義、硬體pin定義
* ArmControl.h/ArmControl.cpp：手臂控制函式
* CarMotor.h/CarMotor.cpp：遙控車控制函式
