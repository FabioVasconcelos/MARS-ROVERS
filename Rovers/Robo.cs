using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using robo.Interfaces;
using robo.Direcao;
using robo.ComandosParser;
using robo.Comandos;
using System.Collections;

namespace robo.Rovers
{

    public static class Facing
    {
        public const string North = "N";
        public const string East = "E";
        public const string South = "S";
        public const string West = "W";
    }

    public class Robo : IRobo
    {
        private INavegacao _navegacao;

        // padrão State

        public IDirecao Direcao { get; set; }

        public Robo(INavegacao navegacao)
        {

            // De acordo com sentido de sua frente o robo muda de comportamento dinamicamente alterando sua classe (State Pattern)

             _navegacao = navegacao;
            string sentido = _navegacao.GetSentido();

            switch (sentido.ToUpper())
            {

                case Facing.North:
                    Direcao = new Norte(_navegacao);
                    break;
                case Facing.East:
                    Direcao = new Leste(_navegacao);
                    break;
                case Facing.South:
                    Direcao = new Sul(_navegacao);
                    break;
                case Facing.West:
                    Direcao = new Oeste(_navegacao);
                    break;

            }
            

        }

        public void RotacionarEsquerda()
        {
            Direcao = Direcao.RotacionaEsquerda();
        }

        public void RotacionarDireita()
        {
            Direcao = Direcao.RotacionaDireita();
        }

        // Command Pattern - Recebe o comando como parâmetro e através de uma lista, adiciona os comandos parses que se
        // encarregam de reconhecer qual é o comando e criar uma instância do comando correspondente. O Foreach é usado para
        // percorrer todos os comandos até achar o certo e direcionar a a classe de comando que ira executar a solicitação feita
        // pelo cliente.

         public ICommand entradaComando(string input)
         {
            
            List<ICommandParser> comandos = new List<ICommandParser>();
            comandos.Add(new AndarCommandParser());
            comandos.Add(new RotacionarDireitaCommandParser());
            comandos.Add(new RotacionarEsquerdaCommandParser());

            foreach (var comandosParser in comandos)
            {

                if (comandosParser.ReconhecerComando(input))
                {
                    return comandosParser.Parse(input);
                }
            }
            Console.WriteLine("Comando não reconhecido");
            return new NotFoundCommand();
        }

        // Separa a sequencia de caracteres em chars para ser passado para o método encarregado de devolver a instância do commando
        // correspondente e é executado pela interface ICommand que atribui ao robo o solicitante.
         public void ExecuteCommands(string commandString)
         {
                   

             for (int index = 0; index < commandString.Length; index++)
             {
                 var command = commandString[index].ToString();
                 var commandToExecute = entradaComando(command);
                 commandToExecute.Execute(this);
             }
         }

        public void Mover()
        {
            Direcao.Mover();
        }


        public override string ToString()
        {
            return string.Format("X : {0}, Y : {1}, Direção : {2}", _navegacao.GetCoordenadaX(), _navegacao.GetCoordenadaY(), Direcao);
        }
 
    }




}
