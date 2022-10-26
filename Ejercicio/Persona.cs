using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Persona
    {
        private string nombre;
        private string email;
        private int sueldo;
        private string sexo;
        private int peso;
        private double altura;

        public Persona(string nombre, int sueldo, string sexo, int peso, double altura)
        {
            this.nombre = nombre;
            this.sexo = sexo;
            this.sueldo = sueldo;
            this.peso = peso;
            this.altura = altura;
            CrearEmail();
        }

        private void CrearEmail()
        {
            email = nombre + "@superempresa.com";
        }


        public string GetNombre()
        {
            return nombre;
        }

        public string GetEmail()
        {
            return email;
        }

        public string GetSueldo()
        {
            return sueldo.ToString();
        }

        public string GetSexo()
        {
            return sexo;
        }

        public string GetPeso()
        {
            return peso.ToString();
        }

        public string GetAltura()
        {
            return altura.ToString();
        }

    }
}
