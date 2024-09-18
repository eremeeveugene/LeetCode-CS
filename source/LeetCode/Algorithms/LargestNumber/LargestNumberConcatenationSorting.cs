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

using System.Text;

namespace LeetCode.Algorithms.LargestNumber;

/// <inheritdoc />
public class LargestNumberConcatenationSorting : ILargestNumber
{
    /// <summary>
    ///     Time complexity - O(n log n * k), where n is the number of numbers and k is the number of digits in the largest
    ///     number
    ///     Space complexity - O(n * k), where n is the number of numbers and k is the number of digits in the largest number
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public string LargestNumber(int[] nums)
    {
        var numsAsStrings = nums.Select(n => n.ToString()).ToArray();

        Array.Sort(numsAsStrings, (a, b) => string.Compare(b + a, a + b, StringComparison.Ordinal));

        if (numsAsStrings[0] == "0")
        {
            return "0";
        }

        var resultStringBuilder = new StringBuilder();

        foreach (var num in numsAsStrings)
        {
            resultStringBuilder.Append(num);
        }

        return resultStringBuilder.ToString();
    }
}