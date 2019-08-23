using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Grupo> grupos = new List<Grupo>();

            Grupo Matematicas = new Grupo("Matematicas", "MAT5736");
            Grupo Historia = new Grupo("Historia", "HST2149");

            grupos.Add(Matematicas);
            grupos.Add(Historia);

            Alumno juan = new Alumno("Juan", "78921");
            Alumno maria = new Alumno("maria", "45976");
            Alumno pedro = new Alumno("pedro", "36489");
            Alumno pablo = new Alumno("pablo", "78141");
            Alumno ana = new Alumno("ana", "14625");

            Historia.Alumnos.Add(juan);
            Historia.Alumnos.Add(ana);
            Historia.Alumnos.Add(pedro);

            Matematicas.Alumnos.Add(juan);
            Matematicas.Alumnos.Add(maria);
            Matematicas.Alumnos.Add(pedro);
            Matematicas.Alumnos.Add(ana);
            Matematicas.Alumnos.Add(pablo);

            foreach (Grupo grupo in grupos)
            {
                Console.WriteLine("Grupo: " + grupo.Codigo);
                Console.WriteLine("Materia: " + grupo.Materia);
                Console.WriteLine("Lista de alumnos:");

                foreach (Alumno alumno in grupo.Alumnos)
                {
                    Console.WriteLine("*" + alumno.Nombre);
                }

            }

            Console.Read();
        }
    }
}
