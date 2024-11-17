using System.Globalization;

namespace lec4_task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {5,1,2,6,4,4,4,4,5};

              removeDuplicate(arr);
         
        }

        static void removeDuplicate(int[] numbers)
        {


            int currentIndex = 0;
            for (int i = 0; i < numbers.Length-1 ; i++)
            {
                if (numbers[i] != numbers[i + 1])
                {

                    numbers[currentIndex++] = numbers[i];


                }
            }

              numbers[currentIndex++] = numbers[numbers.Length-1];

            for(int x = 0; x < currentIndex; x++)
            {
                Console.WriteLine(numbers[x]);
            }
        }
    }
}

