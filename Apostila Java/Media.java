import java.util.Scanner;

public class Media {
    public static void main(String[] args) {

        Scanner entrada = new Scanner(System.in);

        System.out.println("Digite o valor da primeira nota: ");
        double n1 = entrada.nextDouble();

        System.out.println("Digite o valor da segunda nota: ");
        double n2 = entrada.nextDouble();

        System.out.println("Digite o valor da terceira nota: ");
        double n3 = entrada.nextDouble();

        double media = (n1 + n2+ n3) / 3;

        System.out.println("A media das 3 notas é = " + media);

        entrada.close();
 
    }
    
}
