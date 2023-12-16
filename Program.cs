using System;

namespace Projects
{
    public class MyProject
    {
        public static void Main(string[] args)
        {
            const string AskClientName = "Introdueix el nom del client: ", AskClientAge = "Introdueix l'edat del client: ";
            const string AskDiscount = "Introdueix el descompte de l'entrada: ",DefaultNumValue = "0";
            const string DiscountIsZero = "No s'ha indicat cap descompte",DiscountIsNegative = "El descompte no pot ser negatiu";

            int age, discount;
            string name;

            Console.WriteLine(AskClientName);
            name = Console.ReadLine()??"";
            Console.WriteLine(AskClientAge);
            age = Convert.ToInt32(Console.ReadLine()??DefaultNumValue);
            Console.WriteLine(AskDiscount);
            discount = Convert.ToInt32(Console.ReadLine()??DefaultNumValue);

            if (discount == 0)
            {
                Console.WriteLine(DiscountIsZero);
            }
            else if (discount < 0)
            {
                Console.WriteLine(DiscountIsNegative);
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