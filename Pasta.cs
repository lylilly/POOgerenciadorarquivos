using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Pasta
{
    private string nameFolder;
    private bool oculto;
    private List<arquivo> arquivos;

    public string NameFolder
    {
        get { return nameFolder; }
       set { nameFolder = value; }
    }
    public bool Oculto
    {
        get { return oculto; }
         set { oculto = value; }
    }
    public List<Arquivo> Arquivos
    {
        get { return arquivos; }
        private set { arquivos = value; }
    }
    public Pasta(string nameFolder)
    {
        NameFolder = nameFolder;
        Oculto = false;
        Arquivos = new List<Arquivo>();
    }
    public void AddArquivo(Arquivo arquivo)
    {
        Arquivos.Add(arquivo);
    }
    public void Renomear(string novoNome)
    {
        NameFolder = novoNome;
    }
    public void AlterarOculto()
    {
        Oculto = !Oculto;
    }
    public double CalcularSizeFolder()
    {
        double tamanhoTotal = 0;
        foreach (var arquivo in Arquivos)
        {
            tamanhoTotal += arquivo.SizeFile;
        }
        return tamanhoTotal;
    }
    public void PrintPasta()
    {
        Console.WriteLine("PASTA: "+ NameFolder);
        Console.WriteLine("-----------------------------------");
        foreach (var arquivo in Arquivos)
        {
            Console.WriteLine(arquivo[i].NameFile);
        }
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("TAMANHO TOTAL DA PASTA:", CalcularSizeFolder() );
    }
}

