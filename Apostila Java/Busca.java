import java.util.Scanner;

public class Busca {
    public static void main(String[] args) {

        int[]numeros = {10,25,7,40,18,30};
        Scanner entrada = new Scanner(System.in);

        System.out.println("Digite um numero para procurar no vetor");
        int num = entrada.nextInt();

        boolean achou = false;

        for (int i = 0; i <numeros.length; i++) {
            if(num == numeros[i]){
                System.out.println("Numero encontrado no vetor");
                achou = true;
                break;
            }
        }

        if (!achou){
                System.out.println("Numero nao encontrado no vetor");
            }


        entrada.close();
        
    }
    
}
