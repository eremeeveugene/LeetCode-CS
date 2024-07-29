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

namespace LeetCode.Algorithms.FindMinimumOperationsToMakeAllElementsDivisibleByThree;

/// <inheritdoc />
public class FindMinimumOperationsToMakeAllElementsDivisibleByThreeIterative :
    IFindMinimumOperationsToMakeAllElementsDivisibleByThree
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MinimumOperations(int[] nums)
    {
        return nums.Select(num => num % 3).Count(remainder => remainder != 0);
    }
}