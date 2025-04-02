using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DR2_AT
{
    internal class TabelaFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("| Nome | Telefone | Email |");
            Console.WriteLine("----------------------------------------");
            foreach (Contato contato in contatos)
            {
                Console.WriteLine($"|Nome: {contato.Nome} | Telefone: {contato.Telefone} | Email: {contato.Email}|");
                Console.WriteLine("----------------------------------------");
            }

        }
    }
}
