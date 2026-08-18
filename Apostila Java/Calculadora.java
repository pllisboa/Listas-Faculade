import java.util.Scanner;

public class Calculadora {
    public static void main(String[] args) {

        Scanner entrada = new Scanner(System.in);

        System.out.println("Digite o primeiro numero: ");
        int num1 = entrada.nextInt();

        System.out.println("Digite o segundo numero: ");
        int num2 = entrada.nextInt();

        int soma = num1 + num2;
        int subt= num1 - num2;
        int mult= num1 * num2;
        int divi = num1 / num2;

        System.out.println("Soma = " + soma);
        System.out.println("Subtração = " + subt);
        System.out.println("Multiplicação = " + mult);
        System.out.println("Divisão = " + divi);

        entrada.close();
    }
    
}
