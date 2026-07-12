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

namespace LeetCode.Algorithms.GreatestSumDivisibleByThree;

/// <inheritdoc />
public sealed class GreatestSumDivisibleByThreeGreedy : IGreatestSumDivisibleByThree
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </remarks>
    public int MaxSumDivThree(int[] nums)
    {
        var sum = 0;

        var smallestNumberWithRemainderOne = int.MaxValue;
        var secondSmallestNumberWithRemainderOne = int.MaxValue;
        var smallestNumberWithRemainderTwo = int.MaxValue;
        var secondSmallestNumberWithRemainderTwo = int.MaxValue;

        foreach (var num in nums)
        {
            sum += num;

            switch (num % 3)
            {
                case 1:
                    TrackTwoSmallest(num, ref smallestNumberWithRemainderOne, ref secondSmallestNumberWithRemainderOne);

                    break;
                case 2:
                    TrackTwoSmallest(num, ref smallestNumberWithRemainderTwo, ref secondSmallestNumberWithRemainderTwo);

                    break;
            }
        }

        return (sum % 3) switch
        {
            0 => sum,
            1 => sum - GetMinimumRemoval(smallestNumberWithRemainderOne, smallestNumberWithRemainderTwo, secondSmallestNumberWithRemainderTwo),
            _ => sum - GetMinimumRemoval(smallestNumberWithRemainderTwo, smallestNumberWithRemainderOne, secondSmallestNumberWithRemainderOne)
        };
    }

    private static void TrackTwoSmallest(int num, ref int smallest, ref int secondSmallest)
    {
        if (num < smallest)
        {
            secondSmallest = smallest;
            smallest = num;
        }
        else if (num < secondSmallest)
        {
            secondSmallest = num;
        }
    }

    private static int GetMinimumRemoval(int smallestSameRemainder, int smallestOtherRemainder, int secondSmallestOtherRemainder)
    {
        var removePair = smallestOtherRemainder != int.MaxValue && secondSmallestOtherRemainder != int.MaxValue
            ? smallestOtherRemainder + secondSmallestOtherRemainder
            : int.MaxValue;

        return Math.Min(smallestSameRemainder, removePair);
    }
}