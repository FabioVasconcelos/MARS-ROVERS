using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using robo.Interfaces;

namespace robo.Direcao
{
   public  class Norte : IDirecao
    {
        private readonly INavegacao _posicao;

        public Norte(INavegacao posicao)
        {
            _posicao = posicao;

        }


        public IDirecao RotacionaEsquerda()
        {
            return new Oeste(_posicao);
        }


        public IDirecao RotacionaDireita()
        {
            return new Leste(_posicao);
        }

        public override string ToString()
        {
            return "Norte";
        }


        public void Mover()
        {
            _posicao.MoverYFaceFrente();
        }



    }
}
