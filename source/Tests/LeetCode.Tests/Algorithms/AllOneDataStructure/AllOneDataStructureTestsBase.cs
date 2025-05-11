// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.AllOneDataStructure;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.AllOneDataStructure;

public abstract class AllOneDataStructureTestsBase<T> where T : IAllOneDataStructure, new()
{
    private const string GetMaxKey = "getMaxKey";
    private const string GetMinKey = "getMinKey";
    private const string Inc = "inc";
    private const string Dec = "dec";

    [TestMethod]
    [DataRow("[\"inc\", \"inc\", \"getMaxKey\", \"getMinKey\", \"inc\", \"getMaxKey\", \"getMinKey\"]",
        "[[\"hello\"], [\"hello\"], [], [], [\"leet\"], [], []]", "[\"hello\", \"hello\", \"hello\", \"leet\"]")]
    public void IncDecAndGetKeyMethods_WithVariousOperations_ReturnsMaxAndMinKeys(string methodsJson,
        string argumentsJson, string expectedResultJson)
    {
        // Arrange
        var methods = JsonHelper<string[]>.Parse(methodsJson);
        var arguments = JsonHelper<object[][]>.Parse(argumentsJson);
        var expectedResult = JsonHelper<object[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = new List<object>();

        for (var i = 0; i < methods.Length; i++)
        {
            switch (methods[i])
            {
                case Inc:
                    solution.Inc((string)arguments[i][0]);
                    break;
                case Dec:
                    solution.Dec((string)arguments[i][0]);
                    break;
                case GetMaxKey:
                    actualResult.Add(solution.GetMaxKey());
                    break;
                case GetMinKey:
                    actualResult.Add(solution.GetMinKey());
                    break;
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}