package ListaExercicios1.Exercicios;
import java.util.Scanner;

public class Exercicio01 {
    // ENUNCIADO: 1. Crie um programa onde o usuário informe um número e imprima em ordem decrescente o seu valor até 0.
    public static void main(String[] args){
        int numero;
        Scanner sc = new Scanner(System.in);
        try{
            System.out.print("Digite um número: ");
            numero = sc.nextInt();
            System.out.println("A sequência de "+numero+" até 0 é:");
            for(int i = numero; i >= 0; i--){
            System.out.println(i);
        }
        }catch(Exception e){

        } finally {
            sc.close();
        }
    }
}
