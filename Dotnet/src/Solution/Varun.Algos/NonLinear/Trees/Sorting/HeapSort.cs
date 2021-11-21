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

        private void MaxHeapify(int[] arr, int sizeOfArray, int rootIndex)
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
                MaxHeapify(arr, sizeOfArray, largestValueIndex);
            }

        }

        public void Sort(int[] arr)
        {
            for (int currentRootIndex = arr.Length/2 - 1; //Loop through all non leaf nodes starting from bottom
                currentRootIndex >= 0; //While we do not reach the root node
                currentRootIndex--) //Move up in hierarchy
            {
                MaxHeapify(arr, arr.Length, currentRootIndex); // A heap means, all the values in root node are greater than child nodes
            }

            for (int i = arr.Length-1; i > 0; i--) //Length of array will be reduced cutting out the last element
            {
                Swap(arr, i, 0);//Move the largest element at the last
                MaxHeapify(arr, i, 0); //This will again move the max element at the root node
            }
        }



    }
}
