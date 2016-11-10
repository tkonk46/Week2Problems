using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Problems
{
    class Program
    {
        static void Main(string[] args)
        {   //Problem 1
            //int firstNumber = 32;
            //int secondNumber = 64;
            //Program p = new Program();
            //int result = p.sum(firstNumber, secondNumber);


            //Problem 2
            /* Console.WriteLine("Enter the first string");
             string firstString = Console.ReadLine();

             Console.WriteLine("Enter the second string");
             string secondString = Console.ReadLine();

             Program p = new Program();
             bool areEqual = p.AreStringsEqual(firstString, secondString);
             if(areEqual)
             {
                 Console.WriteLine("The two strings entered are the same");
             }
             else
             {
                 Console.WriteLine("The two strings entered are not the same");

            //Problem #3
            /*Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Program p = new Program();
            p.SayHello(name);
            p.SayHello("Jimmy", "Jerry", "Tessa", "Serkan", "Rick");
            Console.ReadLine();
             }*/
            /*Program p = new Program();

            int[] numbers = p.GetRandomNumbers();
            int result = p.SumNumbers(numbers);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private bool AreStringsEqual(string firstString, string secondString)
        {
            if (firstString == secondString)
                return true;
            else
                return false;
        }

        public int sum(int a, int b)
        {
            int result = a + b;
            return result;
        }






        private void SayHello(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }

        private void SayHello(params string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine("Hello, {0}", name);
            }
        }

        private int[] GetRandomNumbers()
        {
            Random r = new Random();
            int[] randomNumbers = new int[10];
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = r.Next(100000, 999999);
            }

            return randomNumbers;
        }

        private int SumNumbers(int[] randomNumbers)
        {
            int runningSum = 0;
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                runningSum += randomNumbers[i];
            }
            return runningSum;*/
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();

            Console.WriteLine("Enter a character");
            string character = Console.ReadLine();

            Console.WriteLine("Enter a position");
            string position = Console.ReadLine();

            char c = character[0];

            int positionAsInt = Convert.ToInt32(position);

            Program p = new Program();
            string result = p.ReplaceChar(input, positionAsInt, c);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private string ReplaceChar(string input, int positionAsInt, char c)
        {
            char[] inputAsArray = input.ToCharArray();
            inputAsArray[positionAsInt - 1] = c;
            return new string(inputAsArray);
        }
    }
}
