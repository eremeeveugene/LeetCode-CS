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

namespace LeetCode.Algorithms.PartitionArrayIntoThreePartsWithEqualSum;

/// <inheritdoc />
public class PartitionArrayIntoThreePartsWithEqualSumSinglePass : IPartitionArrayIntoThreePartsWithEqualSum
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public bool CanThreePartsEqualSum(int[] arr)
    {
        var totalSum = arr.Sum();

        if (totalSum % 3 != 0)
        {
            return false;
        }

        var targetSum = totalSum / 3;
        var currentSum = 0;
        var foundSegments = 0;

        for (var i = 0; i < arr.Length - 1; i++)
        {
            currentSum += arr[i];

            if (currentSum != targetSum)
            {
                continue;
            }

            foundSegments++;
            currentSum = 0;

            if (foundSegments == 2)
            {
                return true;
            }
        }

        return false;
    }
}