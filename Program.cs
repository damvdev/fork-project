using System;

namespace Projects
{
    public class MyProject
    {
        public static void Main(string[] args)
        {
            //Asignem els misatges com a constants.
            const string AskCustomerName = "Introdueix el nom del client:";
            const string AskCustomerAge = "Introdueix l'edat del client:";
            const string AskCustomerDiscount = "Introdueix el descompte de l'entrada:";
            const string MsgNotDiscount = "No s'ha indicat cap descompte";
            const string MsgInvalidDiscount = "El descompte no pot ser negatiu";
            const string MsgValidDiscount = "El descompte de {0} queda guardat correctament";

            int age, discount;
            string name;

            name = StringUserInput(AskCustomerName);
            age = IntUserInput(AskCustomerAge);
            discount = IntUserInput(AskCustomerDiscount);

            //Si el cliente introdueix un nombre negatiu (invalid), la maquina li seguirà demanant un descompte, sino en té cap haurà d'introdüir un 0, perque la maquina no pararà
            while (discount < 0)
            {
                Console.WriteLine(MsgInvalidDiscount);
                discount = IntUserInput(AskCustomerDiscount);
            }

            //Utilitzem un operador ternari per indicar si el cliente té descomptes o no
            Console.WriteLine(discount == 0 ? MsgNotDiscount : MsgValidDiscount, discount);

            PrintCompte(age, name);
        }

        public static void PrintCompte(int age, string name)
        {
            //Creem una constant on s'agrupi les dades del client
            const string MsgCustomerData = "Nom: {0} \nEdat: {1}";

            //Creem constants de missatges per tenir més control de codi
            const string MsgFreeTicket = "El client té entrada gratis.";
            const string MsgNotFreeTicket = "El client no té entrada gratis.";


            PrintHeader();

            //Printem per pantalla les dades amb només una crida
            Console.WriteLine(MsgCustomerData, name, age);

            Console.WriteLine(EntradaGratis(age) ? MsgFreeTicket : MsgNotFreeTicket); 
        }
        public static void PrintHeader()
        {
            //Enlloc de printar cinc vegades, printem només una amb salts de linea
            Console.WriteLine("*******************************************" +
                            "\n*******************************************" +
                            "\n*********** Control clients ***************" +
                            "\n*******************************************" +
                            "\n*******************************************");
        }
        public static bool EntradaGratis(int edat)
        {
            //Enlloc de retornar 1 i 0, ho fem directament amb dades boleans (true i false)
            return Jubilat(edat);
        }
        public static bool Jubilat(int edat)
        {
            return edat >= 65;
        }
        public static string StringUserInput (string msg)
        {
            //Creem una funcio fer mostrar un missatge al usuari i demanar que introdueixi una dada del tipus STRING
            Console.WriteLine(msg);
            return Console.ReadLine();
        }
        public static int IntUserInput(string msg)
        {
            //Creem una funcio fer mostrar un missatge al usuari i demanar que introdueixi una dada del tipus INT
            Console.WriteLine(msg);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}