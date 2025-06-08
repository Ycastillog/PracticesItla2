using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiembrosApp.Clases
{
    public class Docente : Empleado
    {
        public string AreaEspecialidad { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Área de Especialidad: {AreaEspecialidad}");
        }
    }
}

