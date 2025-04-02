import java.util.ArrayList;
import java.util.List;
import java.util.Random;
import java.util.Scanner;

public class Questao_11 {
    public static void main(String[] args) {
        Random aleatorios = new Random();
        List<Integer> loteria = new ArrayList<>();
        int acertos = 0;
        for (int i = 0; i < 6; i++) {
            int numero = aleatorios.nextInt(60)+1;
            if (!loteria.contains(numero)) {
                loteria.add(numero);
            }
            System.out.println(numero);
        }

        Scanner input = new Scanner(System.in);
        for (int i = 1; i < 7; i++) {
            System.out.print("Digite um numero entre 1 e 60 (tentativa " + i + "): ");
            int tentativa = input.nextInt();
            while(tentativa < 1 || tentativa > 60) {
                    System.out.println("numero nao esta no intervalo. Digite outro numero");
                    tentativa = input.nextInt();
            }
            if (loteria.contains(tentativa)) {
                acertos++;
                System.out.println("Voce acertou o numero " + tentativa);
            }
        }
        System.out.println("Seu resultado: " + acertos + " acertos.");
    }
}
