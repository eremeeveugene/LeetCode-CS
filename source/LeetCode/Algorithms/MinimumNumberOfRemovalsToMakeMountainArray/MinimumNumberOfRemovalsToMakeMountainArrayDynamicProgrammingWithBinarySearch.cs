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

namespace LeetCode.Algorithms.MinimumNumberOfRemovalsToMakeMountainArray;

/// <inheritdoc />
public sealed class MinimumNumberOfRemovalsToMakeMountainArrayDynamicProgrammingWithBinarySearch : IMinimumNumberOfRemovalsToMakeMountainArray
{
    /// <inheritdoc />
    /// <remarks>
    ///     Combines increasing and decreasing subsequences at each peak, requiring both sides to have length greater than one.
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(n)
    /// </remarks>
    public int MinimumMountainRemovals(int[] nums)
    {
        var n = nums.Length;

        Span<int> increasingLengths = stackalloc int[n];
        Span<int> decreasingLengths = stackalloc int[n];
        Span<int> smallestTails = stackalloc int[n];

        var longestLength = 0;

        for (var i = 0; i < n; i++)
        {
            var num = nums[i];

            var insertionIndex = smallestTails[..longestLength].BinarySearch(num);

            if (insertionIndex < 0)
            {
                insertionIndex = ~insertionIndex;
            }

            smallestTails[insertionIndex] = num;

            if (insertionIndex == longestLength)
            {
                longestLength++;
            }

            increasingLengths[i] = insertionIndex + 1;
        }

        longestLength = 0;

        for (var i = n - 1; i >= 0; i--)
        {
            var num = nums[i];

            var insertionIndex = smallestTails[..longestLength].BinarySearch(num);

            if (insertionIndex < 0)
            {
                insertionIndex = ~insertionIndex;
            }

            smallestTails[insertionIndex] = num;

            if (insertionIndex == longestLength)
            {
                longestLength++;
            }

            decreasingLengths[i] = insertionIndex + 1;
        }

        var longestMountainLength = 0;

        for (var i = 1; i < n - 1; i++)
        {
            var increasingLength = increasingLengths[i];
            var decreasingLength = decreasingLengths[i];

            if (increasingLength <= 1 || decreasingLength <= 1)
            {
                continue;
            }

            var mountainLength = increasingLength + decreasingLength - 1;

            longestMountainLength = Math.Max(longestMountainLength, mountainLength);
        }

        return n - longestMountainLength;
    }
}