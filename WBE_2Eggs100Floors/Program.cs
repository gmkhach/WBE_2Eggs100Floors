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
            int testFloor;
            bool keepLooping = true;
            // dropping the first egg from the 50th floor.
            // if it doesn't break then start dropping the next egg from every other floor above 50th until it breaks.
            if (highest >= 50)
            {
                Console.WriteLine("\nTest 1: The 1st Egg was dropped from floor #50 and it didn't break");
                testFloor = 51;
                do
                {
                    Console.WriteLine($"\nTest {testFloor - 49}: The 2nd egg was dropped from floor #{testFloor++} and it didn't break");
                } while (highest >= testFloor);
                Console.WriteLine($"\nTest {testFloor - 49}: The 2nd egg was dropped from floor #{testFloor} and it broke");
            }
            // if it breaks then start dropping the other egg from the 1st floor and work your way up until it breaks.
            else
            {
                Console.WriteLine("\nTest 1: The 1st Egg was dropped from floor #50 and it broke");
                testFloor = 1;
                do
                {
                    Console.WriteLine($"\nTest {testFloor + 1}: The 2nd egg was dropped from floor #{testFloor++} and it didn't break");
                } while (highest >= testFloor);
                Console.WriteLine($"\nTest {testFloor + 1}: The 2nd egg was dropped from floor #{testFloor} and it broke");
            }
        }
    }
}
