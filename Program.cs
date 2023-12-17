using System;

namespace Projects
{
    public class MyProject
    {
        public static void Main(string[] args)
        {
            string name = GetClientName();
            int age = GetClientAge();
            int discount = GetDiscount();

            PrintCompte(age, name, discount);
        }

        static string GetClientName()
        {
            Console.WriteLine("Introdueix el nom del client: ");
            return Console.ReadLine();
        }

        static int GetClientAge()
        {
            Console.WriteLine("Introdueix l'edat del client: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int GetDiscount()
        {
            Console.WriteLine("Introdueix el descompte de l'entrada: ");
            int discount = Convert.ToInt32(Console.ReadLine());

            if (discount == 0)
            {
                Console.WriteLine("No s'ha indicat cap descompte");
            }
            else if (discount < 0)
            {
                Console.WriteLine("El descompte no pot ser negatiu");
                return GetDiscount(); 
            }

            return discount;
        }

        static void PrintCompte(int age, string name, int discount)
        {
            PrintHeader();
            Console.WriteLine($"Nom: {name}");
            Console.WriteLine($"Edat: {age}");

            if (IsFreeEntry(age))
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

        static bool IsFreeEntry(int age)
        {
            return IsRetired(age);
        }

        static bool IsRetired(int age)
        {
            return age >= 65;
        }
    }
}
