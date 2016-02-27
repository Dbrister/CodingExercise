using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MindOverMachinesProject.Extensions;
using MindOverMachinesProject.Models;

namespace MindOverMachinesProject.Tests
{
    /// <summary>
    /// This Class contains all methods to calculate and compare the current product. 
    /// </summary>
    public static class Calculate
    {
        /// <summary>
        /// Returns the product of 4 numbers, starting with data[YIndex, XIndex] and includes the next 3 numbers moving up through the 2D array. 
        /// </summary>
        /// <param name="data">2D integer array storing the integer values to multiply.</param>
        /// <param name="YIndex">Index representing the row of the starting number</param>
        /// <param name="XIndex">Index representing the column of the starting number</param>
        /// <returns>The product of the 4 numbers. A 1 will be returned in the case of an IndexOutOfRangeException.</returns>
        public static int ProductAlongUpDirection(int[,] data, int YIndex, int XIndex)
        {
            if (YIndex >= 3)
            {
                int product = 1;
                for (int i = 0; i < 4; i++)
                {
                    product = product.MultiplyBy(data[YIndex - i, XIndex]);
                }

                return product;
            }
            else
            {
                return 1;
            }
        }

        /// <summary>
        /// Returns the product of 4 numbers, starting with data[YIndex, XIndex] and includes the next 3 numbers moving down through the 2D array. 
        /// </summary>
        /// <param name="data">2D integer array storing the integer values to multiply.</param>
        /// <param name="YIndex">Index representing the row of the starting number</param>
        /// <param name="XIndex">Index representing the column of the starting number</param>
        /// <returns>The product of the 4 numbers. A 1 will be returned in the case of an IndexOutOfRangeException.</returns>
        public static int ProductAlongDownDirection(int[,] data, int YIndex, int XIndex)
        {
            if (YIndex <= (data.GetLength(0) - 4))
            {
                int product = 1;
                for (int i = 0; i < 4; i++)
                {
                    product = product.MultiplyBy(data[YIndex + i, XIndex]);
                }

                return product;
            }
            else
            {
                return 1;
            }
        }

        /// <summary>
        /// Returns the product of 4 numbers, starting with data[YIndex, XIndex] and includes the next 3 numbers moving right through the 2D array. 
        /// </summary>
        /// <param name="data">2D integer array storing the integer values to multiply.</param>
        /// <param name="YIndex">Index representing the row of the starting number</param>
        /// <param name="XIndex">Index representing the column of the starting number</param>
        /// <returns>The product of the 4 numbers. A 1 will be returned in the case of an IndexOutOfRangeException</returns>
        public static int ProductAlongRightDirection(int[,] data, int YIndex, int XIndex)
        {
            if (XIndex <= (data.GetLength(1) - 4))
            {
                int product = 1;
                for (int i = 0; i < 4; i++)
                {
                    product = product.MultiplyBy(data[YIndex, XIndex + i]);
                }

                return product;
            }
            else
            {
                return 1;
            }
        }

        /// <summary>
        /// Returns the product of 4 numbers, starting with data[YIndex, XIndex] and includes the next 3 numbers moving left through the 2D array. 
        /// </summary>
        /// <param name="data">2D integer array to get the data from.</param>
        /// <param name="YIndex">Index representing the row of the starting number</param>
        /// <param name="XIndex">Index representing the column of the starting number</param>
        /// <returns>The product of the 4 numbers. A 1 will be returned in the case of an IndexOutOfRangeException</returns>
        public static int ProductAlongLeftDirection(int[,] data, int YIndex, int XIndex)
        {
            if (XIndex >= 3)
            {
                int product = 1;
                for (int i = 0; i < 4; i++)
                {
                    product = product.MultiplyBy(data[YIndex, XIndex - i]);
                }

                return product;
            }
            else
            {
                return 1;
            }
        }

        /// <summary>
        /// Returns the product of 4 numbers, starting with data[YIndex, XIndex] and includes the next 3 numbers moving diagonally up and right through the 2D array. 
        /// </summary>
        /// <param name="data">2D integer array to get the data from.</param>
        /// <param name="YIndex">Index representing the row of the starting number</param>
        /// <param name="XIndex">Index representing the column of the starting number</param>
        /// <returns>The product of the 4 numbers. A 1 will be returned in the case of an IndexOutOfRangeException.</returns>
        public static int ProductAlongUpAndRightDirection(int[,] data, int YIndex, int XIndex)
        {
            if (YIndex >= 3 && XIndex <= (data.GetLength(1) - 4))
            {
                int product = 1;
                for (int i = 0; i < 4; i++)
                {
                    product = product.MultiplyBy(data[YIndex - i, XIndex + i]);
                }

                return product;
            }
            else
            {
                return 1;
            }
        }

        /// <summary>
        /// Returns the product of 4 numbers, starting with data[YIndex, XIndex] and includes the next 3 numbers moving diagonally up and left through the 2D array. 
        /// </summary>
        /// <param name="data">2D integer array to get the data from.</param>
        /// <param name="YIndex">Index representing the row of the starting number</param>
        /// <param name="XIndex">Index representing the column of the starting number</param>
        /// <returns>The product of the 4 numbers. A 1 will be returned in the case of an IndexOutOfRangeException.</returns>
        public static int ProductAlongUpAndLeftDirection(int[,] data, int YIndex, int XIndex)
        {
            if (YIndex >= 3 && XIndex >= 3)
            {
                int product = 1;
                for (int i = 0; i < 4; i++)
                {
                    product = product.MultiplyBy(data[YIndex - i, XIndex - i]);
                }

                return product;
            }
            else
            {
                return 1;
            }
        }

        /// <summary>
        /// Returns the product of 4 numbers, starting with data[YIndex, XIndex] and includes the next 3 numbers moving diagonally down and right through the 2D array. 
        /// </summary>
        /// <param name="data">2D integer array to get the data from.</param>
        /// <param name="YIndex">Index representing the row of the starting number</param>
        /// <param name="XIndex">Index representing the column of the starting number</param>
        /// <returns>The product of the 4 numbers. A 1 will be returned in the case of an IndexOutOfRangeException</returns>
        public static int ProductAlongDownAndRightDirection(int[,] data, int YIndex, int XIndex)
        {
            if (YIndex <= (data.GetLength(0) - 4) && XIndex <= (data.GetLength(1) - 4))
            {
                int product = 1;
                for (int i = 0; i < 4; i++)
                {
                    product = product.MultiplyBy(data[YIndex + i, XIndex + i]);
                }

                return product;
            }
            else
            {
                return 1;
                //throw new IndexOutOfRangeException("YIndex must be greater than or equal to 3 to be able to calculate the product of the initial number by the next 3 above numbers.");
            }
        }

        /// <summary>
        /// Returns the product of 4 numbers, starting with data[YIndex, XIndex] and includes the next 3 numbers moving diagonally down and left through the 2D array. 
        /// </summary>
        /// <param name="data">2D integer array to get the data from.</param>
        /// <param name="YIndex">Index representing the row of the starting number</param>
        /// <param name="XIndex">Index representing the column of the starting number</param>
        /// <returns>The product of the 4 numbers. A 1 will be returned in the case of an IndexOutOfRangeException</returns>
        public static int ProductAlongDownAndLeftDirection(int[,] data, int YIndex, int XIndex)
        {
            if (YIndex <= (data.GetLength(0) - 4) && XIndex >= 3)
            {
                int product = 1;
                for (int i = 0; i < 4; i++)
                {
                    product = product.MultiplyBy(data[YIndex + i, XIndex - i]);
                }

                return product;
            }
            else
            {
                return 1;
            }
        }
    }
}
