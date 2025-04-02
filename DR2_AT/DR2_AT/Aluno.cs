using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DR2_AT
{
    internal class Aluno
    {
        public string nome;
        public int matricula;
        public string curso;
        public double mediaNotas;

        public void ExibirDados()
        {
            Console.WriteLine($"Nome do aluno: {nome}. Matricula: {matricula}. Curso: {curso}. Media das Notas: {mediaNotas}");
        }
        public void VerificarAprovacao()
        {
            if (mediaNotas >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
