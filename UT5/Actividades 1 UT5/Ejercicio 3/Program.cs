using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Guerrero guerrero1 = new Guerrero("pablo", 18, 60, "hombre", 0, 0, 0, 0, "espada", "Armadura");
            string infoGuerrero = guerrero1.ATexto();
            Console.WriteLine(infoGuerrero);

            Console.WriteLine("Mago:");
            Mago mago1 = new Mago("pablo", 18, 60, "hombre", 0, 0, 0, 0, "Caromagia fundamental", "Rojo");
            string infoMago = mago1.ATexto();
            Console.WriteLine(infoMago);
        }
    }
}
