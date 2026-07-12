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

namespace LeetCode.Algorithms.TwentyFourGame;

/// <inheritdoc />
public sealed class TwentyFourGameBruteForce : ITwentyFourGame
{
    private const double TargetValue = 24.0;
    private const double Tolerance = 1e-6;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(1)
    ///     Space complexity - O(1)
    /// </remarks>
    public bool JudgePoint24(int[] cards)
    {
        Array.Sort(cards);

        Span<bool> isCardUsed = stackalloc bool[4];
        Span<int> cardPermutation = stackalloc int[4];

        return TryBuildPermutation(0, cards, isCardUsed, cardPermutation);
    }

    private static bool TryBuildPermutation(int depth, ReadOnlySpan<int> cards, Span<bool> isCardUsed, Span<int> cardPermutation)
    {
        if (depth == 4)
        {
            return TryEvaluateAllExpressions(cardPermutation[0], cardPermutation[1], cardPermutation[2], cardPermutation[3]);
        }

        var previousCard = -1;

        for (var i = 0; i < 4; i++)
        {
            if (isCardUsed[i])
            {
                continue;
            }

            if (cards[i] == previousCard)
            {
                continue;
            }

            isCardUsed[i] = true;
            cardPermutation[depth] = cards[i];

            if (TryBuildPermutation(depth + 1, cards, isCardUsed, cardPermutation))
            {
                return true;
            }

            isCardUsed[i] = false;
            previousCard = cards[i];
        }

        return false;
    }

    private static bool TryEvaluateAllExpressions(double a, double b, double c, double d)
    {
        foreach (var firstOperator in Enum.GetValues<Operation>())
        {
            foreach (var secondOperator in Enum.GetValues<Operation>())
            {
                foreach (var thirdOperator in Enum.GetValues<Operation>())
                {
                    if (TryEvaluateAllExpressionTrees(a, b, c, d, firstOperator, secondOperator, thirdOperator))
                    {
                        return true;
                    }
                }
            }
        }

        return false;
    }

    private static bool TryEvaluateAllExpressionTrees(
        double a,
        double b,
        double c,
        double d,
        Operation firstOperator,
        Operation secondOperator,
        Operation thirdOperator)
    {
        return EvaluatesToTarget(a, b, c, d, firstOperator, secondOperator, thirdOperator) ||
               EvaluatesToTargetInnerFirst(a, b, c, d, firstOperator, secondOperator, thirdOperator) ||
               EvaluatesToTargetInnerPairFirst(a, b, c, d, firstOperator, secondOperator, thirdOperator) ||
               EvaluatesToTargetRightToLeft(a, b, c, d, firstOperator, secondOperator, thirdOperator) ||
               EvaluatesToTargetPairs(a, b, c, d, firstOperator, secondOperator, thirdOperator);
    }

    private static bool EvaluatesToTarget(
        double a,
        double b,
        double c,
        double d,
        Operation firstOperator,
        Operation secondOperator,
        Operation thirdOperator)
    {
        return TryApplyOperator(a, b, firstOperator, out var t) &&
               TryApplyOperator(t, c, secondOperator, out var u) &&
               TryApplyOperator(u, d, thirdOperator, out var v) &&
               IsTargetValue(v);
    }

    private static bool EvaluatesToTargetInnerFirst(
        double a,
        double b,
        double c,
        double d,
        Operation firstOperator,
        Operation secondOperator,
        Operation thirdOperator)
    {
        return TryApplyOperator(b, c, secondOperator, out var t) &&
               TryApplyOperator(a, t, firstOperator, out var u) &&
               TryApplyOperator(u, d, thirdOperator, out var v) &&
               IsTargetValue(v);
    }

    private static bool EvaluatesToTargetInnerPairFirst(
        double a,
        double b,
        double c,
        double d,
        Operation firstOperator,
        Operation secondOperator,
        Operation thirdOperator)
    {
        return TryApplyOperator(b, c, secondOperator, out var t) &&
               TryApplyOperator(t, d, thirdOperator, out var u) &&
               TryApplyOperator(a, u, firstOperator, out var v) &&
               IsTargetValue(v);
    }

    private static bool EvaluatesToTargetRightToLeft(
        double a,
        double b,
        double c,
        double d,
        Operation firstOperator,
        Operation secondOperator,
        Operation thirdOperator)
    {
        return TryApplyOperator(c, d, thirdOperator, out var t) &&
               TryApplyOperator(b, t, secondOperator, out var u) &&
               TryApplyOperator(a, u, firstOperator, out var v) &&
               IsTargetValue(v);
    }

    private static bool EvaluatesToTargetPairs(
        double a,
        double b,
        double c,
        double d,
        Operation firstOperator,
        Operation secondOperator,
        Operation thirdOperator)
    {
        return TryApplyOperator(a, b, firstOperator, out var t) &&
               TryApplyOperator(c, d, thirdOperator, out var u) &&
               TryApplyOperator(t, u, secondOperator, out var v) &&
               IsTargetValue(v);
    }

    private static bool IsTargetValue(double value)
    {
        return Math.Abs(value - TargetValue) < Tolerance;
    }

    private static bool TryApplyOperator(double left, double right, Operation operation, out double result)
    {
        switch (operation)
        {
            case Operation.Addition:
                result = left + right;

                return true;
            case Operation.Subtraction:
                result = left - right;

                return true;
            case Operation.Multiplication:
                result = left * right;

                return true;
            case Operation.Division:
                if (Math.Abs(right) < Tolerance)
                {
                    result = 0;

                    return false;
                }

                result = left / right;

                return true;
            default:
                throw new ArgumentOutOfRangeException(nameof(operation), operation, null);
        }
    }

    private enum Operation
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }
}