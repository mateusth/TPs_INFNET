package TP2;

import java.util.Scanner;

public class Questao_11  {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Digite um valor inicial de 0 a 100: ");
        int num = input.nextInt();
        System.out.print("Digite o incremento maior que 0: ");
        int incremento = input.nextInt();
        while (num<100) {
            System.out.print(num + ", ");
            num = num + incremento;
        }            System.out.print(num + ".");

    }
}
