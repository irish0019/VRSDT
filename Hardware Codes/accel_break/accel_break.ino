/*
This code is for reading values form break pedal 
and accelerator pedal using slide potentiometer 
*/

int potmeterPin0 = A0;              // Slide potentiometer vlaue from A0 for accelerator
int potmeterPin1 = A1;              // Slide potentiometer vlaue from A1 for break
int potmeterVal1 = 0;               // Slide potentiometer value of accelerator
int potmeterVal2 = 0;               // Slide potentiometer value of break

void setup() {
  Serial.begin(9600);              // Initialise the serial monitor
}

void loop() {
  
  potmeterVal = analogRead(potmeterPin0);    // Read the analog value of the slide potentiometer for accelerator
  potmeterVal = analogRead(potmeterPin1);    // Read the analog value of the slide potentiometer for break
  Serial.println("Accelerator Value: "); 
  Serial.print(potmeterVal0);                // Displaying value of accelerator
  Serial.println("Break Value: ");           
  Serial.print(potmeterVal1);                // Displaying value of break
  delay(100);                                // Pause of 100ms
  
}