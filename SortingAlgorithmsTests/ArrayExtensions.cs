﻿using System;

namespace SortingAlgorithmsTests
{
    static class ArrayExtensions
    {
        public static bool IsSorted<T>(this T[] array) where T : struct, IComparable<T>
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1].CompareTo(array[i]) > 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}