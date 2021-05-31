using System;
using System.Collections.Generic;
using System.Linq;

namespace Manager
{
    public static class ArraysExtension
    {
        private const int rowsDimension = 0;
        private const int columnsDimension = 1;

        public static int GetColumns(this double[,] values)
        {
            return values.GetLength(columnsDimension);
        }

        public static int GetRows(this double[,] values)
        {
            return values.GetLength(rowsDimension);
        }
        public static double[] GetDimension(this double[,] array, int dimension)
        {
            int length = array.GetRows();
            double[] result = new double[length];

            for(int i = 0; i < length; i++)
            {
                result[i] = array[i, dimension]; 
            }

            return result;
        }

        public static void RandomizeArray(this double[,] array, Random rnd)
        {
            for(int i = 0; i < array.GetRows(); i++)
            {
                for(int j = 0; j < array.GetColumns(); j++)
                {
                    array[i, j] = rnd.NextDouble();
                }
            }
        }

        public static double[] TransformIn1DArray(this double[,] array)
        {
            int length = array.GetColumns() * array.GetRows();
            double[] result = new double[length];

            int index = 0;
            for (int i = 0; i < array.GetRows(); i++)
            {
                for(int j = 0; j < array.GetColumns(); j++)
                {
                    result[index++] = array[i, j];
                }
            }

            return result;
        }

        public static void RandomizeArray(this double[] array, Random rnd)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = -1 + rnd.NextDouble() * 2;
            }
        }

        public static double[] GetArrayFromListOfArrays(this List<double[]> list)
        {
            return ListIterator(list).ToArray();
        }

        private static IEnumerable<double> ListIterator(List<double[]> list)
        {
            foreach(double[] array in list)
            {
                for(int i = 0; i < array.Length; i++)
                {
                    yield return array[i];
                }
            }
        }

        public static IEnumerable<double> ConvertSequenseToDouble(this string[] array)
        {
            foreach(string elem in array)
            {
                yield return double.Parse(elem);
            }
        }
        public static IEnumerable<int> ConvertSequenseToInt(this string[] array)
        {
            foreach (string elem in array)
            {
                yield return int.Parse(elem);
            }
        }
    }
}
