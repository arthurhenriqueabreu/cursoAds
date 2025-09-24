
import java.util.Scanner;

public class quaseTudoGostoso {
    public static void main(String[] args) {
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
                               |4. Listar y           |\r
                               +----------------------+"""
            );
                                escolha = sc.nextInt();
        }while(escolha !=6);
        switch (escolha) {
            case 1:
                System.out.println();
                break;
        }
    }
}