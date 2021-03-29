using System;

namespace Week4_Lab4._1
{
    class Program
    {
        static bool ReRoll()
        {
            string yn;
            while (true)
            {
                Console.Write("\nWould you like to roll again? (y/n): ");
                yn = Console.ReadLine().ToLower();
                if (yn == "y")
                    return true;
                else if (yn == "n")
                    return false;
            }


        }
        static void ResultSwitch(int total)
        {
            switch (total)
            {
                case 2:
                    Console.WriteLine("Snake Eyes");
                    Console.WriteLine("Craps!");
                    Console.WriteLine(@"     
                                                        ______
                                            .-------.  /\     \
                                           /   o   /| /o \  o  \
                                          /_______/o|/   o\_____\
                                         | o     |  |\o   /o    /
                                         |   o   |o/  \ o/  o  /
                                         |     o |/    \/____o/
                                         '-------'                 ");
                                                  
                    break;
                case 3:
                    Console.WriteLine("Ace Deuce");
                    Console.WriteLine("Craps!");
                    Console.WriteLine(@"     
                                                        ______
                                            .-------.  /\    o\
                                           /   o   /| /o \     \
                                          /_______/o|/   o\o____\
                                         | o     |  |\o   /o    /
                                         |   o   |o/  \ o/  o  /
                                         |     o |/    \/____o/
                                         '-------'                 ");
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    Console.WriteLine("Win!");
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    Console.WriteLine("Win!");
                    break;
                case 12:
                    Console.WriteLine("Box Cars");
                    Console.WriteLine("Craps!");
                    Console.WriteLine(@"     
                                                        ______
                                            .-------.  /\o o o\
                                           /o  o  o/| /o \     \
                                          /o__o__o/o|/   o\o_o_o\
                                         | o     |  |\o   /o    /
                                         |   o   |o/  \ o/  o  /
                                         |     o |/    \/____o/
                                         '-------'                 ");
                    break;

            }
        }
        static void DaddyNeedsANewPairOfShoes(int numSides)
        {
            int die1;
            int die2;
            int roll = 1;
            bool anotherRoll;
            Random rand = new();

            do
            {
                die1 = rand.Next(1, numSides + 1);
                die2 = rand.Next(1, numSides + 1);

                Console.WriteLine("\nRoll: " + roll + ":");
                Console.WriteLine($"You rolled a {die1} and a {die2} ({die1 + die2} total)");
                if (numSides == 6)
                    ResultSwitch(die1 + die2);
                roll++;
                anotherRoll = ReRoll();

            } while (anotherRoll == true);
        }
        static void Main(string[] args)
        {

            int sides = 0;
            bool firstPass = true;

            while (sides < 1)
            {
                if (firstPass == false)
                    Console.WriteLine("\nPlease enter a valid number of sides greater than 0.");
                Console.Write("How many sides should each die have? ");
                Int32.TryParse(Console.ReadLine(), out sides);
                firstPass = false;
            }

            DaddyNeedsANewPairOfShoes(sides);

            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                                  Thanks for playing");
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n");

        }
    }
}
