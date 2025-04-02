namespace DR2_AT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Questao 1
            //Console.WriteLine("Olá, meu nome é Mateus!");
            //Console.WriteLine("Nasci em Fortaleza e estou aprendendo C#!");



            //Questao 2
            //Console.Write("Digite seu nome completo: ");
            //string nome = Console.ReadLine();
            //string nomeCripto;
            //for (int i = 0; i < nome.Length; i++)
            //{
            //    char letra = (char) (nome[i]+2);
            //    if (nome[i] == 'y')
            //    {
            //        letra = 'a';
            //    } else if (nome[i] == 'z') {
            //        letra = 'b';
            //    }
            //    else if (nome[i] == (char)32)
            //    {
            //        letra = ' ';
            //    }
            //    Console.Write(letra);
            // }



            ////Questao 3
            //Console.Write("Digite o primeiro algarismo: ");
            //int algarismo1 = int.Parse(Console.ReadLine());
            //Console.Write("Digite o segundo algarismo: ");
            //int algarismo2 = int.Parse(Console.ReadLine()); 
            //Console.WriteLine("Digite o numero da operacao que voce quer fazer:\n1- Soma\n2- Subtração\n3- Multiplicação\n4- Divisão");
            //int operacao = int.Parse(Console.ReadLine());
            //int resultado = 0;
            //string simbolo = "";
            //switch (operacao)
            //{
            //    case 1:
            //        resultado = algarismo1 + algarismo2;
            //        simbolo = " + ";
            //        Console.WriteLine("O resultado de " + algarismo1 + simbolo + algarismo2 + " é: " + resultado);
            //        break;
            //    case 2:
            //        resultado = algarismo1 - algarismo2;
            //        simbolo = " - ";
            //        Console.WriteLine("O resultado de " + algarismo1 + simbolo + algarismo2 + " é: " + resultado);
            //        break;
            //    case 3:
            //        resultado = algarismo1 * algarismo2;
            //        simbolo = " x ";
            //        Console.WriteLine("O resultado de " + algarismo1 + simbolo + algarismo2 + " é: " + resultado);
            //        break;
            //    case 4:
            //        if (algarismo2 == 0)
            //        {
            //            Console.WriteLine("Divisao por zero nao possivel");
            //        }
            //        else
            //        {
            //            resultado = algarismo1 / algarismo2;
            //            simbolo = " / ";
            //            Console.WriteLine("O resultado de " + algarismo1 + simbolo + algarismo2 + " é: " + resultado);
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("ENTRADA INVALIDA!");
            //        break;
            //}


            //Questao 4
            //DateTime dtNasc;
            //int dia, mes, ano, diasAniversario;
            //DateTime today = DateTime.Now;

            //Console.Write("Digite o dia de nascimento: ");
            //dia = int.Parse(Console.ReadLine());
            //Console.Write("Digite o mes de nascimento: ");
            //mes = int.Parse(Console.ReadLine());
            //Console.Write("Digite o ano de nascimento: ");
            //ano = int.Parse(Console.ReadLine());
            //dtNasc = new DateTime(ano, mes, dia);

            //DateTime aniversario = new DateTime(today.Year, mes, dia);
            //if (today > aniversario)
            //{
            //    aniversario = aniversario.AddYears(1);
            //}
            //diasAniversario = (aniversario - today).Days;
            //if (diasAniversario <= 7)
            //{
            //    Console.WriteLine("Obaa, seu aniversario esta chegando. Faltam apenas " + diasAniversario + " dias.");
            //}
            //else {
            //    Console.WriteLine("Faltam " + diasAniversario + " dias para seu aniversario.");
            //}



            //Questao 5
            //Console.WriteLine("Data de Formatura prevista: 15/12/2026");
            //DateTime dataFormatura = new DateTime(2026, 12, 15);
            //Console.Write("Digite a data atual (mes/dia/ano): ");
            //DateTime data = DateTime.Parse(Console.ReadLine());
            //DateTime today = DateTime.Now;
            //TimeSpan dif = dataFormatura - data;
            //int anos = dataFormatura.Year - today.Year;
            //int meses = dataFormatura.Month - today.Month;
            //int dias = dataFormatura.Day - today.Day;
            //if (dias < 0)
            //{
            //    dias += DateTime.DaysInMonth(today.Year, today.Month);
            //    meses--;
            //}
            //if (meses < 0)
            //{
            //    meses += 12;
            //    anos--;
            //}
            //if (data > today)
            //{
            //    Console.WriteLine("Erro: A data informada não pode ser no futuro!");
            //}
            //else if (dif < TimeSpan.Zero)
            //{
            //    Console.WriteLine("Parabéns! Você já deveria estar formado!");
            //}
            //else if (dif == TimeSpan.Zero)
            //{
            //    Console.WriteLine("Parabéns! Você está se formando hoje!");
            //}
            //else if (dif.Days < (6*30)) {
            //    Console.WriteLine($"Faltam {meses} meses e {dias} dias para sua formatura!");
            //    Console.WriteLine("A reta final chegou! Prepare-se para a formatura!");
            //} else
            //{
            //    Console.WriteLine($"Faltam {anos} anos, {meses} meses e {dias} dias para sua formatura!");
            //}



            //Questao 6
            //Aluno al = new Aluno();
            //al.nome = "Mateus";
            //al.matricula = 1234;
            //al.curso = "ADS";
            //al.mediaNotas = 9.5;
            //al.ExibirDados();
            //al.VerificarAprovacao();



            //Questao 7
            //ContaBancaria cb = new ContaBancaria();
            //cb.Titular = "Mateus";
            //cb.Depositar(2000);
            //cb.ExibirSaldo();
            //cb.Sacar(3000);
            //cb.ExibirSaldo();
            //cb.Sacar(1000);
            //cb.ExibirSaldo();



            //Questao 8
            //Funcionario ff = new Funcionario("Mateus", "Software Developer", 1000);
            //ff.exibirSalario();
            //Gerente gg = new Gerente("Nadja", "A.I Architect", 20000);
            //gg.exibirSalario();



            //Questao 9 -------------------------------------- CONSOLE
            //bool continua = true;
            //List<string> lista = new List<string>();
            //while (continua)
            //{
            //    Console.WriteLine("\nEscolha uma das opcoes a seguir:");
            //    Console.WriteLine("1. Inserir Produto");
            //    Console.WriteLine("2. Listar Produtos");
            //    Console.WriteLine("3. Sair");
            //    int opcao = int.Parse(Console.ReadLine());

            //    if (opcao == 1)
            //    {
            //        if (lista.Count == 5)
            //        {
            //            Console.WriteLine("Limite de produtos atingido!");
            //        }
            //        else
            //        {
            //            Console.Write("Digite o nome do produto: ");
            //            string produto = Console.ReadLine();
            //            Console.Write("Digite a quantidade: ");
            //            int quant = int.Parse(Console.ReadLine());
            //            Console.Write("Digite o preço ");
            //            double preco = double.Parse(Console.ReadLine());
            //            lista.Add($"Produto: {produto} | Quantidade: {quant} | Preço: R${preco}");
            //        }
            //    }
            //    else if (opcao == 2)
            //    {
            //        if (lista.Count == 0)
            //        {
            //            Console.WriteLine("Lista vazia.");
            //        }
            //        else
            //        {
            //            foreach (string li in lista)
            //            {
            //                Console.WriteLine(li);
            //            }
            //        }
            //    }
            //    else if (opcao == 3)
            //    {
            //        Console.WriteLine("FIM");
            //        continua = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Opcao invalida.");
            //    }
            //}

            //Questao 9-------------------------------------- ARQUIVO

            //string nomeArquivo = "estoque";
            //Arquivo a = new Arquivo(nomeArquivo);

            //while (true)
            //{
            //    Console.WriteLine("\nEscolha uma das opções a seguir:");
            //    Console.WriteLine("1. Inserir Produto");
            //    Console.WriteLine("2. Listar Produtos");
            //    Console.WriteLine("3. Sair");
            //    try
            //    {
            //        int opcao = int.Parse(Console.ReadLine());
            //        if (opcao == 1)
            //        {
            //            a.CriarAbreArquivo();
            //            Console.Write("Digite o nome do produto: ");
            //            string nome = Console.ReadLine();
            //            Console.Write("Digite a quantidade: ");
            //            int quantidade = int.Parse(Console.ReadLine());
            //            Console.Write("Digite o preço: ");
            //            double preco = double.Parse(Console.ReadLine());
            //            a.GravarMensagem($"Produto: {nome} | Quantidade: {quantidade} | Preço: R$ {preco}");
            //            Console.WriteLine("Produto inserido com sucesso!");
            //        }

            //        else if (opcao == 2)
            //        {
            //            try
            //            {
            //                if (File.Exists(nomeArquivo))
            //                {
            //                    Console.WriteLine("Nenhum produto cadastrado.");
            //                }
            //                else
            //                {
            //                    a.LerArquivo();
            //                }
            //            }
            //            catch (Exception e)
            //            {

            //                Console.WriteLine("Arquivo ainda nao criado: " + e.Message);
            //            }
            //        }
            //        else if (opcao == 3)
            //        {
            //            Console.WriteLine("FIM");
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Opcao invalida");
            //        }
            //    }
            //    catch (Exception e)
            //    {

            //        Console.WriteLine("Formato invalido: " + e.Message);
            //    }
            //}


            //Questao 10
            //int num = 0, tentativa = 1;
            //Random rand;
            //Console.Write("Tente adivinhar o numero de 1 a 50: ");
            //rand = new Random();
            //int aleat = rand.Next(1, 50);
            ////Console.WriteLine(aleat);
            //while (num != aleat && tentativa < 5)
            //{
            //    try
            //    {
            //        num = int.Parse(Console.ReadLine());

            //        if (num < 1 || num > 50)
            //        {
            //            throw new ArgumentOutOfRangeException("Número fora do intervalo! Digite um número entre 1 e 50");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Errou. Tente novamente: ");
            //        }
            //        tentativa++;
            //    }
            //    catch (ArgumentOutOfRangeException ex)
            //    {
            //        Console.WriteLine($"Erro: {ex.Message}");
            //    }

            //}
            //if (num == aleat)
            //{
            //    Console.WriteLine($"Parabens você acertou na tentativa {tentativa}. O número era: {aleat}.");
            //} else
            //{
            //    Console.WriteLine($"Voce perdeu. O número era: {aleat}.");
            //}





            //Questao 11

            //string nomeArquivo = "contatos";
            //Contatos a = new Contatos(nomeArquivo);

            //while (true)
            //{
            //    Console.WriteLine("\n=== Gerenciador de Contatos ===");
            //    Console.WriteLine("1 - Adicionar novo contato");
            //    Console.WriteLine("2 - Listar contatos cadastrados");
            //    Console.WriteLine("3 - Sair");
            //    try
            //    {
            //        int opcao = int.Parse(Console.ReadLine());
            //        if (opcao == 1)
            //        {
            //            a.CriarAbreArquivo();
            //            Console.Write("Digite o nome do contato: ");
            //            string nome = Console.ReadLine();
            //            Console.Write("Digite o telefone: ");
            //            string telefone = Console.ReadLine();
            //            Console.Write("Digite o email: ");
            //            string email = Console.ReadLine();
            //            a.GravarMensagem($"Nome: {nome} | Telefone: {telefone} | Email: {email}");
            //            Console.WriteLine("Contato inserido com sucesso!");
            //        }

            //        else if (opcao == 2)
            //        {
            //            try
            //            {
            //                if (File.Exists(nomeArquivo))
            //                {
            //                    Console.WriteLine("Nenhum contato cadastrado.");
            //                }
            //                else
            //                {
            //                    a.LerArquivo();
            //                }
            //            }
            //            catch (Exception e)
            //            {

            //                Console.WriteLine("Arquivo ainda nao criado: " + e.Message);
            //            }
            //        }
            //        else if (opcao == 3)
            //        {
            //            Console.WriteLine("Encerrando programa...");
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Opcao invalida");
            //        }
            //    }
            //    catch (Exception e)
            //    {

            //        Console.WriteLine("Formato invalido: " + e.Message);
            //    }
            //}



            //Questao 12

            string nomeArquivo = "contatosForm";
            Contato a = new Contato(nomeArquivo);
            MarkdownFormatter m = new MarkdownFormatter(nomeArquivo);
            TabelaFormatter t = new TabelaFormatter(nomeArquivo);
            RawTextFormatter r = new RawTextFormatter(nomeArquivo);

            while (true)
            {
                Console.WriteLine("\n=== Gerenciador de Contatos ===");
                Console.WriteLine("1 - Adicionar novo contato");
                Console.WriteLine("2 - Listar contatos cadastrados");
                Console.WriteLine("3 - Sair");
                try
                {
                    int opcao = int.Parse(Console.ReadLine());
                    if (opcao == 1)
                    {
                        a.CriarAbreArquivo();
                        Console.Write("Digite o nome do contato: ");
                        string nome = Console.ReadLine();
                        Console.Write("Digite o telefone: ");
                        string telefone = Console.ReadLine();
                        Console.Write("Digite o email: ");
                        string email = Console.ReadLine();
                        a.GravarMensagem($"{nome},{telefone},{email}");
                        Console.WriteLine("Contato inserido com sucesso!");
                    }

                    else if (opcao == 2)
                    {
                        try
                        {
                            Console.WriteLine("\n=== Qual formato de exibicao? ===");
                            Console.WriteLine("1 - Markdown");
                            Console.WriteLine("2 - Tabela");
                            Console.WriteLine("3 - Texto Puro");
                            int opcao2 = int.Parse(Console.ReadLine());
                            switch (opcao2)
                            {
                                case 1:
                                    m.ExibirContatos();
                                    break;
                                case 2:
                                    t.ExibirContatos();
                                    break;
                                case 3:
                                    r.ExibirContatos();
                                    break;
                                default:
                                    Console.WriteLine("Opcao invalida");
                                    break;
                            }
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine("Arquivo ainda nao criado: " + e.Message);
                        }
                    }
                    else if (opcao == 3)
                    {
                        Console.WriteLine("Encerrando programa...");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Opcao invalida");
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine("Formato invalido: " + e.Message);
                }
            }

        }

    }
}


using System;
using System.Collections.Generic;
using System.IO;

class Contato
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
}

abstract class ContatoFormatter
{
    public abstract void ExibirContatos(List<Contato> contatos);
}

class MarkdownFormatter : ContatoFormatter
{
    public override void ExibirContatos(List<Contato> contatos)
    {
        Console.WriteLine("## Lista de Contatos");
        foreach (var contato in contatos)
        {
            Console.WriteLine($"- **Nome:** {contato.Nome}");
            Console.WriteLine($"- 📞 Telefone: {contato.Telefone}");
            Console.WriteLine($"- 📧 Email: {contato.Email}\n");
        }
    }
}

class TabelaFormatter : ContatoFormatter
{
    public override void ExibirContatos(List<Contato> contatos)
    {
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("| Nome           | Telefone     | Email         |");
        Console.WriteLine("----------------------------------------");
        foreach (var contato in contatos)
        {
            Console.WriteLine($"| {contato.Nome,-15} | {contato.Telefone,-12} | {contato.Email,-15} |");
        }
        Console.WriteLine("----------------------------------------");
    }
}

class RawTextFormatter : ContatoFormatter
{
    public override void ExibirContatos(List<Contato> contatos)
    {
        foreach (var contato in contatos)
        {
            Console.WriteLine($"Nome: {contato.Nome} | Telefone: {contato.Telefone} | Email: {contato.Email}");
        }
    }
}
/*
class Program
{
    static void Main()
    {
        List<Contato> contatos = LerContatos();

        Console.WriteLine("Escolha o formato de exibição:");
        Console.WriteLine("1️⃣ Markdown");
        Console.WriteLine("2️⃣ Tabela");
        Console.WriteLine("3️⃣ Texto Puro");
        string escolha = Console.ReadLine();

        ContatoFormatter formatter = escolha switch
        {
            "1" => new MarkdownFormatter(),
            "2" => new TabelaFormatter(),
            "3" => new RawTextFormatter(),
            _ => null
        };

        if (formatter != null)
        {
            formatter.ExibirContatos(contatos);
        }
        else
        {
            Console.WriteLine("Opção inválida.");
        }

        Console.WriteLine("Deseja cadastrar um novo contato? (s/n)");
        string cadastrar = Console.ReadLine();
        if (cadastrar?.ToLower() == "s")
        {
            Contato novoContato = new Contato();
            Console.Write("Nome: ");
            novoContato.Nome = Console.ReadLine();
            Console.Write("Telefone: ");
            novoContato.Telefone = Console.ReadLine();
            Console.Write("Email: ");
            novoContato.Email = Console.ReadLine();

            contatos.Add(novoContato);
            SalvarContatos(contatos);
        }
    }

    static List<Contato> LerContatos()
    {
        var contatos = new List<Contato>();
        if (File.Exists("contatos.txt"))
        {
            foreach (var linha in File.ReadLines("contatos.txt"))
            {
                var partes = linha.Split('|');
                contatos.Add(new Contato { Nome = partes[0], Telefone = partes[1], Email = partes[2] });
            }
        }
        return contatos;
    }

    static void SalvarContatos(List<Contato> contatos)
    {
        using (var writer = new StreamWriter("contatos.txt"))
        {
            foreach (var contato in contatos)
            {
                writer.WriteLine($"{contato.Nome}|{contato.Telefone}|{contato.Email}");
            }
        }
    }
}