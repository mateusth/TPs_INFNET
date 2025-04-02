import java.util.Scanner;

public class Questao_2 {
    public static void main(String[] args) {
        boolean maiuscula = false;
        boolean numero = false;
        boolean caracEspec = false;

        Scanner input = new Scanner(System.in);
        System.out.print("Digite seu nome: ");
        String nome = input.nextLine();
        System.out.println("Digite sua senha: (Minimo: uma letra maiúscula, um número e um caractere especial (@, #, $, etc.)");
        String senha = input.nextLine();

        try {
            if (senha.length() < 8) {
                throw new Exception("A senha deve ter pelo menos 8 caracteres.");
            }
            for (char c : senha.toCharArray()) {
                if (Character.isUpperCase(c)) {
                    maiuscula = true;
                } else if (Character.isDigit(c)) {
                    numero = true;
                } else if ("@#$%&*!".contains(String.valueOf(c))) {
                    caracEspec = true;
                }
            }

            if (!maiuscula) {
                throw new Exception("A senha digitada nao tem letra maiúscula.");
            }
            if (!numero) {
                throw new Exception("A senha digitada nao tem numero.");
            }
            if (!caracEspec) {
                throw new Exception("A senha digitada nao tem caractere especial.");
            }

            System.out.println("Senha gravada com sucesso.");
        } catch (Exception e) {
            System.out.println("Erro: " + e.getMessage());
        }
    }
}

