
import java.util.ArrayList;
import java.util.Scanner;

public class QuaseTudoGostoso {
    public static void main(String[] args) {
        ArrayList<Receita> receitas = new ArrayList<>();
        int escolha = 0;
        Scanner sc = new Scanner(System.in);
        do{
            System.out.println("""
                               +----------------------+\r
                               |       Quase tudo     |\r
                               |         Gostoso      |\r
                               |----------------------|\r
                               |1. Adicionar Receita  |\r
                               |----------------------|\r
                               |2. Listar Receitas    |\r
                               |----------------------|\r
                               |3. Editar receita     |\r
                               |----------------------|\r
                               |4. Sair               |\r
                               +----------------------+"""
            );
            escolha = sc.nextInt();
            sc.nextLine();

            switch (escolha) {
                case 1:
                    String titulo;
                    int idReceita;
                    System.out.println("Define o título da receita: ");
                    titulo = sc.nextLine();
                    
                    break;
                case 2:
                    System.out.println("\n=== Lista de Receitas ===");
                    
                    break;
                case 4:
                    System.out.println("Até logo!");
                    break;
            }
        }while(escolha !=4);
    }
}