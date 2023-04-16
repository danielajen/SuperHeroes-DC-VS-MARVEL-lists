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
            StreamReader output = new StreamReader(filename);
            List<string> allList = new List<string>();
            string[] allData;
            string[] words;
            string input = "";
            input = output.ReadLine();

            allData = input.Split(' '); 
            #region Lists
           
            List<string> battle1 = new List<string>();
            List<string> battle2 = new List<string>();
            List<string> battle3 = new List<string>();
            List<string> Marvel1 = new List<string>();
            List<string> Marvel2 = new List<string>();
            List<string> Marvel3 = new List<string>();
            List<string> DC1 = new List<string>();
            List<string> DC2 = new List<string>();
            List<string> DC3 = new List<string>();
            #endregion
            #region splits

            // splitting the line into universe and hero name
            foreach (string hero in allData)
            {
                words = hero.Split(","); // AT COMMA
                 
                if (words[0] == "1")
                {
                    battle1.Add(words[1]);
                }
                if (words[0] == "2")
                {
                    battle2.Add(words[1]);
                }
                if (words[0] == "3")
                {
                    battle3.Add(words[1]);
                }
            }
            foreach (string universe in battle1) // universe marvel or dc coming from . split
            {
                words = universe.Split("."); // AT period

                if (words[0] == "Marvel")
                {
                    Marvel1.Add(words[1]);
                }
                if (words[0] == "DC")
                {
                    DC1.Add(words[1]);
                }
            }
            foreach (string universe in battle2) // universe marvel or dc coming from . split
            {
                words = universe.Split("."); // AT period

                if (words[0] == "Marvel")
                {
                    Marvel2.Add(words[1]);
                }
                if (words[0] == "DC")
                {
                    DC2.Add(words[1]);
                }
            }
                    foreach (string universe in battle3) // universe marvel or dc coming from . split
                    {
                        words = universe.Split("."); // AT period

                        if (words[0] == "Marvel")
                        {
                            Marvel3.Add(words[1]);
                        }
                        if (words[0] == "DC")
                        {
                            DC3.Add(words[1]);
                        }
                    }
            #endregion
            #region sort
            Marvel1.Sort();
            DC1.Sort();
            Marvel2.Sort();
            DC2.Sort();
            Marvel3.Sort();
            DC3.Sort();
            #endregion
            // foreach loop for winners of each battle
            Console.WriteLine("battle 1");
            Console.WriteLine();
            
            foreach (string inputs in Marvel1) Console.WriteLine(inputs + "  : Marvel 1");
            foreach (string inputs in DC1) Console.WriteLine(inputs + "  : DC 1"); // each inputs
            Console.WriteLine();
            if (Marvel1.Count > DC1.Count)
            {
                Console.WriteLine("Marvel Wins");
                marvelwins++;
            }
            else if (Marvel1.Count == DC1.Count)
            {
                Console.WriteLine("TIE! EVEN DOMINATION!");
            }
            else
            {
                Console.WriteLine("DC WINS!");
                dcwins++;
            }
            Console.WriteLine();
            Console.WriteLine("battle 2");
            Console.WriteLine();

            foreach (string inputs in Marvel2) Console.WriteLine(inputs + "  : Marvel 2");
            foreach (string inputs in DC2) Console.WriteLine(inputs + "  : DC 2"); // each inputs
            Console.WriteLine();
            if (Marvel2.Count > DC2.Count)
            {
                Console.WriteLine("Marvel Wins");
                marvelwins++;
            }
            else if (Marvel2.Count == DC2.Count)
            {
                Console.WriteLine("TIE! EVEN DOMINATION!");
            }
            else
            {
                Console.WriteLine("DC WINS!");
                dcwins++;
            }
            Console.WriteLine();
            Console.WriteLine("battle 3");
            Console.WriteLine();

            foreach (string inputs in Marvel3) Console.WriteLine(inputs + "  : Marvel 3");
            foreach (string inputs in DC3) Console.WriteLine(inputs + "  : DC 3"); // each inputs
            Console.WriteLine();
            if (Marvel3.Count > DC3.Count)
            {
                Console.WriteLine("Marvel Wins");
                marvelwins++;
            }
            else if (Marvel3.Count == DC3.Count)
            {
                Console.WriteLine("TIE! EVEN DOMINATION!");
            }
            else
            {
                Console.WriteLine("DC WINS!");
                dcwins++;
            }
            // overall domination
            Console.WriteLine();
            if (marvelwins > dcwins)
            {
                Console.WriteLine("Overall Marvel dominated DC! THERREFORE MARVEL WINS!");
            }
            else if (marvelwins == dcwins)
            {
                Console.WriteLine("Overall it must be a tie!");
            }
            else
            {
                Console.WriteLine("Overall the DC JUSTICE LEAGUE dominated Marvel! THERREFORE DC WINS!");
            }


        }

       

    }
    }







