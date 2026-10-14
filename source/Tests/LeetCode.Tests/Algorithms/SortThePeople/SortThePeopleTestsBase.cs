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

using LeetCode.Algorithms.SortThePeople;

namespace LeetCode.Tests.Algorithms.SortThePeople;

public abstract class SortThePeopleTestsBase<T> where T : ISortThePeople, new()
{
    [TestMethod]
    [DataRow(new[] { "Mary", "John", "Emma" }, new[] { 180, 165, 170 }, new[] { "Mary", "Emma", "John" })]
    [DataRow(new[] { "Alice", "Bob", "Bob" }, new[] { 155, 185, 150 }, new[] { "Bob", "Alice", "Bob" })]
    [DataRow(new[] { "A" }, new[] { 1 }, new[] { "A" })]
    [DataRow(new[] { "Zed" }, new[] { 100000 }, new[] { "Zed" })]
    [DataRow(new[] { "A", "B" }, new[] { 1, 2 }, new[] { "B", "A" })]
    [DataRow(new[] { "A", "B" }, new[] { 2, 1 }, new[] { "A", "B" })]
    [DataRow(new[] { "Bob", "Bob" }, new[] { 10, 20 }, new[] { "Bob", "Bob" })]
    [DataRow(new[] { "Bob", "Bob", "Alice" }, new[] { 10, 30, 20 }, new[] { "Bob", "Alice", "Bob" })]
    [DataRow(new[] { "a", "b", "c", "d", "e" }, new[] { 5, 4, 3, 2, 1 }, new[] { "a", "b", "c", "d", "e" })]
    [DataRow(new[] { "a", "b", "c", "d", "e" }, new[] { 1, 2, 3, 4, 5 }, new[] { "e", "d", "c", "b", "a" })]
    [DataRow(new[] { "Tall", "Short", "Mid" }, new[] { 100000, 1, 50000 }, new[] { "Tall", "Mid", "Short" })]
    [DataRow(new[] { "x", "y", "z", "x", "y", "z" }, new[] { 6, 1, 5, 2, 4, 3 }, new[] { "x", "z", "y", "z", "x", "y" })]
    [DataRow(new[] { "Mia", "Noah", "Noah", "Alice", "Liam", "John", "Z", "A", "Liam", "Sophia", "Bob", "Bob" }, new[] { 53602, 56390, 49148, 67389, 75800, 60746, 20252, 83455, 58066, 60115, 40583, 83911 }, new[] { "Bob", "A", "Liam", "Alice", "John", "Sophia", "Liam", "Noah", "Mia", "Noah", "Bob", "Z" })]
    [DataRow(new[] { "Oliver", "Alice", "John", "Bob", "Mia", "Mary", "Liam", "Bob", "Oliver", "Noah", "Noah", "Mary", "Oliver", "Ava", "Oliver", "A", "Sophia", "Mary", "Bob" }, new[] { 84461, 46644, 69101, 86056, 45653, 23331, 3853, 88932, 53125, 45106, 14132, 55862, 59629, 45361, 58407, 49321, 496, 88617, 54198 }, new[] { "Bob", "Mary", "Bob", "Oliver", "John", "Oliver", "Oliver", "Mary", "Bob", "Oliver", "A", "Alice", "Mia", "Ava", "Noah", "Mary", "Noah", "Liam", "Sophia" })]
    [DataRow(new[] { "Bob", "Noah", "Mia", "Mary", "John", "Emma", "Bob", "Sophia", "A", "Z", "A", "Liam", "Noah", "Z", "Oliver" }, new[] { 60329, 52217, 20020, 60512, 31512, 89192, 62852, 33807, 71271, 68273, 3077, 78019, 11080, 34669, 46809 }, new[] { "Emma", "Liam", "A", "Z", "Bob", "Mary", "Bob", "Noah", "Oliver", "Z", "Sophia", "John", "Mia", "Noah", "A" })]
    [DataRow(new[] { "Ava", "Alice", "Alice", "A", "Liam", "Bob", "A", "Anna", "Sophia", "Noah", "Bob", "Sophia", "Ava", "John", "A" }, new[] { 13662, 85529, 41218, 45166, 76475, 90156, 64898, 37451, 22852, 12700, 65651, 66160, 20349, 79995, 39146 }, new[] { "Bob", "Alice", "John", "Liam", "Sophia", "Bob", "A", "A", "Alice", "A", "Anna", "Sophia", "Ava", "Ava", "Noah" })]
    [DataRow(new[] { "Z", "Liam", "Liam", "Mia", "Emma", "Z", "Oliver", "Emma", "Bob", "Bob" }, new[] { 26739, 5463, 52538, 35606, 11039, 23831, 909, 78253, 28415, 40549 }, new[] { "Emma", "Liam", "Bob", "Mia", "Bob", "Z", "Z", "Emma", "Liam", "Oliver" })]
    [DataRow(new[] { "Bob", "Mia", "Bob", "Noah", "Noah", "Liam", "Noah", "Bob", "Z", "A", "A", "Emma", "John", "Oliver", "Anna", "Alice", "Mary", "Z", "Mary" }, new[] { 89532, 89401, 77193, 51903, 33301, 5343, 26144, 79214, 2683, 71257, 52787, 61843, 14740, 60659, 48386, 77579, 74967, 47158, 27962 }, new[] { "Bob", "Mia", "Bob", "Alice", "Bob", "Mary", "A", "Emma", "Oliver", "A", "Noah", "Anna", "Z", "Noah", "Mary", "Noah", "John", "Liam", "Z" })]
    [DataRow(new[] { "Bob", "Z", "Mia", "Oliver", "A", "Anna", "Mary", "Ava", "Bob", "Anna", "Bob", "Liam" }, new[] { 84623, 62442, 78992, 33928, 77378, 96249, 21738, 40891, 20327, 96415, 84507, 15433 }, new[] { "Anna", "Anna", "Bob", "Bob", "Mia", "A", "Z", "Ava", "Oliver", "Mary", "Bob", "Liam" })]
    [DataRow(new[] { "Ava", "Bob", "Ava", "Anna", "Oliver" }, new[] { 24749, 51616, 7956, 66658, 79428 }, new[] { "Oliver", "Anna", "Bob", "Ava", "Ava" })]
    public void SortPeople_WithNamesAndHeights_ReturnsSortedNamesByHeight(string[] names, int[] heights, string[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SortPeople(names, heights);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }
}