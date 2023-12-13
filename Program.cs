using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projects {
    public class MyProject
    {
        public static void Main(string[] args)
        {
            const string nameAsk = "Introdueix el nom del client: ";
            const string ageAsk = "Introdueix l'edat del client: ";
            const string discountAsk = "Introdueix el descompte de l'entrada: ";
            const string nullDiscount = "No s'ha indicat cap descompte";
            const string negativeDiscount = "El descompte no pot ser negatiu";
            
            int age;
            int discount;

            string name;


            Console.WriteLine(nameAsk);
            name = Console.ReadLine();

            Console.WriteLine(ageAsk);
            age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(discountAsk);
            discount = Convert.ToInt32(Console.ReadLine());

            if (discount == 0)
            {
                Console.WriteLine(nullDiscount);
            }
            else if (discount < 0) {
                Console.WriteLine(negativeDiscount);
            }
            printCompte(age, name);
        }

        public static void printCompte(int age, string name)
        {
            const string freeTicket = "El client té entrada gratis.";
            const string notFreeTicket = "El client no té entrada gratis.";

            printHeader();
            Console.WriteLine($"nom: {name}");
            Console.WriteLine($"edat: {age}");

            if (freeEntry(age) == true)
            {
                Console.WriteLine(freeTicket);
            }
            else 
            {
                Console.WriteLine(notFreeTicket);
            }    
        }
        public static void printHeader()
        {
            const string controlClients = "*******************************************\n" +
                "*******************************************\n" +
                "*********** Control clients ***************\n" +
                "*******************************************\n" +
                "*******************************************";
            Console.WriteLine(controlClients);
        }
        public static bool freeEntry(int edat)
        {
            if (edat>=65) return true;
            return false;
        }
    }
}