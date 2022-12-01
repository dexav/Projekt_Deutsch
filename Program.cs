using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Projekt_Deutsch
{
    internal class Program
    {
    


        private static int richtig = 0;
        private static int versuche = 0;
        private static int rgnrnd1 = 0;
        private static int rgnrnd2 = 0;
        static void Main(string[] args)
        {

            

                using (var reader = new StreamReader(@"C:\Users\xnurs\Desktop\Verben2.txt"))
                {
                    List<string> listinfinitv = new List<string>();
                    List<string> listpraet = new List<string>();
                    List<string> listPart2 = new List<string>();
                    List<string> listDupräs = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        listinfinitv.Add(values[0]);
                        listpraet.Add(values[1]);
                        listPart2.Add(values[2]);
                        listDupräs.Add(values[3]);



                    }
                    void Runde1()
                    {
                    for (richtig = 0; versuche < 10; versuche++)
                    {
                        Console.WriteLine("sage mir die 3 person singular im Präteritum und dann den Partizip 2 von diesem Verb:");
                        Random Verb1 = new Random();
                        int verb1 = Verb1.Next(0, listpraet.Count());
                        Console.WriteLine(listinfinitv[verb1]);
                        string antwort = Console.ReadLine();
                        bool Richtig = antwort.Equals(listpraet[verb1]);
                        if (Richtig == true)
                        {
                            //farbe
                            Console.WriteLine("Richtig ");
                            richtig++;
                        }
                        else
                        {
                            //farbe
                            Console.WriteLine("falsch");
                        }
                    }
                }
                void Runde2()
                {
                    for (richtig = 0; versuche < 10; versuche++)
                    {
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Random Verb1 = new Random();
                            int verb1 = Verb1.Next(0, listpraet.Count());
                        Console.WriteLine("sage mir die 3 person im Präteritum von diesem Verb:");
                            Console.WriteLine(listinfinitv[verb1]);
                            string antwort = Console.ReadLine();
                            bool Richtig = antwort.Equals(listpraet[verb1]);
                            if (Richtig == true)
                            {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Richtig ");
                            richtig++;
                            }
                            else
                            {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("falsch");
                            }
                        }
                    }
                    void Runde3()
                    {
                        Random Verb1 = new Random();
                        int verb1 = Verb1.Next(rgnrnd1, rgnrnd2);
                        Console.WriteLine("runde 3");


                    Console.WriteLine("sage mir die 3 person im Präteritum von diesem Verb:");
                    Console.WriteLine(listpraet[verb1]);
                    string antwort = Console.ReadLine();
                    bool Richtig = antwort.Equals(listpraet[verb1]);
                    if (Richtig == true)
                    {
                        Console.WriteLine("Richtig ");
                    }
                    else
                    {
                        Console.WriteLine("falsch");
                    }
                }


                    Console.WriteLine("ich bin gut (true/false)");
                    bool profi = Convert.ToBoolean(Console.ReadLine());
                    if (profi == true)
                    {
                        rgnrnd1 = 0;
                        rgnrnd2 = 108;
                        Runde2();
                        Runde3();
                    
                        rgnrnd1 = 0;
                        rgnrnd2 = 108;
                        Random Verb1 = new Random();
                        int verb1 = Verb1.Next(rgnrnd1, rgnrnd2);
                        Runde1();
                        Runde2();
                        Runde3();
                    }
                }
            
        }
    }
}

