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

            int dcwins = 0;
            int marvelwins = 0;
            using (StreamWriter output = new StreamWriter("output.txt", true))
            {
                for (int battle = 1; battle <= 3; battle++)
                {
                    int dchero = 0;
                    int marvelhero = 0;
                    List<string> heroes = new List<string>();

                    // files read gets # of battle and gets all for the file
                    string file = "super" + battle + ".txt";
                    StreamReader file1 = new StreamReader(file);
                    string input = file1.ReadLine();
                    while (input != null)
                    {
                        heroes.Add(input);
                        input = file1.ReadLine();
                    }
                    file1.Close();

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
                        {
                            marvelhero++;
                            marvel.Add(heroName);
                        }
                        else
                        {
                            dchero++;
                            dc.Add(heroName);
                        }
                    }
                
                // Outputs 
                    output.WriteLine("battle " + battle + ":");
                    output.WriteLine("marvel heroes:");
                    foreach (string hero in marvel.OrderBy(h => h))
                    {
                        output.WriteLine("-" + hero);
                    }
                    output.WriteLine("dc heroes:");
                    foreach (string hero in dc.OrderBy(h => h))
                    {
                        output.WriteLine("-" + hero);
                    }
                    if (marvelhero > dchero)
                    {
                        output.WriteLine("avengers win for marvel");
                        marvelwins++;
                    }
                    else if (dchero > marvelhero)
                    {
                        output.WriteLine("justice league win for dc");
                        dcwins++;
                    }
                    else
                    {
                        output.WriteLine(" tie!");
                    }
                    output.WriteLine();
                }

                        // for the WINS
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



   

