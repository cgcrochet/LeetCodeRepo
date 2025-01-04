// See https://aka.ms/new-console-template for more information

using LeetCodeRepo;

/* RemoveElement solution and test case
 * The solution returns the amount of numbers in the array that are not equal 
 * to the provided value. It also modifies the nums array such that elements
 * which are not equal to val are in the front of the array and in their
 * original order
 */
int[] nums = [3, 2, 2, 3];
int val = 3;

int result = RemoveElement.Solution(nums, val);

Console.WriteLine("result: " + result);
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(i + ": " + nums[i]);
}