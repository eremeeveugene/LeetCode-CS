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

namespace LeetCode.Algorithms.DividePlayersIntoTeamsOfEqualSkill;

/// <inheritdoc />
public class DividePlayersIntoTeamsOfEqualSkillSorting : IDividePlayersIntoTeamsOfEqualSkill
{
    /// <summary>
    ///     Time complexity - O(n log n)
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="skill"></param>
    /// <returns></returns>
    public long DividePlayers(int[] skill)
    {
        Array.Sort(skill);

        var left = 0;
        var right = skill.Length - 1;

        var groupSum = skill[left] + skill[right];

        long chemistry = skill[left] * skill[right];

        left++;
        right--;

        while (left < right)
        {
            var currentGroupSum = skill[left] + skill[right];

            if (currentGroupSum != groupSum)
            {
                return -1;
            }

            chemistry += skill[left] * skill[right];

            left++;
            right--;
        }

        return chemistry;
    }
}