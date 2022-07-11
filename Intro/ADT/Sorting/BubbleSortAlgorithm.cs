using System.Diagnostics.Metrics;
using System.Globalization;

namespace Intro.ADT.Sorting
{
    public class BubbleSortAlgorithm
    {
        public IEnumerable<int> BubbleSort(int[] unsortedArray){

            int temp;

            for (int i = 0; i < unsortedArray.Length -1; i++)
            {
                for (int j = 0; j < unsortedArray.Length -1; j++)
                {
                    if(unsortedArray[j] > unsortedArray[j+1]){

                        temp = unsortedArray[j+1];
                        unsortedArray[j+1]= unsortedArray[j];
                        unsortedArray[j] = temp;

                    }
                }
            }
            return unsortedArray.ToList();
        }
        
    }
}