package TP2;

import java.util.Scanner;

public class Questao_5 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Digite o valor da compra:  ");
        int valor = input.nextInt();
        double valorFinal;
        String desconto;
        if(valor > 1000) {
            desconto = "10%";
            valorFinal = valor * .9;
        } else if (valor > 500) {
            desconto = "5%";
            valorFinal = valor * .5;
        } else {
            desconto = "0%";
            valorFinal = valor;
        }
        System.out.println("Valor do produto: " + valor + ". Desconto: " + desconto + ". Valor final: " + valorFinal + ".");
    }
}
