package ListaExercicios1.Exercicios;

public class Exercicio02 {
    // ENUNCIADO: 2. Crie um programa que imprima em tela os números ímpares entre 0 e 30 e, após, os números pares entre 0 e 30.

    public static void main(String[] args){
        try{
            System.out.print("Os números pares entre 0 e 30 são: ");
            for(int i = 0; i <= 30; i++ ){
                if(i % 2 == 0){
                    //acrescenta virgulas aos pares
                    System.out.print(i);
                    if(i != 30){
                        System.out.print(", ");
                    }
                }
            }
            System.out.println();
            System.out.print("Os números ímpares entre 0 e 30 são: ");
            for(int i = 0; i <= 30; i++ ){
                if(i % 2 != 0){
                    //acrescenta virgula aos impares
                    System.out.print(i);
                    if(i != 29){
                        System.out.print(", ");
                    }
                }
            }
        }catch(Exception e){

        }finally{
            
        }
        
    }
}
