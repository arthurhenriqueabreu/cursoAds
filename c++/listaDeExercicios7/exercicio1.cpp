#include <iostream>
#include "arthur.h"

using namespace std;
//convertendo celsius em fahrenheit


main(){
	float celsius, fahrenheit;
	system("chcp 65001");
	cout<<"Digite uma temperatura em Celsius: ";
	cin>>celsius;
	fahrenheit = converterCelsiusParaFahrenheit(celsius);
	cout<<"A temperatura digitada em Fahrenheit ficou: "<<fahrenheit;
}