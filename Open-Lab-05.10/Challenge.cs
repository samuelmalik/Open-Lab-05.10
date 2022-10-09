using System;

namespace Open_Lab_05._10
{
    public class Challenge
    {
        public int MysteryFunc(int num)
        {
            string numbers = num.ToString();
            int result = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                result *= Int32.Parse(numbers[i].ToString());
            }
            return result;
        }
    }
}
