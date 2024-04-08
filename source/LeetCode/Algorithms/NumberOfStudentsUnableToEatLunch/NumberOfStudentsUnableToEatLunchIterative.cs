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

namespace LeetCode.Algorithms.NumberOfStudentsUnableToEatLunch;

/// <inheritdoc />
public class NumberOfStudentsUnableToEatLunchIterative : INumberOfStudentsUnableToEatLunch
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="students"></param>
    /// <param name="sandwiches"></param>
    /// <returns></returns>
    public int CountStudents(int[] students, int[] sandwiches)
    {
        var countZero = 0;
        var countOne = 0;

        foreach (var student in students)
        {
            if (student == 0)
            {
                countZero++;
            }

            else
            {
                countOne++;
            }
        }

        foreach (var sandwich in sandwiches)
        {
            if (sandwich == 0 && countZero > 0)
            {
                countZero--;
            }
            else if (sandwich == 1 && countOne > 0)
            {
                countOne--;
            }
            else
            {
                break;
            }
        }

        return countZero + countOne;
    }
}