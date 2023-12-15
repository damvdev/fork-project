using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projects {
    public class MyProject
    {
        public static void Main(string[] args)
        {
            int age, num, discount;
            string name;
            
            const string IntroName = "Introdueix el nom del client: ", IntroSurname = "Introdueix l'edat del client: ", Desc = "Introdueix el descompte de l'entrada: ", ErrorVoid = "No s'ha indicat cap descompte", ErrorNegative = "El descompte no pot ser negatiu";
            Console.WriteLine(IntroName);
            name = Console.ReadLine();
            Console.WriteLine(IntroSurname);
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Desc);
            discount = Convert.ToInt32(Console.ReadLine());
            if (discount == 0)
            {
                Console.WriteLine(ErrorVoid);
            }
            else if (discount < 0) {
                Console.WriteLine(ErrorNegative);
            }
            PrintCompte(age, name);
        }

        public static void PrintCompte(int age, string name)
        {
            const string header = @"
                                *******************************************
                                *******************************************
                                *********** Control clients ***************
                                *******************************************
                                *******************************************";
            Console.WriteLine(header);
            Console.WriteLine("nom: " + age);
            Console.WriteLine("edat: " + name);
            if (EntradaGratis(age) == 1) Console.WriteLine("El client té entrada gratis.");
            else Console.WriteLine("El client no té entrada gratis.");  
        }

        public static int EntradaGratis(int edat)
        {
            return (Jubilat(edat)) ? 1 : 0;
        }
        public static bool Jubilat(int edat)
        {
            return edat >= 65;
        }
    }
}