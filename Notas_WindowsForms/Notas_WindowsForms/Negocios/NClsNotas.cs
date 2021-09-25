using Notas_WindowsForms.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas_WindowsForms.Negocios
{
    class NClsNotas
    {
        public String Periodo1(Notas nota)
        {
            nota.NotaPeriodo1 = (nota.Lab1 * 0.4) + (nota.Parcial1 * 0.6);
            return nota.NotaPeriodo1.ToString("0.0");
        }

        public String Periodo2(Notas nota)
        {
            nota.NotaPeriodo2 = (nota.Lab2 * 0.4) + (nota.Parcial2 * 0.6);
            return nota.NotaPeriodo2.ToString("0.0");
        }

        public String Periodo3(Notas nota)
        {
            nota.NotaPeriodo3 = (nota.Lab3 * 0.4) + (nota.Parcial3 * 0.6);
            return nota.NotaPeriodo3.ToString("0.0");
        }

        public String Promedio(Notas nota)
        {
            nota.Promedio = (nota.NotaPeriodo1 + nota.NotaPeriodo2 + nota.NotaPeriodo3) / 3;
            return nota.Promedio.ToString("0.0");
        }
    }
}
