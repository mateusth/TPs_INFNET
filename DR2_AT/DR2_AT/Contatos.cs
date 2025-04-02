using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DR2_AT
{
    internal class Contatos
    {
        private string _nome;
        private StreamWriter _sw;
        private StreamReader _sr;
        public string Mensagem { get; set; }
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _nome = value;
                }
            }
        }
        public Contatos(string nome)
        {
            Nome = nome;    //nome é a propriedade para garantir que eu instaciee um nome de arquivo que existe
        }

        //CRIAR, GRAVAR e FECHAR ARQUIVO

        public void CriarAbreArquivo()
        {
            _sw = new StreamWriter("C:\\Users\\mateu\\source\\repos\\DR2_AT\\" + Nome + ".txt", true, Encoding.UTF8);
        }

        public void GravarMensagem(string mensagem)
        {
            _sw.WriteLine(mensagem);
            FecharArquivo();
        }

        public void FecharArquivo()
        {
            _sw.Close();
        }

        //LER e FECHAR ARQUIVO
        public void LerArquivo()
        {
            string linha;
            _sr = new StreamReader("C:\\Users\\mateu\\source\\repos\\DR2_AT\\" + Nome + ".txt");
            linha = _sr.ReadLine();
            while (linha != null)
            {
                Console.WriteLine(linha);
                linha = _sr.ReadLine();
            }
            _sr.Close();
        }
    }
}
