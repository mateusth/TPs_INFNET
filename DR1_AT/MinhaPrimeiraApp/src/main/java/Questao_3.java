import java.util.Scanner;

public class Questao_3 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Digite seu nome:  ");
        String nome = input.nextLine();
        System.out.print("Digite seu salário bruto mensal:  ");
        double salarioBrutoAnual = input.nextDouble() * 12;
        double salarioFinal;
        double impostoPagar = 0;
        if (salarioBrutoAnual <= 22847.76) {
            salarioFinal = salarioBrutoAnual;
        } else if(salarioBrutoAnual <= 33919.80) {
            impostoPagar = salarioBrutoAnual * .075;
            salarioFinal = salarioBrutoAnual - impostoPagar;
        } else if (salarioBrutoAnual <= 45012.60) {
            impostoPagar = salarioBrutoAnual * .15;
            salarioFinal = salarioBrutoAnual - impostoPagar;
        } else {
            impostoPagar = salarioBrutoAnual * .275;
            salarioFinal = salarioBrutoAnual - impostoPagar;
        }
        System.out.printf("Ola %.2s, Salário bruto: %.2f. Imposto à pagar: %.2f. Salário liquido: %.2f.",nome, salarioBrutoAnual, impostoPagar, salarioFinal);
    }
}