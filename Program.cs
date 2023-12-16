using System;

namespace Projects
{
    public class MyProject
    {
        public static void Main(string[] args)
        {
            int age, num, discount;
            string name;

            Console.WriteLine("Introdueix el nom del client: ");
            name = Console.ReadLine();
            Console.WriteLine("Introdueix l'edat del client: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introdueix el descompte de l'entrada: ");
            discount = Convert.ToInt32(Console.ReadLine());

            if (discount == 0)
            {
                Console.WriteLine("No s'ha indicat cap descompte");
            }
            else if (discount < 0)
            {
                Console.WriteLine("El descompte no pot ser negatiu");
            }
            PrintCompte(age, name);
        }

        static void PrintCompte(int age, string name)
        {
            PrintHeader();
            Console.WriteLine("nom: " + age);
            Console.WriteLine("edat: " + name);
            Console.WriteLine(EntradaGratis(age) ? "El client té entrada gratis." : "El client no té entrada gratis.");
        }
        static void PrintHeader()
        {
            Console.WriteLine("*******************************************\n*******************************************\n" +
                              "*********** Control clients ***************\n*******************************************\n" +
                              "*******************************************");
        }
        static bool EntradaGratis(int edat)
        {
            return Jubilat(edat);
        }
        static bool Jubilat(int edat)
        {
            return edat >= 65;
        }
    }
}