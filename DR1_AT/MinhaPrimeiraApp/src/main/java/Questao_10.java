import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.util.Scanner;

public class Questao_10 {

    static class Compras {
        String produto;
        int quant;
        double preco;

        public Compras(String produto, int quant, double preco) {
            this.produto = produto;
            this.quant = quant;
            this.preco = preco;
        }

        @Override
        public String toString() {
            return "Produto: " + produto + ". Quantidade: " + quant + ". Preço: R$" + preco;
        }
    }

    public static void main(String[] args) throws IOException {
        Scanner input = new Scanner(System.in);
        System.out.print("Cadastre o primeiro produto: ");
        String produto1 = input.nextLine();
        System.out.print("Digite quantas unidades do primeiro produto: ");
        int quantidade1 = input.nextInt();
        System.out.print("Digite o preço do primeiro produto: ");
        double preco1 = input.nextDouble();
        input.nextLine();
        Compras c1 = new Compras(produto1, quantidade1, preco1);

        System.out.print("Cadastre o segundo produto: ");
        String produto2 = input.nextLine();
        System.out.print("Digite quantas unidades do segundo produto: ");
        int quantidade2 = input.nextInt();
        System.out.print("Digite o preço do segundo produto: ");
        double preco2 = input.nextDouble();
        input.nextLine();
        Compras c2 = new Compras(produto2, quantidade2, preco2);

        System.out.print("Cadastre o terceiro produto: ");
        String produto3 = input.nextLine();
        System.out.print("Digite quantas unidades do terceiro produto: ");
        int quantidade3 = input.nextInt();
        System.out.print("Digite o preço do terceiro produto: ");
        double preco3 = input.nextDouble();
        input.nextLine();
        Compras c3 = new Compras(produto3, quantidade3, preco3);

        try (FileWriter arquivo = new FileWriter("compras.txt")) {
            System.out.println("Arquivo Criado.");
            arquivo.write(c1.toString() + "\n");
            arquivo.write(c2.toString() + "\n");
            arquivo.write(c3.toString() + "\n");
            System.out.println("Arquivo modificado.");
        } catch (IOException e) {
            System.out.println("Erro: nao consegui escrever no arquivo");
        }

        Scanner fileReader = new Scanner(new File("compras.txt"));
            while (fileReader.hasNextLine()) {
                System.out.println(fileReader.nextLine());
            }
            fileReader.close();
}
}

