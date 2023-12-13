using System;

namespace Projects
{
    public class MyProject
    {
        public static void Main()
        {
            int age, discount;
            string name;

            Console.Write("Introdueix el nom del client: ");
            name = Console.ReadLine() ?? "";

            Console.Write("Introdueix l'edat del client: ");
            age = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.Write("Introdueix el descompte de l'entrada: ");
                discount = Convert.ToInt32(Console.ReadLine());

                if (discount == 0)
                {
                    Console.WriteLine("No s'ha indicat cap descompte");
                }
                else if (discount < 0)
                {
                    Console.WriteLine("El descompte no pot ser negatiu");
                }

            } while (discount < 0);

            PrintCompte(age, name);
        }

        public static void PrintCompte(int age, string name)
        {
            PrintHeader();

            Console.WriteLine("nom: " + name);
            Console.WriteLine("edat: " + age);

            if (EsJubilat(age))
            {
                Console.WriteLine("El client té entrada gratis.");
            }
            else
            {
                Console.WriteLine("El client no té entrada gratis.");
            }
        }

        public static void PrintHeader()
        {
            const string MsgAsteriscs = ("*******************************************");

            Console.WriteLine(MsgAsteriscs);
            Console.WriteLine(MsgAsteriscs);
            Console.WriteLine("*********** Control clients ***************");
            Console.WriteLine(MsgAsteriscs);
            Console.WriteLine(MsgAsteriscs);
        }

        public static bool EsJubilat(int edat)
        {
            return edat >= 65;
        }
    }
}