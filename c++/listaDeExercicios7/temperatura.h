//essa função vai coverter uma temperatura de celsius para fahrenheit
float converterCelsiusParaFahrenheit(float celsius){
	return((celsius*1.8)+32);
}

void retornoNumMaior(int num1, float num2){
	if(num1>num2){
		cout<<"O número "<<num1<<" é maior que "<<num2;
	} else if (num2>num1){
		cout<<"O número "<<num2<<" é maior que "<<num1;
	} else {
		cout<<"Os números "<<num1<<" e "<<num2<<" são iguais";
	}
}