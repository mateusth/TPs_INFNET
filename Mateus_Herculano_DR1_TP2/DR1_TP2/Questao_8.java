package TP2;

import java.util.Scanner;

public class Questao_8 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Digite um lado do triangulo:  ");
        int lado1 = input.nextInt();
        System.out.print("Digite o segundo lado do triangulo:  ");
        int lado2 = input.nextInt();
        System.out.print("Digite o terceiro do triangulo:  ");
        int lado3 = input.nextInt();

        if(lado1 == lado2 && lado2 == lado3) {
            System.out.print("O triangulo é equilátero.");
        } else if(lado1 != lado2 && lado2 != lado3 && lado1 != lado3) {
            System.out.print("O triangulo é escaleno.");
        } else {
            System.out.print("O triangulo é isósceles.");
        }
    }
}
