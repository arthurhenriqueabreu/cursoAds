import java.util.InputMismatchException;

public class HelloWorld {
    public static void main(String[] args) {
        System.out.println("Olá, Mundo!");
        //System.out.println("Erro: " + (7/0));
        try {
            System.out.println("Erro: " + (7/0));
        } catch (InputMismatchException e) {
            System.out.println("Exceção capturada: " + e.getMessage());
        } catch (ArithmeticException e) {
            System.out.println("Exceção capturada: " + e.getMessage());
        }
        

        System.out.println("Continua o código");
    }
}
