package ListaExercicios1.Exercicios;

import java.util.Scanner;

public class Exercicio04 {
    // ENUNCIADO 4. Crie um programa que receba o valor do salário em horas e a quantidade de horas trabalhadas em uma semana, imprimindo em tela o valor a ser recebido pelo funcionário. Caso a jornada seja maior que 40 horas o excedente deverá ser pago com acréscimo de 50%.
    public static void main(String[]args){
            double valorSalarioHora, salarioMensal, salarioSemanal;
            int horasTrabalhadas;
            Scanner sc = new Scanner(System.in);
        try{
            System.out.println("Digite o valor do salário por hora: ");
            valorSalarioHora = sc.nextDouble();
            System.out.println("Digite a quantia de horas trabalhadas na semana: ");
            horasTrabalhadas = sc.nextInt();
            if(horasTrabalhadas>40){
                salarioSemanal = (((horasTrabalhadas - 40)*1.5)+horasTrabalhadas) * valorSalarioHora;
                salarioMensal = salarioSemanal * 4;
            }else{
                salarioSemanal = horasTrabalhadas * valorSalarioHora;
                salarioMensal = salarioSemanal * 4;
            }
            System.out.println("Valor salário hora: "+ valorSalarioHora);
            System.out.println("Valor salário semanal: "+ salarioSemanal);
            System.out.println("Valor salário mensal: "+ salarioMensal);
        }catch(Exception e){
            System.out.println("Valor inválido!");
        }finally{
            sc.close();
        }
    }
}
