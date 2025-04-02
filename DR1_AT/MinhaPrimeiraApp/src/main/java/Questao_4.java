import java.util.Scanner;

public class Questao_4 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Digite seu nome:  ");
        String nome = input.nextLine();
        System.out.print("Digite o valor do emprestimo:  ");
        double emprestimo = input.nextDouble();
        System.out.print("Em quantas parcelas voce deseja liquidar o valor? Entre 6 e 48 meses: ");
        int parcelas = input.nextInt();
        boolean continua = true;
        while(continua) {
            if (parcelas >= 6 && parcelas <= 48) {
                System.out.printf("Ola %s. Valor da parcela: %.2f. Valor total: R$%.2f.", nome, (emprestimo * 1.03 / parcelas), emprestimo * 1.03);
                continua = false;
            } else {
                System.out.print("Numero de parcelas invalido. Escolha entre 6 e 48 meses:");
                parcelas = input.nextInt();
            }
        }
    }
}
