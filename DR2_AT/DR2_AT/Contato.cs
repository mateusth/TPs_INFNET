using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DR2_AT
{
    internal class Contato
    {
            public string _nome { get; set; }
            public string _telefone { get; set; }
            public string _email { get; set; }


        private StreamWriter _sw;
        private StreamReader _sr;
        public string Mensagem { get; set; }
        public string Nome
        { get { return _nome; }
            set { 
                if (!string.IsNullOrEmpty(value))
                { _nome = value; }
                }
        }
        public string Telefone
        {
            get { return _telefone; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                { _telefone = value; }
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                { _email = value; }
            }
        }

        public Contato(string nomeArquivo)
        {
            Nome = nomeArquivo;

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
                linha = _sr.ReadLine();
            }
            _sr.Close();
        }
    }
}