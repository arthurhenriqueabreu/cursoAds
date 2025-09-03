package Java.Avaliacao1;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.nio.file.Files;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

public class Avaliacao {
    public static void main(String[]args){
        try{
            //Variáveis
            int[] vet = {8, 9, 3, 5, 1};            
            int aux = 0;
            //String diretorioValoresTxt;

            //Transformar bloco de notas em array (Ainda em desenvolvimento)
            /*System.out.println("Digite o caminho do arquivo .txt a ser lido: ");
            Scanner sc = new Scanner(System.in);
            diretorioValoresTxt = sc.nextLine();
            List<String> linhasDoArquivo = new ArrayList<>();
            List<Integer> valores = new ArrayList<>();
            

            System.out.println("Avaliação de Orientação a objetos | Ordenação de valores");

            try{
                            Scanner scanner = new Scanner(new File(diretorioValoresTxt));

                            // enquanto houver números no arquivo, adiciona no List
                            while (scanner.hasNextInt()) {
                                valores.add(scanner.nextInt());
                            }
            }catch(FileNotFoundException el){
                System.out.println("Arquivo para leitura não encontrado!");
            }catch(IOException e){
                System.err.println("Erro ao ler o arquivo: " + e.getMessage());
                e.printStackTrace();
                return;
            }*/
            
            //Exibe o vetor organizado com uso de Collection
            System.out.println("Vetor em forma de List(Collections):");
            // cria uma lista com os mesmos elementos do array
            List<Integer> vetorList = new ArrayList<>();
            for (int n : vet) {
                vetorList.add(n);
            }

            // ordena a lista
            Collections.sort(vetorList);

            System.out.println("Collection ordenada: " + vetorList);
            
            //Só exibe o vetor
            System.out.println("Vetor desordenado: ");
            for(int i = 0; i<5; i++){
                System.out.println(" "+vet[i]);
            }
            System.out.println(" ");
            
            for(int i = 0; i<5; i++){
                for(int j = 0; j<4; j++){
                    if(vet[j] > vet[j + 1]){
                        aux = vet[j];
                        vet[j] = vet[j+1];
                        vet[j+1] = aux;
                    }
                }
            }
            System.out.println("Vetor organizado:");
            for(int i = 0; i<5; i++){
                System.out.println(" "+vet[i]);
            }
            

        }catch(Exception e){
            System.out.println("Erro");
        }finally{
            System.out.println("Fim!");
        }
    }
}
