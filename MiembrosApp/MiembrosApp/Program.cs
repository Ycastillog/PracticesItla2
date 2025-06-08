using MiembrosApp.Clases;

List<MiembroDeLaComunidad> miembros = new List<MiembroDeLaComunidad>();

bool salir = false;

while (!salir)
{
    Console.Clear();
    Console.WriteLine("===== MENÚ PRINCIPAL =====");
    Console.WriteLine("1. Agregar Estudiante");
    Console.WriteLine("2. Agregar ExAlumno");
    Console.WriteLine("3. Agregar Administrativo");
    Console.WriteLine("4. Agregar Docente");
    Console.WriteLine("5. Agregar Maestro");
    Console.WriteLine("6. Agregar Administrador");
    Console.WriteLine("7. Ver todos los miembros");
    Console.WriteLine("0. Salir");
    Console.Write("Seleccione una opción: ");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            miembros.Add(AgregarEstudiante());
            break;
        case "2":
            miembros.Add(AgregarExAlumno());
            break;
        case "3":
            miembros.Add(AgregarAdministrativo());
            break;
        case "4":
            miembros.Add(AgregarDocente());
            break;
        case "5":
            miembros.Add(AgregarMaestro());
            break;
        case "6":
            miembros.Add(AgregarAdministrador());
            break;
        case "7":
            MostrarMiembros(miembros);
            break;
        case "0":
            salir = true;
            break;
        default:
            Console.WriteLine("Opción no válida. Presiona una tecla para continuar.");
            Console.ReadKey();
            break;
    }
}

static Estudiante AgregarEstudiante()
{
    Console.Write("Nombre: ");
    string nombre = Console.ReadLine();
    Console.Write("Cédula: ");
    string cedula = Console.ReadLine();
    Console.Write("Matrícula: ");
    int matricula = int.Parse(Console.ReadLine());
    Console.Write("Carrera: ");
    string carrera = Console.ReadLine();

    return new Estudiante
    {
        Nombre = nombre,
        Cedula = cedula,
        Matricula = matricula,
        Carrera = carrera
    };
}

static ExAlumno AgregarExAlumno()
{
    Console.Write("Nombre: ");
    string nombre = Console.ReadLine();
    Console.Write("Cédula: ");
    string cedula = Console.ReadLine();
    Console.Write("Carrera que estudió: ");
    string carrera = Console.ReadLine();
    Console.Write("Año de egreso: ");
    int anio = int.Parse(Console.ReadLine());

    return new ExAlumno
    {
        Nombre = nombre,
        Cedula = cedula,
        Carrera = carrera,
        AnioEgreso = anio
    };
}

static Administrativo AgregarAdministrativo()
{
    Console.Write("Nombre: ");
    string nombre = Console.ReadLine();
    Console.Write("Cédula: ");
    string cedula = Console.ReadLine();
    Console.Write("Departamento: ");
    string dep = Console.ReadLine();
    Console.Write("Oficina: ");
    string oficina = Console.ReadLine();

    return new Administrativo
    {
        Nombre = nombre,
        Cedula = cedula,
        Departamento = dep,
        Oficina = oficina
    };
}

static Docente AgregarDocente()
{
    Console.Write("Nombre: ");
    string nombre = Console.ReadLine();
    Console.Write("Cédula: ");
    string cedula = Console.ReadLine();
    Console.Write("Área de especialidad: ");
    string area = Console.ReadLine();

    return new Docente
    {
        Nombre = nombre,
        Cedula = cedula,
        AreaEspecialidad = area
    };
}

static Maestro AgregarMaestro()
{
    Console.Write("Nombre: ");
    string nombre = Console.ReadLine();
    Console.Write("Cédula: ");
    string cedula = Console.ReadLine();
    Console.Write("Área de especialidad: ");
    string area = Console.ReadLine();

    return new Maestro
    {
        Nombre = nombre,
        Cedula = cedula,
        AreaEspecialidad = area
    };
}

static Administrador AgregarAdministrador()
{
    Console.Write("Nombre: ");
    string nombre = Console.ReadLine();
    Console.Write("Cédula: ");
    string cedula = Console.ReadLine();
    Console.Write("Departamento: ");
    string departamento = Console.ReadLine();
    Console.Write("Área de especialidad: ");
    string area = Console.ReadLine();
    Console.Write("Oficina: ");
    string oficina = Console.ReadLine();

    return new Administrador
    {
        Nombre = nombre,
        Cedula = cedula,
        Departamento = departamento,
        AreaEspecialidad = area,
        Oficina = oficina
    };
}

static void MostrarMiembros(List<MiembroDeLaComunidad> miembros)
{
    Console.Clear();
    Console.WriteLine("===== LISTADO DE MIEMBROS =====\n");

    if (miembros.Count == 0)
    {
        Console.WriteLine("No hay miembros registrados.");
    }
    else
    {
        foreach (var miembro in miembros)
        {
            miembro.MostrarInformacion();
            Console.WriteLine("--------------------------------\n");
        }
    }

    Console.WriteLine("Presiona una tecla para continuar...");
    Console.ReadKey();
}

