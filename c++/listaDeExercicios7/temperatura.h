//essa fun��o vai coverter uma temperatura de celsius para fahrenheit
float converterCelsiusParaFahrenheit(float celsius){
	return((celsius*1.8)+32);
}

void retornoNumMaior(int num1, float num2){
	if(num1>num2){
		cout<<"O n�mero "<<num1<<" � maior que "<<num2;
	} else if (num2>num1){
		cout<<"O n�mero "<<num2<<" � maior que "<<num1;
	} else {
		cout<<"Os n�meros "<<num1<<" e "<<num2<<" s�o iguais";
	}
}