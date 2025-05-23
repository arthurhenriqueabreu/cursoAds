#include <iostream>
using namespace std;
main(){
	int idade, acumula, media, i;
	for(i=1; 1<=3; i++){
		do{
			cout<<"\n\n Digite a idade da "<<i<<"ª pessoa: ";
			cin>>idade;
			if((idade<0) || (idade>145)){
				cout<<"\n\n ATENÇÃO IDADE ERRADA";
				cout<<"\n\n Digite a idade novamente da "<<i<<"ª pessoa: ";
				cin>>idade;
			}
		} while ((idade<0) || (idade>145));
		acumula = acumula + idade;
	}
	media=acumula/(i-1));
}