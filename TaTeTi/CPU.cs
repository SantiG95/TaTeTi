using System;
using System.Collections.Generic;
using System.Text;

namespace TaTeTi
{
    class CPU
    {
        List<int> casillasElegibles = new List<int>();
        List<int> misCasillas = new List<int>();
        Random random = new Random();

        public CPU()
        {
            for (int i = 1; i < 10; i++)
            {
                casillasElegibles.Add(i);
            }
        }

        internal int hacerDecision()
        {
            int miEleccion = buscarRespuesta();
            misCasillas.Add(miEleccion);
            return miEleccion;

        }

        public void registrarCuadroOcupado(int nCuadro)
        {
            casillasElegibles.Remove(nCuadro);
        }

        int buscarRespuesta()
        {
            
            //Horizontal
            for(int nCasillaH = 1; nCasillaH < 8; nCasillaH += 3)
            {
                if (misCasillas.Contains(nCasillaH) && misCasillas.Contains(nCasillaH +1) && casillasElegibles.Contains(nCasillaH +2))
                {
                    return nCasillaH + 2;
                }
                else if (misCasillas.Contains(nCasillaH) && casillasElegibles.Contains(nCasillaH +1) && misCasillas.Contains(nCasillaH + 2))
                {
                    return nCasillaH + 1;
                }
                else if (casillasElegibles.Contains(nCasillaH) && misCasillas.Contains(nCasillaH + 1) && misCasillas.Contains(nCasillaH + 2))
                {
                    return nCasillaH;
                }
            }

            //Vertical
            for(int nCasillaV = 1; nCasillaV < 4; nCasillaV++)
            {
                if (misCasillas.Contains(nCasillaV) && misCasillas.Contains(nCasillaV + 3) && casillasElegibles.Contains(nCasillaV + 6))
                {
                    return nCasillaV + 6;
                }
                else if (misCasillas.Contains(nCasillaV) && casillasElegibles.Contains(nCasillaV + 3) && misCasillas.Contains(nCasillaV + 6))
                {
                    return nCasillaV + 3;
                }
                else if (casillasElegibles.Contains(nCasillaV) && misCasillas.Contains(nCasillaV + 3) && misCasillas.Contains(nCasillaV + 6))
                {
                    return nCasillaV;
                }
            }

            //Diagonales ArIz/AbDe
            if (misCasillas.Contains(1) && misCasillas.Contains(5) && casillasElegibles.Contains(9))
            {
                return 9;
            }
            else if (misCasillas.Contains(1) && casillasElegibles.Contains(5) && misCasillas.Contains(9))
            {
                return 5;
            }
            else if (casillasElegibles.Contains(1) && misCasillas.Contains(5) && misCasillas.Contains(9))
            {
                return 1;
            }

            //Diagonal ArDe/AbIz
            if (misCasillas.Contains(7) && misCasillas.Contains(5) && casillasElegibles.Contains(3))
            {
                return 3;
            }
            else if (misCasillas.Contains(7) && casillasElegibles.Contains(5) && misCasillas.Contains(3))
            {
                return 5;
            }
            else if (casillasElegibles.Contains(7) && misCasillas.Contains(5) && misCasillas.Contains(3))
            {
                return 7;
            }


            return casillasElegibles[random.Next(casillasElegibles.Count)];

        }
    }
}
