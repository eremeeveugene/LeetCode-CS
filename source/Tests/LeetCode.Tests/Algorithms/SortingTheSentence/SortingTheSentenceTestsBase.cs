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

using LeetCode.Algorithms.SortingTheSentence;

namespace LeetCode.Tests.Algorithms.SortingTheSentence;

public abstract class SortingTheSentenceTestsBase<T> where T : ISortingTheSentence, new()
{
    [TestMethod]
    [DataRow("is2 sentence4 This1 a3", "This is a sentence")]
    [DataRow("Myself2 Me1 I4 and3", "Me Myself and I")]
    [DataRow("b2 a1", "a b")]
    [DataRow("Hello1 World2", "Hello World")]
    [DataRow("here3 I1 am2", "I am here")]
    [DataRow("y2 x1 w4 z3", "x y z w")]
    [DataRow("I9 F6 B2 G7 A1 E5 H8 C3 D4", "A B C D E F G H I")]
    [DataRow("One1 Two2", "One Two")]
    [DataRow("bb2 dd4 ee5 cc3 aa1", "aa bb cc dd ee")]
    [DataRow("jumps5 lazy8 The1 the7 brown3 over6 quick2 fox4 dog9", "The quick brown fox jumps over the lazy dog")]
    [DataRow("Z1 a2", "Z a")]
    [DataRow("same3 same2 same1", "same same same")]
    [DataRow("UP3 cXkDgB5 jpELv9 nog6 zYrG4 V1 n7 p2 H8", "V p UP zYrG cXkDgB nog n H jpELv")]
    [DataRow("yHtXF1 N2", "yHtXF N")]
    [DataRow("D1 Pg2", "D Pg")]
    [DataRow("G3 JF1 jBZzkC2", "JF jBZzkC G")]
    [DataRow("Cswp6 wcKF2 CGwVNiw4 y3 Y5 diFLrXMX1", "diFLrXMX wcKF y CGwVNiw Y Cswp")]
    [DataRow("rrzKUg1 AcXyzr2", "rrzKUg AcXyzr")]
    [DataRow("irEL6 vXQ7 uay5 dRp1 X2 oWMgIr4 sGVzUuk3", "dRp X sGVzUuk oWMgIr uay irEL vXQ")]
    [DataRow("BZNhe2 YKJqdnV4 VNR3 z1", "z BZNhe VNR YKJqdnV")]
    public void SortSentence_WithShuffledSentence_ReturnsWordsInOriginalOrderBasedOnTrailingIndices(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.SortSentence(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}