using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varun.Algos.NonLinear.Trees.Sorting
{
    public class HeapSort
    {

        private int GetLeftIndex(int pos)
        {
            var result = pos * 2 + 1;
            return result;
        }

        private int GetRightIndex(int pos)
        {
            var result = pos * 2 + 2;
            return result;
        }

        private void Swap(int[] arr, int sourceIndex, int destIndex)
        {
            int temp = arr[sourceIndex];
            arr[sourceIndex] = arr[destIndex];
            arr[destIndex] = temp;
        }

        private void Heapify(int[] arr, int sizeOfArray, int rootIndex)
        {
            int largestValueIndex = rootIndex;
            int leftIndex = this.GetLeftIndex(rootIndex);
            int rightIndex = this.GetRightIndex(rootIndex);
            if (leftIndex < sizeOfArray && arr[leftIndex] > arr[largestValueIndex])
            {
                largestValueIndex = leftIndex;
            }

            if (rightIndex < sizeOfArray && arr[rightIndex] > arr[largestValueIndex])
            {
                largestValueIndex = rightIndex;
            }

            if (largestValueIndex != rootIndex) //If there is update in value 
            {
                Swap(arr, largestValueIndex, rootIndex);
                Heapify(arr, sizeOfArray, largestValueIndex);
            }

        }

        public void Sort(int[] arr)
        {
            for (int currentRootIndex = arr.Length/2 - 1; //Loop through all non leaf nodes starting from bottom
                currentRootIndex > 0; //While we do not reach the root node
                currentRootIndex--) //Move up in hierarchy
            {
                Heapify(arr, arr.Length, currentRootIndex);
            }

            for (int i = arr.Length-1; i > 0; i--)
            {
                Swap(arr, 0, i);
                Heapify(arr, arr.Length, 0);
            }
        }



    }
}
