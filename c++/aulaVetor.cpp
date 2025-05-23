#include<iostream>
#include<time.h>

using namespace std;
int const TAM = 10;

int vetor[TAM],par=0,acum=0,comparativoMaior=0,comparativoMenor=60;
float media;

int i;
main() 
{
	srand(time(0));//Reinicia o relógio do processor
	system("chcp 65001");// Para acentuar as palavras
	cout<<"\n\n\t Programa Vetor Números \n\n\n";
    cout<<"\n Digite 10 números \n\n\n";
	for(i=0; i<TAM; i++)
    {
    	vetor[i]= rand() % 60;
		cout<<"\n Número Gerado "<<i+1<< "º "<<vetor[i];
		
		if(comparativoMaior<vetor[i]){
			comparativoMaior = vetor[i];
		}
		if(comparativoMenor>vetor[i]){
			comparativoMenor = vetor[i];
		}
		
		if (vetor[i]%2==0)
		    par++;// Contador
		acum = acum + vetor[i]; //Acumulador  
		//acum += vetor[i]; //Acumulador  
	}
	media = acum / TAM;
	cout<< "\n A média dos números: "<<media;
	cout<< "\n Foram informados: " <<par<<" pares";
	cout<< "\n O maior número é o: "<<comparativoMaior;
	cout<< "\n O menor número é o: "<<comparativoMenor;
    cout<<"\n\n\n\n";
}