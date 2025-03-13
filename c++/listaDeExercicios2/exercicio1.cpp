#include <iostream>
using namespace std;

main(){
	int opcaoId;
	do{	
		int areaQuadrado, perimetroQuadrado, ladoQuadrado, areaRetangulo, perimetroRetangulo, ladoRetangulo, areaCirculo, perimetroCirculo, raioCirculo;
		cout << "\tEscolha uma opção: \n[1] Calcule a área e o perímetro de um quadrado\n[2] Calcule a área e o perímetro de um retângulo\n[3] Calcule a área e o perímetro de um círculo\n[4] Sair\n";
		cin >> opcaoId;
		switch(opcaoId){
			case 1: {
				cin >> ladoQuadrado;
				areaQuadrado = ladoQuadrado ^ 2;
				perimetroQuadrado = ladoQuadrado * 4;
				cout << "\nÁrea do quadrado: " << areaQuadrado << "\nPerímetro do quadrado: " << perimetroQuadrado;
				break;
			};
			case 2: {
				break;
			};
			case 3: {
				break;
			};
			case 4: {
				cout << "Encerrando programa";
				break;
			};
			default: {
				cout <<"Opção Inválida!\n";
				break;
			};
		}
	}while (opcaoId != 4);
}