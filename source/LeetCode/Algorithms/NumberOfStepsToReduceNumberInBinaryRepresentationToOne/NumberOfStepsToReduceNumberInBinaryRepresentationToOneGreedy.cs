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

namespace LeetCode.Algorithms.NumberOfStepsToReduceNumberInBinaryRepresentationToOne;

public class NumberOfStepsToReduceNumberInBinaryRepresentationToOneGreedy :
    INumberOfStepsToReduceNumberInBinaryRepresentationToOne
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int NumSteps(string s)
    {
        var steps = 0;

        var carry = 0;

        for (var i = s.Length - 1; i > 0; i--)
        {
            if ((s[i] - '0' + carry) % 2 == 0)
            {
                steps++;
            }
            else
            {
                steps += 2;

                carry = 1;
            }
        }

        return steps + carry;
    }
}