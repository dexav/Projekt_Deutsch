using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Projekt_Deutsch
{
    internal class Program
    {

        private static string[] infinitiv =
{

        };
        private static string[] Präsenz =
        {

        };
        private static string[] Partizip2 =
        {

        };
        private static string[] Präteritum =
        {

        };

        private static int richtig = 0;
        private static int versuche = 0;
        private static int rgnrnd1 = 0;
        private static int rgnrnd2 = 0;






        static void Main(string[] args)
        {

            Console.WriteLine("ich bin gut (true/false)");
            bool profi = Convert.ToBoolean(Console.ReadLine());

            if (profi == true)
            {
                rgnrnd1 = 0;
                rgnrnd2 = 20;



                Runde2();
                Runde3();
            }
            else
            {
                rgnrnd1 = 21;
                rgnrnd2 = 40;

                Random Verb1 = new Random();
                int verb1 = Verb1.Next(rgnrnd1, rgnrnd2);
                Runde1();
                Runde2();
                Runde3();
            }
                static void Runde1()
                {

                for (versuche = 0; versuche / richtig < 0.7; versuche++)
                {
                    Random Verb1 = new Random();
                    int verb1 = Verb1.Next(rgnrnd1, rgnrnd2);
                    
                }
                

                }
                static void Runde2()
                {
                Random Verb1 = new Random();
                int verb1 = Verb1.Next(rgnrnd1, rgnrnd2);

                Console.WriteLine("sage mir die 3 person im Präteritum von diesem Verb:");
                Console.WriteLine(Präteritum[verb1]);
                }
                static void Runde3()
                {
                    Random Verb1 = new Random();
                    int verb1 = Verb1.Next(rgnrnd1, rgnrnd2);
                    Console.WriteLine("runde 3");
                }
        }
    }
}
