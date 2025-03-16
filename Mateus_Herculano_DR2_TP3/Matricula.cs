using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DR2_TP3
{
    internal class Matricula
    {
        public string NomeDoAluno;
        public string Curso;
        public int NumeroMatricula;
        public string Situacao;     //Ativa, Trancada, Concluida
        public string DataInicial;

        public void Trancar()
        {
            Situacao = "Trancada";
        }
        public void Reativar()
        {
            Situacao = "Ativa";
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine("\nNome do Aluno: " + NomeDoAluno + ".\nCurso: " + Curso + ".\nNumero Matricula: " + NumeroMatricula + ".\nSituacao Atual: " + Situacao + ".\nData Inicial da Matricula: " + DataInicial);
        }


     //internal class TestaMatricula
     //   {
     //       static void Main(string[] args)
     //       {
     //        Matricula m1 = new Matricula();
     //           m1.NomeDoAluno = "Mateus";
     //           m1.Curso = "Analise e Desenvolvimento de Sistemas";
     //           m1.NumeroMatricula = 123445;
     //           m1.Situacao = "Ativa";
     //           m1.DataInicial = "15/07/2024";

     //           m1.Trancar();
     //           m1.ExibirInformacoes();

     //           m1.Reativar();
     //           m1.ExibirInformacoes();
     //       }
     //   }



    }
}
