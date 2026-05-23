using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    //Campo que representa una lista de alumnos
    private List<Alumno> _alumnos = new List<Alumno>();

    //Método para agregar alumnos a la lista
    public void AgregarAlumno(Alumno alumno)
    {
        _alumnos.Add(alumno);
    }

    //Metodo para retornar la lista
    public List<Alumno> GetAlumnos()
    {
        return _alumnos;
    }

    //Metodo para buscar un alumno por su nombre
    //Uso de equals para comparar el nombre del alumno con el nombre buscado, ignorando mayúsculas y minúsculas
    public Alumno? BuscarAlumno(string nombre)
    {
        return _alumnos.FirstOrDefault(a => a.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
    }

    //Metodo para eliminar un alumno (Remove)
    public bool EliminarAlumno(Alumno alumno)
    {
        return _alumnos.Remove(alumno);
    }

    //Metodo para eliminar un alumno en una determinada posición de la lista (RemoveAt)
    public void EliminarAlumnoPorPosicion(int posicion)
    {
        if (posicion >= 0 && posicion < _alumnos.Count)
        {
            _alumnos.RemoveAt(posicion);
        }
    }
}
