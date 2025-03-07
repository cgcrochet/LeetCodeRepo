namespace LeetCodeRepo
{
    public static class RemoveElement
    {
        public static int Solution(int[] nums, int val)
        {
            List<int> numsNotEqualToVal = new();
            List<int> numsEqualToVal = new();

            foreach (int num in nums)
            {
                if (num != val)
                {
                    numsNotEqualToVal.Add(num);
                }
                else
                {
                    numsEqualToVal.Add(num);
                }
            }

            for (int i = 0; i < numsNotEqualToVal.Count; i++)
            {
                nums[i] = numsNotEqualToVal[i];
            }

            for (int j = numsNotEqualToVal.Count; j < nums.Length; j++)
            {
                nums[j] = val;
            }

            return numsNotEqualToVal.Count();
        }
    }
}
