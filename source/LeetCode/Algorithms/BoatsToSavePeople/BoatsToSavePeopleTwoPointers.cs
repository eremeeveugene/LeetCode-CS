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

namespace LeetCode.Algorithms.BoatsToSavePeople;

/// <inheritdoc />
public class BoatsToSavePeopleTwoPointers : IBoatsToSavePeople
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="people"></param>
    /// <param name="limit"></param>
    /// <returns></returns>
    public int NumRescueBoats(int[] people, int limit)
    {
        var result = 0;

        Array.Sort(people);

        var left = 0;
        var right = people.Length - 1;

        while (left <= right)
        {
            var leftValue = people[left];
            var rightValue = people[right];

            if (leftValue + rightValue <= limit)
            {
                left++;
            }

            right--;

            result++;
        }

        return result;
    }
}