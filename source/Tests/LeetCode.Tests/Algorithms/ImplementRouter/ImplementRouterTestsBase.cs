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

using LeetCode.Algorithms.ImplementRouter;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.ImplementRouter;

public abstract class ImplementRouterTestsBase
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void ImplementRouter_WithMixedOperations_ProcessesOperationsAccordingToSpecification(RouterScenario scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = GetSolution(scenario.MemoryLimit);

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

    protected abstract IImplementRouter GetSolution(int memoryLimit);

    private static IEnumerable<RouterScenario[]> GetScenarios()
    {
        yield return
        [
            new RouterScenario(
                3,
                [
                    new AddPacketOperation(1, 4, 90),
                    new AddPacketOperation(2, 5, 90),
                    new AddPacketOperation(1, 4, 90),
                    new AddPacketOperation(3, 5, 95),
                    new AddPacketOperation(4, 5, 105),
                    new ForwardPacketOperation(),
                    new AddPacketOperation(5, 2, 110),
                    new GetCountOperation(5, 100, 110)
                ],
                [
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(false),
                    new AddPacketOperation.Result(true),
                    new AddPacketOperation.Result(true),
                    new ForwardPacketOperation.Result([2, 5, 90]),
                    new AddPacketOperation.Result(true),
                    new GetCountOperation.Result(1)
                ])
        ];

        yield return
        [
            new RouterScenario(
                4,
                [new AddPacketOperation(4, 2, 1), new AddPacketOperation(3, 2, 1), new GetCountOperation(2, 1, 1)],
                [new AddPacketOperation.Result(true), new AddPacketOperation.Result(true), new GetCountOperation.Result(2)])
        ];

        yield return
        [
            new RouterScenario(
                5,
                [new AddPacketOperation(1, 2, 10), new AddPacketOperation(1, 2, 10), new GetCountOperation(2, 10, 10)],
                [new AddPacketOperation.Result(true), new AddPacketOperation.Result(false), new GetCountOperation.Result(1)])
        ];

        yield return
        [
            new RouterScenario(
                3,
                [new AddPacketOperation(1, 2, 10), new ForwardPacketOperation(), new ForwardPacketOperation()],
                [new AddPacketOperation.Result(true), new ForwardPacketOperation.Result([1, 2, 10]), new ForwardPacketOperation.Result([])])
        ];
    }

    public sealed class RouterScenario : IScenario<IImplementRouter>
    {
        public RouterScenario(int memoryLimit, IOperation<IImplementRouter>[] operations, IOperationResult[] operationResults)
        {
            MemoryLimit = memoryLimit;
            Operations = operations;
            OperationResults = operationResults;
        }

        public int MemoryLimit { get; }

        public IOperation<IImplementRouter>[] Operations { get; }

        public IOperationResult[] OperationResults { get; }
    }

    private sealed class AddPacketOperation : IOperation<IImplementRouter>
    {
        private readonly int _destination;
        private readonly int _source;
        private readonly int _timestamp;

        public AddPacketOperation(int source, int destination, int timestamp)
        {
            _source = source;
            _destination = destination;
            _timestamp = timestamp;
        }

        public IOperationResult Execute(IImplementRouter implementRouter)
        {
            var result = implementRouter.AddPacket(_source, _destination, _timestamp);

            return new Result(result);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly bool _added;

            public Result(bool added)
            {
                _added = added;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _added == other._added;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_added);
            }
        }
    }

    private sealed class ForwardPacketOperation : IOperation<IImplementRouter>
    {
        public IOperationResult Execute(IImplementRouter implementRouter)
        {
            var packet = implementRouter.ForwardPacket();

            return new Result(packet);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly int[] _packet;

            public Result(int[] packet)
            {
                _packet = packet;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _packet.SequenceEqual(other._packet);
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                var hashCode = new HashCode();

                foreach (var value in _packet)
                {
                    hashCode.Add(value);
                }

                return hashCode.ToHashCode();
            }
        }
    }

    private sealed class GetCountOperation : IOperation<IImplementRouter>
    {
        private readonly int _destination;
        private readonly int _endTime;
        private readonly int _startTime;

        public GetCountOperation(int destination, int startTime, int endTime)
        {
            _destination = destination;
            _startTime = startTime;
            _endTime = endTime;
        }

        public IOperationResult Execute(IImplementRouter implementRouter)
        {
            var count = implementRouter.GetCount(_destination, _startTime, _endTime);

            return new Result(count);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly int _count;

            public Result(int count)
            {
                _count = count;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _count == other._count;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_count);
            }
        }
    }
}