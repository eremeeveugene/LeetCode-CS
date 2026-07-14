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

using LeetCode.Algorithms.DesignMovieRentalSystem;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.DesignMovieRentalSystem;

public abstract class DesignMovieRentalSystemTestsBase
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void DesignMovieRentalSystem_WithMixedOperations_ProcessesOperationsAccordingToSpecification(MovieRentalSystemScenario scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = GetSolution(scenario.N, scenario.Entries);

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

    protected abstract IDesignMovieRentalSystem GetSolution(int n, int[][] entries);

    private static IEnumerable<MovieRentalSystemScenario[]> GetScenarios()
    {
        yield return
        [
            new MovieRentalSystemScenario(
                3,
                [[0, 1, 5], [0, 2, 6], [0, 3, 7], [1, 1, 4], [1, 2, 7], [2, 1, 5]],
                [
                    new SearchOperation(1),
                    new RentOperation(0, 1),
                    new RentOperation(1, 2),
                    new ReportOperation(),
                    new DropOperation(1, 2),
                    new SearchOperation(2)
                ],
                [
                    new SearchOperation.Result([1, 0, 2]),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new ReportOperation.Result([[0, 1], [1, 2]]),
                    VoidOperationResult.Instance,
                    new SearchOperation.Result([0, 1])
                ])
        ];

        yield return
        [
            new MovieRentalSystemScenario(
                2,
                [[0, 1, 10], [1, 1, 20], [2, 1, 10], [3, 1, 5], [4, 1, 15], [5, 1, 10]],
                [new SearchOperation(1)],
                [new SearchOperation.Result([3, 0, 2, 5, 4])])
        ];

        yield return
        [
            new MovieRentalSystemScenario(
                3,
                [[0, 1, 5], [0, 2, 3], [1, 1, 8], [1, 3, 2], [2, 2, 6]],
                [new RentOperation(0, 1), new RentOperation(0, 2), new RentOperation(1, 1), new RentOperation(1, 3), new ReportOperation()],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new ReportOperation.Result([[1, 3], [0, 2], [0, 1], [1, 1]])
                ])
        ];

        yield return
        [
            new MovieRentalSystemScenario(
                2,
                [[0, 1, 5], [1, 1, 3]],
                [new RentOperation(0, 1), new RentOperation(1, 1), new SearchOperation(1), new DropOperation(0, 1), new SearchOperation(1)],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new SearchOperation.Result([]),
                    VoidOperationResult.Instance,
                    new SearchOperation.Result([0])
                ])
        ];

        // Search for a movie that has no offers exercises the empty-result early return.
        yield return [new MovieRentalSystemScenario(1, [[0, 1, 5]], [new SearchOperation(99)], [new SearchOperation.Result([])])];

        // Report with no rentals exercises the empty-rentals early return.
        yield return [new MovieRentalSystemScenario(1, [[0, 1, 5]], [new ReportOperation()], [new ReportOperation.Result([])])];

        // Two rentals with identical price and shop but different movies exercise the movie tiebreaker in RentalRecord.CompareTo.
        yield return
        [
            new MovieRentalSystemScenario(
                1,
                [[0, 1, 5], [0, 2, 5]],
                [new RentOperation(0, 1), new RentOperation(0, 2), new ReportOperation()],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new ReportOperation.Result([[0, 1], [0, 2]])])
        ];
    }

    public sealed class MovieRentalSystemScenario : IScenario<IDesignMovieRentalSystem>
    {
        public MovieRentalSystemScenario(
            int n,
            int[][] entries,
            IOperation<IDesignMovieRentalSystem>[] operations,
            IOperationResult[] operationResults)
        {
            N = n;
            Entries = entries;
            Operations = operations;
            OperationResults = operationResults;
        }

        public int N { get; }
        public int[][] Entries { get; }

        public IOperation<IDesignMovieRentalSystem>[] Operations { get; }

        public IOperationResult[] OperationResults { get; }
    }

    private sealed class SearchOperation : IOperation<IDesignMovieRentalSystem>
    {
        private readonly int _movie;

        public SearchOperation(int movie)
        {
            _movie = movie;
        }

        public IOperationResult Execute(IDesignMovieRentalSystem designMovieRentalSystem)
        {
            var shops = designMovieRentalSystem.Search(_movie);

            return new Result(shops);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly IList<int> _shops;

            public Result(IList<int> shops)
            {
                _shops = shops;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _shops.SequenceEqual(other._shops);
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                var hashCode = new HashCode();

                foreach (var shop in _shops)
                {
                    hashCode.Add(shop);
                }

                return hashCode.ToHashCode();
            }
        }
    }

    private sealed class ReportOperation : IOperation<IDesignMovieRentalSystem>
    {
        public IOperationResult Execute(IDesignMovieRentalSystem designMovieRentalSystem)
        {
            var entries = designMovieRentalSystem.Report();

            return new Result(entries);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly IList<IList<int>> _entries;

            public Result(IList<IList<int>> entries)
            {
                _entries = entries;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _entries.Count == other._entries.Count &&
                       _entries.Zip(other._entries, (a, b) => a.SequenceEqual(b)).All(x => x);
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                var hashCode = new HashCode();

                foreach (var entry in _entries)
                {
                    foreach (var value in entry)
                    {
                        hashCode.Add(value);
                    }
                }

                return hashCode.ToHashCode();
            }
        }
    }

    private sealed class RentOperation : IOperation<IDesignMovieRentalSystem>
    {
        private readonly int _movie;
        private readonly int _shop;

        public RentOperation(int shop, int movie)
        {
            _shop = shop;
            _movie = movie;
        }

        public IOperationResult Execute(IDesignMovieRentalSystem designMovieRentalSystem)
        {
            designMovieRentalSystem.Rent(_shop, _movie);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class DropOperation : IOperation<IDesignMovieRentalSystem>
    {
        private readonly int _movie;
        private readonly int _shop;

        public DropOperation(int shop, int movie)
        {
            _shop = shop;
            _movie = movie;
        }

        public IOperationResult Execute(IDesignMovieRentalSystem designMovieRentalSystem)
        {
            designMovieRentalSystem.Drop(_shop, _movie);

            return VoidOperationResult.Instance;
        }
    }
}