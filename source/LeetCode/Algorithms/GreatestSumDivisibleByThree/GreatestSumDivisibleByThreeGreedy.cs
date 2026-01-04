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
public class GreatestSumDivisibleByThreeGreedy : IGreatestSumDivisibleByThree
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MaxSumDivThree(int[] nums)
    {
        var sum = 0;

        var smallestNumberWithRemainderOne = int.MaxValue;
        var secondSmallestNumberWithRemainderOne = int.MaxValue;
        var smallestNumberWithRemainderTwo = int.MaxValue;
        var secondSmallestNumberWithRemainderTwo = int.MaxValue;

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            sum += num;

            var remainder = num % 3;

            switch (remainder)
            {
                case 1 when num < smallestNumberWithRemainderOne:
                    secondSmallestNumberWithRemainderOne = smallestNumberWithRemainderOne;
                    smallestNumberWithRemainderOne = num;

                    break;
                case 1:
                    {
                        if (num < secondSmallestNumberWithRemainderOne)
                        {
                            secondSmallestNumberWithRemainderOne = num;
                        }

                        break;
                    }
                case 2 when num < smallestNumberWithRemainderTwo:
                    secondSmallestNumberWithRemainderTwo = smallestNumberWithRemainderTwo;
                    smallestNumberWithRemainderTwo = num;

                    break;
                case 2:
                    {
                        if (num < secondSmallestNumberWithRemainderTwo)
                        {
                            secondSmallestNumberWithRemainderTwo = num;
                        }

                        break;
                    }
            }
        }

        var sumRemainder = sum % 3;

        switch (sumRemainder)
        {
            case 0:
                return sum;
            case 1:
                {
                    var remove2 = smallestNumberWithRemainderTwo != int.MaxValue &&
                                  secondSmallestNumberWithRemainderTwo != int.MaxValue
                        ? smallestNumberWithRemainderTwo + secondSmallestNumberWithRemainderTwo
                        : int.MaxValue;

                    return sum - Math.Min(smallestNumberWithRemainderOne, remove2);
                }
            default:
                {
                    var remove2 = smallestNumberWithRemainderOne != int.MaxValue &&
                                  secondSmallestNumberWithRemainderOne != int.MaxValue
                        ? smallestNumberWithRemainderOne + secondSmallestNumberWithRemainderOne
                        : int.MaxValue;

                    return sum - Math.Min(smallestNumberWithRemainderTwo, remove2);
                }
        }
    }
}