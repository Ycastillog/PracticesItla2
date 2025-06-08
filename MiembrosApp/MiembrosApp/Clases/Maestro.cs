using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiembrosApp.Clases
{
    public class Maestro : Docente
    {
        public string Grado { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Grado: {Grado}");
        }
    }
}

