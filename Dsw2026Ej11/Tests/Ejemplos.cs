using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();

        Alumno alumno1 = new Alumno(1, "Martina", 8.5);
        Alumno alumno2 = new Alumno(2, "Catalina", 9.0);
        Alumno alumno3 = new Alumno(3, "Ian", 7.5);

        casoList.AgregarAlumno(alumno1);
        casoList.AgregarAlumno(alumno2);
        casoList.AgregarAlumno(alumno3);

        Console.WriteLine("---Listado de Alumnos---");
        foreach (var alumno in casoList.GetAlumnos())
        {
            Console.WriteLine(alumno);
        }
        Console.WriteLine();

        Console.WriteLine("---Buscar Alumno por Nombre---");
        Alumno? alumnoBuscado = casoList.BuscarAlumno("Catalina");
        if (alumnoBuscado != null)
        {
            Console.WriteLine(alumnoBuscado);
        }
        else
        {
            Console.WriteLine("No existe");
        }
        Console.WriteLine();

        Console.WriteLine("---Buscar Alumno por Nombre (No existe)---");
        Alumno? alumnoNoExistente = casoList.BuscarAlumno("Sofía");
        if (alumnoNoExistente != null)

        {
            Console.WriteLine(alumnoNoExistente);
        }
        else
        {
            Console.WriteLine("No existe");
        }
        Console.WriteLine();

        Console.WriteLine("---Eliminar Alumno por Nombre---");
        casoList.EliminarAlumno(alumno2);
        Console.WriteLine("Listado actualizado");
        foreach (var alumno in casoList.GetAlumnos())
        {
            Console.WriteLine(alumno);
        }
        Console.WriteLine();

        Console.WriteLine("---Eliminar Alumno por Posición---");
        casoList.EliminarAlumnoPorPosicion(0);
        Console.WriteLine("Listado actualizado");
        foreach (var alumno in casoList.GetAlumnos())
        {
            Console.WriteLine(alumno);
        } 

    }




    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary casoDictionary = new CasoDictionary();

        casoDictionary.agregarAlumno(new Alumno(1, "Martina", 8.5));
        casoDictionary.agregarAlumno(new Alumno(2, "Catalina", 9.0));
        casoDictionary.agregarAlumno(new Alumno(3, "Ian", 7.5));

        Console.WriteLine("---Listado de Alumnos---");
        foreach (var alumno in casoDictionary.getDiccionario())
        {
            Console.WriteLine(alumno.Value);
        }
        Console.WriteLine();

        Console.WriteLine("---Buscar Alumno por Clave---");
        Alumno? alumnoBuscado = casoDictionary.buscarPorClave(2);
        if (alumnoBuscado != null)
        {
            Console.WriteLine(alumnoBuscado);
        }
        else
        {
            Console.WriteLine("No existe");
        }
        Console.WriteLine();

        Console.WriteLine("---Buscar Alumno por Clave (No existe)---");
        Alumno? alumnoNoExistente = casoDictionary.buscarPorClave(4);
        if (alumnoNoExistente != null)
        {
            Console.WriteLine(alumnoNoExistente);
        }
        else { Console.WriteLine("No existe");
        }
        Console.WriteLine();

        Console.WriteLine("---Eliminar Alumno por Clave---");
        casoDictionary.eliminarAlumno(2);
        foreach (var alumno in casoDictionary.getDiccionario())
        {
            Console.WriteLine(alumno.Value);
        }
        Console.WriteLine();
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq();

        Console.WriteLine("----Pruebas de metodos----");
        var primero = casoLinq.GetPrimero();
        Console.WriteLine($"1- Primer libro: {primero?.Titulo ?? "No hay libros" }");

        var ultimo = casoLinq.GetUltimo();
        Console.WriteLine($"2- Ultimo libro: {ultimo?.Titulo ?? "No hay libros"}");

        decimal totalPrecios = casoLinq.GetTotalPrecios();
        Console.WriteLine($"3- Suma total de precios: {totalPrecios:C}");

        decimal promedioPrecios = casoLinq.GetPromedioPrecios();
        Console.WriteLine($"4- Promedio de precios: {promedioPrecios:C}\n");

        Console.WriteLine("5- Libros con Id mayor a 15:");
        var librosByIdMayorA15 = casoLinq.GetListById();
        foreach (var libro in librosByIdMayorA15)
        {
            Console.WriteLine($"   - {libro.Titulo} (Id: {libro.Id})");
        }
        Console.WriteLine();

        Console.WriteLine("6- Libros con título y precio en formato moneda:");
        var librosConFormato = casoLinq.GetLibros();
        foreach (var libro in librosConFormato)
        {
            Console.WriteLine($"   - {libro}");
        }
        Console.WriteLine();

        var libroMasCaro = casoLinq.GetMayorPrecio();
        Console.WriteLine($"7- Libro con el precio mas alto: {libroMasCaro.Titulo} ({libroMasCaro.Precio:C})");

        var libroMasBarato = casoLinq.GetMenorPrecio();
        Console.WriteLine($"8- Libro con el precio mas bajo: {libroMasBarato.Titulo} ({libroMasBarato.Precio:C})");

        Console.WriteLine("9- Libros con precio mayor al promedio:");
        var librosMayorAlPromedio = casoLinq.GetMayorPromedio();
        foreach (var libro in librosMayorAlPromedio)
        {
            Console.WriteLine($"   - {libro.Titulo} ({libro.Precio:C})");
        }
        Console.WriteLine();

        Console.WriteLine("10- Libros ordenados por título de forma descendente:");
        var librosOrdenadosDesc = casoLinq.GetLibrosOrdenados();
        foreach (var libro in librosOrdenadosDesc)
        {
            Console.WriteLine($"   - {libro.Titulo}");
        }
    }
}
