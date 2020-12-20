using System;
using System.Collections.Generic;
using System.Text;

namespace TaTeTi
{
    class CPU
    {
        List<int> casillasElegibles = new List<int>();
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
            return casillasElegibles[random.Next(casillasElegibles.Count)] ;

        }

        public void registrarCuadroOcupado(int nCuadro)
        {
            casillasElegibles.Remove(nCuadro);
        }
    }
}
