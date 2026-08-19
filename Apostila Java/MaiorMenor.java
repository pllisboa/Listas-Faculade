public class MaiorMenor {
    public static void main(String[] args) {
        int[] numeros = {15,8,32,4,21,17};

        int maior = numeros[0];
        int menor = numeros[0];

        for (int i =1; i <numeros.length;i++){
            if(numeros[i]>maior){
                maior = numeros[i];
            }

            if(numeros[i]<menor){
                menor = numeros[i];
            }
        }

        System.out.println("O maior numero do vetor é "+maior+" e o menor é "+menor);
    }
    
}
