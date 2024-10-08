﻿// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.ImplementStackUsingQueues;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ImplementStackUsingQueues;

public abstract class ImplementStackUsingQueuesTestsBase<T> where T : IImplementStackUsingQueues, new()
{
    [TestMethod]
    [DataRow("[1, 2, 3]", 3, 3, 2)]
    [DataRow("[5, 10, 15, 20]", 20, 20, 15)]
    [DataRow("[42]", 42, 42, null)]
    public void PushPopTop_WithVariousElements_ReturnsExpectedTopAndPopValues(string pushElementsJsonArray,
        int topExpected, int popExpected, int? popAfterTopExpected)
    {
        // Arrange
        var pushElements = JsonHelper<int>.DeserializeToArray(pushElementsJsonArray);

        var solution = new T();

        // Act
        foreach (var element in pushElements)
        {
            solution.Push(element);
        }

        // Assert
        Assert.AreEqual(topExpected, solution.Top());
        Assert.AreEqual(popExpected, solution.Pop());

        if (popAfterTopExpected.HasValue)
        {
            Assert.AreEqual(popAfterTopExpected.Value, solution.Top());
        }
    }

    [TestMethod]
    public void Empty_WhenItemPushed_ReturnsFalse()
    {
        // Arrange
        var solution = new T();

        // Act
        solution.Push(0);

        // Assert
        Assert.IsFalse(solution.Empty());
    }

    [TestMethod]
    [DataRow("[1, 2, 3]", "[3, 2, 1]")]
    [DataRow("[5, 10, 15]", "[15, 10, 5]")]
    [DataRow("[]", "[]")]
    public void MultiplePushAndPop_WithVariousElements_ReturnsElementsInLIFOOrder(string pushElementsJsonArray,
        string popExpectedJsonArray)
    {
        // Arrange
        var pushElements = JsonHelper<int>.DeserializeToArray(pushElementsJsonArray);
        var popExpected = JsonHelper<int>.DeserializeToArray(popExpectedJsonArray);

        var solution = new T();

        // Act
        foreach (var element in pushElements)
        {
            solution.Push(element);
        }

        // Assert
        foreach (var expected in popExpected)
        {
            Assert.AreEqual(expected, solution.Pop());
        }

        Assert.IsTrue(solution.Empty());
    }
}