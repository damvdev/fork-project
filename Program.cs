using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projects {
    public class MyProject
    {
        public static void Main(string[] args)
        {
            const string MsgInputName = "Introdueix el nom del client: ";
            const string MsgInputAge = "Introdueix l'edat del client: ";
            const string MsgInputDiscount = "Introdueix el descompte de l'entrada: ";
            const string MsgDiscount = "El descompte de l'entrada és: ";
            const string MsgNotDiscount = "No s'ha indicat cap descompte";
            const string NotName = "Sin nombre";
            const int zero = 0;
            int age, discount;
            string name;

            Console.WriteLine(MsgInputName);
            name = Console.ReadLine() ?? NotName;

            Console.WriteLine(MsgInputAge);
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MsgInputDiscount);
            discount = Convert.ToInt32(Console.ReadLine());

            if (discount == zero)
            {
                Console.WriteLine(MsgNotDiscount);
            }
            else if (discount < zero) 
            {
                Console.WriteLine(MsgDiscount);
            }
            PrintCompte(age, name);
        }

        static void PrintCompte(int age, string name)
        {
            const string MsgName = "nom: {0}";
            const string MsgAge = "edat: {0}";
            const string MSGTicketFree = "El client té entrada gratis.";
            const string MSGTicketNoFree = "El client no té entrada gratis.";
            const int one = 1;

            PrintHeader();
            Console.WriteLine(MsgName, age);
            Console.WriteLine(MsgAge, name);

            Console.WriteLine(EntradaGratis(age) == one ? MSGTicketFree : MSGTicketNoFree);   
        }
        static void PrintHeader()
        {
            const string MsgAsterisks = "*******************************************";
            const string MsgHeader = "*********** Control clients ***************";

            Console.WriteLine(MsgAsterisks);
            Console.WriteLine(MsgAsterisks);
            Console.WriteLine(MsgHeader);
            Console.WriteLine(MsgAsterisks);
            Console.WriteLine(MsgAsterisks);
        }
        static int EntradaGratis(int edat)
        {
            return (Jubilat(edat)) ? 1 : 0;
        }
        static bool Jubilat(int edat)
        {
            return edat >= 65;
        }
    }
}