package TP2;

import java.util.Scanner;

public class Questao_2 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Digite a nota 1: ");
        float nota1 = input.nextFloat();
        System.out.print("Digite a nota 2: ");
        float nota2 = input.nextFloat();
        System.out.print("Digite a nota 3: ");
        float nota3 = input.nextFloat();
        System.out.print("Digite a nota 4: ");
        float nota4 = input.nextFloat();
        float media = (nota1 + nota2 + nota3 + nota4)/4;

        if(media >= 7) {
            System.out.println("Voce esta aprovado. Media = " + media + ".");
        } else if ( media >=5) {
            System.out.println("Voce esta de recuperacao. Media = " + media + ".");
        } else {
            System.out.println("Voce esta reprovado. Media = " + media + ".");
        }
    }
}
