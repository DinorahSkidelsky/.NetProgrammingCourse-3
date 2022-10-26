using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int sueldo;
            string sexo;
            int peso;
            double altura;

            Console.WriteLine("Bienvenidos al sistema de gestión de personas, a continuación ingrese sus datos:");
            Console.WriteLine("Ingrese nombre:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese sueldo:");
            sueldo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese sexo:");
            sexo = Console.ReadLine();

            Console.WriteLine("Ingrese peso:");
            peso = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese altura:");
            altura = double.Parse(Console.ReadLine());

            Persona primeraPersona = new Persona(nombre, sueldo, sexo, peso, altura);
            Console.WriteLine("");
            Console.WriteLine("Datos de la persona registrada: ");
            Console.WriteLine("-Nombre: " + primeraPersona.GetNombre());
            Console.WriteLine("-Email: " + primeraPersona.GetEmail());
            Console.WriteLine("-Sueldo: " + primeraPersona.GetSueldo() + " ARS");
            Console.WriteLine("-Sexo: " + primeraPersona.GetSexo());
            Console.WriteLine("-Peso: " + primeraPersona.GetPeso() + " kg(B)");
            Console.WriteLine("-Altura: " + primeraPersona.GetAltura() + " m");
            Console.Read();
        }
    }
}
