using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Election
{
    class Program
    {
        static void Main(string[] args)
        {
            // string numCan = Console.ReadLine();

            // var cans = new Dictionary<string, string>(){
            //     {"Marilyn Manson", "Rhinoceros"},
            //     {"Jane Doe", "Family Coalition"},
            //     {"John Smith", "independent"}
            // };

            var cans = new Dictionary<string, string>();
            var votes = new Dictionary<Int32, string>();

            int x = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < x; i++){
                cans.Add(Console.ReadLine(),Console.ReadLine());
            }
            
            Console.WriteLine("We have " + cans.Count + " cans");

            int voteNum = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < voteNum; i++){
                votes.Add(i,Console.ReadLine());
                
                Console.WriteLine(votes[i]);
            }


        }
    }
}
