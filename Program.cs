using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projects {
    public class MyProject
    {
        public static void Main(string[] args)
        {
            const string NAME = "Introdueix el nom del client: ", AGE = "Introdueix l'edat del client: ", HEADER =
                "*******************************************\n" +
                "*******************************************\n" +
                "*********** Control clients ***************\n" +
                "*******************************************\n" +
                "*******************************************";
            int age;
            string name;
            Console.WriteLine(HEADER);
            Console.WriteLine(NAME);
            name = Console.ReadLine() ?? "";
            Console.WriteLine(AGE);
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write(PrintCompte(age, name));
        }
        public static string PrintCompte(int age, string name)
        {
            return (age >= 65) ?
                $"Nom: {name}. Edat: {age}. El client té entrada gratis." :
                $"Nom: {name}. Edat: {age}. El client no té entrada gratis.";
        }
    }
}