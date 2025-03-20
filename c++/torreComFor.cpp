#include <iostream>
using namespace std;

int altura;

main(){
	cout<<"Digite a altura desejada da torre: ";
	cin>>altura;
	for (int i = 0; i < altura; i++){
		cout<<"\n";
		for(int j = 0; j <= i; j++){
			cout<<" * ";
		}
	}
}