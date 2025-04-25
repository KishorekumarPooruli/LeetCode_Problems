namespace _01_ProblemNo1342
{
    //// https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/description/
    using System;

    public class Leet_Code_ProblemNo_1342
    {
        public int ProcessCoreLogic(int num)
        {
            if (num % 2 == 0) /// Check if a Num is even
            {
                //// num is Even
                num = num / 2;
                return num;
            }

            //// num is Odd
            num = num - 1;
            return num;
        }

        public void NumberOfStepsToComplete(int numInput)
        {
            if (numInput >= 0)
            {
                int steps = 0;
                while (numInput > 0)
                {
                    steps++;
                    numInput = this.ProcessCoreLogic(numInput);
                }

                if (numInput == 0)
                {
                    Console.WriteLine(steps);
                }
            }
        }
    }

    public class RunnerClass
    {
        public static void Main()
        {
            Leet_Code_ProblemNo_1342 leetObject = new Leet_Code_ProblemNo_1342();
            leetObject.NumberOfStepsToComplete(14);
            //// Input: 14 Output: 6
            ///  Input: 8 Output: 4
            ///  Input: 123 Output: 12
        }
    }
}
