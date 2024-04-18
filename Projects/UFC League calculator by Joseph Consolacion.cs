    using System;

    namespace MMAFightingProgram
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to the MMA Fighting Program!");

            
                Console.Write("Enter the fighter's weight: ");
                string input = Console.ReadLine();
                int weight = Convert.ToInt32(input);

                Console.WriteLine($"\nWeight Class:\n{GetWeightClass(weight)}");
                Console.WriteLine($"\nWins: {GetWins()}\nLosses: {GetLosses()}");

            
                string leagueOrRank = GetLeagueOrRank(GetWins(), GetLosses());
                Console.WriteLine($"\nLeague/Rank: {leagueOrRank}");

            }

        
            static string GetWeightClass(int weight)
            {
                if (weight < 125)
                {
                    return "Not a valid weight for MMA fighting";
                }
                else if (weight >= 125 && weight <= 135)
                {
                    return "Bantamweight";
                }
                else if (weight > 135 && weight <= 145)
                {
                    return "Featherweight";
                }
                else if (weight > 145 && weight <= 155)
                {
                    return "Lightweight";
                }
                else if (weight > 155 && weight <= 170)
                {
                    return "Welterweight";
                }
                else if (weight > 170 && weight <= 185)
                {
                    return "Middleweight";
                }
                else if (weight > 185 && weight <= 205)
                {
                    return "Light Heavyweight";
                }
                else if (weight > 205 && weight <= 265)
                {
                    return "Heavyweight";
                }
                else
                {
                    return "Not a valid weight for MMA fighting";
                }
            }

            
            static int GetWins()
            {
                Console.Write("Enter the number of wins: ");
                string input = Console.ReadLine();
                return Convert.ToInt32(input);
            }

        
            static int GetLosses()
            {
                Console.Write("Enter the number of losses: ");
                string input = Console.ReadLine();
                return Convert.ToInt32(input);
            }

            static string GetLeagueOrRank(int wins, int losses)
            {
                if (wins >= 10 && losses <= 2)
                {
                    return "UFC Champion";
                }
                else if (wins >= 5 && losses <= 5)
                {
                    return "UFC Contender";
                }
                else
                {
                    return "Amateur League";
                }
            }
        }
    }