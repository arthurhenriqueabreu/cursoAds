#include <iostream>
using namespace std;

main() {
	system("chcp 65001");
	cout<<"\n\n\n\n\n\n\n";
    // Parte do telhado
    for (int i = 1; i <= 8; i++) {
        // Espaços em branco à esquerda
        for (int j = 9; j > i; j--) {
            cout << "  ";
        }
        // Telhado com emojis
        for (int k = 0; k < (2 * i - 1); k++) {
        	//cout<<k;
            cout << "🧱";
        }
        cout << endl;
    }

    // Parte do corpo da casa
    for (int i = 0; i < 10; i++) {
        cout << "  ";
        for (int j = 0; j < 15; j++) {
            if (i >= 4 && j >= 3 && j <= 7) {
                cout << "🪟"; // janelas
            } else {
                cout << "🏠"; // parede
            }
        }
        cout << endl;
    }
cout<<"\n\n\n\n\n\n\n";
}
