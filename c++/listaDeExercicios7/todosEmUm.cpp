/* ENUNCIADOS
1. Crie uma função que receba uma temperatura em graus Celsius e retorne o valor
em Fahrenheit.

2. Crie uma função que receba dois números inteiros e retorne o maior deles.

3. Crie uma função que receba um número inteiro e retorne o fatorial desse número.

4. Crie uma função que receba três números inteiros e retorne a média inteira entre
eles.

5. Crie uma função que receba um número inteiro e retorne 1 se ele for primo, e 0
caso contrário.

6. Crie uma função que receba uma letra minúscula e retorne sua versão
maiúscula.

7. Crie uma função que receba uma letra e retorne se ela é uma vogal ou consoante.
Se for vogal deve retornar o número 1 se for consoante deverá retornar 0.

8. Crie uma função que receba dois caracteres e retorne o que vier primeiro no
alfabeto.

9. Crie uma função que receba uma temperatura em graus Fahrenheit e retorne o
valor em Celsius.

10.Crie uma função que receba a base e a altura de um triângulo e retorne sua área.

11.Crie uma função que receba a distância percorrida (em km) e o combustível
consumido (em litros) e retorne o consumo médio.

12.Crie uma função que receba um número inteiro e exiba se ele é par ou ímpar.

13.Crie uma função que receba dois valores e imprima o menor deles. Retorne o
menor número. Considere o caso de números iguais.

14.Crie uma função que receba três números e exiba o maior.

15.Crie uma função que receba três números e exiba o menor.

16.Crie uma função que receba um caractere e um número inteiro, e retorne o
caractere repetido n vezes.

17.Crie uma função que receba um número inteiro e um número decimal, e retorne
a soma como float
*/
#include<iostream>
using namespace std;

//Converte temperatura de celsius para fahrenheit
	
void celsiusParaFahrenheit (){
	int celsius, fahrenheit, op;
	do{
		system("cls");
		cout<<"Digite uma temperatura em Celsius: ";
		cin>>celsius;
		fahrenheit = (celsius * 1.8)+32;
		cout<<"A temperatura em Fahrenheit é: "<< fahrenheit;
		cout<<"\n\n\nDigite [1] para repetir\n";
		cout<<"Digite [2] para sair\n";
		cin>>op;
		if(op !=1 && op!=2){
			do{
			system("cls");
			cout<<"Opção inválida!\n";
			cout<<"\n\n\nDigite [1] para repetir\n";
			cout<<"Digite [2] para sair\n";
			cin>>op;
			}while(op!=1 && op!=2);
		}
	}while (op!=2);
}

//Recebe 2 números inteiros e retorna o maior entre eles

void maiorNumeroEntreDois(){
	int num1, num2, op;
	do{
		system("cls");
		cout<<"Digite um número: ";
		cin>>num1;
		cout<<"Digite outro número: ";
		cin>>num2;
		if(num1>num2){
			cout<<"O número "<<num1<<" é maior que o número "<<num2;
		}else if(num2>num1){
			cout<<"O número "<<num2<<" é maior que o número "<<num1;
		}else {
			cout<<"Os números sâo iguais!";
		}
		cout<<"\n\n\nDigite [1] para repetir\n";
		cout<<"Digite [2] para sair\n";
		cin>>op;
		if(op !=1 && op!=2){
			do{
			system("cls");
			cout<<"Opção inválida!\n";
			cout<<"\n\n\nDigite [1] para repetir\n";
			cout<<"Digite [2] para sair\n";
			cin>>op;
			}while(op!=1 && op!=2);
		}
	}while (op!=2);
}

void fatorialDeUmNumero(){
	int numero, fatorial;
	do{
		system("cls");
		cout<<"Digite um número: ";
		cin>>numero;
		for(int i = 1; fatorial ){
			
		}
		cout<<"A fatorial desse número é "<<fatorial;
	}while(op!=2);
}

main(){
	int op;
	system("chcp 65001");
	do{
		
		system("cls");
		cout<<"--------------Lista de Exercícios 7--------------\n";
        cout<<"Selecione uma opção\n";
        cout<<"[1] Converte temperatura Celsius em Fahrenheit.\n";
        cout<<"[2] Verifica o maior número entre 2 inteiros. \n";
        cout<<"[3] Fatorial de um número. \n";
        cout<<"[4] Média de três números inteiros. \n";
        cout<<"[5] Verificador de número primo. \n";
        cout<<"[6] Conversor de letra minúscula em maiúscula. \n";
        cout<<"[7] Verifica se é vogal ou consoante. \n";
        cout<<"[8] Compara dois caracteres e retorna o que vem primeiro no alfabeto. \n";
        cout<<"[9] Converte Fahrenheit para Celsius.\n";
        cout<<"[10] Calcula a área de um triângulo. \n";
        cout<<"[11] Calcula o consumo médio de combustível. \n";
        cout<<"[12] Verifica se um número é par ou ímpar. \n";
        cout<<"[13] Imprime o menor número entre dois. \n";
        cout<<"[14] Exibe o maior número entre três. \n";
        cout<<"[15] Exibe o menor número entre três. \n";
        cout<<"[16] Repete um caractere n vezes. \n";
        cout<<"[17] Soma de um número inteiro e um decimal. \n";
        cout<<"[18] Sair \n";
        cout<<"\n\n-----------------------------------------------------------\n\n";
        cout<<"Escolha uma opção: ";
		cin>>op;
		switch(op){
		case 1:
			celsiusParaFahrenheit();
			break;	
		
		case 2:
			maiorNumeroEntreDois();
			break;
		case 3:
			fatorialDeUmNumero();
			break;
		case 18:
			cout<<"Tchau!";
			break;
		default:
			cout<<"Opção inválida!";
			break;
		}
	}while(op!=18);
}