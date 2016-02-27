using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using MindOverMachinesProject.Tests;
using MindOverMachinesProject.Models;

namespace MindOverMachinesProject
{
    class Program
    {
        private const int X_AND_Y_DIMENSION = 20;

        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "MindOverMachinesProject.Resources.TestData.txt";
            int largestProduct = 0;
            var calculatedProducts = new List<CalculatedProduct>();
            var testData = new int[X_AND_Y_DIMENSION, X_AND_Y_DIMENSION];

            //Read test data sheet
            using (StreamReader reader = new StreamReader(assembly.GetManifestResourceStream(resourceName)))
            {
                string line;
                string[] seperatedLine;
                var column = 0;

                //Keep reading line by line until the end is reached. 
                while ((line = reader.ReadLine()) != null)
                {
                    seperatedLine = line.Split(" ".ToCharArray());

                    for (int i = 0; i < X_AND_Y_DIMENSION; i++)
                    {
                        testData[column, i] = int.Parse(seperatedLine[i]);
                    }

                    column++;
                }
            }

            //Print initial Data
            var newLine = "";
            var nextNumber = "";
            for (int i = 0; i < X_AND_Y_DIMENSION; i++)
            {
                for (int e = 0; e < X_AND_Y_DIMENSION; e++)
                {
                    nextNumber = testData[i, e].ToString();
                    if (nextNumber.Length < 2)
                        nextNumber = nextNumber.Insert(0, "0");

                    newLine += nextNumber;
                    newLine += " ";
                }

                Console.WriteLine(newLine);
                newLine = "";
            }
            Console.WriteLine();


            //Find the largest product of all 4 consecutive numbers in any of the 8 possible directions
            for (int i = 0; i < X_AND_Y_DIMENSION; i++)
            {
                for (int e = 0; e < X_AND_Y_DIMENSION; e++)
                {
                    //Test Up
                    calculatedProducts.Add(
                        new CalculatedProduct(Calculate.ProductAlongUpDirection(testData, i, e), i, e, DirectionOfCalculation.UP));

                    //Test Down
                    calculatedProducts.Add(
                        new CalculatedProduct(Calculate.ProductAlongDownDirection(testData, i, e), i, e, DirectionOfCalculation.DOWN));

                    //Test Right
                    calculatedProducts.Add(
                        new CalculatedProduct(Calculate.ProductAlongRightDirection(testData, i, e), i, e, DirectionOfCalculation.RIGHT));

                    //Test Left
                    calculatedProducts.Add(
                        new CalculatedProduct(Calculate.ProductAlongLeftDirection(testData, i, e), i, e, DirectionOfCalculation.LEFT));

                    // Test Up-Right diagonal
                    calculatedProducts.Add(
                        new CalculatedProduct(Calculate.ProductAlongUpAndRightDirection(testData, i, e), i, e, DirectionOfCalculation.UPANDRIGHT));

                    // Test Up-Left diagonal
                    calculatedProducts.Add(
                        new CalculatedProduct(Calculate.ProductAlongUpAndLeftDirection(testData, i, e), i, e, DirectionOfCalculation.UPANDLEFT));

                    // Test Down-Right diagonal 
                    calculatedProducts.Add(
                        new CalculatedProduct(Calculate.ProductAlongDownAndRightDirection(testData, i, e), i, e, DirectionOfCalculation.DOWNANDRIGHT));

                    // Test Down-Left diagonal
                    calculatedProducts.Add(
                        new CalculatedProduct(Calculate.ProductAlongDownAndLeftDirection(testData, i, e),i, e, DirectionOfCalculation.DOWNANDLEFT));
                }
            }

            //Find the largest product
            largestProduct = calculatedProducts.Select(cp => cp.Product).Max();

            //Print all calculatedProducts that match the largestProduct incase more resulted in the same product other than the inverse. 
            foreach (var calculatedProduct in calculatedProducts.Where(cp => cp.Product == largestProduct))
            {
                Console.WriteLine(calculatedProduct.PrintResult(testData));
            }

            Console.WriteLine("\nPress any key to exit...");

            Console.ReadKey();
        }
    }
}


