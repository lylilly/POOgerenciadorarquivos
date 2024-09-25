using System.Collections.Generic;
using System;

    
public class Program
{
    static void Main()
    {
        MenuPrincipal();
    }

    public static void MenuPrincipal()
    {
        Console.WriteLine("GERENCIADOR DE ARQUIVOS");
        Console.WriteLine("=================================");
        Console.WriteLine("1. Nova Pasta");
        Console.WriteLine("2. Novo Arquivo");
        Console.WriteLine("3. Mostrar Pasta");
        Console.WriteLine("0. Sair");
        Console.WriteLine("--------------------------------");

        bool exit = false;
        Pasta pasta = null;

        while (exit)
        {
            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Nome da nova pasta: ");
                    string nomePasta = Console.ReadLine();
                    pasta = new Pasta(nomePasta);
                    Console.WriteLine("Pasta criada com sucesso!!!");
                    break;
                case 2:
                    if (pasta != null)
                    {
                        Console.Write("Nome do arquivo: ");
                        string nomeArquivo = Console.ReadLine();
                        Console.Write("Tipo do arquivo: ");
                        string tipoArquivo = Console.ReadLine();
                        Console.Write("Tamanho do arquivo (MB): ");
                        double tamanhoArquivo = double.Parse(Console.ReadLine());
                        arquivo arquivo = new arquivo(nomeArquivo, tipoArquivo, tamanhoArquivo);
                        pasta.AddArquivo(arquivo);
                        Console.WriteLine("Arquivo adicionado com sucesso!!!");
                    }
                    else
                    {
                        Console.WriteLine("Nenhuma pasta criada ainda.");
                    }
                    break;
                case 3:
                    if (pasta != null)
                    {
                        pasta.PrintPasta();
                    }
                    else
                    {
                        Console.WriteLine("Nenhuma pasta criada ainda.");
                    }
                    break;
                case 0:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        } 
    }
}

