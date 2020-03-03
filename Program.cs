using System;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
      //    static string Sorting(string[] arrays)
            {
      //        string sorted_ascending = arrays.Sort(); 
            }
            

            string [] array1 = File.ReadAllLines($"Net_1_256.txt");
            string[] array2 = File.ReadAllLines($"Net_2_256.txt");
            string[] array3 = File.ReadAllLines($"Net_3_256.txt");
            int counter = 1;
            string user_response; 

            string[] lists = { "Net_1_256", "Net_2_256", "Net_3_256" };

            Console.WriteLine("Which Array would you like to analyse? (Please enter the desired number):");
            foreach (var entrys in lists)
            {

                Console.WriteLine($"{counter++}) {entrys}");
            }

            Console.WriteLine(array1);
            user_response = Console.ReadLine();

            if (user_response == "1")
            {
                Console.WriteLine("1");
               //orting(array1); 
            }
            else if (user_response == "2")
            {
                Console.WriteLine("2");
       //       Sorting(array2);
            }
            else if (user_response == "3")
            {
                Console.WriteLine("3");
     //         Sorting(array3);
            }
             

            
            



        }
    }
}
