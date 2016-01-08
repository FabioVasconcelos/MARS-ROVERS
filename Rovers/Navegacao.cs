using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using robo.Interfaces;

namespace robo.Rovers

{
      

    public class Navegacao : INavegacao
    {
             

        private int coordenadaX;

        public int GetCoordenadaX()
        {
            return coordenadaX;
        }
        private int coordenadaY;

        public int GetCoordenadaY()
        {
            return coordenadaY;
        }
        private int _maxWidth;
        private int _maxHeight;

        private string _sentido;    


        public String GetSentido()
        {

            return _sentido;

        }
        

        public Navegacao(int x, int y, string sentido)
        {
            // atribui as coordenadas e o sentido para ser passado para classe Robo que fará mudança de estado em tempo de execução (State Pattern)
            switch (sentido.ToUpper())
            {

                case "N":
                    this._sentido = "N";
                    break;
                case "E":
                    this._sentido = "E";
                    break;
                case "S":
                    this._sentido = "S";
                    break;
                case "W":
                    this._sentido = "W";
                    break;

            }

            // coloca limite de 300 quadros para altura e largura

            _maxWidth = 300;
            _maxHeight = 300;
            coordenadaX = x;
            coordenadaY = y;
        }

        

        public override string ToString()
        {
            return string.Format("{0} {1}", coordenadaX, coordenadaY);
        }

        // Movimenta o robo de acordo com o seu sentido da face

        public void MoverYFaceFrente()
        {
            if (coordenadaY < _maxHeight)
                coordenadaY++;

        }

        public void MoverYFaceCosta()
        {
            if (coordenadaY > 0)
                coordenadaY--;
        }


        public void MoverXFaceFrente()
        {
            if (coordenadaX < _maxWidth)
               coordenadaX++;
        }
        

        public void MoverXFaceCosta()
        {
            if (coordenadaX > 0)
                coordenadaX--;
        }
        
      
        }
    }
