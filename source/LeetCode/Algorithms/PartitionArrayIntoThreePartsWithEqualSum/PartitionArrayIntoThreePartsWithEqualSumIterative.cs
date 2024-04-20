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
public class PartitionArrayIntoThreePartsWithEqualSumIterative : IPartitionArrayIntoThreePartsWithEqualSum
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

        var singleSum = totalSum / 3;

        var firstSum = 0;

        var index = 0;

        for (var i = 0; i < arr.Length; i++)
        {
            firstSum += arr[i];

            if (firstSum != singleSum)
            {
                continue;
            }

            index = i + 1;

            break;
        }

        if (index >= arr.Length)
        {
            return false;
        }

        var secondSum = 0;

        for (var i = index; i < arr.Length; i++)
        {
            secondSum += arr[i];

            if (secondSum != singleSum)
            {
                continue;
            }

            index = i + 1;

            break;
        }

        if (index >= arr.Length)
        {
            return false;
        }

        var thirdSum = 0;

        for (var i = index; i < arr.Length; i++)
        {
            thirdSum += arr[i];

            if (thirdSum == singleSum)
            {
                break;
            }
        }

        return totalSum - firstSum - secondSum - thirdSum == 0;
    }
}