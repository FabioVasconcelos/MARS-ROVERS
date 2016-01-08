using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using robo.Rovers;

namespace robo.Interfaces
{
    public interface INavegacao
    {

        string ToString();
        void MoverYFaceFrente();
        void MoverXFaceFrente();
        void MoverYFaceCosta();
        void MoverXFaceCosta();       
        int GetCoordenadaX();
        int GetCoordenadaY();
        String GetSentido();
    }
}
