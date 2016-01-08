using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using robo.Interfaces;
namespace robo.Direcao
{
    public class Sul : IDirecao
    {
        private readonly INavegacao _posicao;

        public Sul(INavegacao posicao)
        {
            _posicao = posicao;

        }

        public IDirecao RotacionaEsquerda()
        {
            return new Leste(_posicao);
        }

        public IDirecao RotacionaDireita()
        {
            return new Oeste(_posicao);
        }

        public override string ToString()
        {
            return "Sul";
        }



        public void Mover()
        {
            _posicao.MoverYFaceCosta();
        }
    }
}
