// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.SumOfUniqueElements;

/// <inheritdoc />
public sealed class SumOfUniqueElementsFrequencyArray : ISumOfUniqueElements
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int SumOfUnique(int[] nums)
    {
        var frequencyArray = new int[100];

        foreach (var num in nums)
        {
            frequencyArray[num - 1]++;
        }

        var sum = 0;

        for (var i = 0; i < frequencyArray.Length; i++)
        {
            var frequency = frequencyArray[i];

            if (frequency == 1)
            {
                sum += i + 1;
            }
        }

        return sum;
    }
}