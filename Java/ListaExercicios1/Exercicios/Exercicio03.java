package ListaExercicios1.Exercicios;

import java.util.Scanner;

public class Exercicio03 {
    //3. Crie um programa que receba dois números (`a` e `b`) e imprima a variáves e seus valores na ordem inversa, ou seja, se `a` receber 1 e `b` receber 2 deve ser impresso `a=2` e `b=1`.
    public static void main(String[] args){
        int a, b;
        Scanner sc = new Scanner(System.in);
        System.out.print("Digite um número: ");
        a = sc.nextInt();
        System.out.print("Digite outro número: ");
        b = sc.nextInt();
        System.out.println("a = "+b);
        System.out.println("b = "+a);
        sc.close();
    }
}
