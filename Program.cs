using System;
using System.Collections;
using System.Collections.Generic;

namespace Election
{
    class Program
    {
        static void Main(string[] args)
        {
            // string numCan = Console.ReadLine();

            var cans = new Dictionary<string, string>(){
                {"Marilyn Manson", "Rhinoceros"},
                {"Jane Doe", "Family Coalition"},
                {"John Smith", "independent"}
            };

            Console.WriteLine(cans["Marilyn Manson"]);
        }
    }
}
