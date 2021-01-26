using System;

namespace POO
{
    public class Persona
    {
      public string Nombre;
      public string Apellido;
      public string DNI;
      public DateTime FechaNacimiento;
      public Persona()
      {

      }
      public Persona(string nombre, string apellido, string dni, DateTime fechaNac)
      {
          Nombre= nombre;
          Apellido= apellido;
          DNI= dni;
          FechaNacimiento= fechaNac; 
      }
    public class Profesor: Persona
    {
        public string Materia;
    }

    public class Alumno: Persona
    {
        public string Legajo;
    }

    public class Curso
    {
        public Alumno[] Alumnos;
        public Profesor[] Profesores;
    }

    }
    class Program
    {
        static void Main(string[] args)
        {
           Persona persona1= new Persona() ;
        }
    }
}
