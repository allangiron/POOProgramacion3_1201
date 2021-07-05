using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOProgramacion3_1201
{
    public class Persona
    {
        ////Atributos
        //private string nombre;
        //private string apellido;
        //private int edad;
        //private string direccion;

        ////Propiedades 
        //public string Nombre
        //{
        //    get { return nombre; }
        //    set { nombre = value; }
        //}

        //public string Apellido
        //{
        //    get { return apellido; }
        //    set { apellido = value; }
        //}
        //public int Edad
        //{
        //    get { return edad; }
        //    set { edad = value; }
        //}
        //public string Direccion
        //{
        //    get { return direccion; }
        //    set { direccion = value; }
        //}

        //Otra Manera de Crear las Propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }

        // Contructor Vacio
        public Persona() { }

        // Constructor Con Parametros
        public Persona (string _nombre, string _apellido, int _edad, string _direccion)
        {
            Nombre = _nombre;
            Apellido = _apellido;
            Edad = _edad;
            Direccion = _direccion;
        }

        //Metodos o Funciones
        public string DevolverNombreCompleto()
        {
            return Nombre + " " + Apellido;
            //return Edad + " " + Direccion;
        }

        public string DevolverDireccion()
        {
            return Edad + " " + Direccion;
        }

    }
}
