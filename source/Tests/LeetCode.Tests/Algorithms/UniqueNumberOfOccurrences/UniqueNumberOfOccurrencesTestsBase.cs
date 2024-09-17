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

using LeetCode.Algorithms.UniqueNumberOfOccurrences;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.UniqueNumberOfOccurrences;

public abstract class UniqueNumberOfOccurrencesTestsBase<T> where T : IUniqueNumberOfOccurrences, new()
{
    [TestMethod]
    [DataRow("[1,2]", false)]
    [DataRow("[1,2,2,1,1,3]", true)]
    [DataRow("[-3,0,1,-3,1,1,1,-3,10,0]", true)]
    public void UniqueOccurrences_WithIntegerArray_ReturnsIfOccurrencesAreUnique(string arrJsonArray,
        bool expectedResult)
    {
        // Arrange
        var arr = JsonHelper<int>.DeserializeToArray(arrJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.UniqueOccurrences(arr);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}