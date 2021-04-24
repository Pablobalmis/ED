using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_4
{
    class Mago:Humano
    {
        /// <summary>
        /// Clase mago, hereda de humano y le añade el tipo de tunica y el libro de hechizos
        /// </summary>
        //campos
        private string tipoLibroHechizos;
        private string tipoTunica;

        //Constructores

        public Mago(string nombre, int edad, int peso, string sexo, int inteligencia, int fuerza, int destreza, int energia, string tipoLibroHechizos, string tipoTunica)
            : base(nombre, edad, peso, sexo, inteligencia, fuerza, destreza, energia)
        {
            this.tipoLibroHechizos = tipoLibroHechizos;
            this.tipoTunica = tipoTunica;
        }

        //Getters
        public string GetTipoLibroHechizos()
        {
            return tipoLibroHechizos;
        }
        public string GetTipoTunica()
        {
            return tipoTunica;
        }

        //Setters
        private void SetTipoLibroHechizos(string nuevaLibroHechizos)
        {
            this.tipoLibroHechizos = nuevaLibroHechizos;
        }
        private void SetTipoTunica(string nuevaTunica)
        {
            this.tipoTunica = nuevaTunica;
        }

        //Metodos
        public override string ATexto()
        {
            string cadena = base.ATexto() + "\nLibro de hechizos:" + GetTipoLibroHechizos() + "\nTunica: " + GetTipoTunica();

            return cadena;
        }
    }
}
