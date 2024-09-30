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
    [DataRow(
        "[\"inc\",\"inc\",\"getMaxKey\",\"getMinKey\",\"inc\",\"getMaxKey\",\"getMinKey\"]",
        "[\"hello\",\"hello\",null,null,\"leet\",null,null]",
        "[\"hello\",\"hello\",\"hello\",\"leet\"]")]
    [DataRow(
        "[\"inc\",\"inc\",\"inc\",\"inc\",\"getMaxKey\",\"getMinKey\"]",
        "[\"a\",\"b\",\"c\",\"d\",null,null]",
        "[\"a\",\"d\"]")]
    [DataRow(
        "[\"inc\",\"inc\",\"inc\",\"inc\",\"inc\",\"dec\",\"dec\",\"getMaxKey\",\"getMinKey\"]",
        "[\"a\",\"b\",\"c\",\"d\",\"c\",\"c\",\"c\",null,null]",
        "[\"a\",\"d\"]")]
    public void IncDecAndGetKeyMethods_WithVariousOperations_ReturnsMaxAndMinKeys(string methodsJsonArray, string argsJsonArray,
        string expectedResultsJsonArray)
    {
        // Arrange
        var methods = JsonHelper<string>.DeserializeToArray(methodsJsonArray);
        var args = JsonHelper<string>.DeserializeToArray(argsJsonArray);
        var expectedResult = JsonHelper<string>.DeserializeToArray(expectedResultsJsonArray);

        var solution = new T();

        // Act
        var actualResult = new List<string>();

        for (var i = 0; i < methods.Length; i++)
        {
            switch (methods[i])
            {
                case Inc:
                    solution.Inc(args[i]);
                    break;
                case Dec:
                    solution.Dec(args[i]);
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