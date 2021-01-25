#include <DHT11.h>
#include <Servo.h>

#define photo_resistor A1
#define led_1 2
#define led_2 4
#define dht11 7
#define rgb_r 10
#define rgb_g 9
#define rgb_b 8
//#define servo_pin 13
#define flame_sensor A0
#define buzzer 12

DHT11 dht11_status(dht11) ;
//Servo servo ;

int threshold = 970;


void setup() {

  Serial.begin(9600) ;
  
// dht11
  pinMode(dht11, INPUT) ;

// rgb
  pinMode(rgb_r, OUTPUT) ;
  pinMode(rgb_g, OUTPUT) ;
  pinMode(rgb_b, OUTPUT) ;

// led
//  pinMode(led_1, OUTPUT) ;
  pinMode(led_2, OUTPUT) ;

// flame_sensor && buzzer
  pinMode(flame_sensor, INPUT) ;
  pinMode(buzzer, OUTPUT) ;

// servo
//  servo.attach(servo) ;
}


void loop() {

// dht11  
  int err ;
  float temp, humi ;
  
  if( (err = dht11_status.read(humi,temp)) == 0 ){
    Serial.print(temp) ;
    Serial.print(",") ;
    Serial.print(humi) ;
  }else{
    Serial.print("Error No : ") ;
    Serial.println(err) ;
  }


// rgb
  if(temp >= 20 && temp < 25) {
    digitalWrite(rgb_r, LOW) ;
    digitalWrite(rgb_g, HIGH) ;
    digitalWrite(rgb_b, LOW) ;
  } else if (temp < 20) {
    digitalWrite(rgb_r, LOW) ;
    digitalWrite(rgb_g, LOW) ;
    digitalWrite(rgb_b, HIGH) ;
  } else {
    digitalWrite(rgb_r, HIGH) ;
    digitalWrite(rgb_g, LOW) ;
    digitalWrite(rgb_b, LOW) ;    
  }


// photo_resistor
  if(analogRead(photo_resistor) > threshold){    
    digitalWrite(led_2, HIGH) ;
  }else{
    digitalWrite(led_2, LOW) ; 
  }


// flame_sensor && buzzer
  Serial.print(",") ;
  Serial.println(analogRead(flame_sensor)) ;
  digitalWrite(buzzer, LOW) ;

  if(analogRead(flame_sensor) >= 700) {
    digitalWrite(buzzer, HIGH) ;
  }


// servo
/*  servo.write(0);
  delay(3000);
  servo.write(240);
  delay(3000);
*/

  delay(1000);
}
