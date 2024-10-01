// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.CheckIfArrayPairsAreDivisibleByK;

/// <inheritdoc />
public class CheckIfArrayPairsAreDivisibleByKTwoPointers : ICheckIfArrayPairsAreDivisibleByK
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(log n)
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public bool CanArrange(int[] arr, int k)
    {
        Array.Sort(arr, new Comparator(k));

        var left = 0;
        var right = arr.Length - 1;

        while (left < right)
        {
            if (arr[left] % k != 0)
            {
                break;
            }

            if (arr[left + 1] % k != 0)
            {
                return false;
            }

            left += 2;
        }

        while (left < right)
        {
            if ((arr[left] + arr[right]) % k != 0)
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }

    private class Comparator(int k) : IComparer<int>
    {
        public int Compare(int i, int j)
        {
            return ((k + (i % k)) % k) - ((k + (j % k)) % k);
        }
    }
}