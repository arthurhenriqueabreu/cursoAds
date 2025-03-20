#include <iostream>
using namespace std;

int num1, num2, resultado;
char operador;
main(){
	system ("chcp 65001");
	cout << "Digite um número: ";
	cin >> num1;
	cout << "Digite outro número: ";
	cin >> num2;
	cout << "Digite um operador aritmético: ";
	cin >> operador;
	switch(operador){
		case '+':
			resultado = num1 + num2;
			break;
		case '-':
			resultado = num1 - num2;
			break;
		case '/':
			resultado = num1 / num2;
			break;
		case '*':
			resultado = num1 * num2;
			break;
	}
	cout << "A operação ficou: "<< num1 << operador << num2 << "=" << resultado;
}