package TP2;

import java.util.Scanner;

public class Questao_3 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Digite o quanto voce quer converter: ");
        float valor = input.nextFloat();
        System.out.println("Digite:\n1 = dolar (1 dolar = 5,80 reais)\n2 = euro (1 euro = 6 reais)\n3 = libra (1 libra = 7,20 reais)");
        int moeda = input.nextInt();
        float reais;
        switch (moeda) {
            case 1:
                reais = valor * 5.8f;
                System.out.printf("%.2f sera convertido para dolar, resultando em: %.2f reais.", valor, reais);
                break;
            case 2:
                reais = valor * 6;
                System.out.printf("%.2f sera convertido para euro, resultando em: %.2f reais.", valor, reais);
                break;
            case 3:
                reais = valor * 7.2f;
                System.out.printf("%.2f sera convertido para libras, resultando em: %.2f reais.", valor, reais);
                break;
            default:
                System.out.println("Entrada invalida");
        }
    }
}