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
public class NumberOfStudentsUnableToEatLunchQueue : INumberOfStudentsUnableToEatLunch
{
    /// <summary>
    ///     Time complexity - O(n^2)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="students"></param>
    /// <param name="sandwiches"></param>
    /// <returns></returns>
    public int CountStudents(int[] students, int[] sandwiches)
    {
        var studentsQueue = new Queue<int>(students);

        var sandwichesIndex = 0;

        var count = 0;

        while (studentsQueue.Count > 0 && sandwichesIndex < sandwiches.Length &&
               count < sandwiches.Length - sandwichesIndex)
        {
            var student = studentsQueue.Dequeue();
            var sandwich = sandwiches[sandwichesIndex];

            if (student == sandwich)
            {
                count = 0;
                sandwichesIndex++;
            }
            else
            {
                count++;
                studentsQueue.Enqueue(student);
            }
        }

        return studentsQueue.Count;
    }
}