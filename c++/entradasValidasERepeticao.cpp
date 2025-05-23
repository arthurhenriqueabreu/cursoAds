#include <iostream>
#include <iomanip>
using namespace std;

int ano;
char continuar;
main(){
	system ("chcp 65001");
	do{
		do{
		cout << "\nDigite um ano de 0 a 2050: ";
		cin >> ano;
		if(!(ano<0 || ano>2050)){
			if (ano % 4 == 0){
			cout << "O ano é bissexto!";
			} else {
			cout << "O ano não é bissexto!";
			}
		}else{
			cout<<"Ano inválido!\n";
		}
		}while (ano<0 || ano>2050);
		cout<<"\nDeseja continuar [S/N]? ";
		cin>>continuar;
		continuar = toupper(continuar);
	}while(continuar != 'N');
	
}