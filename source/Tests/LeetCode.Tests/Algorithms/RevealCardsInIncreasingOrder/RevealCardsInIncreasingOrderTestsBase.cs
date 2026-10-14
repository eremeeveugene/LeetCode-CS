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

using LeetCode.Algorithms.RevealCardsInIncreasingOrder;

namespace LeetCode.Tests.Algorithms.RevealCardsInIncreasingOrder;

public abstract class RevealCardsInIncreasingOrderTestsBase<T> where T : IRevealCardsInIncreasingOrder, new()
{
    [TestMethod]
    [DataRow(new[] { 1 }, new[] { 1 })]
    [DataRow(new[] { 1, 1000 }, new[] { 1, 1000 })]
    [DataRow(new[] { 1, 2, 3 }, new[] { 1, 3, 2 })]
    [DataRow(new[] { 1, 2, 3, 4 }, new[] { 1, 3, 2, 4 })]
    [DataRow(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 5, 2, 4, 3 })]
    [DataRow(new[] { 17, 13, 11, 2, 3, 5, 7 }, new[] { 2, 13, 3, 11, 5, 17, 7 })]
    [DataRow(new[] { 5, 3 }, new[] { 3, 5 })]
    [DataRow(new[] { 3, 5 }, new[] { 3, 5 })]
    [DataRow(new[] { 2, 1 }, new[] { 1, 2 })]
    [DataRow(new[] { 9, 8, 7, 6 }, new[] { 6, 8, 7, 9 })]
    [DataRow(new[] { 1, 10, 100, 1000, 10000, 100000 }, new[] { 1, 1000, 10, 100000, 100, 10000 })]
    [DataRow(new[] { 1000000, 1 }, new[] { 1, 1000000 })]
    [DataRow(new[] { 6, 5, 4, 3, 2, 1 }, new[] { 1, 4, 2, 6, 3, 5 })]
    [DataRow(new[] { 2, 4, 6, 8, 10, 12, 14, 16 }, new[] { 2, 10, 4, 14, 6, 12, 8, 16 })]
    [DataRow(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, new[] { 1, 6, 2, 10, 3, 7, 4, 9, 5, 8 })]
    [DataRow(new[] { 4, 2, 9, 1, 7, 3, 8 }, new[] { 1, 8, 2, 7, 3, 9, 4 })]
    [DataRow(new[] { 1000000, 999999, 999998, 999997, 999996 }, new[] { 999996, 1000000, 999997, 999999, 999998 })]
    [DataRow(new[] { 28, 98, 14, 95, 87, 9, 63, 65, 69, 60, 84, 67, 12, 17, 57 }, new[] { 9, 84, 12, 65, 14, 95, 17, 67, 28, 87, 57, 69, 60, 98, 63 })]
    [DataRow(new[] { 567, 765, 686, 601, 181, 509, 690, 53, 24, 488, 979, 991, 145, 575, 391, 591, 775, 197, 865, 650, 809, 31, 678, 887, 338, 81, 527, 65, 308, 898, 39 }, new[] { 24, 765, 31, 575, 39, 887, 53, 591, 65, 775, 81, 601, 145, 979, 181, 650, 197, 809, 308, 678, 338, 898, 391, 686, 488, 865, 509, 690, 527, 991, 567 })]
    [DataRow(new[] { 408511, 126782, 709636, 612488, 584100, 121783, 416510, 764558, 83656, 192591, 469895, 819870, 282480, 732621, 312292, 227951, 475650, 119432, 374279, 207688, 600651, 236589, 822166, 111878, 704047, 788482, 780252, 47827, 452506, 965307, 890190, 169592, 734724, 60212, 852139, 441666, 87902, 648199, 245642, 249728, 821031, 856530, 225473, 423877, 552993, 658603, 493567, 788371, 87812, 293180 }, new[] { 47827, 452506, 60212, 890190, 83656, 469895, 87812, 734724, 87902, 475650, 111878, 821031, 119432, 493567, 121783, 764558, 126782, 552993, 169592, 856530, 192591, 584100, 207688, 780252, 225473, 600651, 227951, 822166, 236589, 612488, 245642, 788371, 249728, 648199, 282480, 965307, 293180, 658603, 312292, 788482, 374279, 704047, 408511, 852139, 416510, 709636, 423877, 819870, 441666, 732621 })]
    public void DeckRevealedIncreasing_WithUnorderedDeck_ReturnsOrderThatRevealsCardsInIncreasingSequence(int[] deck, int[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.DeckRevealedIncreasing(deck);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}