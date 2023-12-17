using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projects
{
    public class MyProject
    {
        public static void Main(string[] args)
        {
            int age;
            string name;
            const string MsgInputName = "Introdueix el nom del client: ";
            const string MsgInputAge = "Introdueix l'edat del client: ";

            PrintHeader();
            Console.WriteLine();

            Console.Write(MsgInputName);
            name = Console.ReadLine();
            Console.WriteLine();

            Console.Write(MsgInputAge);
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            PrintCompte(age, name);
        }
        public static void PrintHeader()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*********** Control clients ***************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
        }
        public static void PrintCompte(int age, string name)
        {
            Console.WriteLine("nom: " + age);
            Console.WriteLine("edat: " + name);
            if (EntradaGratis(age))
            {
                Console.WriteLine("El client té entrada gratis.");
            }
            else
            {
                Console.WriteLine("El client no té entrada gratis.");
            }
        }
        public static bool EntradaGratis(int edat)
        {
            return edat >= 65 ? true : false;
        }
    }
}