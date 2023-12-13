using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projects {
    public class MyProject
    {
        public static void Main(string[] args)
        {
            int age, discount;
            string name;
            const string Header = "*******************************************\n*******************************************\n*********** Control clients ***************\n*******************************************\n*******************************************",
                IntroName= "Introdueix el nom del client: ", IntroAge= "Introdueix l'edat del client: ", IntroDiscount= "Introdueix el descompte de l'entrada: ", ErrorDiscount= "El descompte no pot ser negatiu, introdueix un descompte vàlid";
            Console.WriteLine(IntroName);
            name = Console.ReadLine() ?? "";
            Console.WriteLine(IntroAge);
            age = Convert.ToInt32(Console.ReadLine());
            if (age >= 65)
            {
                Console.WriteLine(Header);
                Console.WriteLine(PrintCompte(age, name));
            }
            else
            {
                Console.WriteLine(IntroDiscount);
                discount = Convert.ToInt32(Console.ReadLine());
                while (discount < 0)
                {
                    Console.WriteLine(ErrorDiscount);
                    discount = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine(Header);
                Console.WriteLine(PrintCompte(age, name, discount));
            }
        }
        public static string PrintCompte(int age, string name)
        {
            return "nom: " + name + "\nedat: " + age + "\nEl client té entrada gratis.";
        }
        public static string PrintCompte(int age, string name, int discount)
        {
            if (discount == 0)
            {
                return "nom: " + name + "\nedat: " + age + "\nNo s'ha indicat cap descompte";
            }
            else
            {
                return "nom: " + name + "\nedat: " + age + "\nEl client té un descompte de: " + discount;
            }
        }
    }
}