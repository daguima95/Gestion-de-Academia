using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestAcaLib.Entities;
using GestAcaLib.Persistence;

namespace TestPersistenciaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GestAcaDAL dal = GestAcaDAL.getGestAcaDAL();
            IStudentDAO estudianteDAO = dal.studentDAO;

            Console.WriteLine("*** Añadir Estudiante: \n");
            Console.WriteLine("introduzca Nombre: ");
            String nombre = Console.ReadLine();

            Console.WriteLine("introduzca DNI: ");
            String id = Console.ReadLine();

            Console.WriteLine("introduzca ZIP: ");
            int zip = Int32.Parse(Console.ReadLine());

            Console.WriteLine("introduzca direccion: ");
            String direccion = Console.ReadLine();

            Console.WriteLine("introduzca IBAN: ");
            String iban = Console.ReadLine();

            Student estudiante = new Student(id,nombre,direccion,zip,iban);
            estudianteDAO.addStudent(estudiante);

            Console.WriteLine("Elementos en la base de datos:");
            ICollection <Student> listaEstudiantes = estudianteDAO.findAllStudents();
            foreach (Student std in listaEstudiantes)
            {
                Console.WriteLine("ID: " + std.Id + ", Nombre: " + std.Name+ ", Codigo ZIP: "+std.ZipCode);
            }

            Console.WriteLine("Pulsa cualquier tecla para salir...");
            Console.ReadKey();


        }
    }
}
