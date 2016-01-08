using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using robo.Rovers;

namespace robo
{
    class Program
    {
        static void Main(string[] args)
        {
           Help();
            string commandsToExecute = string.Empty;
            while (commandsToExecute != "E")
            {

           
            
                // Pequena falha a ser corrigida. Na implementação atual da erro caso a sequencia de caracteres escrita sem espaço
 
                Console.WriteLine("Digite a posição do robo COM ESPAÇO: EX: 1 2 N ");

                String posicao = Console.ReadLine().ToUpper();
                string[] inputdata = posicao.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                var navegacao = new Navegacao(int.Parse(inputdata[0]), int.Parse(inputdata[1]), inputdata[2]);
                var robo = new Robo(navegacao);
                Console.WriteLine(robo.ToString());
                Console.Write("Digite o comando: ");
                commandsToExecute = Console.ReadLine().ToUpper();
                robo.ExecuteCommands(commandsToExecute);
                Console.WriteLine();
                Console.WriteLine(string.Format("Posição atual do robo: {0}", robo.ToString()));


            }
        }


        private static void Help()
        {
            Console.WriteLine("Comandos válidos:");
            Console.WriteLine("L - Turn Rover Left");
            Console.WriteLine("R - Turn Rover Right");
            Console.WriteLine("M - Move Rover Forward");
            Console.WriteLine("E - End");
            Console.WriteLine("Tecle enter para executar o comando");
        }
    }
}
