using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using MiembrosApp.Clases;

public class ExAlumno : MiembroDeLaComunidad
{
    public string Carrera { get; set; }
    public int AnioEgreso { get; set; } 

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Carrera: {Carrera}");
        Console.WriteLine($"Año de Egreso: {AnioEgreso}");
    }
}


