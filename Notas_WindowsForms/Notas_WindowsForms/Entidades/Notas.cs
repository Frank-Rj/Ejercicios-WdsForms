using Notas_WindowsForms.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas_WindowsForms.Entidades
{
    class Notas
    {
        // Primer periodo
        private double lab1;
        private double parcial1;
        private double notaPeriodo1;

        // Segundo periodo
        private double lab2;
        private double parcial2;
        private double notaPeriodo2;

        // Tercer periodo
        private double lab3;
        private double parcial3;
        private double notaPeriodo3;
        private double promedio;

        public double Lab1 { get => lab1; set => lab1 = value; }
        public double Parcial1 { get => parcial1; set => parcial1 = value; }
        public double Lab2 { get => lab2; set => lab2 = value; }
        public double Parcial2 { get => parcial2; set => parcial2 = value; }
        public double Lab3 { get => lab3; set => lab3 = value; }
        public double Parcial3 { get => parcial3; set => parcial3 = value; }
        public double NotaPeriodo1 { get => notaPeriodo1; set => notaPeriodo1 = value; }
        public double NotaPeriodo2 { get => notaPeriodo2; set => notaPeriodo2 = value; }
        public double NotaPeriodo3 { get => notaPeriodo3; set => notaPeriodo3 = value; }
        public double Promedio { get => promedio; set => promedio = value; }
    }
}
