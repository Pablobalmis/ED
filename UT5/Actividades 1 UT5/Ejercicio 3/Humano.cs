using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_4
{
    class Humano
    {
        /// <summary>
        /// Clase Humano la clase de la cual parten mago y guerrero
        /// </summary>
        // Campos 
        protected string nombre;
        protected int edad;
        protected int peso;
        protected string sexo;
        protected int inteligencia;
        protected int fuerza;
        protected int destreza;
        protected int energia;

        // Constructor
        public Humano(string nombre, int edad, int peso, string sexo, int inteligencia, int fuerza, int destreza, int energia)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.peso = peso;
            this.sexo = sexo;
            this.inteligencia = inteligencia;
            this.fuerza = fuerza;
            this.destreza = destreza;
            this.energia = energia;
        }
        public Humano(Humano H)
        {
            nombre = H.GetNombre();
            edad = H.GetEdad();
            peso = H.GetPeso();
            sexo = H.GetSexo();
            inteligencia = H.GetInteligencia();
            fuerza = H.GetFuerza();
            destreza = H.GetDestreza();
            energia = GetEnergia();
        }

        // Getters
        public string GetNombre()
        {
            return nombre;
        }
        public int GetEdad()
        {
            return edad;
        }
        public int GetPeso()
        {
            return peso;
        }
        public string GetSexo()
        {
            return sexo;
        }
        public int GetInteligencia()
        {
            return inteligencia;
        }
        public int GetFuerza()
        {
            return fuerza;
        }
        public int GetDestreza()
        {
            return destreza;
        }
        public int GetEnergia()
        {
            return energia;
        }
        // Setters
        public void SetNombre(string nuevoNombre)
        {
            nombre = nuevoNombre;
        }
        public void SetEdad(int nuevaEdad)
        {
            edad = nuevaEdad;
        }
        public void SetPeso(int nuevoPeso)
        {
            peso = nuevoPeso;
        }
        public void SetSexo(string nuevoSexo)
        {
            sexo = nuevoSexo;
        }
        public void SetInteligencia(int nuevaInteligencia)
        {
            inteligencia = nuevaInteligencia;
        }
        public void Setfuerza(int NuevaFuerza)
        {
            fuerza = NuevaFuerza;
        }
        public void SetDestreza(int nuevaDestreza)
        {
            destreza = nuevaDestreza;
        }
        public void SetEnergia(int nuevaEnergia)
        {
            energia = nuevaEnergia;
        }
        // Metodos

        public virtual string ATexto()
        {
            string cadena = "Nombre: "+GetNombre()+"\nEdad: "+GetEdad()+ "\nPeso:"+ GetPeso()+"\nSexo: "+ GetSexo()+"\nInteligencia: "+GetInteligencia()+
                "\nFuerza: "+ GetFuerza()+ "\nDestreza: "+ GetDestreza()+"\nEnergia: "+GetEnergia();

            return cadena;
        }
    }
}
