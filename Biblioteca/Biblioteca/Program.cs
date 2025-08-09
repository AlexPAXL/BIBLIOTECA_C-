// EJEMPLO DE COMO CREAR UNA CLASE EN POO
using System;
using Microsoft.VisualBasic;
//Clase que representa un vehiculo
public class biblioteca
{
    //Atributos de la clase Vehiculo
    public string Id_libro { get; set; }
    public string nombre { get; set; }
    public string autor { get; set; }
    public int edision { get; set; }

    //Constructor de la clase Vehiculo
    public biblioteca(string Id_libro, string nombre, string autor, int edision)
    {
        this.Id_libro = Id_libro;
        this.nombre = nombre;
        this.autor = autor;
        this.edision = edision;
    }
    
    public string Id_libro{
        get => Id_libro;
        set => Id_libro = value;
    }
    // Metodo para acceder a los atributos
   
    public string nombre
    {
        get => nombre;
        set => nombre = value;
    }
      public string autor
    {
        get => autor;
        set => autor = value;
    }
      public int edision
    {
        get => edision;
        set => edision = value;
    }

    public int anio
    {
        get => Anio;
        set
        {
            if (value > 1990 && value < DateTime.Now.Year)
            {
                Anio = value;
            }
            else
            {
                throw new ArgumentException("El año debe ser mayor que 1990.");
            }
        }
    }
    //Metodo para mostrar informacion de la clase
    public void MostrarInformacion()
    {
        Console.WriteLine($"ID Libro: {Id_libro}, Nombre: {nombre}, Autor: {autor}, Edision: {edision}");
    }

}
public class Program{
    public static void Main(string[] args)
    {
        var miLibro = new biblioteca("001", "Cien Años de Soledad", "Gabriel García Márquez", 1967);
        miLibro.MostrarInformacion();
        miLibro.edision = 2021;
        miLibro.MostrarInformacion();
    }
}
