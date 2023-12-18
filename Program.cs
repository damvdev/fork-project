

namespace Projects {
    public class MyProject
    {
        public static void Main(string[] args)
        {
            const string customerNameMessage = "Introdueix el nom del client: ";
            const string customerAgeMessage = "Introdueix l'edat del client: ";
            const string customerDiscountMessage = "Introdueix el descompte de l'entrada: ";
            const string noDiscountMessage = "No s'ha indicat cap descompte";
            const string negativeDiscountError = "El descompte no pot ser negatiu";

            int age;
            int discount;

            string name;

            Console.WriteLine(customerNameMessage);
            name = Console.ReadLine();
            Console.WriteLine(customerAgeMessage);
            age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(customerDiscountMessage);
            discount = Convert.ToInt32(Console.ReadLine());
            if (discount == 0)
            {
                Console.WriteLine(noDiscountMessage);
            }
            else if (discount < 0) {
                Console.WriteLine(negativeDiscountError);
            }
            PrintCompte(age, name);
        }

        static void PrintCompte(int age, string name)
        {
            const string freeMessage = "El client té entrada gratis.";
            const string notFreeMessage = "El client no té entrada gratis.";

            PrintHeader();
            Console.WriteLine("Nom: " + age);
            Console.WriteLine("Edat: " + name);
            Console.WriteLine(EntradaGratis(age) == 1 ? freeMessage : notFreeMessage);
        }
        static void PrintHeader()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*********** Control clients ***************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
        }
        static int EntradaGratis(int edat)
        {
            return Jubilat(edat) ? 1 : 0;
        }
        static bool Jubilat(int edat)
        {
            return edat >= 65;
        }
    }
}