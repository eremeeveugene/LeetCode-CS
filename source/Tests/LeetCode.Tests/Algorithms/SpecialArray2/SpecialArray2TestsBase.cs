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

using LeetCode.Algorithms.SpecialArray2;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SpecialArray2;

public abstract class SpecialArray2TestsBase<T> where T : ISpecialArray2, new()
{
    [TestMethod]
    [DataRow("[3,4,1,2,6]", "[[0,4]]", "[false]")]
    [DataRow("[4,3,1,6]", "[[0,2],[2,3]]", "[false,true]")]
    public void IsArraySpecial_WithSubarrayQueries_ReturnsWhetherEachSubarrayHasAlternatingParity(string numsJson,
        string queriesJson, string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);
        var queries = JsonHelper<int[][]>.Parse(queriesJson);
        var expectedResult = JsonHelper<bool[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.IsArraySpecial(nums, queries);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}