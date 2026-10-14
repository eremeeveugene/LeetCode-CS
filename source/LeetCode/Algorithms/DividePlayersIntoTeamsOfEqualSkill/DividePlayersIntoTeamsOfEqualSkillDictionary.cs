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

namespace LeetCode.Algorithms.DividePlayersIntoTeamsOfEqualSkill;

/// <inheritdoc />
public sealed class DividePlayersIntoTeamsOfEqualSkillDictionary : IDividePlayersIntoTeamsOfEqualSkill
{
    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </remarks>
    public long DividePlayers(int[] skill)
    {
        long totalSkill = 0;

        for (var i = 0; i < skill.Length; i++)
        {
            totalSkill += skill[i];
        }

        if (totalSkill % (skill.Length / 2) != 0)
        {
            return -1;
        }

        var targetSkill = totalSkill / (skill.Length / 2);

        var skillCountDictionary = new Dictionary<int, int>();

        long totalChemistry = 0;

        for (var i = 0; i < skill.Length; i++)
        {
            var skillItem = skill[i];

            var complement = (int)(targetSkill - skillItem);

            if (skillCountDictionary.TryGetValue(complement, out var value) && value > 0)
            {
                totalChemistry += (long)skillItem * complement;

                skillCountDictionary[complement]--;
            }
            else
            {
                skillCountDictionary.TryAdd(skillItem, 0);

                skillCountDictionary[skillItem]++;
            }
        }

        var counts = new int[skillCountDictionary.Count];

        skillCountDictionary.Values.CopyTo(counts, 0);

        for (var i = 0; i < counts.Length; i++)
        {
            if (counts[i] > 0)
            {
                return -1;
            }
        }

        return totalChemistry;
    }
}