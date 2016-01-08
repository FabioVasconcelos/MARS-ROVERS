using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using robo.Interfaces;
namespace robo.Comandos
{
    public class RotacionarDireitaCommand :ICommand
    {
        public void Execute(IRobo robo)
        {
            robo.RotacionarDireita();
        }
    }
}
