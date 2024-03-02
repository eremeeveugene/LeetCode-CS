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

namespace LeetCode.Algorithms.SquaresOfSortedArray;

/// <inheritdoc />
public class SquaresOfSortedArrayIterative : ISquaresOfSortedArray
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] SortedSquares(int[] nums)
    {
        var sortedSquares = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            var squareNum = (int)Math.Pow(num, 2);

            for (var j = 0; j < i; j++)
            {
                if (sortedSquares[j] > squareNum)
                {
                    (sortedSquares[j], squareNum) = (squareNum, sortedSquares[j]);
                }
            }

            sortedSquares[i] = squareNum;
        }

        return sortedSquares;
    }
}