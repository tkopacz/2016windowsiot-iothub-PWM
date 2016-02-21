# Remarks 

Used chip: PCA9685 (PWM)

PCA9685: [http://cache.nxp.com/documents/data_sheet/PCA9685.pdf?fpsp=1&WT_TYPE=Data Sheets&WT_VENDOR=FREESCALE&WT_FILE_FORMAT=pdf&WT_ASSET=Documentation&fileExt=.pdf](http://cache.nxp.com/documents/data_sheet/PCA9685.pdf?fpsp=1&WT_TYPE=Data Sheets&WT_VENDOR=FREESCALE&WT_FILE_FORMAT=pdf&WT_ASSET=Documentation&fileExt=.pdf "http://cache.nxp.com/documents/data_sheet/PCA9685.pdf?fpsp=1&WT_TYPE=Data Sheets&WT_VENDOR=FREESCALE&WT_FILE_FORMAT=pdf&WT_ASSET=Documentation&fileExt=.pdf")

## Driver source for FEZ Hat
Product page: https://www.ghielectronics.com/catalog/product/500 
Source for drivers: https://bitbucket.org/ghi_elect/windows-iot
Schematic: http://www.ghielectronics.com/downloads/schematic/FEZ_HAT_SCH.pdf

### Servos (one of many):


### Physical Connection:
Just connect 2 servos to S1 and S2 (3 pins)
Usual colors for servos: 
Power: Red
Ground: Black, Brown
Signal: Yellow, White, Orange, Gray, OTHER color


#### Note from doc:

When using the servo motors, and only when using the servo motors, the driver will switch the clock frequency to 50Hz. This may cause some flickering on the LEDs when dimmed. Also, the DC motor may jitter. Adding a 470uF capacitor in parallel with the motor will help in the jitter.

## Other (similar) products: 
https://learn.adafruit.com/adafruit-tb6612-h-bridge-dc-stepper-motor-driver-breakout/overview
https://www.pololu.com/product/713
http://botland.com.pl/sterowniki-silnikow-moduly/32-tb6612-dwukanalowy-sterownik-silnikow-modul-pololu.html
http://botland.com.pl/sterowniki-silnikow-moduly/5459-explore-duonect-pca9685-generator-pwm-i2c-mod-71.html
...(use favorite search engine) 

#### Caution: you need to adopt source code of course!

