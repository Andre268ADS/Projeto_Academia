using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Academia
{
    internal class Globais
    {
        public static string versao = "1.0";
        public static bool logado = false;
        public static int nivel=0; //0=usuárioBasico - 1=UsuárioGerente - 2=usuárioMaster
        public static string caminho = System.Environment.CurrentDirectory;
        public static string nomeBanco = "bd_academia.db";
        public static string caminhoBanco = caminho + @"\banco\";

    }
}
