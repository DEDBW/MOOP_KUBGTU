﻿using System;
namespace STLab01
{
    public class ShellSort
    {
        public static void Sort(int[] arr)
        {
            if (arr == null)
            {
                return;
            }

            int n = arr.Length;

            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j = i;

                    while (j >= gap && arr[j - gap] > temp)
                    {
                        arr[j] = arr[j - gap];
                        j -= gap;
                    }

                    arr[j] = temp;
                }
            }
        }
    }
}