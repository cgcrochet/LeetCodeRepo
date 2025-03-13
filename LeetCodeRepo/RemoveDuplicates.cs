namespace LeetCodeRepo;

internal class RemoveDuplicates
{
    public static int Solution(int[] nums)
    {
        int k = 0;
        int[] existingNums = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            if (!existingNums.Contains(nums[i]))
            {
                nums[k] = nums[i];
                k++;
            }
            existingNums[i] = nums[i];
        }
        return k;
    }
}
