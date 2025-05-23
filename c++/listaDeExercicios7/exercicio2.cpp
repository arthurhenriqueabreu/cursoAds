#include <iostream>
#include "arthur.h"

using namespace std;

main(){
	int num1, num2, numMaior;
	system("chcp 65001");
	
	cout<<"Digite um número: ";
	cin>>num1;
	cout<<"Digite outro número: ";
	cin>>num2;
	numMaior = retornoNumMaior(num1, num2);
	cout<<"O maior número é o"<<numMaior;
}