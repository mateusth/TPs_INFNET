package TP2;

import java.util.Scanner;

public class Questao_7 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Digite seu salário bruto anual:  ");
        double salarioB = input.nextDouble();
        double salarioFinal, impostoPagar;
        String imposto;
        if (salarioB >= 15000) {
            imposto = "45%";
            impostoPagar = salarioB * .45;
            salarioFinal = salarioB - impostoPagar;
        } else if(salarioB >= 10000) {
            imposto = "40%";
            impostoPagar = salarioB * .4;
            salarioFinal = salarioB - impostoPagar;
        } else if (salarioB >= 5000) {
            imposto = "35%";
            impostoPagar = salarioB * .35;
            salarioFinal = salarioB - impostoPagar;
        } else {
            imposto = "30%";
            impostoPagar = salarioB * .3;
            salarioFinal = salarioB - impostoPagar;
        }
        System.out.printf("Salário bruto: %.2f. Zona de imposto de %s. Imposto à pagar: %.2f. Salário final: %.2f.",salarioB, imposto, impostoPagar, salarioFinal );
    }
}