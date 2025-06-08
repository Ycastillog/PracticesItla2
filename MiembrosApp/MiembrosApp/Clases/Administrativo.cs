using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using MiembrosApp.Clases;

public class Administrativo : Empleado
{
    public string Cargo { get; set; }
    public string Oficina { get; set; }  // Agrega esta propiedad

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Cargo: {Cargo}");
        Console.WriteLine($"Oficina: {Oficina}");
    }
}


