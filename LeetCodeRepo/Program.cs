using LeetCodeRepo;

/* RemoveElement solution and test case
 * The solution returns the amount of numbers in the array that are not equal 
 * to the provided value. It also modifies the nums array such that elements
 * which are not equal to val are in the front of the array and in their
 * original order
 */
 static void RunRemoveElementSolution(int[] nums, int val)
{
    int result = RemoveElement.Solution(nums, val);

    Console.WriteLine("result: " + result);
    for (int i = 0; i < nums.Length; i++)
    {
        Console.WriteLine(i + ": " + nums[i]);
    }
}
//RunRemoveElementSolution([3, 2, 2, 3], 3);

static void RunMergeSortedArraySolution()
{
    int[] nums1 = [1, 2, 3, 0, 0, 0];
    int m = 3;

    int[] nums2 = [2, 5, 6];
    int n = 3;

    int[] result = Merge.Solution(nums1, m, nums2, n);
    for (int i = 0; i < result.Length; i++)
    {
        Console.WriteLine($"result[{i}]: " + result[i]);
    }
}
RunMergeSortedArraySolution();
