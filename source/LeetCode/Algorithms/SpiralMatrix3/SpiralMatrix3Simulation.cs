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

namespace LeetCode.Algorithms.SpiralMatrix3;

/// <inheritdoc />
public class SpiralMatrix3Simulation : ISpiralMatrix3
{
    /// <summary>
    ///     Time complexity - O(rows x cols)
    ///     Space complexity - O(rows x cols)
    /// </summary>
    /// <param name="rows"></param>
    /// <param name="cols"></param>
    /// <param name="rStart"></param>
    /// <param name="cStart"></param>
    /// <returns></returns>
    public int[][] SpiralMatrixIII(int rows, int cols, int rStart, int cStart)
    {
        var result = new int[rows * cols][];

        var direction = 0;
        var directionCounter = 1;
        var directionCount = -1;
        var i = 0;

        while (i < result.Length)
        {
            if (rStart >= 0 && cStart >= 0 && rStart < rows && cStart < cols)
            {
                result[i] = [rStart, cStart];

                i++;
            }

            directionCount++;

            if (directionCount >= directionCounter)
            {
                directionCount = 0;

                direction++;

                if (direction > 0 && direction % 2 == 0)
                {
                    directionCounter++;
                }

                if (direction > 3)
                {
                    direction = 0;
                }
            }

            switch (direction)
            {
                case 0:
                    cStart++;
                    break;
                case 1:
                    rStart++;
                    break;
                case 2:
                    cStart--;
                    break;
                default:
                    rStart--;
                    break;
            }
        }

        return result;
    }
}