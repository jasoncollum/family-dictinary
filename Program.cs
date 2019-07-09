using System;
using System.Collections.Generic;

namespace family_ditionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("father", new Dictionary<string, string>(){
                {"name", "Richard"},
                {"age", "72"}
            });
            myFamily.Add("mother", new Dictionary<string, string>(){
                {"name", "Sherry"},
                {"age", "72"}
            });
            myFamily.Add("brother", new Dictionary<string, string>(){
                {"name", "Josh"},
                {"age", "38"}
            });

            // Iterate of each item
            foreach (KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
            {
                Console.WriteLine($"{familyMember.Value["name"]} is my {familyMember.Key} and is {familyMember.Value["age"]} years old");
            }
        }

    }
}
