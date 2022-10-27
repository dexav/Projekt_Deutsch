
using System.Runtime.CompilerServices;

namespace Projekt_Deutsch
{
    internal class Program
    {
        




        static void Main(string[] args)
        {
            string[] infinitiv =
{
            
        };
            string[] Präsenz =
            {

        };
            string[] Partizip2 =
            {

        };
            string[] Präteritum =
            {

        };
            
            int richtig = 0;
            int versuche = 0;


            Console.WriteLine("ich bin gut (true/false)");
            bool profi = Convert.ToBoolean(Console.ReadLine());

            if (profi == true)
            {

                Random Verb1 = new Random();
                int verb1 = Verb1.Next(0, 20);

                Runde2();
                Runde3();
            }
            else
            {
                
                Random Verb1 = new Random();
                int verb1 = Verb1.Next(21, 40);
                Runde1();
                Runde2();
                Runde3();
            }
                static void Runde1()
                {

                for (versuche = 0; versuche / richtig > 0.69; versuche++) ;
                    
                }
                static void Runde2()
                {
                    Console.WriteLine("sage mir die 3 person im Präteritum von diesem Verb:");
                    Console.WriteLine(Präteritum[]);
                }
                static void Runde3()
                {
                Console.WriteLine("runde 3");
                }
        }
    }
}
