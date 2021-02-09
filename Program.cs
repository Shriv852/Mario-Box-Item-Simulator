using System;

namespace Mario_Kart_Item_Box
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] items = { 0, 0, 0, 0, 0 };
            int place = 12;
            bool loop = true;
            while (loop == true)
            {
                int num = Run(place);

                if (num >= 8)
                {
                    Console.WriteLine("Invalid Number, Please try again");
                    Run(place);
                }

                if (num == 1) //Set Position
                {
                    Console.WriteLine("What place would you like to be in?  (Between 1 and 12)");
                    if (place < 13)
                    {
                        place = Convert.ToInt32(Console.ReadLine());
                    } else
                    {
                        Console.WriteLine("Invalid Place");
                    }
                }

                if (num == 2) //Run Probability Function once (Run Simulation Onnce)
                {
                    Probability(place, items);
                }

                if (num == 3) //Run Simulation 'n' number of times 
                {
                    Console.WriteLine("How many times would you like to run this simulation?");
                    int runSimulation = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < runSimulation; i++)
                    {
                        Probability(place, items);
                    }
                }

                if (num == 4) //Run until 10 Bullet Bills
                {
                    while (items[4] < 10)
                    {
                        Probability(place, items);
                    }
                }

                if (num == 5) //Count Total Items
                {
                    Console.WriteLine("---------TOTALS----------");
                    Console.WriteLine("Banana = " + items[0]);
                    Console.WriteLine("Green Shell = " + items[1]);
                    Console.WriteLine("Star = " + items[2]);
                    Console.WriteLine("Golden Mushroom = " + items[3]);
                    Console.WriteLine("Bullet Bill = " + items[4]);
                    Console.WriteLine("-------------------------");
                }

                if (num == 6 ) //Reset Item Count
                {
                    Array.Clear(items, 0, items.Length);
                    Console.WriteLine("----------RESET---------");
                    Console.WriteLine("Banana = " + items[0] );
                    Console.WriteLine("Green Shell = " + items[1]);
                    Console.WriteLine("Star = " + items[2]);
                    Console.WriteLine("Golden Mushroom = " + items[3]);
                    Console.WriteLine("Bullet Bill = " + items[4]);
                    Console.WriteLine("-------------------------");
                }

                if (num == 7)
                {
                    Console.WriteLine("Goodbye!");
                    loop = false;
                }
            } //End While
            
        }
        public static int Run(int place)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Main Menu: Current Position is " + place);
            Console.WriteLine("Press 1 to Set Position");
            Console.WriteLine("Press 2 to Run Simulation Once");
            Console.WriteLine("Press 3 to Run Simulation 'n' Times");
            Console.WriteLine("Press 4 to Run Simulation until 10 Bullet Bills");
            Console.WriteLine("Press 5 to Display Totals");
            Console.WriteLine("Press 6 to Reset Totals");
            Console.WriteLine("Press 7 to Exit");
            Console.WriteLine("-------------------------");

            return Convert.ToInt32(Console.ReadLine());
        }

        public static void Probability(int place, int[] items)
        {
            Random rnd = new Random();
            int randnum = rnd.Next(1, 101);

            if (place >= 1 && place <= 6)
            {
                if (randnum < 45)
                {
                    items[0]++;
                    Console.WriteLine("Banana");
                }
                else if (randnum < 80)
                {
                    items[1]++;
                    Console.WriteLine("Green Shell");
                }
                else if (randnum < 95)
                {
                    items[2]++;
                    Console.WriteLine("Star");
                }
                else if (randnum < 99)
                {
                    items[3]++;
                    Console.WriteLine("Golden Mushroom");
                }
                else
                {
                    items[4]++;
                    Console.WriteLine("Bullet Bill");
                }
            }
            else if (place >= 7 && place <= 12)
            {
                if (randnum < 5)
                {
                    items[0]++;
                    Console.WriteLine("Banana");
                }
                else if (randnum < 10)
                {
                    items[1]++;
                    Console.WriteLine("Green Shell");
                }
                else if (randnum < 35)
                {
                    items[2]++;
                    Console.WriteLine("Star");
                }
                else if (randnum < 70)
                {
                    items[3]++;
                    Console.WriteLine("Golden Mushroom");
                }
                else
                {
                    items[4]++;
                    Console.WriteLine("Bullet Bill");
                }
            }
        } //End of Probability
    }
}