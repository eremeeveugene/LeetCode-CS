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

using LeetCode.Algorithms.AccountsMerge;

namespace LeetCode.Tests.Algorithms.AccountsMerge;

public abstract class AccountsMergeTestsBase<T> where T : IAccountsMerge, new()
{
    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void AccountsMerge_WithAccounts_ReturnsMergedAccounts(IList<IList<string>> accounts, IList<IList<string>> expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.AccountsMerge(accounts);

        // Assert
        Assert.AreEquivalent(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            new IList<string>[]
            {
                new[] { "John", "johnsmith@mail.com", "john_newyork@mail.com" },
                new[] { "John", "johnsmith@mail.com", "john00@mail.com" },
                new[] { "Mary", "mary@mail.com" },
                new[] { "John", "johnnybravo@mail.com" }
            },
            new IList<string>[]
            {
                new[] { "John", "john00@mail.com", "john_newyork@mail.com", "johnsmith@mail.com" },
                new[] { "Mary", "mary@mail.com" },
                new[] { "John", "johnnybravo@mail.com" }
            }
        ];

        yield return
        [
            new IList<string>[]
            {
                new[] { "Gabe", "Gabe0@m.co", "Gabe3@m.co", "Gabe1@m.co" },
                new[] { "Kevin", "Kevin3@m.co", "Kevin5@m.co", "Kevin0@m.co" },
                new[] { "Ethan", "Ethan5@m.co", "Ethan4@m.co", "Ethan0@m.co" },
                new[] { "Hanzo", "Hanzo3@m.co", "Hanzo1@m.co", "Hanzo0@m.co" },
                new[] { "Fern", "Fern5@m.co", "Fern1@m.co", "Fern0@m.co" }
            },
            new IList<string>[]
            {
                new[] { "Gabe", "Gabe0@m.co", "Gabe1@m.co", "Gabe3@m.co" },
                new[] { "Kevin", "Kevin0@m.co", "Kevin3@m.co", "Kevin5@m.co" },
                new[] { "Ethan", "Ethan0@m.co", "Ethan4@m.co", "Ethan5@m.co" },
                new[] { "Hanzo", "Hanzo0@m.co", "Hanzo1@m.co", "Hanzo3@m.co" },
                new[] { "Fern", "Fern0@m.co", "Fern1@m.co", "Fern5@m.co" }
            }
        ];

        yield return [new IList<string>[] { new[] { "Alex", "alex@mail.com" } }, new IList<string>[] { new[] { "Alex", "alex@mail.com" } }];

        yield return
        [
            new IList<string>[] { new[] { "Alex", "c@m.com", "a@m.com", "b@m.com" } },
            new IList<string>[] { new[] { "Alex", "a@m.com", "b@m.com", "c@m.com" } }
        ];

        yield return [new IList<string>[] { new[] { "Alex", "a@m.com", "a@m.com" } }, new IList<string>[] { new[] { "Alex", "a@m.com" } }];

        yield return
        [
            new IList<string>[] { new[] { "John", "a@m.com" }, new[] { "John", "b@m.com" } },
            new IList<string>[] { new[] { "John", "a@m.com" }, new[] { "John", "b@m.com" } }
        ];

        yield return
        [
            new IList<string>[] { new[] { "John", "b@m.com", "c@m.com" }, new[] { "John", "a@m.com", "b@m.com" } },
            new IList<string>[] { new[] { "John", "a@m.com", "b@m.com", "c@m.com" } }
        ];

        yield return
        [
            new IList<string>[] { new[] { "A", "a@x.com", "b@x.com" }, new[] { "A", "c@x.com", "d@x.com" }, new[] { "A", "b@x.com", "c@x.com" } },
            new IList<string>[] { new[] { "A", "a@x.com", "b@x.com", "c@x.com", "d@x.com" } }
        ];

        yield return
        [
            new IList<string>[] { new[] { "Bob", "bob@m.com" }, new[] { "Bob", "bob@m.com" } },
            new IList<string>[] { new[] { "Bob", "bob@m.com" } }
        ];

        yield return
        [
            new IList<string>[]
            {
                new[] { "A", "a1@m.com" }, new[] { "B", "b1@m.com" }, new[] { "A", "a2@m.com" }, new[] { "A", "a1@m.com", "a2@m.com" }
            },
            new IList<string>[] { new[] { "A", "a1@m.com", "a2@m.com" }, new[] { "B", "b1@m.com" } }
        ];

        yield return
        [
            new IList<string>[] { new[] { "B", "b@m.com" }, new[] { "A", "a@m.com" }, new[] { "B", "b2@m.com", "b@m.com" } },
            new IList<string>[] { new[] { "B", "b2@m.com", "b@m.com" }, new[] { "A", "a@m.com" } }
        ];

        yield return
        [
            new IList<string>[] { new[] { "Zed", "zed@m.com", "Zed@m.com", "alpha@m.com" } },
            new IList<string>[] { new[] { "Zed", "Zed@m.com", "alpha@m.com", "zed@m.com" } }
        ];

        yield return
        [
            new IList<string>[] { new[] { "Kim", "kim.lee@m.com", "kim_lee@m.com", "kim@m.com", "kimlee@m.com" } },
            new IList<string>[] { new[] { "Kim", "kim.lee@m.com", "kim@m.com", "kim_lee@m.com", "kimlee@m.com" } }
        ];

        yield return
        [
            new IList<string>[]
            {
                new[] { "S", "s1@m.com" },
                new[] { "S", "s2@m.com" },
                new[] { "S", "s3@m.com" },
                new[] { "S", "s1@m.com", "s2@m.com", "s3@m.com" }
            },
            new IList<string>[] { new[] { "S", "s1@m.com", "s2@m.com", "s3@m.com" } }
        ];

        yield return
        [
            new IList<string>[]
            {
                new[] { "Ann", "ann@m.com" }, new[] { "Ben", "ben@m.com" }, new[] { "Cal", "cal@m.com" }, new[] { "Dan", "dan@m.com" }
            },
            new IList<string>[]
            {
                new[] { "Ann", "ann@m.com" }, new[] { "Ben", "ben@m.com" }, new[] { "Cal", "cal@m.com" }, new[] { "Dan", "dan@m.com" }
            }
        ];

        yield return
        [
            new IList<string>[]
            {
                new[] { "L", "e@m.com", "f@m.com" },
                new[] { "L", "d@m.com", "e@m.com" },
                new[] { "L", "c@m.com", "d@m.com" },
                new[] { "L", "b@m.com", "c@m.com" },
                new[] { "L", "a@m.com", "b@m.com" }
            },
            new IList<string>[] { new[] { "L", "a@m.com", "b@m.com", "c@m.com", "d@m.com", "e@m.com", "f@m.com" } }
        ];

        yield return
        [
            new IList<string>[]
            {
                new[] { "P", "p1@m.com" },
                new[] { "Q", "q1@m.com" },
                new[] { "P", "p2@m.com", "p1@m.com" },
                new[] { "Q", "q2@m.com", "q1@m.com" }
            },
            new IList<string>[] { new[] { "P", "p1@m.com", "p2@m.com" }, new[] { "Q", "q1@m.com", "q2@m.com" } }
        ];

        yield return
        [
            new IList<string>[]
            {
                new[] { "John", "j1@m.com", "j2@m.com" },
                new[] { "John", "j3@m.com" },
                new[] { "John", "j4@m.com", "j1@m.com" },
                new[] { "John", "j3@m.com", "j5@m.com" }
            },
            new IList<string>[] { new[] { "John", "j1@m.com", "j2@m.com", "j4@m.com" }, new[] { "John", "j3@m.com", "j5@m.com" } }
        ];

        yield return
        [
            new IList<string>[] { new[] { "Max", "m9@m.com", "m10@m.com", "m1@m.com", "m2@m.com" } },
            new IList<string>[] { new[] { "Max", "m10@m.com", "m1@m.com", "m2@m.com", "m9@m.com" } }
        ];

        yield return
        [
            new IList<string>[] { new[] { "T", "t1@m.com", "t2@m.com", "t3@m.com" }, new[] { "T", "t3@m.com", "t3@m.com", "t4@m.com" } },
            new IList<string>[] { new[] { "T", "t1@m.com", "t2@m.com", "t3@m.com", "t4@m.com" } }
        ];

        yield return
        [
            new IList<string>[]
            {
                new[] { "X", "x1@m.com" },
                new[] { "X", "x2@m.com" },
                new[] { "Y", "y1@m.com" },
                new[] { "X", "x3@m.com", "x2@m.com" },
                new[] { "X", "x1@m.com", "x3@m.com" }
            },
            new IList<string>[] { new[] { "X", "x1@m.com", "x2@m.com", "x3@m.com" }, new[] { "Y", "y1@m.com" } }
        ];

        yield return
        [
            new IList<string>[]
            {
                new[] { "John", "johnnybravo@mail.com" },
                new[] { "John", "johnsmith@mail.com", "john_newyork@mail.com" },
                new[] { "Mary", "mary@mail.com" },
                new[] { "John", "johnsmith@mail.com", "john00@mail.com" }
            },
            new IList<string>[]
            {
                new[] { "John", "johnnybravo@mail.com" },
                new[] { "John", "john00@mail.com", "john_newyork@mail.com", "johnsmith@mail.com" },
                new[] { "Mary", "mary@mail.com" }
            }
        ];

        var distinctAccounts = new IList<string>[1000];

        for (var i = 0; i < distinctAccounts.Length; i++)
        {
            distinctAccounts[i] = new[] { "User", $"user{i}@m.com" };
        }

        yield return [distinctAccounts, distinctAccounts];
    }
}