public class Questao_6 {
    static class Veiculo {
        String placa;
        String modelo;
        int anoDeFabricacao;
        double quilometragem;
        public void exibirDetalhes() {
            System.out.printf("Placa: %s. Modelo: %s. Ano de Fabricacao: %d. Quilometragem: %.2fKm\n", placa,modelo, anoDeFabricacao, quilometragem);
        }
        public void registrarViagem(double km) {
            quilometragem += km;
        }
    }
    public static void main(String[] args) {
        Veiculo v1 = new Veiculo();
        v1.placa = "H1234QQ";
        v1.modelo = "Corolla";
        v1.anoDeFabricacao = 1995;
        v1.quilometragem = 150000.50;
        v1.exibirDetalhes();
        v1.registrarViagem(1000);
        v1.exibirDetalhes();

        Veiculo v2 = new Veiculo();
        v2.placa = "G2334HH";
        v2.modelo = "Civic";
        v2.anoDeFabricacao = 2005;
        v2.quilometragem = 10000.80;
        v2.exibirDetalhes();
        v2.registrarViagem(2000);
        v2.exibirDetalhes();
    }
}
