using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiembrosApp.Clases
{
    public class Estudiante : MiembroDeLaComunidad
    {
        public int Matricula { get; set; }
        public string Carrera { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Matrícula: {Matricula}");
            Console.WriteLine($"Carrera: {Carrera}");
        }
    }
}

