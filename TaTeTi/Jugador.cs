using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Collections;

namespace TaTeTi
{
    class Jugador
    {
        bool humano;
        string nombre;
        CPU cpu;
        int figura;
        String figuraDebug;

        public Jugador(bool humanoBool, string nombreElegido, int figuraElegida)
        {
            humano = humanoBool;
            if (!humano) cpu = new CPU();
            nombre = nombreElegido;
            if (figuraElegida == 1) { figura = 1; figuraDebug = "Circulo"; }
            else { figura = 2; figuraDebug = "Cruz"; }
            
        }

        public int miFigura()
        {
            return figura;
        }

        internal int hacerTurno()
        {
            if (humano) { return 0; } 

            return cpu.hacerDecision();

        }

        internal void registrarJugada(int nCuadro)
        {
            if (humano) return;
            cpu.registrarCuadroOcupado(nCuadro);
        }

        public bool esCPU()
        {
            return !humano;
        }
    }
}
