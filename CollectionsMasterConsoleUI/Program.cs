using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            
            //TODO: Create an integer Array of size 50

            var numbers = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50

            Populater(numbers);

            NumberPrinter(numbers);

            //TODO: Print the first number of the array

            Console.WriteLine("First Number of array:");
            Console.WriteLine($"{numbers[0]}");

            //TODO: Print the last number of the array

            Console.WriteLine("Last number of array:");
            Console.WriteLine($"{numbers[numbers.Length -1]}");

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            
            NumberPrinter(numbers);

            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            ReverseArray(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("---------REVERSE CUSTOM------------");

            var reversedArray = new int[50];

            for (int i = 0; i < 50; i++)
            {
                reversedArray[i] = numbers[numbers.Length - (i+1)];
                
            }

            NumberPrinter(reversedArray);



            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            ThreeKiller(numbers);
            NumberPrinter(numbers);
            

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            
            Array.Sort(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List

            var randomNumbers = new List<int>();
            

            //TODO: Print the capacity of the list to the console
            
            Console.WriteLine(randomNumbers.Count);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            


            Populater(randomNumbers);


            //TODO: Print the new capacity

            Console.WriteLine("Here is a list of random numbers:");
            
            NumberPrinter(randomNumbers);


            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!


            NumberChecker(randomNumbers, 5);

            Console.WriteLine("All Numbers:");
            
            //UNCOMMENT this method to print out your numbers from arrays or lists
            
            NumberPrinter(randomNumbers);
            
            Console.WriteLine("-------------------");

            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            OddKiller(randomNumbers);
            NumberPrinter(randomNumbers);

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results

            randomNumbers.Sort();
            NumberPrinter(randomNumbers);
            

            Console.WriteLine("Sorted Evens!!");
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            
            var newArray = randomNumbers.ToArray();

            //TODO: Clear the list
            
            randomNumbers.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for(int i = 0; i < 50; i ++)
            {
                var num = numbers[i];
                
                if(num % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        public static void OddKiller(List<int> numberList)
        {
           for(int i = numberList.Count - 1; i >=0; i --)
            {
               
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }
              
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            int userGuess;
            bool isInt;

            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isInt = int.TryParse(Console.ReadLine(), out userGuess);
            }
            while (isInt == false);
                
            for (int i = 0; i < 51; i++)
                {
                    int comparedNumber = numberList[i];

                    if (comparedNumber == userGuess)
                    {
                        Console.WriteLine($"Wow! you guessed {userGuess} and that was in the list. Good job!");
                        break;
                    }
                    if (comparedNumber != userGuess && numberList[i] == numberList[numberList.Count - 1])
                    {
                    Console.WriteLine("Oh, I am sorry that number is not on the list!");
                    break;
                    }
                }
        }

        private static void Populater(List<int> numberList)
        {
            for (int i = 0; i < 50; i++)
            {
                Random rng = new Random();

                int ranInteger = rng.Next(1, 50);

                numberList.Add(ranInteger);

            }
        }

        private static void Populater(int[] numbers)
        {
           for (int i = 0; i< numbers.Length; i++) 
            {
                Random rng2 = new Random();
                numbers[i] =rng2.Next(0, 50);
            }
        }        

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
        }


        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
