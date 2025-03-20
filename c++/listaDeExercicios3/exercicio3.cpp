#include <iostream>
using namespace std;

int ano;
main(){
	system ("chcp 65001");
	cout << "Digite um ano: ";
	cin >> ano;
	if (ano % 4 == 0){
		cout << "O ano é bissexto!";
	} else {
		cout << "O ano não é bissexto!";
	}
}