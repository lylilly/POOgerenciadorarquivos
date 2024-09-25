using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOGerenciadorDeArquivos
{
    internal interface IOperações
    {
        bool Renomear();
        void AlterarOculto();
        void AlterarSoLeitura();
    }
}
