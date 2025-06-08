using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiembrosApp.Clases
{
    public class Administrador : Docente
    {
        public string Oficina { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Oficina: {Oficina}");
        }
    }
}

