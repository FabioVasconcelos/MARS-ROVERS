using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robo.Interfaces
{
    public interface ICommand
    {
        void Execute(IRobo robo);
    }
}
