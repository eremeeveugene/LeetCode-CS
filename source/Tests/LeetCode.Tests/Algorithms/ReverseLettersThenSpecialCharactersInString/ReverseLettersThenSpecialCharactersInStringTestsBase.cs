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

using LeetCode.Algorithms.ReverseLettersThenSpecialCharactersInString;

namespace LeetCode.Tests.Algorithms.ReverseLettersThenSpecialCharactersInString;

public abstract class ReverseLettersThenSpecialCharactersInStringTestsBase<T> where T : IReverseLettersThenSpecialCharactersInString, new()
{
    [TestMethod]
    [DataRow("a", "a")]
    [DataRow("z", "z")]
    [DataRow("!", "!")]
    [DataRow(")ebc#da@f(", "(fad@cb#e)")]
    [DataRow("!@#$%^&*()", ")(*&^%$#@!")]
    [DataRow("ab", "ba")]
    [DataRow("a!", "a!")]
    [DataRow("!a", "!a")]
    [DataRow("ab!", "ba!")]
    [DataRow("!ab", "!ba")]
    [DataRow("a!b", "b!a")]
    [DataRow("!a!", "!a!")]
    [DataRow("abc", "cba")]
    [DataRow("!@#", "#@!")]
    [DataRow("a!b@c#d", "d#c@b!a")]
    [DataRow("ab!!cd", "dc!!ba")]
    [DataRow("!!ab!!", "!!ba!!")]
    [DataRow("abcdefghij", "jihgfedcba")]
    [DataRow("bko%k&xv(b)ginriv)dz&u(!(havng", "gnv(a!hu(z&dvirni)gb)v(&%xkokb")]
    [DataRow("wm@ydgqe#ipb^&@(ddddh%fmr@^mxtz%(kxbio*m#soyy$*(a*kriwh#morqlj&@*ul@()cyspx@ew)bwrg*i*drwqwt)hq$)kg$", "gk$qhtwq)wrd$)**igrwb)wex@)psyc(@lujlq*r@omhw&#*i(rkayy*osmoib$#*xk(%^ztxmr@mf%hddd(d@bpieqg&dy^#mw@")]
    public void ReverseByType_WithInputString_ReturnsStringWithReversedLetterAndSpecialCharacters(string s, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ReverseByType(s);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}