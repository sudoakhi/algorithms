using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.XPath;

namespace Algorithms.Arrays.WaterfallStreams
{
    public static class Algorithm
    {
        public static double[ ] Run(double[ ][ ] array, int source)
        {
            if(array == null)
            {
                return null;
            }

            var numOfRows = array.Length;
            var lastRowIndex = numOfRows - 1;
            var lastRowNumOfColumns = array[lastRowIndex].Length;
            var result = new double[lastRowNumOfColumns];
            var waterFallSources = new List<int>
            {
                source
            };
            var startingRow = 1;
            result[source] = 100;

            while(startingRow < lastRowIndex && waterFallSources.Count > 0)
            {
                var currentWaterFallSources = new List<int>();
                foreach(var wfSource in waterFallSources)
                {
                    currentWaterFallSources.Add(wfSource);
                }

                foreach(var waterFallSource in currentWaterFallSources)
                {
                    if(array[startingRow][waterFallSource] == 1)
                    {
                        var waterFallPercentage = result[waterFallSource];
                        result[waterFallSource] = 0;
                        _ = waterFallSources.Remove(waterFallSource);
                        var newSourceLeft = waterFallSource - 1;
                        var newSourceRight = waterFallSource + 1;

                        while(newSourceLeft >= 0)
                        {
                            if(array[startingRow - 1][newSourceLeft] == 1)
                            {
                                break;
                            }
                            if(array[startingRow - 1][newSourceLeft] == 0 && array[startingRow][newSourceLeft] == 0)
                            {
                                waterFallSources.Add(newSourceLeft);
                                result[newSourceLeft] = result[newSourceLeft] + ( waterFallPercentage -  (waterFallPercentage / 2)  );
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

                            if(array[startingRow - 1][newSourceRight] == 0 && array[startingRow][newSourceRight] == 0)
                            {
                                waterFallSources.Add(newSourceRight);
                                result[newSourceRight] = result[newSourceRight] + ( waterFallPercentage -  (waterFallPercentage / 2)  );
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
