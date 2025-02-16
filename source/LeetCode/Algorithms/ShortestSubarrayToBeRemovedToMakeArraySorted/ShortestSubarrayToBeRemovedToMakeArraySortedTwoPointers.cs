// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.ShortestSubarrayToBeRemovedToMakeArraySorted;

/// <inheritdoc />
public class ShortestSubarrayToBeRemovedToMakeArraySortedTwoPointers : IShortestSubarrayToBeRemovedToMakeArraySorted
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public int FindLengthOfShortestSubarray(int[] arr)
    {
        var left = 0;

        while (left < arr.Length - 1 && arr[left] <= arr[left + 1])
        {
            left++;
        }

        if (left == arr.Length - 1)
        {
            return 0;
        }

        var right = arr.Length - 1;

        while (right > 0 && arr[right - 1] <= arr[right])
        {
            right--;
        }

        var result = Math.Min(arr.Length - left - 1, right);

        var i = 0;
        var j = right;

        while (i <= left && j < arr.Length)
        {
            if (arr[i] <= arr[j])
            {
                result = Math.Min(result, j - i - 1);

                i++;
            }
            else
            {
                j++;
            }
        }

        return result;
    }
}