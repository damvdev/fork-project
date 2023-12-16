using System;

namespace Projects
{
    public class MyProject
    {
        public static void Main(string[] args)
        {
            const string AskClientName = "Introdueix el nom del client: ", AskClientAge = "Introdueix l'edat del client: ";
            const string DefaultNumValue = "0";

            int age, discount;
            string name;

            Console.WriteLine(AskClientName);
            name = Console.ReadLine()??"";
            Console.WriteLine(AskClientAge);
            age = Convert.ToInt32(Console.ReadLine()??DefaultNumValue);
            PrintCompte(age, name);
        }

        public static void PrintCompte(int age, string name)
        {
            PrintHeader();
            Console.WriteLine("nom: " + name);
            Console.WriteLine("edat: " + age);
            Console.WriteLine(EntradaGratis(age) ? "El client té entrada gratis." : "El client no té entrada gratis.");
        }
        public static void PrintHeader()
        {
            Console.WriteLine("*******************************************\n*******************************************\n" +
                              "*********** Control clients ***************\n*******************************************\n" +
                              "*******************************************");
        }
        public static bool EntradaGratis(int age)
        {
            return Jubilat(age);
        }
        public static bool Jubilat(int age)
        {
            return age >= 65;
        }
    }
}