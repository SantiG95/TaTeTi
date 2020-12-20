using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TaTeTi
{
    class Cuadro
    {
        // Referencia para dibujo:
        // 0 = nada
        // 1 = circulo
        // 2 = cruz
        Bitmap dibujo = TaTeTi.Properties.Resources.Nada;
        int valor = 0;

        public System.Drawing.Bitmap cambiarImagen(int intImagen)
        {
            valor = intImagen;
            return imagen();
        }

        public System.Drawing.Bitmap imagen()
        {
            switch (valor)
            {
                case 1:
                    return TaTeTi.Properties.Resources.Circulo;

                case 2:
                    return TaTeTi.Properties.Resources.Cruz;

                default:
                    return TaTeTi.Properties.Resources.Nada;
            }
        }

        internal bool estaOcupado()
        {
            return (valor != 0);
        }

        public int obtenerImagen()
        {
            return valor;
        }
    }
}
