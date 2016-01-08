using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using robo.Interfaces;
namespace robo.Direcao
{
    public class Leste : IDirecao
    {

        // Padrão de projeto State. Dê acorso com a mudança de estado o objeto se torna outra algo como outra classe
        // por ter outra implementação. É mudado em tempo de execução.


        private readonly INavegacao _posicao;

        public Leste(INavegacao posicao)
        {
            _posicao = posicao;

        }

        public IDirecao RotacionaEsquerda()
        {
            return new Norte(_posicao);
        }

        public IDirecao RotacionaDireita()
        {
            return new Sul(_posicao);
        }

        public override string ToString()
        {
            return "Leste";
        }



        public void Mover()
        {
            _posicao.MoverXFaceFrente();
        }
    }
}
