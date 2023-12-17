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

            const int Zero=0;

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
                if (discount == Zero)
                {
                    Console.WriteLine(DiscountFalseMsg);
                }
                else if (discount < Zero)
                {
                    Console.WriteLine(DiscountErrorMsg);
                }
            } while (discount < Zero);

            PrintTicket(age, name);
        }

        public static void PrintTicket(int age, string name)
        {
           const string NameMsg = "nom:",
            AgeMsg = "edat:";
           PrintHeader();
           Console.WriteLine(NameMsg, name);
           Console.WriteLine(AgeMsg, age);
            Console.WriteLine(FreeEntry(age) ? "El client te entrada gratis." : "El client no te entrada gratis.");
        }
        public static void PrintHeader()
        {
            Console.WriteLine("*******************************************"+
                              "\n*******************************************"+
                              "\n*********** Control clients ***************"+
                              "\n*******************************************"+
                              "\n*******************************************");
        }
        public static bool FreeEntry(int age)
        {
            return (Pensioner(age));
        }
        public static bool Pensioner(int age)
        {
            return age >= 65;
        }
    }
}