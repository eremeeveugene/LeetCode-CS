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

using LeetCode.Algorithms.DesignAnOrderedStream;

namespace LeetCode.Tests.Algorithms.DesignAnOrderedStream;

public abstract class DesignAnOrderedStreamTestsBase<T> where T : IDesignAnOrderedStreamArrayFactory, new()
{
    [TestMethod]
    public void OrderedStream_InsertVariousIndexes_ReturnsExpectedOutput()
    {
        // Arrange
        var designAnOrderedStreamFactory = new T();

        // Act 
        var designAnOrderedStream = designAnOrderedStreamFactory.Create(5);

        // Assert
        CollectionAssert.AreEqual(new List<string>(), designAnOrderedStream.Insert(3, "ccccc").ToArray());

        CollectionAssert.AreEqual(new List<string> { "aaaaa" }, designAnOrderedStream.Insert(1, "aaaaa").ToArray());

        CollectionAssert.AreEqual(new List<string> { "bbbbb", "ccccc" },
            designAnOrderedStream.Insert(2, "bbbbb").ToArray());

        CollectionAssert.AreEqual(new List<string>(), designAnOrderedStream.Insert(5, "eeeee").ToArray());

        CollectionAssert.AreEqual(new List<string> { "ddddd", "eeeee" },
            designAnOrderedStream.Insert(4, "ddddd").ToArray());
    }
}