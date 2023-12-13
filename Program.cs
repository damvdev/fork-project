using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projects {

    // Canviar el nom de la classe per a que sigui intepretable
    public class TicketInfo
    {
        public static void Main(string[] args)
        {
            // Es declaren constants amb els missatges a usuari i magic numbers
            const int Zero = 0;

            const string MsgName = "Introdueix el nom del client: ";
            const string MsgAge = "Introdueix l'edat del client: ";
            const string MsgEnterDiscount = "Introdueix el descompte de l'entrada: ";
            const string MsgDiscountNull = "No s'ha indicat cap descompte";
            const string MsgDiscountNegative = "El descompte no pot ser negatiu";

            // Es declaren tots els ints a la mateixa linea
            int age, discount;
            string name;

            Console.WriteLine(MsgName);
            name = Console.ReadLine();

            Console.WriteLine(MsgAge);
            age = Convert.ToInt32(Console.ReadLine());
            
            // Es llegeix el valor del descompte
            Console.WriteLine(MsgEnterDiscount);
            discount = Convert.ToInt32(Console.ReadLine());

            if (discount == Zero)
            {
                Console.WriteLine(MsgDiscountNull);
            }
            else if (discount < Zero) {
                Console.WriteLine(MsgDiscountNegative);
            }

            Console.WriteLine(PrintCheck(age, name));

        }

        // Fer els métodes públics per fer test

        // PrintCheck retorna una string
        public static string PrintCheck(int age, string name)
        {
            //Declarar constants amb els missatges a l'usuari:
            const string MsgName = "nom: {0}";
            const string MsgEdat = "edat: {0}";
            const string MsgFreeTicket = "El client té entrada gratis.";
            const string MsgNotFreeTicket = "El client no té entrada gratis.";

            PrintHeader();

            Console.WriteLine(MsgName, age);
            Console.WriteLine(MsgEdat, name);


            //Fer un operador ternari en comptes d'if else

            return FreeTicket(age) ? MsgFreeTicket : MsgNotFreeTicket;

        }
        public static void PrintHeader()
        {
            //Canviar els 5 writeline amb una constant i un writeline
            const string Header = "*******************************************\n*******************************************\n*********** Control clients ***************\n*******************************************\n*******************************************";
            Console.WriteLine(Header);
        }

        // Canviar els noms dels métodes i les variables per a seguir la documentació
        // Retornar un bool en comptes d'un int
        public static bool FreeTicket(int age)
        {
            return Jubilee(age);
        }

        // Es podria eliminar aquest métode i retornar directament age >= agejubile a FreeTicket, peró ho deixo ja que podría haver més formes d'obtindre un FreeTicket
        public static bool Jubilee(int age)
        {
            const int AgeJubilee = 65;
            return age >= AgeJubilee;
        }
    }
}