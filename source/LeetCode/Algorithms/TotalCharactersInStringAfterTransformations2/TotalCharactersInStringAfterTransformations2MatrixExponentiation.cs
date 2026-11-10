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

namespace LeetCode.Algorithms.TotalCharactersInStringAfterTransformations2;

/// <inheritdoc />
public sealed class TotalCharactersInStringAfterTransformations2MatrixExponentiation : ITotalCharactersInStringAfterTransformations2
{
    private const int Modulo = 1_000_000_007;
    private const int AlphabetLength = 'z' - 'a' + 1;
    private const int MatrixSize = AlphabetLength * AlphabetLength;

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(n + 26^3 * log t)
    ///     Space complexity - O(26^2)
    /// </remarks>
    public int LengthAfterTransformations(string input, int transformationsCount, IList<int> nums)
    {
        Span<long> frequencies = stackalloc long[AlphabetLength];
        Span<long> nextFrequencies = stackalloc long[AlphabetLength];
        Span<long> transitionMatrix = stackalloc long[MatrixSize];
        Span<long> squaredMatrix = stackalloc long[MatrixSize];

        var n = input.Length;

        for (var i = 0; i < n; i++)
        {
            var c = input[i];

            frequencies[c - 'a']++;
        }

        for (var i = 0; i < AlphabetLength; i++)
        {
            var num = nums[i];
            var rowOffset = i * AlphabetLength;

            for (var offset = 1; offset <= num; offset++)
            {
                var nextIndex = (i + offset) % AlphabetLength;

                transitionMatrix[rowOffset + nextIndex] = 1;
            }
        }

        for (var remainingTransformations = transformationsCount;
             remainingTransformations > 0;
             remainingTransformations /= 2)
        {
            if (remainingTransformations % 2 == 1)
            {
                MultiplyVectorByMatrix(frequencies, transitionMatrix, nextFrequencies);

                var previousFrequencies = frequencies;
                frequencies = nextFrequencies;
                nextFrequencies = previousFrequencies;
            }

            if (remainingTransformations == 1)
            {
                continue;
            }

            MultiplyMatrices(transitionMatrix, transitionMatrix, squaredMatrix);

            var previousMatrix = transitionMatrix;
            transitionMatrix = squaredMatrix;
            squaredMatrix = previousMatrix;
        }

        long result = 0;

        for (var i = 0; i < AlphabetLength; i++)
        {
            var frequency = frequencies[i];

            result = (result + frequency) % Modulo;
        }

        return (int)result;
    }

    /// <summary>
    ///     Multiplies a row vector of letter frequencies by a flattened 26 x 26 matrix modulo 10^9 + 7.
    /// </summary>
    /// <param name="vector">The row vector of 26 letter frequencies.</param>
    /// <param name="matrix">The flattened 26 x 26 matrix, stored row by row.</param>
    /// <param name="destination">The span that receives the resulting row vector.</param>
    /// <remarks>
    ///     Time complexity - O(26^2)
    ///     Space complexity - O(1)
    /// </remarks>
    private static void MultiplyVectorByMatrix(ReadOnlySpan<long> vector, ReadOnlySpan<long> matrix, Span<long> destination)
    {
        destination.Clear();

        for (var i = 0; i < AlphabetLength; i++)
        {
            var value = vector[i];
            var rowOffset = i * AlphabetLength;

            for (var j = 0; j < AlphabetLength; j++)
            {
                var matrixValue = matrix[rowOffset + j];

                destination[j] = (destination[j] + (value * matrixValue)) % Modulo;
            }
        }
    }

    /// <summary>
    ///     Multiplies two flattened 26 x 26 matrices modulo 10^9 + 7.
    /// </summary>
    /// <param name="left">The flattened left matrix operand, stored row by row.</param>
    /// <param name="right">The flattened right matrix operand, stored row by row.</param>
    /// <param name="destination">The span that receives the flattened product, which must not overlap the operands.</param>
    /// <remarks>
    ///     Time complexity - O(26^3)
    ///     Space complexity - O(1)
    /// </remarks>
    private static void MultiplyMatrices(ReadOnlySpan<long> left, ReadOnlySpan<long> right, Span<long> destination)
    {
        destination.Clear();

        for (var i = 0; i < AlphabetLength; i++)
        {
            var leftRowOffset = i * AlphabetLength;

            for (var k = 0; k < AlphabetLength; k++)
            {
                var leftValue = left[leftRowOffset + k];
                var rightRowOffset = k * AlphabetLength;

                for (var j = 0; j < AlphabetLength; j++)
                {
                    var rightValue = right[rightRowOffset + j];

                    destination[leftRowOffset + j] = (destination[leftRowOffset + j] + (leftValue * rightValue)) % Modulo;
                }
            }
        }
    }
}