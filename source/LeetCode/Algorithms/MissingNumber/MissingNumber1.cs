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

namespace LeetCode.Algorithms.MissingNumber;

/// <summary>
///     https://leetcode.com/problems/missing-number/description/
/// </summary>
public static class MissingNumber1
{
    public static int GetResult(int[] nums)
    {
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i)
            {
                return i;
            }
        }

        return nums.Length;
    }

    //public static int GetResult(int[] nums)
    //{
    //    if (nums.Length == 0)
    //    {
    //        return 0;
    //    }

    //    var numsLength = nums.Length;

    //    return numsLength * (numsLength + 1) / 2 - nums.Sum();
    //}

    //public static int GetResult(int[] nums)
    //{
    //    var sum = nums.Sum();

    //    for (int i = 0; i < nums.Length + 1; i++)
    //    {
    //        sum -= i;
    //    }

    //    return -sum;
    //}

    //public static int GetResult(int[] nums)
    //{
    //    var sum = 0;

    //    for (int i = 0; i < nums.Length + 1; i++)
    //    {
    //        sum += i;
    //    }

    //    return sum - nums.Sum();
    //}

    //public static int GetResult(int[] nums)
    //{
    //    List<int> orderedNums = nums.Order().ToList();

    //    int i = 0;

    //    while (i < nums.Length && orderedNums[i] == i)
    //    {
    //        i++;
    //    }

    //    return i;
    //}
}