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

namespace LeetCode.Algorithms.AddToArrayFormOfInteger;

/// <inheritdoc />
public class AddToArrayFormOfIntegerSummation : IAddToArrayFormOfInteger
{
    /// <summary>
    ///     Time complexity - O(max(n, log k)), where n is the length of the array num and log k is the number of digits in the
    ///     integer k
    ///     Space complexity - O(max(n, log k)), where n is the length of the array num and log k is the number of digits in
    ///     the integer k
    /// </summary>
    /// <param name="num"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    public IList<int> AddToArrayForm(int[] num, int k)
    {
        var result = new List<int>();

        var kString = k.ToString();
        var kIndex = kString.Length - 1;
        var numIndex = num.Length - 1;

        var carry = 0;

        while (numIndex >= 0 || kIndex >= 0)
        {
            var val1 = 0;

            if (numIndex >= 0)
            {
                val1 = num[numIndex];
                numIndex--;
            }

            var val2 = 0;

            if (kIndex >= 0)
            {
                val2 = (int)char.GetNumericValue(kString[kIndex]);
                kIndex--;
            }

            var sum = val1 + val2 + carry;

            if (sum >= 10)
            {
                sum -= 10;
                carry = 1;
            }
            else
            {
                carry = 0;
            }

            result.Add(sum);
        }

        if (carry > 0)
        {
            result.Add(carry);
        }

        result.Reverse();

        return result;
    }
}