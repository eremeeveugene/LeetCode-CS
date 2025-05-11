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

using LeetCode.Algorithms.ImplementTrie;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ImplementTrie;

public abstract class ImplementTrieTestsBase<T> where T : IImplementTrie, new()
{
    private const string Insert = "insert";
    private const string Search = "search";
    private const string StartsWith = "startsWith";

    [TestMethod]
    [DataRow("[\"insert\",\"search\",\"search\",\"startsWith\",\"insert\",\"search\"]",
        "[\"apple\",\"apple\",\"app\",\"app\",\"app\",\"app\"]",
        "[true,false,true,true]")]
    public void TrieOperations_WithMultipleCommands_ReturnsActionResults(string methodsJson, string argsJson,
        string expectedResultsJson)
    {
        // Arrange
        var methods = JsonHelper<string[]>.Parse(methodsJson);
        var args = JsonHelper<string[]>.Parse(argsJson);
        var expectedResult = JsonHelper<bool>.DeserializeToArray(expectedResultsJson);

        var solution = new T();

        // Act
        var actualResult = new List<bool>();

        for (var i = 0; i < methods.Length; i++)
        {
            switch (methods[i])
            {
                case Insert:
                    solution.Insert(args[i]);
                    break;
                case Search:
                    actualResult.Add(solution.Search(args[i]));
                    break;
                case StartsWith:
                    actualResult.Add(solution.StartsWith(args[i]));
                    break;
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}