using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class SortAlgorithms
    {
        public int[] MergeSort(int[] nums)
        {
            if (null==nums||nums.Length<=1)
            {
                return nums;
            }

            return MergeSortHelper(nums, 0, nums.Length - 1);
        }

        private int[] MergeSortHelper(int[] nums, int start, int end)
        {
            if (end-start<=0)
            {
                return new int[] { nums[start] };
            }

            int mid = start + (end - start) / 2;
            int[] left = MergeSortHelper(nums, start, mid);
            int[] right = MergeSortHelper(nums, mid+1, end);

            return MergeSortMerge(left, right);
        }

        private int[] MergeSortMerge(int[] left, int[] right)
        {
            int[] rst = new int[left.Length+right.Length];
            int leftIndex = 0;
            int rightIndex = 0;
            int rstIndex = 0;

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] > right[rightIndex])
                {
                    rst[rstIndex++] = right[rightIndex++];
                }
                else
                {
                    rst[rstIndex++] = left[leftIndex++];
                }
            }

            if (leftIndex < left.Length)
            {
                for (int i=leftIndex;i<left.Length;i++)
                {
                    rst[rstIndex++] = left[i];
                }
            }
            else
            {
                for (int i = rightIndex; i < right.Length; i++)
                {
                    rst[rstIndex++] = right[i];
                }
            }

            return rst;
        }
    }
}
