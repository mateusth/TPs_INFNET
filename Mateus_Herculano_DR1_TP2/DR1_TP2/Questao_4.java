package TP2;

import java.time.LocalDate;
import java.time.temporal.ChronoUnit;
import java.util.Scanner;

public class Questao_4 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Digite o dia que voce nasceu ");
        int dia = input.nextInt();
        System.out.print("Digite o numero do mes que voce nasceu ");
        int mes = input.nextInt();
        System.out.print("Digite o ano que voce nasceu ");
        int ano = input.nextInt();

        LocalDate dataNascimento = LocalDate.of(ano, mes, dia);
        LocalDate hoje = LocalDate.now();
        long total = ChronoUnit.DAYS.between(dataNascimento, hoje);

        System.out.println("Voce nasceu em: " + dia + "/" + mes + "/" + ano + ". Hà " + total + " dias.");
        }
    }