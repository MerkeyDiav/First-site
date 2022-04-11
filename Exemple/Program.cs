// See https://aka.ms/new-console-template for more information
using System;
namespace apk
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nehemie est con n'est-ce pas ?");
            int jesuis = testDeSaisie();
            
        }

        static int testDeSaisie()
        {
            int nombre =0 ;
            string saisie ;
            bool isvalid = false;
            while (!isvalid)
            {
                saisie = Console.ReadLine();
                if(int.TryParse(saisie , out nombre))
                {
                    nombre = int.Parse(saisie);
                    isvalid = true ;
                }
                else
                {
                    Console.WriteLine("Recommencez, saisie incorrecte !!!");
                }
            }
            return nombre;
        }
    }
}