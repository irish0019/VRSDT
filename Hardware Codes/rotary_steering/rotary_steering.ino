/*This code is for interfacing rotary encoder with the microcontroller
for monitoring the seering wheel rotaion and its position
*/

 #define outputA 6
 #define outputB 7

 int counter = 0; 
 int aState;
 int aLastState;  

 void setup() { 
   pinMode (outputA,INPUT);
   pinMode (outputB,INPUT);
   
   Serial.begin (9600);
   aLastState = digitalRead(outputA);   //read the initial values at outputA
 } 

 void loop() { 
   aState = digitalRead(outputA); // read current value at outputA

   // A pulse will occur if previous state and current state of outputA is different
   if (aState != aLastState){     
     if (digitalRead(outputB) != aState) { 
       counter ++;
     } else {
       counter --;
     }
     Serial.print("Position: ");
     Serial.println(counter);
   } 
   aLastState = aState; // Updates the previous state of the outputA with the current state
 }