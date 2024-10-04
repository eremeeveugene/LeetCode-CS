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
public class DividePlayersIntoTeamsOfEqualSkillDictionary : IDividePlayersIntoTeamsOfEqualSkill
{
    /// <summary>
    ///     Time complexity - O(n)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="skill"></param>
    /// <returns></returns>
    public long DividePlayers(int[] skill)
    {
        var totalSkill = skill.Aggregate<int, long>(0, (current, skillItem) => current + skillItem);

        if (totalSkill % (skill.Length / 2) != 0)
        {
            return -1;
        }

        var targetSkill = totalSkill / (skill.Length / 2);

        var skillCountDictionary = new Dictionary<int, int>();

        long totalChemistry = 0;

        foreach (var skillItem in skill)
        {
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

        if (skillCountDictionary.Values.Any(count => count > 0))
        {
            return -1;
        }

        return totalChemistry;
    }
}