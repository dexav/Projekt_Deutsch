
using System.IO;
namespace Test
{
    internal class Program
    {
        
  
        static void Main(string[] args)
        {
             using (var reader = new StreamReader(@"C:\Users\xnurs\OneDrive\Desktop\verben.csv.txt"))
            {
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                List<string> listC = new List<string>();
                List<string> listD = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    listA.Add(values[0]);
                    listB.Add(values[1]);
                    listC.Add(values[2]);
                    listD.Add(values[3]);


                }
                Console.WriteLine(listA[2]);
                Console.WriteLine("schreibe die anderen Stammformen");


                string Antwort=Console.ReadLine();
                
                if (Antwort == listB[2])
                {
                    Console.WriteLine("du nigger");
                }
                
               
            }






        }
    }
}
