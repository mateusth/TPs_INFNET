package TP2;

import java.util.Scanner;

public class Questao_1 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Digite seu nome: ");
        String nome = input.nextLine();
        System.out.print("Digite seu sobrenome: ");
        String sobrenome = input.nextLine();
        System.out.print("Digite a sua idade: ");
        int idade = input.nextInt();
        input.nextLine();
        System.out.print("Digite o nome da sua mae: ");
        String mae = input.nextLine();
        System.out.print("Digite o nome do seu pai: ");
        String pai = input.nextLine();
        System.out.println("Seu nome completo é: " + nome + " " + sobrenome + ". Sua idade: " + idade + ". O nome da sua mãe: " + mae + ". O nome do seu pai: " + pai);
        String maior = nome;
        if (pai.length() > mae.length() && pai.length() > maior.length()) {
                maior = pai;
            } else if (mae.length() > pai.length() && mae.length() > maior.length()) {
                maior = maior;
        }
        System.out.println("O mais longo nome é: " + maior + ".");
    }
}