package DR1_TP3;

public class Produto {
    public String nome;
    public Double preco;
    public int quantidadeEmEstoque;

    public Produto(String nome, Double preco, int quantidadeEmEstoque) {
        this.nome = nome;
        this.preco = preco;
        this.quantidadeEmEstoque = quantidadeEmEstoque;
    }

    public void alterarPreco (double novoPreco) {
        if(novoPreco > 0) {
            preco = novoPreco;
        }
    }
    public void alterarQuantidade  (int novaQuantidade) {
        if(novaQuantidade >= 0) {
            quantidadeEmEstoque = novaQuantidade;
        }
    }
    public void exibirInformacoes() {
        System.out.println("Produto: " + nome + ".\nPreço: " + preco + ".\nQuantidade em estoque: " + quantidadeEmEstoque + ".\n");
    }


    public String getNome() {
        return nome;
    }

    public void setNome(String novoNome) {
        this.nome = novoNome;
    }

    public Double getPreco() {
        return preco;
    }

    public void setPreco(Double novoPreco) {
        this.preco = novoPreco;
    }

    public int getQuantidadeEmEstoque() {
        return quantidadeEmEstoque;
    }

    public void setQuantidadeEmEstoque(int novaQuantidade) {
        this.quantidadeEmEstoque = novaQuantidade;
    }
}
