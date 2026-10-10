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

using LeetCode.Algorithms.ImplementTrie;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.ImplementTrie;

public abstract class ImplementTrieTestsBase<T> where T : IImplementTrie, new()
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void ImplementTrie_WithMixedOperations_ProcessesOperationsAccordingToSpecification(IScenario<IImplementTrie> scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = new T();

        // Act
        var operations = scenario.Operations;
        var operationsLength = operations.Length;

        var actualResult = new IOperationResult[operationsLength];

        for (var i = 0; i < operationsLength; i++)
        {
            var operation = operations[i];

            actualResult[i] = operation.Execute(solution);
        }

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<IScenario<IImplementTrie>[]> GetScenarios()
    {
        yield return
        [
            new Scenario<IImplementTrie>(
                [
                    new InsertOperation("apple"),
                    new SearchOperation("apple"),
                    new SearchOperation("app"),
                    new StartsWithOperation("app"),
                    new InsertOperation("app"),
                    new SearchOperation("app")
                ],
                [
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(false),
                    new StartsWithOperation.Result(true),
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IImplementTrie>(
                [new SearchOperation("a"), new StartsWithOperation("a")],
                [new SearchOperation.Result(false), new StartsWithOperation.Result(false)])
        ];

        yield return
        [
            new Scenario<IImplementTrie>(
                [
                    new InsertOperation("a"),
                    new SearchOperation("a"),
                    new StartsWithOperation("a"),
                    new SearchOperation("b"),
                    new StartsWithOperation("b")
                ],
                [
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true),
                    new StartsWithOperation.Result(true),
                    new SearchOperation.Result(false),
                    new StartsWithOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IImplementTrie>(
                [
                    new InsertOperation("abc"),
                    new SearchOperation("ab"),
                    new StartsWithOperation("ab"),
                    new SearchOperation("abcd"),
                    new StartsWithOperation("abcd"),
                    new InsertOperation("ab"),
                    new SearchOperation("ab")
                ],
                [
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(false),
                    new StartsWithOperation.Result(true),
                    new SearchOperation.Result(false),
                    new StartsWithOperation.Result(false),
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IImplementTrie>(
                [
                    new InsertOperation("b"),
                    new SearchOperation("aa"),
                    new StartsWithOperation("a"),
                    new InsertOperation("aaa"),
                    new InsertOperation("aaa")
                ],
                [
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(false),
                    new StartsWithOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IImplementTrie>(
                [
                    new StartsWithOperation("a"),
                    new InsertOperation("ab"),
                    new SearchOperation("ab"),
                    new StartsWithOperation("ab"),
                    new InsertOperation("b"),
                    new SearchOperation("aab")
                ],
                [
                    new StartsWithOperation.Result(false),
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true),
                    new StartsWithOperation.Result(true),
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IImplementTrie>(
                [
                    new InsertOperation("c"),
                    new StartsWithOperation("c"),
                    new StartsWithOperation("c"),
                    new StartsWithOperation("c"),
                    new InsertOperation("c"),
                    new StartsWithOperation("c"),
                    new InsertOperation("c"),
                    new InsertOperation("cbb")
                ],
                [
                    VoidOperationResult.Instance,
                    new StartsWithOperation.Result(true),
                    new StartsWithOperation.Result(true),
                    new StartsWithOperation.Result(true),
                    VoidOperationResult.Instance,
                    new StartsWithOperation.Result(true),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IImplementTrie>(
                [
                    new StartsWithOperation("a"),
                    new InsertOperation("a"),
                    new SearchOperation("a"),
                    new StartsWithOperation("a"),
                    new StartsWithOperation("bb"),
                    new StartsWithOperation("a"),
                    new StartsWithOperation("a"),
                    new SearchOperation("a")
                ],
                [
                    new StartsWithOperation.Result(false),
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true),
                    new StartsWithOperation.Result(true),
                    new StartsWithOperation.Result(false),
                    new StartsWithOperation.Result(true),
                    new StartsWithOperation.Result(true),
                    new SearchOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IImplementTrie>(
                [
                    new SearchOperation("ccb"),
                    new StartsWithOperation("ac"),
                    new SearchOperation("baab"),
                    new SearchOperation("cccac"),
                    new StartsWithOperation("cab"),
                    new InsertOperation("baacc"),
                    new InsertOperation("baacc"),
                    new SearchOperation("baa"),
                    new SearchOperation("c"),
                    new InsertOperation("bac")
                ],
                [
                    new SearchOperation.Result(false),
                    new StartsWithOperation.Result(false),
                    new SearchOperation.Result(false),
                    new SearchOperation.Result(false),
                    new StartsWithOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(false),
                    new SearchOperation.Result(false),
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IImplementTrie>(
                [
                    new StartsWithOperation("xyy"),
                    new SearchOperation("zyz"),
                    new StartsWithOperation("yyx"),
                    new InsertOperation("x"),
                    new InsertOperation("x"),
                    new InsertOperation("zxxx"),
                    new InsertOperation("zxxx"),
                    new InsertOperation("zxxx"),
                    new StartsWithOperation("zzz"),
                    new InsertOperation("x")
                ],
                [
                    new StartsWithOperation.Result(false),
                    new SearchOperation.Result(false),
                    new StartsWithOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new StartsWithOperation.Result(false),
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IImplementTrie>(
                [
                    new InsertOperation("a"),
                    new InsertOperation("a"),
                    new InsertOperation("ababb"),
                    new SearchOperation("a"),
                    new InsertOperation("b"),
                    new SearchOperation("ab"),
                    new SearchOperation("b"),
                    new InsertOperation("a"),
                    new SearchOperation("a"),
                    new StartsWithOperation("b"),
                    new InsertOperation("aabaa"),
                    new SearchOperation("b")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true),
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(false),
                    new SearchOperation.Result(true),
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true),
                    new StartsWithOperation.Result(true),
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IImplementTrie>(
                [
                    new InsertOperation("aa"),
                    new StartsWithOperation("aa"),
                    new StartsWithOperation("bbc"),
                    new StartsWithOperation("a"),
                    new SearchOperation("a"),
                    new StartsWithOperation("aa"),
                    new InsertOperation("bcac"),
                    new SearchOperation("cdcb"),
                    new InsertOperation("ddbd"),
                    new StartsWithOperation("aa"),
                    new InsertOperation("dadb"),
                    new SearchOperation("aa")
                ],
                [
                    VoidOperationResult.Instance,
                    new StartsWithOperation.Result(true),
                    new StartsWithOperation.Result(false),
                    new StartsWithOperation.Result(true),
                    new SearchOperation.Result(false),
                    new StartsWithOperation.Result(true),
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(false),
                    VoidOperationResult.Instance,
                    new StartsWithOperation.Result(true),
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IImplementTrie>(
                [
                    new SearchOperation("bac"),
                    new SearchOperation("b"),
                    new StartsWithOperation("acc"),
                    new InsertOperation("caba"),
                    new SearchOperation("cc"),
                    new SearchOperation("caba"),
                    new SearchOperation("cab"),
                    new SearchOperation("bbbbb"),
                    new InsertOperation("aaabc"),
                    new StartsWithOperation("aa"),
                    new SearchOperation("aaa"),
                    new StartsWithOperation("aaa"),
                    new InsertOperation("c"),
                    new StartsWithOperation("bb"),
                    new InsertOperation("c")
                ],
                [
                    new SearchOperation.Result(false),
                    new SearchOperation.Result(false),
                    new StartsWithOperation.Result(false),
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(false),
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(false),
                    new SearchOperation.Result(false),
                    VoidOperationResult.Instance,
                    new StartsWithOperation.Result(true),
                    new SearchOperation.Result(false),
                    new StartsWithOperation.Result(true),
                    VoidOperationResult.Instance,
                    new StartsWithOperation.Result(false),
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IImplementTrie>(
                [
                    new InsertOperation("a"),
                    new SearchOperation("a"),
                    new InsertOperation("aza"),
                    new StartsWithOperation("a"),
                    new InsertOperation("a"),
                    new InsertOperation("az"),
                    new StartsWithOperation("az"),
                    new SearchOperation("aza"),
                    new StartsWithOperation("azaa"),
                    new InsertOperation("az"),
                    new StartsWithOperation("za"),
                    new SearchOperation("a"),
                    new StartsWithOperation("zaz"),
                    new SearchOperation("aza"),
                    new StartsWithOperation("zzaz")
                ],
                [
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true),
                    VoidOperationResult.Instance,
                    new StartsWithOperation.Result(true),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new StartsWithOperation.Result(true),
                    new SearchOperation.Result(true),
                    new StartsWithOperation.Result(false),
                    VoidOperationResult.Instance,
                    new StartsWithOperation.Result(false),
                    new SearchOperation.Result(true),
                    new StartsWithOperation.Result(false),
                    new SearchOperation.Result(true),
                    new StartsWithOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IImplementTrie>(
                [
                    new StartsWithOperation("ccbc"),
                    new SearchOperation("bcaac"),
                    new InsertOperation("b"),
                    new StartsWithOperation("b"),
                    new StartsWithOperation("b"),
                    new StartsWithOperation("b"),
                    new StartsWithOperation("acb"),
                    new SearchOperation("b"),
                    new InsertOperation("b"),
                    new InsertOperation("b"),
                    new StartsWithOperation("b"),
                    new SearchOperation("b"),
                    new SearchOperation("b"),
                    new SearchOperation("ba"),
                    new StartsWithOperation("ccbaa"),
                    new StartsWithOperation("b"),
                    new StartsWithOperation("b"),
                    new InsertOperation("abac"),
                    new StartsWithOperation("ccba"),
                    new InsertOperation("bab")
                ],
                [
                    new StartsWithOperation.Result(false),
                    new SearchOperation.Result(false),
                    VoidOperationResult.Instance,
                    new StartsWithOperation.Result(true),
                    new StartsWithOperation.Result(true),
                    new StartsWithOperation.Result(true),
                    new StartsWithOperation.Result(false),
                    new SearchOperation.Result(true),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new StartsWithOperation.Result(true),
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(false),
                    new StartsWithOperation.Result(false),
                    new StartsWithOperation.Result(true),
                    new StartsWithOperation.Result(true),
                    VoidOperationResult.Instance,
                    new StartsWithOperation.Result(false),
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IImplementTrie>(
                [
                    new StartsWithOperation("ababbb"),
                    new StartsWithOperation("dbdbcb"),
                    new InsertOperation("ebea"),
                    new InsertOperation("ebea"),
                    new InsertOperation("deab"),
                    new SearchOperation("ebea"),
                    new InsertOperation("ebea"),
                    new InsertOperation("eddaa"),
                    new SearchOperation("d"),
                    new InsertOperation("deab"),
                    new StartsWithOperation("abb"),
                    new SearchOperation("e"),
                    new InsertOperation("deab"),
                    new InsertOperation("eb"),
                    new SearchOperation("de"),
                    new SearchOperation("ada"),
                    new StartsWithOperation("d"),
                    new InsertOperation("eb"),
                    new StartsWithOperation("d"),
                    new InsertOperation("cabc")
                ],
                [
                    new StartsWithOperation.Result(false),
                    new StartsWithOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(false),
                    VoidOperationResult.Instance,
                    new StartsWithOperation.Result(false),
                    new SearchOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(false),
                    new SearchOperation.Result(false),
                    new StartsWithOperation.Result(true),
                    VoidOperationResult.Instance,
                    new StartsWithOperation.Result(true),
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new Scenario<IImplementTrie>(
                [
                    new SearchOperation("abbbba"),
                    new InsertOperation("a"),
                    new InsertOperation("a"),
                    new InsertOperation("baaab"),
                    new SearchOperation("a"),
                    new StartsWithOperation("a"),
                    new InsertOperation("baaab"),
                    new InsertOperation("aabbba"),
                    new SearchOperation("a"),
                    new StartsWithOperation("ba"),
                    new SearchOperation("aabbba"),
                    new InsertOperation("bbab"),
                    new SearchOperation("b"),
                    new InsertOperation("baaab"),
                    new InsertOperation("a"),
                    new StartsWithOperation("aa"),
                    new InsertOperation("ba"),
                    new InsertOperation("bba"),
                    new SearchOperation("ab"),
                    new SearchOperation("bab"),
                    new InsertOperation("aaab"),
                    new InsertOperation("aaa"),
                    new SearchOperation("bba"),
                    new StartsWithOperation("bba"),
                    new SearchOperation("a")
                ],
                [
                    new SearchOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true),
                    new StartsWithOperation.Result(true),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true),
                    new StartsWithOperation.Result(true),
                    new SearchOperation.Result(true),
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new StartsWithOperation.Result(true),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(false),
                    new SearchOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true),
                    new StartsWithOperation.Result(true),
                    new SearchOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IImplementTrie>(
                [
                    new InsertOperation("a"),
                    new SearchOperation("a"),
                    new SearchOperation("a"),
                    new SearchOperation("bbabacc"),
                    new SearchOperation("a"),
                    new SearchOperation("bbbcbb"),
                    new SearchOperation("a"),
                    new StartsWithOperation("a"),
                    new InsertOperation("a"),
                    new StartsWithOperation("bcab"),
                    new StartsWithOperation("a"),
                    new SearchOperation("a"),
                    new SearchOperation("ccabb"),
                    new InsertOperation("c"),
                    new InsertOperation("bb"),
                    new InsertOperation("a"),
                    new SearchOperation("caacc"),
                    new SearchOperation("a"),
                    new StartsWithOperation("a"),
                    new StartsWithOperation("bb"),
                    new InsertOperation("c"),
                    new InsertOperation("babab"),
                    new InsertOperation("aa"),
                    new InsertOperation("bb"),
                    new SearchOperation("b"),
                    new SearchOperation("babab"),
                    new SearchOperation("acabb"),
                    new SearchOperation("a"),
                    new SearchOperation("cbca"),
                    new StartsWithOperation("ccabbb")
                ],
                [
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(false),
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(false),
                    new SearchOperation.Result(true),
                    new StartsWithOperation.Result(true),
                    VoidOperationResult.Instance,
                    new StartsWithOperation.Result(false),
                    new StartsWithOperation.Result(true),
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(false),
                    new SearchOperation.Result(true),
                    new StartsWithOperation.Result(true),
                    new StartsWithOperation.Result(true),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(false),
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(false),
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(false),
                    new StartsWithOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IImplementTrie>(
                [
                    new StartsWithOperation("akxgz"),
                    new InsertOperation("xrugdg"),
                    new InsertOperation("xr"),
                    new InsertOperation("kql"),
                    new SearchOperation("a"),
                    new SearchOperation("xr"),
                    new SearchOperation("xrugdg"),
                    new StartsWithOperation("kql"),
                    new StartsWithOperation("xrugdg"),
                    new SearchOperation("x"),
                    new InsertOperation("x"),
                    new SearchOperation("kq"),
                    new InsertOperation("e"),
                    new InsertOperation("x"),
                    new InsertOperation("fvty"),
                    new SearchOperation("i"),
                    new InsertOperation("x"),
                    new SearchOperation("kpb"),
                    new InsertOperation("xnpkuan"),
                    new SearchOperation("e"),
                    new InsertOperation("xr"),
                    new InsertOperation("x"),
                    new SearchOperation("x"),
                    new StartsWithOperation("ylcgzle"),
                    new StartsWithOperation("pvch"),
                    new SearchOperation("xnpkuan"),
                    new InsertOperation("kql"),
                    new StartsWithOperation("x"),
                    new StartsWithOperation("x"),
                    new SearchOperation("ohu"),
                    new InsertOperation("f"),
                    new InsertOperation("xr"),
                    new StartsWithOperation("kr"),
                    new InsertOperation("swdwpxn"),
                    new InsertOperation("ax"),
                    new InsertOperation("hnktq"),
                    new InsertOperation("iv"),
                    new InsertOperation("swdwpxn"),
                    new SearchOperation("fvty"),
                    new StartsWithOperation("ax")
                ],
                [
                    new StartsWithOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(false),
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(true),
                    new StartsWithOperation.Result(true),
                    new StartsWithOperation.Result(true),
                    new SearchOperation.Result(false),
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(false),
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(false),
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true),
                    new StartsWithOperation.Result(false),
                    new StartsWithOperation.Result(false),
                    new SearchOperation.Result(true),
                    VoidOperationResult.Instance,
                    new StartsWithOperation.Result(true),
                    new StartsWithOperation.Result(true),
                    new SearchOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new StartsWithOperation.Result(false),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true),
                    new StartsWithOperation.Result(true)
                ])
        ];

        yield return
        [
            new Scenario<IImplementTrie>(
                [
                    new InsertOperation(new string('z', 2000)),
                    new SearchOperation(new string('z', 2000)),
                    new SearchOperation(new string('z', 1999)),
                    new StartsWithOperation(new string('z', 1999)),
                    new StartsWithOperation(new string('z', 2000)),
                    new StartsWithOperation("za")
                ],
                [
                    VoidOperationResult.Instance,
                    new SearchOperation.Result(true),
                    new SearchOperation.Result(false),
                    new StartsWithOperation.Result(true),
                    new StartsWithOperation.Result(true),
                    new StartsWithOperation.Result(false)
                ])
        ];
    }

    private sealed class InsertOperation : IOperation<IImplementTrie>
    {
        private readonly string _word;

        public InsertOperation(string word)
        {
            _word = word;
        }

        public IOperationResult Execute(IImplementTrie implementTrie)
        {
            implementTrie.Insert(_word);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class SearchOperation : IOperation<IImplementTrie>
    {
        private readonly string _word;

        public SearchOperation(string word)
        {
            _word = word;
        }

        public IOperationResult Execute(IImplementTrie implementTrie)
        {
            var found = implementTrie.Search(_word);

            return new Result(found);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly bool _found;

            public Result(bool found)
            {
                _found = found;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _found == other._found;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_found);
            }
        }
    }

    private sealed class StartsWithOperation : IOperation<IImplementTrie>
    {
        private readonly string _prefix;

        public StartsWithOperation(string prefix)
        {
            _prefix = prefix;
        }

        public IOperationResult Execute(IImplementTrie implementTrie)
        {
            var found = implementTrie.StartsWith(_prefix);

            return new Result(found);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly bool _found;

            public Result(bool found)
            {
                _found = found;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _found == other._found;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_found);
            }
        }
    }
}