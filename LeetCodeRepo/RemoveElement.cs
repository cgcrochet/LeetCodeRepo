namespace LeetCodeRepo
{
    public static class RemoveElement
    {
        public static int Solution(int[] nums, int val)
        {
            List<int> numsNotEqualToVal = new();

            foreach (int num in nums)
            {
                if (num != val)
                {
                    numsNotEqualToVal.Add(num);
                }
            }

            for (int i = 0; i < numsNotEqualToVal.Count(); i++)
            {
                nums[i] = numsNotEqualToVal[i];
            }

            return numsNotEqualToVal.Count();
        }
    }
}
