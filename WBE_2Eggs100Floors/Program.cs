/*
 * A building has 100 floors. One of the floors is the highest floor an egg can be dropped from without breaking.
 * If an egg is dropped from above that floor, it will break. If it is dropped from that floor or below, 
 * it will be completely undamaged and you can drop the egg again.
 * Given two eggs, find the highest floor an egg can be dropped from without breaking, with as few drops as possible.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBE_2Eggs100Floors
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("\nEnter an integer between 1 and 100\n\n>>> ");
                    int input = int.Parse(Console.ReadLine().Trim());
                    if (input < 1 || input > 100)
                        throw new Exception("Invalid Entry!");
                    FindHighestSafeFloor(input);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n" + ex.Message);
                }
                Console.Write("\nPress Enter to try another floor...");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }

        static void FindHighestSafeFloor(int highest)
        {
            int floor;
            // dropping the first egg from the 51st floor.
            if (highest >= 51)
            {
                // if it doesn't break then start dropping the next egg from every other floor above 51st until it breaks.
                floor = 52;
            }
            else
            {
                // if it breaks then start dropping the other egg from the 2nd floor and work your way up until it breaks.
                floor = 2;
            }
            Console.WriteLine($"\nTest 1: 1st Egg was dropped from floor #51 and it {( highest >=50 ? "didn't break." : "broke.")}");
            while (highest >= floor)
            {
                Console.WriteLine($"\nTest {( highest >=50 ? floor - 50 : floor)}: 2nd egg was dropped from floor #{floor++} and it didn't break.");
            }
            Console.WriteLine($"\nTest {(highest >= 50 ? floor - 50 : floor)}: 2nd egg was dropped from floor #{floor} and it broke.\n\nFloor #{floor - 1} is the highest safe floor.");
        }
    }
}
