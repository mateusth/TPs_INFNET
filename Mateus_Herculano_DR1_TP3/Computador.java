package DR1_TP3;

public class Computador {           //Criacao da classe Computador
    public String marca;            //Criacao de atributos marca, modelo e ano de Fabricacao
    public String modelo;
    public int anoFrabricacao;

    public void ExibirInformacoes() {
        System.out.println("Marca: " + marca + ".\nModelo: " + modelo + ".\nAno de Fabricacao: " + anoFrabricacao + ".\n");
    }

//    public static void main(String[] args) {
//        Computador c1 = new Computador();
//        c1.marca = "Asus";
//        c1.modelo = "As222";
//        c1.anoFrabricacao = 1999;
//        c1.ExibirInformacoes();
//    }
}