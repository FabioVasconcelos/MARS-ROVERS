using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using robo.Interfaces;
using robo.Comandos;
namespace robo.ComandosParser
{
    public class RotacionarEsquerdaCommandParser : ICommandParser
    {
        // Verifica se o input corresponde ao comando desejado e caso sim cria uma instância do comando propriamente dito com
        // o método de execução.


        public bool ReconhecerComando(string input)
        {
            input.ToUpper();

          
            if (input.StartsWith("L"))
                return true;
            else return false;
        }

        public ICommand Parse(string input)
        {
            return new RotacionarEsquerdaCommand();

        }
    }
}
