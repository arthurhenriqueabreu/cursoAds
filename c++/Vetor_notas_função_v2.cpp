//FUP que leia 10 notas num vetor
// Use constante
// Calcule a média numa função e retorne p/prog principal
// Faça uma função que verifique quantos alunos 
//tiraram notas menores que 7 - retorne a 
//quantidade ao programa principal;

#include <iostream>
using namespace std;

// criar constante
int const TAM = 10;
float media,notas[TAM];//TAM para gerenciar o tamanho do vetor
int qtde_menor_7;

float mediaVetor(float notas[],int TAM);
int verificarQtdeVetor(float notas[],int TAM);

float verificarMenorNota(float notas[],int TAM);

float verificarMaiorNota(float notas[],int TAM);

main()
{
  system("chcp 65001"); //para usar acentuação
  cout<<"\n\n\t\t ****  VETORES NOTAS   *** \n\n";
  cout<<"\n Informe " << TAM <<" notas";
  for (int i=0;i<TAM;i++)
  { 
    cout<<"\n Informe a "<<i+1<<"ª nota: ";
	cin>> notas[i];
  }
  media = mediaVetor(notas,TAM);
  qtde_menor_7 = verificarQtdeVetor(notas,TAM); 
  cout<<"\n A média das notas é: " <<media;
  cout<<"\n A qtde de notas menores que 7: "<<qtde_menor_7; 
  cout<<"\n\n\n\n\n"; 
}
//=======================================================
// FUNÇÃO MÉDIA
float mediaVetor(float notas[],int TAM) 
{
 float media,acum=0;
 for (int i=0;i<TAM;i++)
  { 
   	acum = acum + notas[i];
  }
  media=acum/TAM;
  return (media);
}
//=============================================
//FUNÇÃO QTDE NOTAS MENORES QUE SETE
int verificarQtdeVetor(float notas[],int TAM)
{ int cont_menor_7=0;
	for(int i=0;i<TAM; i++)
	 {
	 	if (notas[i]<7)
	 	   cont_menor_7++;//conta notas menores de 7
	 }
  return (cont_menor_7);	 
}
//============================================
//FUNÇÃO MAIOR NOTA VETOR
//=============================================
int verificar
MenorNota(float notas[],int TAM){
	int menor;
	for(int i = 0; i < tam; i++) {
		if(notas[i] < menor){
			menor = notas[i];
		}
	}
}


//============================================
//FUNÇÃO MENOR NOTA VETOR
//=============================================
int verificarMaiorNota(float notas[],int TAM)

