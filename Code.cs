using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Projekt_Deutsch
{
    internal class Program
   
     {

            var item = new List<string>();
            var data = new List<List<string>>();
            var file = @"C:\Users\xnurs\Desktop\Verben.txt";

            data = ReadFromFile(file);
            
            string[][] dataArray = data.Select(a => a.ToArray()).ToArray(); 

         
            for (int i = 0; i < dataArray.Length; i++)
            {
                for (int j = 0; j < dataArray[i].Length; j++)
                {
                    Console.WriteLine(dataArray[i][j]);
                }
            }



        }
        static List<List<string>> ReadFromFile(string filename)
        {
            var fileItem = new List<string>();
            var fileData = new List<List<string>>();
            using (var sr= new StreamReader(filename))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    fileItem = line.Split('\t').ToList();
                    fileData.Add(fileItem);
                }
                return fileData;
            }

        }
    
    
    
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
