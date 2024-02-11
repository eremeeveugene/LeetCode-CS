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

namespace LeetCode.Tests.Algorithms.SortThePeople;

public abstract class SortThePeopleTestsBase<T> where T : ISortThePeople, new()
{
    [TestMethod]
    [DataRow(new[] { "Mary", "John", "Emma" }, new[] { 180, 165, 170 }, new[] { "Mary", "Emma", "John" })]
    [DataRow(new[] { "Alice", "Bob", "Bob" }, new[] { 155, 185, 150 }, new[] { "Bob", "Alice", "Bob" })]
    public void SortPeople_WithNamesAndHeights_ReturnsSortedNamesByHeight(string[] names, int[] heights,
        string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SortPeople(names, heights);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}