int val,i=0,k=0;
int t1g=3; //НАСТРОЙКА!!!//
int t2g=3; //НАСТРОЙКА!!!//
int t1=12; //НАСТРОЙКА!!!//
int t2=12; //НАСТРОЙКА!!!//
int kx=40; //НАСТРОЙКА!!!//
void setup(){
Serial.begin(9600);
Serial.println("Start");
//4,5,6,7 контакты для 1 мотора
pinMode(4, OUTPUT);pinMode(5, OUTPUT);
pinMode(6, OUTPUT);pinMode(7, OUTPUT);
//12,13,10,11 контакты для 2 мотора
pinMode(12, OUTPUT);pinMode(13, OUTPUT);
pinMode(10, OUTPUT);pinMode(11, OUTPUT);
}
void stopPins(){ // функция для остановки ШД
if(Serial.available()){
char val=Serial.read(); //читаем из программного Serial-порта
Serial.println(val); //пишем в Serial-порт
if(val=='0'){i++;}}
}
void loop(){
if(Serial.available()){
char val=Serial.read(); //читаем из программного Serial-порта
Serial.println(val); //пишем в Serial-порт
if (val=='1'){
while (i<1){k++; if(k > kx){t1=t1g;} //цикл для вращения мотора 1 вправо
digitalWrite(7, HIGH);digitalWrite(5, LOW);delay(t1);stopPins();
digitalWrite(6, HIGH);digitalWrite(4, LOW);delay(t1);stopPins();
digitalWrite(5, HIGH);digitalWrite(7, LOW);delay(t1);stopPins();
digitalWrite(4, HIGH);digitalWrite(6, LOW);delay(t1);stopPins();
}i=0, k=0, t1=12;}
if (val=='3'){
while (i<1){k++; if(k>kx){t1=t1g;} //цикл для вращения мотора 1 влево
digitalWrite(4, HIGH);digitalWrite(6, LOW);delay(t1);stopPins();
digitalWrite(5, HIGH);digitalWrite(7, LOW);delay(t1);stopPins();
digitalWrite(6, HIGH);digitalWrite(4, LOW);delay(t1);stopPins();
digitalWrite(7, HIGH);digitalWrite(5, LOW);delay(t1);stopPins();
}i=0,k=0,t1=12;}
if (val=='2'){
while (i<1){k++;if (k>kx){t2=t2g;} //цикл для вращения мотора 1 вправо
digitalWrite(13, HIGH);digitalWrite(11, LOW);delay(t2);stopPins();
digitalWrite(12, HIGH);digitalWrite(10, LOW);delay(t2);stopPins();
digitalWrite(11, HIGH);digitalWrite(13, LOW);delay(t2);stopPins();
digitalWrite(10, HIGH);digitalWrite(12, LOW);delay(t2);stopPins();
}i=0,k=0,t2=12;
}
if (val=='4'){
while (i<1){k++;if (k>kx){t2=t2g;} //цикл для вращения мотора 1 влево
digitalWrite(10, HIGH);digitalWrite(12, LOW);delay(t2);stopPins();
digitalWrite(11, HIGH);digitalWrite(13, LOW);delay(t2);stopPins();
digitalWrite(12, HIGH);digitalWrite(10, LOW);delay(t2);stopPins();
digitalWrite(13, HIGH);digitalWrite(11, LOW);delay(t2);stopPins();
}i=0,k=0,t2=12;}}else{
digitalWrite(4, LOW);digitalWrite(5, LOW);digitalWrite(6, LOW);
digitalWrite(7, LOW);digitalWrite(10, LOW);digitalWrite(11, LOW);
digitalWrite(12, LOW);digitalWrite(13, LOW);}
}
