package TP2;

import java.util.Scanner;

public class Questao_10  {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Digite um número entre 1 e 100: ");
        int num = input.nextInt();
        int tentativaBaixa = 1, tentativaAlta = 100;
        int randomNum = (int)(Math.random() * 100 + 1);
        int aleat = randomNum;
        while (num != aleat) {
            if (num > aleat) {
                tentativaAlta = num;
                System.out.println("O número escondido é menor. Está entre " + tentativaBaixa + " e " + tentativaAlta + ". Tente novamente: ");
            } else {
                tentativaBaixa = num;
                System.out.println("O número escondido é maior. Está entre " + tentativaBaixa + " e " + tentativaAlta + ". Tente novamente: ");
            }
            num = input.nextInt();
        }
        System.out.println("Parabens você acertou. O número era: " + aleat);

    }
}
