import java.util.Scanner;

public class Tabuada {
    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);

        System.out.println("Digite um numero para ser feito a tabuada: ");
        int num = entrada.nextInt();

        for (int i = 1; i <= 10; i++) {
            System.out.println(num + " x " + i + " = " + (num * i ));
            
        }

    }
    
}
