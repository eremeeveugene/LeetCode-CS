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

namespace LeetCode.Algorithms.FindTheMinimumAmountOfTimeToBrewPotions;

/// <summary>
///     https://leetcode.com/problems/find-the-minimum-amount-of-time-to-brew-potions/description/
/// </summary>
public interface IFindTheMinimumAmountOfTimeToBrewPotions
{
    /// <summary>
    ///     Finds the minimum amount of time needed to brew all potions, where each potion must be passed through every
    ///     wizard in sequence and the time a wizard spends on a potion is the product of the wizard's skill and the
    ///     potion's mana capacity.
    /// </summary>
    /// <param name="wizardSkills">The skill levels of the wizards.</param>
    /// <param name="potionMana">The mana capacities of the potions.</param>
    /// <returns>The minimum time required to brew all potions.</returns>
    long MinTime(int[] wizardSkills, int[] potionMana);
}