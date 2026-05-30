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

using LeetCode.Algorithms.DesignAnOrderedStream;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.DesignAnOrderedStream;

public abstract class DesignAnOrderedStreamTestsBase
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void DesignAnOrderedStream_WithMixedOperations_ProcessesOperationsAccordingToSpecification(
        OrderedStreamScenario scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = GetSolution(scenario.Size);

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
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    protected abstract IDesignAnOrderedStream GetSolution(int size);

    private static IEnumerable<OrderedStreamScenario[]> GetScenarios()
    {
        yield return
        [
            new OrderedStreamScenario(5,
                [
                    new InsertOperation(3, "ccccc"),
                    new InsertOperation(1, "aaaaa"),
                    new InsertOperation(2, "bbbbb"),
                    new InsertOperation(5, "eeeee"),
                    new InsertOperation(4, "ddddd")
                ],
                [
                    new InsertOperation.Result(new List<string?>()),
                    new InsertOperation.Result(new List<string?> { "aaaaa" }),
                    new InsertOperation.Result(new List<string?> { "bbbbb", "ccccc" }),
                    new InsertOperation.Result(new List<string?>()),
                    new InsertOperation.Result(new List<string?> { "ddddd", "eeeee" })
                ])
        ];

        yield return
        [
            new OrderedStreamScenario(3,
                [
                    new InsertOperation(1, "aaaaa"),
                    new InsertOperation(2, "bbbbb"),
                    new InsertOperation(3, "ccccc")
                ],
                [
                    new InsertOperation.Result(new List<string?> { "aaaaa" }),
                    new InsertOperation.Result(new List<string?> { "bbbbb" }),
                    new InsertOperation.Result(new List<string?> { "ccccc" })
                ])
        ];

        yield return
        [
            new OrderedStreamScenario(3,
                [
                    new InsertOperation(3, "ccccc"),
                    new InsertOperation(2, "bbbbb"),
                    new InsertOperation(1, "aaaaa")
                ],
                [
                    new InsertOperation.Result(new List<string?>()),
                    new InsertOperation.Result(new List<string?>()),
                    new InsertOperation.Result(new List<string?> { "aaaaa", "bbbbb", "ccccc" })
                ])
        ];

        yield return
        [
            new OrderedStreamScenario(1,
                [
                    new InsertOperation(1, "aaaaa")
                ],
                [
                    new InsertOperation.Result(new List<string?> { "aaaaa" })
                ])
        ];

        yield return
        [
            new OrderedStreamScenario(2,
                [
                    new InsertOperation(2, "bbbbb"),
                    new InsertOperation(1, "aaaaa")
                ],
                [
                    new InsertOperation.Result(new List<string?>()),
                    new InsertOperation.Result(new List<string?> { "aaaaa", "bbbbb" })
                ])
        ];

        yield return
        [
            new OrderedStreamScenario(4,
                [
                    new InsertOperation(2, "bbbbb"),
                    new InsertOperation(1, "aaaaa"),
                    new InsertOperation(4, "ddddd"),
                    new InsertOperation(3, "ccccc")
                ],
                [
                    new InsertOperation.Result(new List<string?>()),
                    new InsertOperation.Result(new List<string?> { "aaaaa", "bbbbb" }),
                    new InsertOperation.Result(new List<string?>()),
                    new InsertOperation.Result(new List<string?> { "ccccc", "ddddd" })
                ])
        ];
    }

    public sealed class OrderedStreamScenario : IScenario<IDesignAnOrderedStream>
    {
        public OrderedStreamScenario(
            int size,
            IOperation<IDesignAnOrderedStream>[] operations,
            IOperationResult[] operationResults)
        {
            Size = size;
            Operations = operations;
            OperationResults = operationResults;
        }

        public int Size { get; }

        public IOperation<IDesignAnOrderedStream>[] Operations { get; }

        public IOperationResult[] OperationResults { get; }
    }

    private sealed class InsertOperation : IOperation<IDesignAnOrderedStream>
    {
        private readonly int _idKey;
        private readonly string _value;

        public InsertOperation(int idKey, string value)
        {
            _idKey = idKey;
            _value = value;
        }

        public IOperationResult Execute(IDesignAnOrderedStream designAnOrderedStream)
        {
            var chunk = designAnOrderedStream.Insert(_idKey, _value);

            return new Result(chunk);
        }

        public sealed class Result : IOperationResult, IEquatable<Result>
        {
            private readonly IList<string?> _chunk;

            public Result(IList<string?> chunk)
            {
                _chunk = chunk;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _chunk.SequenceEqual(other._chunk);
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                var hashCode = new HashCode();

                foreach (var value in _chunk)
                {
                    hashCode.Add(value);
                }

                return hashCode.ToHashCode();
            }
        }
    }
}