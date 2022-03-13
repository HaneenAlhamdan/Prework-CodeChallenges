using System;

namespace Program
{
    class Program
    {
        static int ProblemOne(int[] arr, int x)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                    count++;
            }
            return x * count;
        }
        static string ProblemTwo(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                        return " Is Leap year";
                    else return " Is not Leap year";

                }
                else return " Is Leap year";
            }
            else return " Is not Leap year";
        }
        static string ProblemThree(int[] arr)
        {
            int sum = 0;
            int mult = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                    mult *= arr[i];
                }
                else return " Is not a Perfect ";


            }
            if (sum == mult)
                return "Is a Perfect ";
            else
                return "Is not a Perfect";
        }
        static int[] ProblemFour(int[,] arr, int i, int j)
        {
            int[] returnArr = new int[i];
            int sum;
            for (int c = 0; c < i; c++)
            {
                sum = 0;
                for (int c2 = 0; c2 < j; c2++)
                {
                    sum += arr[c, c2];
                    if (c2 == j - 1)
                    {
                        returnArr[c] = sum;
                    }

                }

            }
            return returnArr;
        }
        static void Main(string[] args)
        {

            // ProblemOne 
            int[] arr = new int[5];
            int select;
            int addItem;
            //Inisial array
            Console.WriteLine("Enter five numbers between 1 & 10, separated by spaces:");
            for (int i = 0; i < arr.Length; i++)
            {
                addItem = int.Parse(Console.ReadLine());
                try
                {
                    if (addItem >= 1 && addItem <= 10)
                        arr[i] = addItem;
                    else throw new ArgumentOutOfRangeException("Your Number it wrong");


                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }
            }
            //chose a number from array
            Console.WriteLine("Enter a number from the List :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("");
            //check if the number inside the array
            try
            {
                select = int.Parse(Console.ReadLine());
                var result = Array.Find(arr, element => element == select);
                if (result != 0)
                {
                    Console.WriteLine("your score: " + ProblemOne(arr, select));
                }
                else throw new Exception("not from the List");



            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            // ProblemTwo
            int year;
            Console.WriteLine("Enter a year:");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine(ProblemTwo(year));




            // ProblemThree
            int[] arrTest = new int[3];
            Console.WriteLine("Enter the item :");
            for (int i = 0; i < arrTest.Length; i++)
            {
                arrTest[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(ProblemThree(arrTest));


           

        }
    }
}