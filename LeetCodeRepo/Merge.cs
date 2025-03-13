using System.Collections.Immutable;

namespace LeetCodeRepo
{
    internal class Merge
    {
        internal static int[] Solution(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = m; i < (m + n); i++)
            {
                nums1[i] = nums2[i - m];
            }
            Array.Sort(nums1);
            return nums1;
        }
    }
}
