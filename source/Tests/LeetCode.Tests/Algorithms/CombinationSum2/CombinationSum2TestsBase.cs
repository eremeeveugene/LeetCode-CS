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

using LeetCode.Algorithms.CombinationSum2;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.CombinationSum2;

public abstract class CombinationSum2TestsBase<T> where T : ICombinationSum2, new()
{
    [TestMethod]
    [DataRow("[10, 1, 2, 7, 6, 1, 5]", 8, "[[1,1,6],[1,2,5],[1,7],[2,6]]")]
    [DataRow("[2, 5, 2, 1, 2]", 5, "[[1,2,2],[5]]")]
    public void CombinationSum2_WithCandidatesAndTarget_ReturnsExpectedCombinations(string candidatesJsonArray,
        int target, string expectedResultJsonArray)
    {
        // Arrange
        var candidates = JsonHelper<int>.DeserializeToArray(candidatesJsonArray);

        var solution = new T();

        var expectedResult = JsonHelper<int>.DeserializeToJaggedList(expectedResultJsonArray);

        // Act
        var actualResult = solution.CombinationSum2(candidates, target);

        // Assert
        JaggedListAssert.AreEquivalent(expectedResult, actualResult);
    }
}