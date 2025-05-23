//vai receber uma temperatura em celsius e retornar em fahrenheit
float converterCelsiusParaFahrenheit(float celsius){
	return((celsius*1.8)+32);
}

//vai receber dois numeros e vai retornar o maior entre eles
int retornoNumMaior(int num1, int num2){
	int numMaior;
	if(num1>num2){
		numMaior = num1;
	} else if (num2>num1){
		numMaior = num2;
	}
	
	return numMaior;
}