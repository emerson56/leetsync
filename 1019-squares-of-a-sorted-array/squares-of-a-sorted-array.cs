public class Solution {
    public int[] SortedSquares(int[] nums) {
        int[] result = new int[nums.Length];
        int lptr = 0; 
        int rptr = nums.Length - 1;
        for(int i = nums.Length -1; i >= 0; i--)
        {
            if(Math.Abs(nums[lptr]) > Math.Abs(nums[rptr]))
            {
                result[i] = nums[lptr] * nums[lptr];
                lptr++;
            }
            else
            {
                result[i] = nums[rptr] * nums[rptr];
                rptr--;
            }
        }

        return result;
    }
}