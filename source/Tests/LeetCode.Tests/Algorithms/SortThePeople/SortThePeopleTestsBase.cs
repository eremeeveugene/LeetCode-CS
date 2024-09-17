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

using LeetCode.Algorithms.SortThePeople;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SortThePeople;

public abstract class SortThePeopleTestsBase<T> where T : ISortThePeople, new()
{
    [TestMethod]
    [DataRow("[\"Mary\",\"John\",\"Emma\"]", "[180,165,170]", "[\"Mary\",\"Emma\",\"John\"]")]
    [DataRow("[\"Alice\",\"Bob\",\"Bob\"]", "[155,185,150]", "[\"Bob\",\"Alice\",\"Bob\"]")]
    public void SortPeople_WithNamesAndHeights_ReturnsSortedNamesByHeight(string namesJsonArray,
        string heightsJsonArray, string expectedResultJsonArray)
    {
        // Arrange
        var names = JsonHelper<string>.DeserializeToArray(namesJsonArray);
        var heights = JsonHelper<int>.DeserializeToArray(heightsJsonArray);
        var expectedResult = JsonHelper<string>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.SortPeople(names, heights);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}