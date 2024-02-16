using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.XPath;

namespace suhyphen.Algo.WaterfallStreams
{
    internal class Algorithm
    {
        public static double[] WaterfallStreams(double[][] array, int source)
        {
            int numOfRows = array.Length;
            int lastRowIndex = numOfRows - 1;
            int lastRowNumOfColumns = array[lastRowIndex].Length;
            double[] result = new double[lastRowNumOfColumns];
            List<int> waterFallSources = new List<int>
            {
                source
            };
            int startingRow = 1;
            result[source] = 100;

            while (startingRow < lastRowIndex && waterFallSources.Count > 0)
            {
                List<int> currentWaterFallSources = new List<int>();
                foreach (int wfSource in waterFallSources)
                {
                    currentWaterFallSources.Add(wfSource);
                }

                foreach (int waterFallSource in currentWaterFallSources)
                { 
                    if (array[startingRow][waterFallSource] == 1)
                    {
                        double waterFallPercentage = result[waterFallSource];
                        result[waterFallSource] = 0;
                        waterFallSources.Remove(waterFallSource);                        
                        int newSourceLeft = waterFallSource - 1;
                        int newSourceRight = waterFallSource + 1;

                        while (newSourceLeft >= 0)
                        {
                            if(array[startingRow - 1][newSourceLeft] == 1)
                            {
                                break;
                            }
                            if(array[startingRow - 1][newSourceLeft] == 0 && array[startingRow][newSourceLeft] == 0)
                            {
                                waterFallSources.Add(newSourceLeft);
                                result[newSourceLeft] = result[newSourceLeft] + (waterFallPercentage - waterFallPercentage / 2);
                                break;
                            }

                            newSourceLeft--;
                        }

                        while(newSourceRight < array[startingRow].Length)
                        {
                            if(array[startingRow - 1][newSourceRight] == 1)
                            {
                                break;
                            }

                            if (array[startingRow - 1][newSourceRight] == 0 && array[startingRow][newSourceRight] == 0)
                            {
                                waterFallSources.Add(newSourceRight);
                                result[newSourceRight] = result[newSourceRight] + (waterFallPercentage - waterFallPercentage / 2);
                                break;
                            }

                            newSourceRight++;
                        }
                    }
                }

                startingRow++;
            }

            return result;

        }
    }
}
