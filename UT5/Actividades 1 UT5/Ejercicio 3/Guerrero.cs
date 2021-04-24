using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_4
{
    class Guerrero :Humano
    {
        /// <summary>
        /// Clase guerrero, hereda de humano le añade aramadura y tipo de armadura
        /// </summary>
        //campos
        private string tipoArma;
        private string tipoArmadura;

        //Constructores

        public Guerrero(string nombre, int edad, int peso, string sexo, int inteligencia, int fuerza, int destreza, int energia, string tipoArma, string tipoArmadura) 
            :base( nombre,  edad,  peso,  sexo,  inteligencia,  fuerza,  destreza,  energia)
        {
            this.tipoArma = tipoArma;
            this.tipoArmadura = tipoArmadura;
        }

        //Getters
        public string GetTipoArma()
        {
            return tipoArma;
        }
        public string GetTipoArmadura()
        {
            return tipoArmadura;
        }

        //Setters
        private void SetTipoArmadura(string nuevaArmadura)
        {
            this.tipoArmadura = nuevaArmadura;
        }
        private void SetTipoArma(string nuevaArma)
        {
            this.tipoArma = nuevaArma;
        }

        //Metodos
        public override string ATexto()
        {
            string cadena = base.ATexto()+"\nArmadura:"+GetTipoArmadura()+"\nArma: "+GetTipoArma();

            return cadena;
        }
    }
}
