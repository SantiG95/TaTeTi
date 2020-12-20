using System;
using TaTeTi;

namespace TaTeTi
{
    public class Turno
    {
        Jugador jugadorActual;
        Jugador jugador1;
        Jugador jugador2;
        Tablero tablero;
        string turno1 = "Turno Jugador1";
        string turno2 = "Turno Jugador 2";
        string turnoCpu = "Turno CPU";

        public void comenzarJuego(bool multijugador)
            // true = 2 jugadores
            //false = 1 jugador
        {
            tablero = new Tablero();
            tablero.prepararJuego();
            

            jugador1 = new Jugador(true, "Jugador 1", 1);

            if (multijugador) { jugador2 = new Jugador(true, "Jugador 2", 2); }
            else              { jugador2 = new Jugador(false, "CPU", 2); }

            jugadorActual = jugador1;

            jugadorActual.hacerTurno();

        }

        public System.Drawing.Bitmap cambiarCuadro(int nCuadro)
        {
            jugador2.registrarJugada(nCuadro);
            return tablero.mostrarJugada(jugadorActual.miFigura(), nCuadro);
        }

        public System.Drawing.Bitmap ponerCuadroEnBlanco(int nCuadro)
        {
            return tablero.mostrarJugada(0, nCuadro);
        }

        internal bool cuadroOcupado(int nCuadro)
        {
            return tablero.comprobarCuadroOcupado(nCuadro);
        }

        public bool siguienteTurno()
        {
            if (jugadorActual == jugador1) { jugadorActual = jugador2; }
            else { jugadorActual = jugador1; }
            return jugadorActual.esCPU();
        }

        internal bool hayLinea()
        {
            return tablero.hayLinea();
        }

        public int cpuElige()
        {
            return jugadorActual.hacerTurno();
        }
    }
}
