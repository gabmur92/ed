using System;

namespace CHolaMundo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string nombre;
            int edad;
            int a;
            int b;
            int suma;
            int resta;
            int mult;
            double div;
            int ra;
            int cont=0;
            int numero = 0;
            System.Random r = new System.Random();
            ra = (r.Next(0, 50 + 1));
            Console.WriteLine(ra);
            Console.WriteLine("introduce tu nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("hola " + nombre + " dime tu edad");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine(nombre + " tienes " + edad + " años");

            Console.WriteLine("dame una cifra");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("dame otro numero");
            b = int.Parse(Console.ReadLine());
            suma = a + b;
            resta = a - b;
            mult = a * b;
            div = a / b;
            Console.WriteLine("operaciones: suma" + suma+" resta "+resta+" multiplicacion "+ mult+ " division "+div);
            Console.WriteLine("adivina el numero..");
           
            do
            {
                numero = int.Parse(Console.ReadLine());
                if (numero != ra)
                {
                    Console.WriteLine("sigue intentandolo");
                    cont++;
                }

            } while (numero == ra);
            {
                Console.WriteLine("has ganado con: "+cont+" intentos");
            }
        }
    }
}
