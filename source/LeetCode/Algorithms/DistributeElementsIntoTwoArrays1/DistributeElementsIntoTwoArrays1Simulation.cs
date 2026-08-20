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

namespace LeetCode.Algorithms.DistributeElementsIntoTwoArrays1;

/// <inheritdoc />
public sealed class DistributeElementsIntoTwoArrays1Simulation : IDistributeElementsIntoTwoArrays1
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int[] ResultArray(int[] nums)
    {
        var n = nums.Length;

        var array1 = new List<int>(n) { nums[0] };
        var array2 = new List<int>(n) { nums[1] };

        for (var i = 2; i < n; i++)
        {
            var destination = array1[^1] > array2[^1] ? array1 : array2;

            destination.Add(nums[i]);
        }

        var numsIndex = 0;

        for (var i = 0; i < array1.Count; i++)
        {
            nums[numsIndex] = array1[i];

            numsIndex++;
        }


        for (var i = 0; i < array2.Count; i++)
        {
            nums[numsIndex] = array2[i];

            numsIndex++;
        }

        return nums;
    }
}