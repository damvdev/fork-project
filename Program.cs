using System;

namespace Projects {
    public class MyProject
    {
        public static void Main(string[] args)
        {
            const string NameInput = "Introdueix el nom del client:";
            const string AgeInput = "Introdueix l'edat del client:";
            const string DiscountInput = "Introdueix el descompte de l'entrada:";
            const string NoDiscount = "No hi ha descompte";
            const string WrongDiscount = "El descompte no pot ser negatiu o superior al 100%";
            const string AgaingInput = "Torna a introduir el descompte amb valors permesos";

            int age, discount = 0;
            bool done = false;

            Console.WriteLine(NameInput);
            string name = Console.ReadLine();
            Console.WriteLine(AgeInput);
            age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(DiscountInput);
            discount = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (discount == 0)
                {
                    Console.WriteLine(NoDiscount);
                    done = true;
                }
                else if (discount < 0 || discount > 100)
                {
                    Console.WriteLine(WrongDiscount);
                    Console.WriteLine(AgaingInput);
                    discount = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    done = true;
                }
            } while(!done);
            PrintCompte(age, name, discount);
            Console.ReadKey();
        }

        public static void PrintHeader()
        {
            Console.WriteLine("\n" +
                              "*******************************************\n" +
                              "*******************************************\n" +
                              $"************* Control clients *************\n" +
                              "*******************************************\n" +
                              "*******************************************");
        }
        public static bool Jubilat(int edat)
        {
            return edat >= 65;
        }
        public static void PrintCompte(int age, string name, int discount)
        {
            const string FreeEnter = "El client té entrada gratis.";
            const string NoFreeEnter = "El client no té entrada gratis.";

            PrintHeader();
            Console.WriteLine("nom: " + name);
            Console.WriteLine("edat: " + age);
            if (Jubilat(age) || discount == 100)
            {
                Console.WriteLine(FreeEnter);
            }
            else 
            {
                Console.WriteLine(NoFreeEnter);
            }    
        }
    }
}