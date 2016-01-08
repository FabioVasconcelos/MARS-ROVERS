using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robo.Interfaces
{
    public interface ICommandParser
    {
        bool ReconhecerComando(string input);
        ICommand Parse(string input);
    }
}
