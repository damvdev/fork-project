using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projects {
    public class MyProject
    {
        public static void Main(string[] args)
        {
            int age;
            int num;
            string name;
            Console.WriteLine("Introdueix el nom del client: ");
            name = Console.ReadLine();
            Console.WriteLine("Introdueix l'edat del client: ");
            age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Introdueix el descompte de l'entrada: ");
            if (discount == 0)
            {
                Console.WriteLine("No s'ha indicat cap descompte");
            }
            else if (discount < 0) {
                Console.WriteLine("El descompte no pot ser negatiu");
            }
            PrintCompte(age, name);
        }

        static void PrintCompte(int age, string name)
        {
            PrintHeader();
            Console.WriteLine("nom: " + age);
            Console.WriteLine("edat: " + name);
            if (EntradaGratis(age) == 1)
            {
                Console.WriteLine("El client té entrada gratis.");
            }
            else 
            {
                Console.WriteLine("El client no té entrada gratis.");
            }    
        }
        static void PrintHeader()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*********** Control clients ***************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
        }
        static int EntradaGratis(int edat)
        {
            return (Jubilat(edat)) ? 1 : 0;
        }
        static bool Jubilat(int edat)
        {
            return edat >= 65;
        }
    }
}