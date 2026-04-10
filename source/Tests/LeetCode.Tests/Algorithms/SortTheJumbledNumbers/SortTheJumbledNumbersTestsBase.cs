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

using LeetCode.Algorithms.SortTheJumbledNumbers;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SortTheJumbledNumbers;

public abstract class SortTheJumbledNumbersTestsBase<T> where T : ISortTheJumbledNumbers, new()
{
    [TestMethod]
    [DataRow("[0,1,2,3,4,5,6,7,8,9]", "[789,456,123]", "[123,456,789]")]
    [DataRow("[9,8,7,6,5,4,3,2,1,0]", "[0,1,2,3,4,5,6,7,8,9]", "[9,8,7,6,5,4,3,2,1,0]")]
    [DataRow("[8,9,4,0,2,1,3,5,7,6]", "[991,338,38]", "[338,38,991]")]
    public void SortJumbled_WithDigitMappingAndNumbers_SortsNumsByMappedValuePreservingRelativeOrder(string mappingJson,
        string numsJson, string expectedResultJson)
    {
        // Arrange
        var mapping = JsonHelper.Parse<int[]>(mappingJson);
        var nums = JsonHelper.Parse<int[]>(numsJson);
        var expectedResult = JsonHelper.Parse<int[]>(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.SortJumbled(mapping, nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}