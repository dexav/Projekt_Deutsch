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
            using (var reader = new StreamReader(@"C:\Users\leona\Desktop\VerbenFürDeutsch.txt"))
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
                    do
                    {
                        for (richtig = 0; versuche < 10; versuche++)
                        {
                            Console.WriteLine("sage mir die 3 person singular im Präteritum und dann den Partizip 2 von diesem Verb:");
                            Random Verb1 = new Random();
                            int verb1 = Verb1.Next(0, 37);
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
                            Console.WriteLine(listinfinitv[verb1]);
                            antwort = Console.ReadLine();
                            Richtig = antwort.Equals(listPart2[verb1]);
                            if (Richtig == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Richtig ");
                                richtig++;
                                versuche++;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("falsch");
                                versuche++;
                            }
                        }
                    } while (versuche / richtig < 0.70);
                }
                void Runde2()
                {
                    do
                    {
                        for (richtig = 0; versuche < 10; versuche++)
                        {
                            Console.WriteLine("sage mir die 3 person singular im Präteritum dann den Partizip 2 und dann 2 Person singular im Präsenz von diesem Verb:");
                            Random Verb1 = new Random();
                            int verb1 = Verb1.Next(0, listpraet.Count());
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
                                Console.ForegroundColor = ConsoleColor.White;

                            }
                            antwort = Console.ReadLine();
                            Richtig = antwort.Equals(listPart2[verb1]);
                            if (Richtig == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Richtig ");
                                richtig++;
                                Console.ForegroundColor = ConsoleColor.White;

                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("falsch");
                                Console.ForegroundColor = ConsoleColor.White;

                            }
                            antwort = Console.ReadLine();
                            Richtig = antwort.Equals(listDupräs[verb1]);
                            if (Richtig == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Richtig ");
                                richtig++;
                                versuche++;
                                Console.ForegroundColor = ConsoleColor.White;

                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("falsch");
                                versuche++;
                                Console.ForegroundColor = ConsoleColor.White;

                            }

                        }
                    } while (versuche / richtig < 0.70);
                }
                void Runde3()
                {
                    do
                    {
                        for (richtig = 0; versuche < 10; versuche++)
                        {
                            Random abfrage = new Random();
                            int Abgefragt = abfrage.Next(0, 4);
                            if (Abgefragt == 1)
                            {
                                Console.WriteLine("sage mir die 3 person singular im Präteritum dann den Partizip 2 und dann 2 Person singular im Präsenz von diesem Verb:");
                                Random Verb1 = new Random();
                                int verb1 = Verb1.Next(0, listpraet.Count());
                                Console.WriteLine(listinfinitv[verb1]);
                                string antwort = Console.ReadLine();
                                bool Richtig = antwort.Equals(listpraet[verb1]);
                                if (Richtig == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Richtig ");
                                    richtig++;
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("falsch");
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                                antwort = Console.ReadLine();
                                Richtig = antwort.Equals(listPart2[verb1]);
                                if (Richtig == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Richtig ");
                                    richtig++;
                                    versuche++;
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("falsch");
                                    versuche++;
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                                antwort = Console.ReadLine();
                                Richtig = antwort.Equals(listDupräs[verb1]);
                                if (Richtig == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Richtig ");
                                    richtig++;
                                    versuche++;
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("falsch");
                                    versuche++;
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                            }
                            if (Abgefragt == 2)
                            {
                                Console.WriteLine("sage mir den infinitiv dann den Partizip 2 und dann 2 Person singular im Präsenz von diesem Verb:");
                                Random Verb1 = new Random();
                                int verb1 = Verb1.Next(0, listpraet.Count());
                                Console.WriteLine(listpraet[verb1]);
                                string antwort = Console.ReadLine();
                                bool Richtig = antwort.Equals(listinfinitv[verb1]);
                                if (Richtig == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Richtig ");
                                    richtig++;
                                    versuche++;
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("falsch");
                                    versuche++;
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                                antwort = Console.ReadLine();
                                Richtig = antwort.Equals(listPart2[verb1]);
                                if (Richtig == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Richtig ");
                                    richtig++;
                                    versuche++;
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("falsch");
                                    versuche++;
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                                antwort = Console.ReadLine();
                                Richtig = antwort.Equals(listDupräs[verb1]);
                                if (Richtig == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Richtig ");
                                    richtig++;
                                    versuche++;
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("falsch");
                                    versuche++;
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                            }
                            if (Abgefragt == 3)
                            {
                                Console.WriteLine("sage mir die 3 person singular im Präteritum dann den infinitiv und dann 2 Person singular im Präsenz von diesem Verb:");
                                Random Verb1 = new Random();
                                int verb1 = Verb1.Next(0, listpraet.Count());
                                Console.WriteLine(listPart2[verb1]);
                                string antwort = Console.ReadLine();
                                bool Richtig = antwort.Equals(listpraet[verb1]);
                                if (Richtig == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Richtig ");
                                    richtig++;
                                    versuche++;
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("falsch");
                                    versuche++;
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                                antwort = Console.ReadLine();
                                Richtig = antwort.Equals(listinfinitv[verb1]);
                                if (Richtig == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Richtig ");
                                    richtig++;
                                    versuche++;
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("falsch");
                                    versuche++;
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                                antwort = Console.ReadLine();
                                Richtig = antwort.Equals(listDupräs[verb1]);
                                if (Richtig == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Richtig ");
                                    richtig++;
                                    versuche++;
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("falsch");
                                    versuche++;
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                            }
                            if (Abgefragt == 4)
                            {
                                Console.WriteLine("sage mir die 3 person singular im Präteritum dann den Partizip 2 und dann den infinitiv von diesem Verb:");
                                Random Verb1 = new Random();
                                int verb1 = Verb1.Next(0, listpraet.Count());
                                Console.WriteLine(listDupräs[verb1]);
                                string antwort = Console.ReadLine();
                                bool Richtig = antwort.Equals(listpraet[verb1]);
                                if (Richtig == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Richtig ");
                                    richtig++;
                                    versuche++;
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("falsch");
                                    versuche++;
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                                antwort = Console.ReadLine();
                                Richtig = antwort.Equals(listPart2[verb1]);
                                if (Richtig == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Richtig ");
                                    richtig++;
                                    versuche++;
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("falsch");
                                    versuche++;
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                                antwort = Console.ReadLine();
                                Richtig = antwort.Equals(listinfinitv[verb1]);
                                if (Richtig == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Richtig ");
                                    richtig++;
                                    versuche++;
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("falsch");
                                    versuche++;
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                            }
                        }
                    } while ((versuche / richtig) < 0.70);
                }


                Console.WriteLine("ich bin gut (true/false)");
                bool profi = Convert.ToBoolean(Console.ReadLine());
                if (profi == true)
                {
                    Runde2();
                    Runde3();
                }
                else
                {
                    Runde1();
                    Runde2();
                    Runde3();
                }
                }
            }

        }
    }
