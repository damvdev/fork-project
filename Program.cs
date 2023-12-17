using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projects {
    public class MyProject
    {
        public static void Main(string[] args)
        {
            int age, num, discount = 0;
            const string MsgIntNom = "Introdueix el nom del client: ";
            const string MsgIntEdad = "Introdueix l'edat del client: ";
            const string MsgIntDesc = "Introdueix el descompte de l'entrada: ";
            const string MsgNotDesc = "No s'ha indicat cap descompte";
            const string MsgNotDesCMinus = "El descompte no pot ser negatiu"; 
            string name;

            Console.WriteLine(MsgIntNom);
            name = Console.ReadLine();
            Console.WriteLine(MsgIntEdad);
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MsgIntDesc);
            discount = Convert.ToInt32(Console.ReadLine());
            if (discount == 0)
            {
                Console.WriteLine(MsgNotDesc);
            }
            else if (discount < 0) {
                Console.WriteLine(MsgNotDesCMinus);
            }
            PrintCompte(age, name);
        }

        public static void PrintCompte(int age, string name)
        {
            const string MsgClientNTicket = "El client té entrada gratis.";
            const string MsgClientNotTicket = "El client no té entrada gratis.";
            PrintHeader();
            Console.WriteLine($"nom: {name} ");
            Console.WriteLine($"edat: {age} ");
            if (EntradaGratis(age) == 1)
            {
                Console.WriteLine(MsgClientNTicket);
            }
            else 
            {
                Console.WriteLine(MsgClientNotTicket);
            }    
        }
        public static void PrintHeader()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*********** Control clients ***************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
        }
        public static int EntradaGratis(int edat)
        {
            return (Jubilat(edat)) ? 1 : 0;
        }
        public static bool Jubilat(int edat)
        {
            return edat >= 65;
        }
    }
}