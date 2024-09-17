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

using LeetCode.Algorithms.RevealCardsInIncreasingOrder;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.RevealCardsInIncreasingOrder;

public abstract class RevealCardsInIncreasingOrderTestsBase<T> where T : IRevealCardsInIncreasingOrder, new()
{
    [TestMethod]
    [DataRow("[1]", "[1]")]
    [DataRow("[1,1000]", "[1,1000]")]
    [DataRow("[1,2,3]", "[1,3,2]")]
    [DataRow("[1,2,3,4]", "[1,3,2,4]")]
    [DataRow("[1,2,3,4,5]", "[1,5,2,4,3]")]
    [DataRow("[17,13,11,2,3,5,7]", "[2,13,3,11,5,17,7]")]
    public void DeckRevealedIncreasing_WithUnorderedDeck_ReturnsCorrectlyOrderedDeck(string deckJsonArray,
        string expectedResultJsonArray)
    {
        // Arrange
        var deck = JsonHelper<int>.DeserializeToArray(deckJsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.DeckRevealedIncreasing(deck);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}