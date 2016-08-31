using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EyeTrackingMouseV03Lib.Utils
{
    /// <summary>
    /// Allows Conversion between jagged and multidimensional arrays
    /// </summary>
    public static class MultiDimensionalArrayExtensions
    {
        /// <summary>
        /// Allows the conversion of a twodimensional array of
        /// a value type into a jagged array
        /// </summary>
        /// <typeparam name="T">A value type</typeparam>
        /// <param name="rect">The twodimensional array to convert</param>
        /// <returns>T[][]</returns>
        public static T[][] AsJagged<T>(this T[,] rect) where T : struct
        {
            int row1 = rect.GetLowerBound(0);
            int rowN = rect.GetUpperBound(0);
            int col1 = rect.GetLowerBound(1);
            int colN = rect.GetUpperBound(1);

            int height = rowN - row1 + 1;
            int width = colN - col1 + 1;
            T[][] jagged = new T[height][];

            for (int i = row1; i < row1 + height; i++)
            {
                T[] temp = new T[width];
                for (int j = col1; j < col1 + width; j++)
                    temp[j] = rect[i, j];
                jagged[i] = temp;
            }
            return jagged;
        }

        /// <summary>
        /// Converts a jagged array of value types into
        /// a twodimensional array
        /// </summary>
        /// <typeparam name="T">A value Type</typeparam>
        /// <param name="jagged">An array of arrays of type T</param>
        /// <returns>T[,]</returns>
        public static T[,] AsTwoDimensional<T>(this T[][] jagged) where T : struct
        {
            int height = jagged.Length;
            int width = jagged.Max(p => p.Length);
            T[,] twoDimensional = new T[height, width];
            for (int i = 0; i < height; i++)
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    twoDimensional[i, j] = jagged[i][j];
                }
            return twoDimensional;
        }
    }
}