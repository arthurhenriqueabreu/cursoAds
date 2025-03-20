//esse programa vai receber a idade de uma pessoa e vai dizer se ela é de maior ou de menor
#include <iostream>
using namespace std;
int idade;

main(){
	system ("chcp 65001");
	cout << "\t----------------------------------------\n";
	cout << "\tDescubra se você é de maior ou de menor!\n";
	cout << "\t----------------------------------------\n";
	cout << "Digite a sua idade em anos: ";
	cin >> idade;
	if (idade >= 18 && idade <= 122){
		cout << "Parabéns! Você já é de maior!";
	} else if (idade < 18 && idade > 0){
		cout << "Poxa! Você ainda é de menor!";
	} else if (idade < 0){
		cout << "Você nem nasceu ainda!";
	} else {
		cout << "Parabéns! Você bateu o recorde mundial de pessoa mais velha!";
	}
}