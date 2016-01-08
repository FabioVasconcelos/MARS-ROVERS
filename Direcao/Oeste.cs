using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using robo.Interfaces;
namespace robo.Direcao
{
    class Oeste : IDirecao
    {
        private readonly INavegacao _posicao;

        public Oeste(INavegacao posicao)
        {
            _posicao = posicao;

        }

        public IDirecao RotacionaEsquerda()
        {
            return new Sul(_posicao);
        }

        public IDirecao RotacionaDireita()
        {
            return new Norte(_posicao);
        }

        public override string ToString()
        {
            return "Oeste";
        }


        public void Mover()
        {
            _posicao.MoverXFaceCosta();
        }
    }
}
