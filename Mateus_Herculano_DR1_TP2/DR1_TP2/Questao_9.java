package TP2;

import java.util.Objects;
import java.util.Scanner;

public class Questao_9 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Digite uma senha para cadastrar: ");
        String senha = input.nextLine();
        System.out.print("Digite novamente a sua senha para confirmar: ");
        String senha2 = input.nextLine();
        if (Objects.equals(senha, senha2)) {
            System.out.println("Senha cadastrada com sucesso.");
        } else {
            while (!Objects.equals(senha, senha2)) {
                System.out.print("Senha digitada nao corresponde à senha criada. Tente novamente: ");
                senha2 = input.nextLine();
            }
            System.out.println("Senha cadastrada com sucesso.");
        }
    }
}
