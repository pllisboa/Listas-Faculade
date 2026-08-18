import java.util.Scanner;

public class Aprovado {
    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);
        
        System.out.println("Digite o valor da nota: ");
        int nota = entrada.nextInt();

        if (nota >= 6){
            System.out.println("Aprovado");
        }

        else {
            System.out.println("Reprovado");
        }

        entrada.close();
    }
    
}
