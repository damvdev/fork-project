using System;
namespace Projects
{
    public class MyProject
    {
        public static void Main()
        {
            int age, discount;
            string name;
            Console.WriteLine("Introdueix el nom del client: ");
            name = Console.ReadLine();
            Console.WriteLine("Introdueix l'edat del client: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introdueix el descompte de l'entrada: ");
            discount = Convert.ToInt32(Console.ReadLine());
            if (discount == 0) Console.WriteLine("No s'ha indicat cap descompte");
            else if (discount < 0) Console.WriteLine("El descompte no pot ser negatiu");
            PrintHeader();
            Console.WriteLine("Nom: " + name);
            Console.WriteLine("Edat: " + age);
            PrintCompte(age, name);
        }
        static void PrintCompte(int age)
        {
            if (Jubilat(age) == true) Console.WriteLine("El client té entrada gratis.");
            else Console.WriteLine("El client no té entrada gratis.");
        }
        static void PrintHeader()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*********** Control clients ***************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
        }
        static bool Jubilat(int edat)
        {
            return edat >= 65;
        }
    }
}
