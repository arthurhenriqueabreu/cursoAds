#include <iostream>
using namespace std;

int lado;

main(){
	cout<<"Digite o tamanho do quadrado: ";
	cin>>lado;
	for (int i = 1; i<=lado*lado; i++){
		if(i%lado != 0 ){
			cout<<" * ";
		}else {
			cout<<" * \n";
		}
	}
}