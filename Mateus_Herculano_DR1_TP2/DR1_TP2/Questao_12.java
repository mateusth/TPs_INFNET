package TP2;

import java.util.Scanner;

public class Questao_12  {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.println("Digite uma frase: ");
        String frase = input.nextLine();
        int quant = frase.split(" ").length;
        System.out.println("A frase \"" + frase + "\" contem " + quant + " palavras.");
    }
}

