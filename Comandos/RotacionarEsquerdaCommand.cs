using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using robo.Interfaces;
namespace robo.Comandos
{
    class RotacionarEsquerdaCommand :ICommand
    {
        public void Execute(IRobo robo)
        {
            robo.RotacionarEsquerda();
        }
    }
}
