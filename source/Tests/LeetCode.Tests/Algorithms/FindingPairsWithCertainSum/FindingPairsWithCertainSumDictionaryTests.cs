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

using LeetCode.Algorithms.FindingPairsWithCertainSum;

namespace LeetCode.Tests.Algorithms.FindingPairsWithCertainSum;

[TestClass]
public sealed class FindingPairsWithCertainSumDictionaryTests : FindingPairsWithCertainSumTestsBase
{
    protected override IFindingPairsWithCertainSum GetSolution(int[] nums1, int[] nums2)
    {
        return new FindingPairsWithCertainSumDictionary(nums1, nums2);
    }
}