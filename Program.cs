 using System;

namespace Projects {
    public class MyProject
    {
        public static void Main()
        {
            const string MsgInName = "Introdueix el nom del client: ";
            const string MsgInAge = "Introdueix l'edat del client: ";
            const string MsgInDiscount = "Introdueix el descompte de l'entrada: ";
            const string MsgNoDiscount = "No s'ha indicat cap descompte";
            const string MsgNegativeDiscount = "El descompte no pot ser negatiu";
            int age,discount;
            string name;

            Console.WriteLine(MsgInName);
            name = Console.ReadLine();
            Console.WriteLine(MsgInAge);
            age = Convert.ToInt32(Console.ReadLine());       
            Console.WriteLine(MsgInDiscount);
            discount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (discount == 0)
            {
                Console.WriteLine(MsgNoDiscount);
            }
            else if (discount < 0) {
                Console.WriteLine(MsgNegativeDiscount);
            }
            PrintBill(age, name);
        }

        public static void PrintBill(int age, string name)
        {
            const string MsgName = "nom: ";
            const string MsgAge = "edat: ";
            const string MsgFreeEntrance = "El client té entrada gratis.";
            const string MsgNoFreeEntrance = "El client no té entrada gratis.";
            PrintHeader();
            Console.WriteLine(MsgName + name);
            Console.WriteLine(MsgAge + age);
            Console.WriteLine(Retired(age) ?  MsgFreeEntrance: MsgNoFreeEntrance);
        }
        public static void PrintHeader()
        {
            const string Header = "*******************************************\n*******************************************\n*********** Control clients ***************\n*******************************************\n*******************************************";
            Console.WriteLine(Header);
        }
        public static bool Retired(int age)
        {
            return age >= 65;
        }
    }
}