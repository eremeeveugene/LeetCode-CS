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

namespace LeetCode.Algorithms.DivideArrayInSetsOfKConsecutiveNumbers;

/// <inheritdoc />
public class DivideArrayInSetsOfKConsecutiveNumbersSortedDictionary : IDivideArrayInSetsOfKConsecutiveNumbers
{
    public bool IsPossibleDivide(int[] nums, int k)
    {
        if (nums.Length % k != 0)
        {
            return false;
        }

        var numsDictionary = new SortedDictionary<int, int>();

        foreach (var num in nums)
        {
            if (!numsDictionary.TryAdd(num, 1))
            {
                numsDictionary[num]++;
            }
        }

        while (numsDictionary.Count > 0)
        {
            var firstNum = numsDictionary.First().Key;

            for (var i = 0; i < k; i++)
            {
                var currentNum = firstNum + i;

                if (numsDictionary.TryGetValue(currentNum, out var value))
                {
                    if (value == 1)
                    {
                        numsDictionary.Remove(currentNum);
                    }
                    else
                    {
                        numsDictionary[currentNum] = value - 1;
                    }
                }
                else
                {
                    return false;
                }
            }
        }

        return true;
    }
}