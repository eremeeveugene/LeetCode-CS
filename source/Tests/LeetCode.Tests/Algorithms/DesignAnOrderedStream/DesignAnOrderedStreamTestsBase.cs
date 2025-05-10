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

using LeetCode.Algorithms.DesignAnOrderedStream;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Exceptions;
using System.Text.Json;

namespace LeetCode.Tests.Algorithms.DesignAnOrderedStream;

public abstract class DesignAnOrderedStreamTestsBase
{
    private const string Insert = "insert";

    protected abstract IDesignAnOrderedStream GetDesignAnOrderedStream(int size);

    [TestMethod]
    [DataRow(5, "[\"insert\",\"insert\",\"insert\",\"insert\",\"insert\"]",
        "[[3, \"ccccc\"], [1, \"aaaaa\"], [2, \"bbbbb\"], [5, \"eeeee\"], [4, \"ddddd\"]]",
        "[[], [\"aaaaa\"], [\"bbbbb\", \"ccccc\"], [], [\"ddddd\", \"eeeee\"]]")]
    public void OrderedStream_InsertVariousIndexes_ReturnsValuesInIncreasingOrder(int size, string methodsJson,
        string argumentsJson, string expectedResultJson)
    {
        // Arrange
        var methods = JsonHelper<string>.DeserializeToArray(methodsJson);
        var arguments = JsonHelper<JsonElement>.DeserializeToJaggedArray(argumentsJson);
        var expectedResult = JsonHelper<string>.DeserializeToJaggedArray(expectedResultJson);

        var designAnOrderedStream = GetDesignAnOrderedStream(5);

        // Act 
        var actualResult = new List<string?[]>();

        for (var i = 0; i < methods.Length; i++)
        {
            switch (methods[i])
            {
                case Insert:
                    var idKey = arguments[i][0].GetInt32();
                    var value = arguments[i][1].GetString()!;

                    actualResult.Add(designAnOrderedStream.Insert(idKey, value).ToArray());
                    break;
                default:
                    throw new UnexpectedMethodException(methods[i]);
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}