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