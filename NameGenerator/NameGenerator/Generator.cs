using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    public class Generator
    {
        string rnd, rndSurname;
        string x;
        public string[] maleName = { "Aiden", "Lucas", "Liam", "Noah", "Ethan", "Jacob", "Grayson", "James", "Michael", "Daniel", "Andrew", "Ryan" }; 
        public string[] femaleName = { "Sophia", "Emma", "Olivia", "Mia", "Aria", "Zoey", "Lily", "Emily", "Harper", "Chloe", "Victoria", "Scarlett" };
        public string[] surname = { "Smith", "Jackson", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Harris", "Martinez", "Young", "Hill" };
        Random random = new Random();

        public void generate(char gender)
        {
            if (gender.Equals('m'))
            {
                rnd = maleName[random.Next(maleName.Length)]; // losowanie stringa z tablicy maleName[]
                x = "male";
            }
            else if (gender.Equals('f'))
            {
                rnd = femaleName[random.Next(femaleName.Length)];
                x = "female";
            }
            rndSurname = surname[random.Next(surname.Length)];

            Console.Write("Random " + x + " name: " + rnd + " " + rndSurname);
        }
    }
}
