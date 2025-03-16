using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DR2_TP3
{
    internal class Ingresso
    {
        public string nomeDoShow;
        public double preco;
        public int quantidadeDisponivel;

        public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel)
        {
            this.nomeDoShow = nomeDoShow;
            this.preco = preco;
            this.quantidadeDisponivel = quantidadeDisponivel;
        }

        //Os atributos sao bem genericos permitindo a classe ser usada para varios shows diferentes.
        //nomeDoShow, preco e quantidadeDisponivel pode ser usada para o show do Michael Jackson como tambem para o de Anitta sem precisar mudar nada.
        public void AlterarPreco(double novoPreco)
        {
            preco = novoPreco;
        }
        public void AlterarQuantidade(int novaQtd)
        {
            quantidadeDisponivel = novaQtd;
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine("Show: " + nomeDoShow + ". Preço: " + preco + ". Quantidade de Ingressos: " + quantidadeDisponivel);
        }

        public void GetNomeDoShow() { Console.WriteLine("Show: " + nomeDoShow); }
        public void SetNomeDoShow(string novoNome) { nomeDoShow = novoNome; }
        public void GetPreco() { Console.WriteLine("Preço: " + preco); }
        public void SetPreco(double novoPreco) { preco = novoPreco; }
        public void GetQuantidadeDisponivel() { Console.WriteLine("Quantidade de Ingressos: " + quantidadeDisponivel); }
        public void SetQuantidadeDisponivel(int novaQtd) { quantidadeDisponivel = novaQtd; }


    }

    }
