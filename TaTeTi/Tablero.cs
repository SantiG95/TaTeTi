using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaTeTi
{
    public class Tablero
    {
        List<Cuadro> listaCuadros = new List<Cuadro>();
        

        public void prepararJuego()
        {
            for (int i = 0; i < 9; i++)
            {
                listaCuadros.Add(new Cuadro());
            }
        }

        public System.Drawing.Bitmap mostrarJugada(int valor, int nCuadro)
        {
            if(listaCuadros[nCuadro - 1].obtenerImagen() != 0) { return listaCuadros[nCuadro - 1].imagen(); }
            return listaCuadros[nCuadro - 1].cambiarImagen(valor);
        }

        internal bool comprobarCuadroOcupado(int nCuadro)
        {
            return listaCuadros[nCuadro - 1].estaOcupado();
        }

        internal bool hayLinea()
        {
            return (lineaHorizontal() || lineaVertical() || lineaDiagonal());
        }

        private bool lineaHorizontal()
        {
            bool linea = false;

            if (listaCuadros[0].obtenerImagen() != 0 && listaCuadros[0].obtenerImagen() == listaCuadros[1].obtenerImagen() && listaCuadros[1].obtenerImagen() == listaCuadros[2].obtenerImagen()) { linea = true; }
            if (listaCuadros[3].obtenerImagen() != 0 && listaCuadros[3].obtenerImagen() == listaCuadros[4].obtenerImagen() && listaCuadros[4].obtenerImagen() == listaCuadros[5].obtenerImagen()) { linea = true; }
            if (listaCuadros[6].obtenerImagen() != 0 && listaCuadros[6].obtenerImagen() == listaCuadros[7].obtenerImagen() && listaCuadros[7].obtenerImagen() == listaCuadros[8].obtenerImagen()) { linea = true; }

            return linea;
        }

        private bool lineaVertical()
        {
            bool linea = false;

            if (listaCuadros[0].obtenerImagen() != 0 && listaCuadros[0].obtenerImagen() == listaCuadros[3].obtenerImagen() && listaCuadros[3].obtenerImagen() == listaCuadros[6].obtenerImagen()) { linea = true; }
            if (listaCuadros[1].obtenerImagen() != 0 && listaCuadros[1].obtenerImagen() == listaCuadros[4].obtenerImagen() && listaCuadros[4].obtenerImagen() == listaCuadros[7].obtenerImagen()) { linea = true; }
            if (listaCuadros[2].obtenerImagen() != 0 && listaCuadros[2].obtenerImagen() == listaCuadros[5].obtenerImagen() && listaCuadros[5].obtenerImagen() == listaCuadros[8].obtenerImagen()) { linea = true; }

            return linea;
        }

        private bool lineaDiagonal()
        {
            bool linea = false;

            if (listaCuadros[0].obtenerImagen() != 0 && listaCuadros[0].obtenerImagen() == listaCuadros[4].obtenerImagen() && listaCuadros[4].obtenerImagen() == listaCuadros[8].obtenerImagen()) { linea = true; }
            if (listaCuadros[2].obtenerImagen() != 0 && listaCuadros[2].obtenerImagen() == listaCuadros[4].obtenerImagen() && listaCuadros[4].obtenerImagen() == listaCuadros[6].obtenerImagen()) { linea = true; }
            
            return linea;
        }
    }
}
