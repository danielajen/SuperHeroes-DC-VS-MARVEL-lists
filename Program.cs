using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace SuperHeroes__DC_VS_MARVEL_
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // amount of wins
            int dcwins = 0;
            int marvelwins = 0;
            // files read
            string filename = "super1.txt";

            List<string> Data = new List<string>();
            // ask which file and place filename paramters to answer
            Console.WriteLine("Which battle file would you like to choose from? Pick a num from 1-3");
            int answer = 0;

            while (answer > 3 || answer < 1)
            {
                bool proper = int.TryParse(Console.ReadLine(), out answer);
                while (proper == false)
                {
                    Console.WriteLine("Enter only numbers!");
                    proper = int.TryParse(Console.ReadLine(), out answer);
                }
                if (answer > 3)
                {
                    proper = false;
                    Console.WriteLine("Sorry, there are only 3 options. Please choose a number from 1-3");
                }
            }
            if (answer == 1) filename = "super1.txt";
            if (answer == 2) filename = "super2.txt";
            if (answer == 3) filename = "super3.txt";

            // read file and add each line to Data list
            using (StreamReader sr = new StreamReader(filename))
            {
                string input = sr.ReadLine();
                while (input != null)
                {
                    Data.Add(input);
                    input = sr.ReadLine();
                }
            }

            // create output file and write the results
            using (StreamWriter output = new StreamWriter("output.txt"))
            {
                // for each line we need to split it and check heroes name and universe from left and right side after index 0 comma
                int battleCount = 1;
                foreach (string line in Data)
                {
                    int marvelhero = 0;
                    int dchero = 0;

                    List<string> marvel = new List<string>();
                    List<string> dc = new List<string>();

                    // splitting the line into universe and hero name
                    string[] parts = line.Split(',');
                    string universe = parts[1].Split('.')[0];
                    string heroName = parts[1].Split('.')[1];

                    if (universe == "Marvel")
                    {
                        // if marvel
                        marvelhero ++;
                        marvel.Add(heroName);
                    }
                    else
                    {
                        // if dc
                        dchero ++;
                        dc.Add(heroName);
                    }

                    // output results for each battle
                    output.WriteLine("Battle " + battleCount + ":");
                    output.WriteLine("Marvel heroes (" + marvelhero + "):");
                    marvel.Sort(); // sorting the hero names
                    foreach (string hero in marvel)
                    {
                        output.WriteLine("- " + hero);
                    }

                    output.WriteLine("DC heroes (" + dchero + "):");
                    dc.Sort(); // sorting the hero names
                    foreach (string hero in dc)
                    {
                        output.WriteLine("- " + hero);
                    }

                    if (marvelhero > dchero)
                    {
                        output.WriteLine("Avengers win for Marvel");
                        marvelwins++;
                    }
                    else if (dchero > marvelhero)
                    {
                        output.WriteLine("Justice League win for DC");
                        dcwins++;
                    }
                    else
                    {
                        output.WriteLine("It's a tie");
                    }

                    battleCount++;
                }

                output.WriteLine("Overall wins:");
                output.WriteLine("Marvel: " + marvelwins);
                output.WriteLine("DC: " + dcwins);

            }
        }
    }
}





