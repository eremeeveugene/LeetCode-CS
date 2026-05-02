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

using LeetCode.Algorithms.DesignFoodRatingSystem;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.DesignFoodRatingSystem;

public abstract class DesignFoodRatingSystemTestsBase
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void DesignFoodRatingSystem_WithMixedOperations_ProcessesOperationsAccordingToSpecification(
        FoodRatingSystemScenario scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = GetSolution(scenario.Foods, scenario.Cuisines, scenario.Ratings);

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

    protected abstract IDesignFoodRatingSystem GetSolution(string[] foods, string[] cuisines, int[] ratings);

    private static IEnumerable<FoodRatingSystemScenario[]> GetScenarios()
    {
        yield return
        [
            new FoodRatingSystemScenario(
                ["kimchi", "miso", "sushi", "moussaka", "ramen", "bulgogi"],
                ["korean", "japanese", "japanese", "greek", "japanese", "korean"],
                [9, 12, 8, 15, 14, 7],
                [
                    new HighestRatedOperation("korean"),
                    new HighestRatedOperation("japanese"),
                    new ChangeRatingOperation("sushi", 16),
                    new HighestRatedOperation("japanese"),
                    new ChangeRatingOperation("ramen", 16),
                    new HighestRatedOperation("japanese")
                ],
                [
                    new HighestRatedOperation.Result("kimchi"),
                    new HighestRatedOperation.Result("ramen"),
                    VoidOperationResult.Instance,
                    new HighestRatedOperation.Result("sushi"),
                    VoidOperationResult.Instance,
                    new HighestRatedOperation.Result("ramen")
                ])
        ];

        yield return
        [
            new FoodRatingSystemScenario(
                ["apple", "banana"],
                ["fruit", "fruit"],
                [5, 5],
                [
                    new HighestRatedOperation("fruit")
                ],
                [
                    new HighestRatedOperation.Result("apple")
                ])
        ];

        yield return
        [
            new FoodRatingSystemScenario(
                ["pizza"],
                ["italian"],
                [10],
                [
                    new HighestRatedOperation("italian"),
                    new ChangeRatingOperation("pizza", 1),
                    new HighestRatedOperation("italian")
                ],
                [
                    new HighestRatedOperation.Result("pizza"),
                    VoidOperationResult.Instance,
                    new HighestRatedOperation.Result("pizza")
                ])
        ];

        yield return
        [
            new FoodRatingSystemScenario(
                ["a", "b", "c"],
                ["x", "x", "x"],
                [10, 8, 6],
                [
                    new HighestRatedOperation("x"),
                    new ChangeRatingOperation("a", 3),
                    new HighestRatedOperation("x")
                ],
                [
                    new HighestRatedOperation.Result("a"),
                    VoidOperationResult.Instance,
                    new HighestRatedOperation.Result("b")
                ])
        ];

        yield return
        [
            new FoodRatingSystemScenario(
                ["tacos", "pasta", "sushi"],
                ["mexican", "italian", "japanese"],
                [7, 9, 11],
                [
                    new HighestRatedOperation("mexican"),
                    new HighestRatedOperation("italian"),
                    new HighestRatedOperation("japanese"),
                    new ChangeRatingOperation("tacos", 15),
                    new HighestRatedOperation("mexican"),
                    new HighestRatedOperation("italian")
                ],
                [
                    new HighestRatedOperation.Result("tacos"),
                    new HighestRatedOperation.Result("pasta"),
                    new HighestRatedOperation.Result("sushi"),
                    VoidOperationResult.Instance,
                    new HighestRatedOperation.Result("tacos"),
                    new HighestRatedOperation.Result("pasta")
                ])
        ];
    }

    public sealed class FoodRatingSystemScenario : IScenario<IDesignFoodRatingSystem>
    {
        private readonly Scenario<IDesignFoodRatingSystem> _scenario;

        public FoodRatingSystemScenario(
            string[] foods,
            string[] cuisines,
            int[] ratings,
            IOperation<IDesignFoodRatingSystem>[] operations,
            IOperationResult[] operationResults)
        {
            Foods = foods;
            Cuisines = cuisines;
            Ratings = ratings;
            _scenario = new Scenario<IDesignFoodRatingSystem>(operations, operationResults);
        }

        public string[] Foods { get; }
        public string[] Cuisines { get; }
        public int[] Ratings { get; }

        public IOperation<IDesignFoodRatingSystem>[] Operations => _scenario.Operations;

        public IOperationResult[] OperationResults => _scenario.OperationResults;
    }

    private sealed class HighestRatedOperation : IOperation<IDesignFoodRatingSystem>
    {
        private readonly string _cuisine;

        public HighestRatedOperation(string cuisine)
        {
            _cuisine = cuisine;
        }

        public IOperationResult Execute(IDesignFoodRatingSystem designFoodRatingSystem)
        {
            var food = designFoodRatingSystem.HighestRated(_cuisine);

            return new Result(food);
        }

        public sealed class Result : IOperationResult, IEquatable<Result>
        {
            private readonly string _food;

            public Result(string food)
            {
                _food = food;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _food == other._food;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_food);
            }
        }
    }

    private sealed class ChangeRatingOperation : IOperation<IDesignFoodRatingSystem>
    {
        private readonly string _food;
        private readonly int _newRating;

        public ChangeRatingOperation(string food, int newRating)
        {
            _food = food;
            _newRating = newRating;
        }

        public IOperationResult Execute(IDesignFoodRatingSystem designFoodRatingSystem)
        {
            designFoodRatingSystem.ChangeRating(_food, _newRating);

            return VoidOperationResult.Instance;
        }
    }
}