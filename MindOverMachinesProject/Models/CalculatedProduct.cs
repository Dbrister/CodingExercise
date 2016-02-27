using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindOverMachinesProject.Models
{
    public class CalculatedProduct
    {
        public CalculatedProduct(int resultingProduct, int startYIndex, int startXIndex, DirectionOfCalculation direction)
        {
            this.Product = resultingProduct;
            this.StartYIndex = startYIndex;
            this.StartXIndex = startXIndex;
            this.Direction = direction;
        }

        public int Product { get; set; }

        public int StartYIndex { get; set; }

        public int StartXIndex { get; set; }

        public DirectionOfCalculation Direction { get; set; }

        public string PrintResult(int[,] data )
        {
            var numbers = new int[4];
            for (int i = 0; i < 4; i++)
            {
                switch (Direction)
                {
                    case DirectionOfCalculation.NONE:
                        break;
                    case DirectionOfCalculation.UP:
                        numbers[i] = data[StartYIndex - i, StartXIndex];
                        break;
                    case DirectionOfCalculation.RIGHT:
                        numbers[i] = data[StartYIndex, StartXIndex + i];
                        break;
                    case DirectionOfCalculation.DOWN:
                        numbers[i] = data[StartYIndex + i, StartXIndex];
                        break;
                    case DirectionOfCalculation.LEFT:
                        numbers[i] = data[StartYIndex, StartXIndex - i];
                        break;
                    case DirectionOfCalculation.UPANDRIGHT:
                        numbers[i] = data[StartYIndex - i, StartXIndex + i];
                        break;
                    case DirectionOfCalculation.UPANDLEFT:
                        numbers[i] = data[StartYIndex - i, StartXIndex - i];
                        break;
                    case DirectionOfCalculation.DOWNANDRIGHT:
                        numbers[i] = data[StartYIndex + i, StartXIndex + i];
                        break;
                    case DirectionOfCalculation.DOWNANDLEFT:
                        numbers[i] = data[StartYIndex + i, StartXIndex - i];
                        break;
                    default:
                        break;
                }
            }
            return String.Format("{0} x {1} x {2} x {3} = {4} Direction: {5}", numbers[0], numbers[1], numbers[2], numbers[3], Product, Direction.ToString());
        }

    }
}
