using System;

namespace DailyChallenge312
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1234 -> {0}", FindNextInt(1234));
            Console.WriteLine("1243 -> {0}", FindNextInt(1243));
            Console.WriteLine("123765 -> {0}", FindNextInt(234765));
            Console.WriteLine("19000 -> {0}", FindNextInt(19000));

            Console.ReadKey();
        }

        static int FindNextInt(int input)
        {
            /* Brute force find next largest integer using same digits as input */
            
            char[] origArr = input.ToString().ToCharArray();
            Array.Sort(origArr);
            string origStr = null;
            for (int i = 0; i < origArr.Length; i++)            
                origStr += origArr[i].ToString();

            for (int j = input + 1; j < int.MaxValue; j++)
            {
                char[] nextArr = j.ToString().ToCharArray();
                Array.Sort(nextArr);
                string nextStr = null;
                for (int k = 0; k < nextArr.Length; k++)
                    nextStr += nextArr[k].ToString();
                if (origStr == nextStr)
                    return j;                
            }

            return -1;
        }
    }
}
