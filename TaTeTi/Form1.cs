using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaTeTi
{
    public partial class Form1 : Form
    {
        bool juegoComenzado = false;
        Turno juego;
        List<PictureBox> listaCuadros = new List<PictureBox>();
        int nTurno;


        public Form1()
        {
            InitializeComponent();
            listaCuadros.Add(cuadro1);
            listaCuadros.Add(cuadro2);
            listaCuadros.Add(cuadro3);
            listaCuadros.Add(cuadro4);
            listaCuadros.Add(cuadro5);
            listaCuadros.Add(cuadro6);
            listaCuadros.Add(cuadro7);
            listaCuadros.Add(cuadro8);
            listaCuadros.Add(cuadro9);
        }

        
        private void cuadro1_Click(object sender, EventArgs e)
        {
            cuadroAccionar(1);
        }

        private void cuadro2_Click(object sender, EventArgs e)
        {
            cuadroAccionar(2);
        }

        private void cuadro3_Click(object sender, EventArgs e)
        {
            cuadroAccionar(3);
        }

        private void cuadro4_Click(object sender, EventArgs e)
        {
            cuadroAccionar(4);
        }

        private void cuadro5_Click(object sender, EventArgs e)
        {
            cuadroAccionar(5);
        }

        private void cuadro6_Click(object sender, EventArgs e)
        {
            cuadroAccionar(6);
        }

        private void cuadro7_Click(object sender, EventArgs e)
        {
            cuadroAccionar(7);
        }

        private void cuadro8_Click(object sender, EventArgs e)
        {
            cuadroAccionar(8);
        }

        private void cuadro9_Click(object sender, EventArgs e)
        {
            cuadroAccionar(9);
        }

        private void unJugadorBox_Click(object sender, EventArgs e)
        {
            prepararJuego();
            juego.comenzarJuego(false);

        }

        private void dosJugadoresBox_Click(object sender, EventArgs e)
        {
            prepararJuego();
            juego.comenzarJuego(true);
        }

        private void cuadroAccionar(int nCuadro)
        {
            if (!juegoComenzado || juego.cuadroOcupado(nCuadro)) { return; }
            listaCuadros[nCuadro - 1].Image = juego.cambiarCuadro(nCuadro);
            if (controlTurno()) { return; }
            if (juego.siguienteTurno()) { cpuElige(); }
        }

        private void prepararJuego()
        {
            for (int i = 0; i < 9; i++)
            {
                listaCuadros[i].Image = TaTeTi.Properties.Resources.Nada;
            }

            nTurno = 0;
            unJugadorBox.Visible = false;
            dosJugadoresBox.Visible = false;
            IndicadorLabel.Visible = false;

            juegoComenzado = true;
            juego = new Turno();
        }

        private void terminarJuego()
        {
            unJugadorBox.Visible = true;
            dosJugadoresBox.Visible = true;
            IndicadorLabel.Visible = true;

            juegoComenzado = false;
        }

        private bool controlTurno()
        {
            nTurno++;
            if(nTurno == 9 || juego.hayLinea()) { 
                terminarJuego();
                return true;
            }
            return false;
        }

        private void cpuElige()
        {
            switch (juego.cpuElige())
            {
                case 1:
                    cuadro1_Click(this.cuadro1, null);
                    break;
                case 2:
                    cuadro2_Click(this.cuadro2, null);
                    break;
                case 3:
                    cuadro3_Click(this.cuadro3, null);
                    break;
                case 4:
                    cuadro4_Click(this.cuadro4, null);
                    break;
                case 5:
                    cuadro5_Click(this.cuadro5, null);
                    break;
                case 6:
                    cuadro6_Click(this.cuadro6, null);
                    break;
                case 7:
                    cuadro7_Click(this.cuadro7, null);
                    break;
                case 8:
                    cuadro8_Click(this.cuadro8, null);
                    break;
                case 9:
                    cuadro9_Click(this.cuadro9, null);
                    break;
            }
        }
    }
}
