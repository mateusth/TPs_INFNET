namespace DR2_TP2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////Questao 1 à 3
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

            //int idadeAnos = today.Year - dtNasc.Year;
            //int idadeMeses = today.Month - dtNasc.Month*idadeAnos*12;
            //int idadeDias = (today - dtNasc).Days;

            ////Console.WriteLine("Data de nascimento: " + dtNasc.Date);
            ////Console.WriteLine("Idade em anos: " + idadeAnos);
            ////Console.WriteLine("Idade em meses: " + idadeMeses);
            ////Console.WriteLine("Idade em dias: " + idadeDias);


            //DateTime aniversario = new DateTime(today.Year, mes, dia);

            //if (today > aniversario) {
            //    aniversario = aniversario.AddYears(1);
            //}

            //diasAniversario = (aniversario - today).Days;
            //Console.WriteLine("Faltam " + diasAniversario + " dias para seu aniversario.");



            //Questao 3
            Console.Write("Digite a primeira data (formato: yyyy-MM-dd): ");
            DateTime data1 = DateTime.Parse(Console.ReadLine());

            Console.Write("Digite a segunda data (formato: yyyy-MM-dd): ");
            DateTime data2 = DateTime.Parse(Console.ReadLine());

            TimeSpan dif = data2 - data1;

            int dias = dif.Days;
            int meses = dif.Days/30;
            int anos = Math.Abs(data2.Year - data1.Year);

            Console.WriteLine($"Diferença: {anos} anos ou {meses} meses ou {dias} dias");


            //Questao 4
            //String nome, email;
            //int idade, tel;
            //Console.Write("Digite seu nome: ");
            //nome = Console.ReadLine();
            //Console.Write("Digite sua idade: ");
            //idade = int.Parse(Console.ReadLine());
            //Console.Write("Digite seu telefone: ");
            //tel = int.Parse(Console.ReadLine());
            //Console.Write("Digite seu email: ");
            //email = Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine("Seu nome: " + nome);
            //Console.WriteLine("Sua idade: " + idade);
            //Console.WriteLine("Seu telefone: " + tel);
            //Console.WriteLine("Seu email: " + email);

            //Questao 5
            //double tempC, tempF, tempK;
            //Console.Write("Digite a temperatura em Celsius: ");
            //tempC = double.Parse(Console.ReadLine());
            //tempF = tempC * 9 / 5 + 32;
            //tempK = tempC + 273.15;
            //Console.WriteLine(tempC + "C em Fahrenheit é: " + tempF + ". E em Kelvin é: " + tempK);

            //Questao 6
            //double peso, altura, IMC;
            //Console.Write("Digite sua altura em cm: ");
            //altura = double.Parse(Console.ReadLine())/100;
            //Console.Write("Digite seu peso em kg: ");
            //peso = double.Parse(Console.ReadLine());
            //IMC = peso/altura/altura;
            //Console.WriteLine(".Seu IMC é: " + IMC.ToString("F2"));

            //Questao 7
            //int num;
            //String paridade;
            //Console.Write("Digite um numero inteiro  paa saber se é par ou impar: ");
            //num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    paridade = "par";
            //} else {
            //    paridade = "impar";
            //}
            //Console.WriteLine("O numero " + num + " é " + paridade);

            //Questao 8
            //double nota;
            //String classifica;
            //Console.Write("Digite sua nota de 0 à 10: ");
            //nota = double.Parse(Console.ReadLine());
            //if (nota >= 9)
            //{
            //    classifica = "Excelente";
            //}
            //else if (nota >= 8)
            //{
            //    classifica = "Bom";
            //}
            //else if (nota >= 7)
            //{
            //    classifica = "Regular";
            //}
            //else
            //{
            //    classifica = "Insuficiente";
            //}
            //Console.WriteLine("A sua nota foi " + nota + " que é " + classifica);

            //Questao 9
            //double salarioB, salarioL, imposto;
            //Console.Write("Digite seu salario bruto: ");
            //salarioB = double.Parse(Console.ReadLine());

            //if (salarioB >= 10000)
            //{
            //    salarioL = salarioB*.65;
            //}
            //else if (salarioB >= 7000)
            //{
            //    salarioL = salarioB * .7;
            //}
            //else if (salarioB >= 5000)
            //{
            //    salarioL = salarioB * .75;
            //}
            //else
            //{
            //    salarioL = salarioB * .8;
            //}
            //Console.WriteLine("Seu salario Bruto: " + salarioB);
            //Console.WriteLine("Descontos no salario: " + (salarioB - salarioL));
            //Console.WriteLine("Seu salario Liquido: " + salarioL);

            //Questao 10
            //int num;
            //Console.Write("Digite um numero: ");
            //num = int.Parse(Console.ReadLine());

            //for (;num>=0; num--)
            //{
            //    Console.WriteLine(num);
            //}

            //Questao 11
            //int num, i;
            //Console.Write("Digite um numero para saber a tabuada: ");
            //num = int.Parse(Console.ReadLine());
            //for (i=1; i <= 10; i++)
            //{
            //    Console.WriteLine(num + " x " + i + " = " + num*i);
            //}

            //Questao 12
            //int num, tentativaBaixa = 1, tentativaAlta = 100;
            //Random rand;
            //Console.Write("Tente adivinhar o numero de 1 a 100: ");
            //num = int.Parse(Console.ReadLine());
            //rand = new Random();
            //int aleat = rand.Next(1,100);
            ////Console.WriteLine(aleat);
            //while (num != aleat)
            //{
            //    if (num>aleat)
            //    {
            //        tentativaAlta = num;
            //        Console.Write("O número escondido é menor. Está entre " + tentativaBaixa + " e " + tentativaAlta + ". Tente novamente: ");
            //    } else
            //    {
            //        tentativaBaixa = num;
            //        Console.Write("O número escondido é maior. Está entre " + tentativaBaixa + " e " + tentativaAlta + ". Tente novamente: ");
            //    }
            //    num = int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine("Parabens você acertou. O número era: " + aleat);


        }
    }
}
