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
            Console.WriteLine("which battle file would you like to choose from? Pick a num from 1-3");
            int answer = 0;

            while (answer > 3 || answer < 1)
            {
                bool proper = int.TryParse(Console.ReadLine(), out answer);
                while (proper == false)
                {
                    Console.WriteLine("enter only numbers!");
                    proper = int.TryParse(Console.ReadLine(), out answer);
                }
                if (answer > 3)
                {
                    proper = false;
                    Console.WriteLine("Sory, they're only 3 options, only from 1-3");
                }
            }
            if (answer == 1) filename = "super1.txt";
            if (answer == 2) filename = "super2.txt";
            if (answer == 3) filename = "super3.txt";
            //streamwriter to write ouput
            using (StreamWriter output = new StreamWriter("")
            {     
                    List<string> heroes = new List<string>();

                    string input = filename.ReadLine();
                    while (input != null)
                    {
                        heroes.Add(input);
                        input = filename.ReadLine();
                    }
                    filename.Close();
                    // lists
                    List<string> marvel = new List<string>();
                    List<string> dc = new List<string>();

                    // for each line we needa split it and check heroes name and universe from left and right side after index 0 comma
                    foreach (string line in heroes)
                    {
                        // seperating each split
                        string[] broken = line.Split(',');
                        string universe = broken[1].Split('.')[0];
                        string heroName = broken[1].Split('.')[1];
                        if (universe == "Marvel")
                        {   // if marvel
                            marvelhero++;
                            marvel.Add(heroName);
                        }
                        else
                        {    // if dc
                            dchero++;
                            dc.Add(heroName);
                        }
                    }
                
                // Outputs 
                    output.WriteLine("battle " + battle + ":");
                    output.WriteLine("marvel heroes:");
                    // order from least to greatest 
                    foreach (string hero in marvel.OrderBy(h => h))
                    {
                        // add hero
                        output.WriteLine("-" + hero);
                    }
                    output.WriteLine("dc heroes:");
                    foreach (string hero in dc.OrderBy(h => h))
                    {
                        // add hero
                        output.WriteLine("-" + hero);
                    }
                    if (marvelhero > dchero)
                    {
                        // win per battle
                        output.WriteLine("avengers win for marvel");
                        marvelwins++;
                    }
                    else if (dchero > marvelhero)
                    {
                        // win per battle
                        output.WriteLine("justice league win for dc");
                        dcwins++;
                    }
                    else
                    {
                            //tie?
                        output.WriteLine(" tie!");
                    }
                    output.WriteLine();
                }

                        // for the WINS overall
                        output.WriteLine();
                        if (marvelwins > dcwins)
                        {
                            output.WriteLine("marvel for overall win");
                        }
                        else if (dcwins > marvelwins)
                        {
                            output.WriteLine("justice league overall win for dc");
                        }
                        else
                        {
                            output.WriteLine("tie");
                        }
                    }
                }

            }

        }



   

