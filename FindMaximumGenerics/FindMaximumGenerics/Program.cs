﻿using System;

namespace FindMaximumGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 112, 344, 432, 555, 678 };
            FindMaximum<int> find1 = new FindMaximum<int>(intArray);
            float[] floatArray = { 11.2f, 34.4f, 4.32f, 55.5f, 6.78f };
            FindMaximum<float> find2 = new FindMaximum<float>(floatArray);
            string[] stringArray = { "111", "222", "333", "55", "999" };
            FindMaximum<string> find3 = new FindMaximum<string>(stringArray);
            find1.PrintMax();
            find2.PrintMax();
            find3.PrintMax();

        }
    }
}
