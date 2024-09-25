using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOGerenciadorDeArquivos
{

    public class Arquivo
    {
        private string name;
        private string tipo;
        private double sizeFile;
        private bool oculto;
        private bool soLeitura;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Tipo
        {
            get { return tipo; }
             set { tipo = value; }
        }
        public double SizeFile
        {
            get { return sizeFile; }
            set { sizeFile = value; }
        }
        public bool Oculto
        { 
            get { return oculto; }
            set { oculto = value; }
        }
        public bool SoLeitura
        {
            get { return soLeitura; }
            set { soLeitura = value; }
        }
        public Arquivo(string name, string tipo, double sizeFile)
        {
            Name = name;
            Tipo = tipo;
            SizeFile = sizeFile;
            Oculto = false;
            SoLeitura = false;
        }
        public void Renomear(string novoNome)
        {
            if (SoLeitura)
            {
                Name = novoNome;
            }
            else
            {
                Console.WriteLine("O arquivo está em somente leitura!!!");
            }
        }
        public void AlterarOculto()
        {
            Oculto = Oculto;
        }
        public void AlterarSoLeitura()
        {
            SoLeitura = SoLeitura;
        }
    }
}


