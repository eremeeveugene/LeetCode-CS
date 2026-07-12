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
    public void DesignFoodRatingSystem_WithMixedOperations_ProcessesOperationsAccordingToSpecification(FoodRatingSystemScenario scenario)
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
                [new HighestRatedOperation("fruit")],
                [new HighestRatedOperation.Result("apple")])
        ];

        yield return
        [
            new FoodRatingSystemScenario(
                ["pizza"],
                ["italian"],
                [10],
                [new HighestRatedOperation("italian"), new ChangeRatingOperation("pizza", 1), new HighestRatedOperation("italian")],
                [new HighestRatedOperation.Result("pizza"), VoidOperationResult.Instance, new HighestRatedOperation.Result("pizza")])
        ];

        yield return
        [
            new FoodRatingSystemScenario(
                ["a", "b", "c"],
                ["x", "x", "x"],
                [10, 8, 6],
                [new HighestRatedOperation("x"), new ChangeRatingOperation("a", 3), new HighestRatedOperation("x")],
                [new HighestRatedOperation.Result("a"), VoidOperationResult.Instance, new HighestRatedOperation.Result("b")])
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

        // Single food item
        yield return
        [
            new FoodRatingSystemScenario(
                ["burger"],
                ["american"],
                [10],
                [new HighestRatedOperation("american")],
                [new HighestRatedOperation.Result("burger")])
        ];

        // Change rating then check
        yield return
        [
            new FoodRatingSystemScenario(
                ["x", "y"],
                ["c1", "c1"],
                [5, 10],
                [new HighestRatedOperation("c1"), new ChangeRatingOperation("y", 1), new HighestRatedOperation("c1")],
                [new HighestRatedOperation.Result("y"), VoidOperationResult.Instance, new HighestRatedOperation.Result("x")])
        ];

        // Three foods same cuisine, all same rating - lexicographic winner
        yield return
        [
            new FoodRatingSystemScenario(
                ["cherry", "apple", "banana"],
                ["fruit", "fruit", "fruit"],
                [5, 5, 5],
                [new HighestRatedOperation("fruit")],
                [new HighestRatedOperation.Result("apple")])
        ];

        // Multiple changes to same food
        yield return
        [
            new FoodRatingSystemScenario(
                ["noodle"],
                ["asian"],
                [3],
                [new ChangeRatingOperation("noodle", 100), new HighestRatedOperation("asian")],
                [VoidOperationResult.Instance, new HighestRatedOperation.Result("noodle")])
        ];

        // Two foods, one cuisine, multiple changes
        yield return
        [
            new FoodRatingSystemScenario(
                ["pad thai", "pho"],
                ["asian", "asian"],
                [8, 6],
                [
                    new HighestRatedOperation("asian"),
                    new ChangeRatingOperation("pho", 20),
                    new HighestRatedOperation("asian"),
                    new ChangeRatingOperation("pad thai", 25),
                    new HighestRatedOperation("asian")
                ],
                [
                    new HighestRatedOperation.Result("pad thai"),
                    VoidOperationResult.Instance,
                    new HighestRatedOperation.Result("pho"),
                    VoidOperationResult.Instance,
                    new HighestRatedOperation.Result("pad thai")
                ])
        ];

        // Foods with same rating after change - lexicographic order
        yield return
        [
            new FoodRatingSystemScenario(
                ["zebra roll", "avocado toast"],
                ["fusion", "fusion"],
                [10, 8],
                [new ChangeRatingOperation("avocado toast", 10), new HighestRatedOperation("fusion")],
                [VoidOperationResult.Instance, new HighestRatedOperation.Result("avocado toast")])
        ];

        // Different cuisines no interference
        yield return
        [
            new FoodRatingSystemScenario(
                ["croissant", "baguette", "ramen"],
                ["french", "french", "japanese"],
                [9, 7, 15],
                [
                    new HighestRatedOperation("french"),
                    new HighestRatedOperation("japanese"),
                    new ChangeRatingOperation("baguette", 20),
                    new HighestRatedOperation("french")
                ],
                [
                    new HighestRatedOperation.Result("croissant"),
                    new HighestRatedOperation.Result("ramen"),
                    VoidOperationResult.Instance,
                    new HighestRatedOperation.Result("baguette")
                ])
        ];

        // Rating goes down to zero - still highest in cuisine
        yield return
        [
            new FoodRatingSystemScenario(
                ["a", "b"],
                ["cat", "cat"],
                [100, 50],
                [new ChangeRatingOperation("a", 1), new HighestRatedOperation("cat")],
                [VoidOperationResult.Instance, new HighestRatedOperation.Result("b")])
        ];

        // Multiple foods single cuisine check order stability
        yield return
        [
            new FoodRatingSystemScenario(
                ["m", "n", "o", "p"],
                ["q", "q", "q", "q"],
                [1, 2, 3, 4],
                [new HighestRatedOperation("q"), new ChangeRatingOperation("p", 0), new HighestRatedOperation("q")],
                [new HighestRatedOperation.Result("p"), VoidOperationResult.Instance, new HighestRatedOperation.Result("o")])
        ];

        // Decrease highest-rated food rating below second highest
        yield return
        [
            new FoodRatingSystemScenario(
                ["taco", "burrito"],
                ["mex", "mex"],
                [10, 5],
                [new ChangeRatingOperation("taco", 3), new HighestRatedOperation("mex")],
                [VoidOperationResult.Instance, new HighestRatedOperation.Result("burrito")])
        ];

        // Many changes across cuisines
        yield return
        [
            new FoodRatingSystemScenario(
                ["steak", "salad", "soup"],
                ["american", "salad_bar", "soup_kitchen"],
                [7, 6, 5],
                [
                    new ChangeRatingOperation("steak", 1),
                    new ChangeRatingOperation("salad", 1),
                    new ChangeRatingOperation("soup", 1),
                    new HighestRatedOperation("american"),
                    new HighestRatedOperation("salad_bar"),
                    new HighestRatedOperation("soup_kitchen")
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new HighestRatedOperation.Result("steak"),
                    new HighestRatedOperation.Result("salad"),
                    new HighestRatedOperation.Result("soup")
                ])
        ];

        // Same food rated multiple times
        yield return
        [
            new FoodRatingSystemScenario(
                ["pizza", "pasta"],
                ["italian", "italian"],
                [10, 8],
                [
                    new ChangeRatingOperation("pizza", 5),
                    new HighestRatedOperation("italian"),
                    new ChangeRatingOperation("pizza", 15),
                    new HighestRatedOperation("italian")
                ],
                [
                    VoidOperationResult.Instance,
                    new HighestRatedOperation.Result("pasta"),
                    VoidOperationResult.Instance,
                    new HighestRatedOperation.Result("pizza")
                ])
        ];

        // All foods in one cuisine, select highest changes frequently
        yield return
        [
            new FoodRatingSystemScenario(
                ["aa", "bb", "cc", "dd"],
                ["x", "x", "x", "x"],
                [4, 3, 2, 1],
                [
                    new HighestRatedOperation("x"),
                    new ChangeRatingOperation("dd", 10),
                    new HighestRatedOperation("x"),
                    new ChangeRatingOperation("aa", 0),
                    new HighestRatedOperation("x")
                ],
                [
                    new HighestRatedOperation.Result("aa"),
                    VoidOperationResult.Instance,
                    new HighestRatedOperation.Result("dd"),
                    VoidOperationResult.Instance,
                    new HighestRatedOperation.Result("dd")
                ])
        ];

        // Tie breaking with identical names after rating changes
        yield return
        [
            new FoodRatingSystemScenario(
                ["alpha", "beta", "gamma"],
                ["greek", "greek", "greek"],
                [10, 9, 8],
                [
                    new ChangeRatingOperation("beta", 10),
                    new HighestRatedOperation("greek"),
                    new ChangeRatingOperation("gamma", 10),
                    new HighestRatedOperation("greek")
                ],
                [
                    VoidOperationResult.Instance,
                    new HighestRatedOperation.Result("alpha"),
                    VoidOperationResult.Instance,
                    new HighestRatedOperation.Result("alpha")
                ])
        ];

        // Sequential changes lead to single winner
        yield return
        [
            new FoodRatingSystemScenario(
                ["spring roll", "dim sum"],
                ["chinese", "chinese"],
                [5, 5],
                [
                    new ChangeRatingOperation("dim sum", 6),
                    new HighestRatedOperation("chinese"),
                    new ChangeRatingOperation("spring roll", 7),
                    new HighestRatedOperation("chinese")
                ],
                [
                    VoidOperationResult.Instance,
                    new HighestRatedOperation.Result("dim sum"),
                    VoidOperationResult.Instance,
                    new HighestRatedOperation.Result("spring roll")
                ])
        ];
    }

    public sealed class FoodRatingSystemScenario : IScenario<IDesignFoodRatingSystem>
    {
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
            Operations = operations;
            OperationResults = operationResults;
        }

        public string[] Foods { get; }
        public string[] Cuisines { get; }
        public int[] Ratings { get; }

        public IOperation<IDesignFoodRatingSystem>[] Operations { get; }

        public IOperationResult[] OperationResults { get; }
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

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
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