using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projects
{
    public class MyProject
    {
        public static void Main(string[] args)
        {
            const string GetNameMsg = "Introdueix el nom del client:",
              GetAgeMsg = "Introdueix l'edat del client: ",
              GetDiscountMsg = "Introdueix el descompte de l'entrada: ",
              DiscountFalseMsg = "No s'ha indicat cap descompte",
              DiscountErrorMsg = "El descompte no pot ser negatiu";

            string name;
            int age, discount;

            Console.WriteLine(GetNameMsg);
            name = Console.ReadLine() ?? "Antonio";

            Console.WriteLine(GetAgeMsg);
            age = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine(GetDiscountMsg);
                discount = Convert.ToInt32(Console.ReadLine());
                if (discount == 0)
                {
                    Console.WriteLine(DiscountFalseMsg);
                }
                else if (discount < 0)
                {
                    Console.WriteLine(DiscountErrorMsg);
                }
            } while (discount < 0);

            PrintCompte(age, name);
        }

        static void PrintCompte(int age, string name)
        {
            const string NameMsg = "nom [0]",
              AgeMsg = "edat: [0]";
            PrintHeader();
            Console.WriteLine(NameMsg, name);
            Console.WriteLine(AgeMsg, age);
            Console.WriteLine(EntradaGratis(age) ? "El client té entrada gratis." : "El client no té entrada gratis.");

        }
        static void PrintHeader()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*********** Control clients ***************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
        }
        static bool EntradaGratis(int edat)
        {
            return (Jubilat(edat));
        }
        static bool Jubilat(int edat)
        {
            return edat >= 65;
        }
    }
}