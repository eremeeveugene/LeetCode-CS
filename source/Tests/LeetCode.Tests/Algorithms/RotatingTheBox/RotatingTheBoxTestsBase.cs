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

using LeetCode.Algorithms.RotatingTheBox;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.RotatingTheBox;

public abstract class RotatingTheBoxTestsBase<T> where T : IRotatingTheBox, new()
{
    [TestMethod]
    [DataRow("[[\"#\",\".\",\"#\"]]", "[[\".\"],[\"#\"],[\"#\"]]")]
    [DataRow("[[\"#\",\".\",\"*\",\".\"],[\"#\",\"#\",\"*\",\".\"]]",
        "[[\"#\",\".\"],[\"#\",\"#\"],[\"*\",\"*\"],[\".\",\".\"]]")]
    [DataRow(
        "[[\"#\",\"#\",\"*\",\".\",\"*\",\".\"],[\"#\",\"#\",\"#\",\"*\",\".\",\".\"],[\"#\",\"#\",\"#\",\".\",\"#\",\".\"]]",
        "[[\".\",\"#\",\"#\"],[\".\",\"#\",\"#\"],[\"#\",\"#\",\"*\"],[\"#\",\"*\",\".\"],[\"#\",\".\",\"*\"],[\"#\",\".\",\".\"]]")]
    public void RotateTheBox_WithJaggedArrayInput_ReturnsRotatedBox(string boxJsonArray, string expectedResultJsonArray)
    {
        // Arrange
        var box = JsonHelper<char>.DeserializeToJaggedArray(boxJsonArray);
        var expectedResult = JsonHelper<char>.DeserializeToJaggedArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.RotateTheBox(box);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}