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

namespace LeetCode.Algorithms.StudentAttendanceRecord1;

/// <inheritdoc />
public sealed class StudentAttendanceRecord1Simulation : IStudentAttendanceRecord1
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public bool CheckRecord(string s)
    {
        var lateCount = 0;
        var absentCount = 0;

        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];

            switch (c)
            {
                case 'A':
                    {
                        absentCount++;

                        if (absentCount > 1)
                        {
                            return false;
                        }

                        lateCount = 0;

                        break;
                    }
                case 'L':
                    {
                        lateCount++;

                        if (lateCount > 2)
                        {
                            return false;
                        }

                        break;
                    }
                default:
                    lateCount = 0;

                    break;
            }
        }

        return true;
    }
}